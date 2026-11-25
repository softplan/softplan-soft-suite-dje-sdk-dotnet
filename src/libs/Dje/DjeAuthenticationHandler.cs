using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Softplan.Soft.Suite.Dje.Sdk;

internal sealed class DjeAuthenticationHandler : DelegatingHandler
{
    private const int DefaultTokenLifetimeSeconds = 300;
    private static readonly TimeSpan RenewalMargin = TimeSpan.FromSeconds(60);

    private readonly DjeClientCredentials _credentials;
    private readonly TimeProvider _timeProvider;
    private readonly IDjeAccessTokenStore _tokenStore;
    private readonly SemaphoreSlim _gate = new(1, 1);

    public DjeAuthenticationHandler(
        DjeClientCredentials credentials,
        HttpMessageHandler innerHandler,
        TimeProvider timeProvider,
        IDjeAccessTokenStore tokenStore)
        : base(innerHandler)
    {
        _credentials = credentials;
        _timeProvider = timeProvider;
        _tokenStore = tokenStore;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (request.Content is not null)
        {
            await request.Content.LoadIntoBufferAsync(cancellationToken).ConfigureAwait(false);
        }

        var token = await GetTokenAsync(rejectedToken: null, cancellationToken).ConfigureAwait(false);
        var response = await SendWithTokenAsync(request, token, cancellationToken).ConfigureAwait(false);
        if (response.StatusCode != HttpStatusCode.Unauthorized)
        {
            return response;
        }

        response.Dispose();
        token = await GetTokenAsync(rejectedToken: token, cancellationToken).ConfigureAwait(false);
        using var retry = await CloneAsync(request, cancellationToken).ConfigureAwait(false);
        response = await SendWithTokenAsync(retry, token, cancellationToken).ConfigureAwait(false);
        response.RequestMessage = request;
        return response;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _gate.Dispose();
        }

        base.Dispose(disposing);
    }

    private static async Task<HttpRequestMessage> CloneAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var clone = new HttpRequestMessage(request.Method, request.RequestUri)
        {
            Version = request.Version,
            VersionPolicy = request.VersionPolicy,
        };

        foreach (var header in request.Headers)
        {
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        if (request.Content is not null)
        {
            var content = new ByteArrayContent(
                await request.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false));
            foreach (var header in request.Content.Headers)
            {
                content.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            clone.Content = content;
        }

        return clone;
    }

    private Task<HttpResponseMessage> SendWithTokenAsync(
        HttpRequestMessage request,
        string token,
        CancellationToken cancellationToken)
    {
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        request.Headers.Remove("User-Agent");
        request.Headers.TryAddWithoutValidation("User-Agent", _credentials.UserAgent);
        return base.SendAsync(request, cancellationToken);
    }

    private async Task<string> GetTokenAsync(string? rejectedToken, CancellationToken cancellationToken)
    {
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var stored = await _tokenStore.GetAsync(cancellationToken).ConfigureAwait(false);
            if (stored is not null && stored.Value != rejectedToken && _timeProvider.GetUtcNow() < stored.ExpiresAt)
            {
                return stored.Value;
            }

            var issued = await RequestTokenAsync(cancellationToken).ConfigureAwait(false);
            await _tokenStore.SetAsync(issued, cancellationToken).ConfigureAwait(false);
            return issued.Value;
        }
        finally
        {
            _gate.Release();
        }
    }

    private async Task<DjeAccessToken> RequestTokenAsync(CancellationToken cancellationToken)
    {
        List<KeyValuePair<string, string>> form =
        [
            new("grant_type", "client_credentials"),
            new("client_id", _credentials.ClientId),
            new("client_secret", _credentials.ClientSecret),
        ];
        if (!string.IsNullOrWhiteSpace(_credentials.Scope))
        {
            form.Add(new("scope", _credentials.Scope));
        }

        using var request = new HttpRequestMessage(HttpMethod.Post, _credentials.TokenUrl)
        {
            Content = new FormUrlEncodedContent(form),
        };
        request.Headers.TryAddWithoutValidation("User-Agent", _credentials.UserAgent);

        var issuedAt = _timeProvider.GetUtcNow();
        using var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var token = await response.Content
            .ReadFromJsonAsync(DjeTokenJsonContext.Default.DjeTokenResponse, cancellationToken)
            .ConfigureAwait(false);
        if (token?.AccessToken is not { Length: > 0 } accessToken)
        {
            throw new HttpRequestException("The DJE token response has no access_token.");
        }

        var lifetime = TimeSpan.FromSeconds(token.ExpiresIn ?? DefaultTokenLifetimeSeconds);
        return new DjeAccessToken { Value = accessToken, ExpiresAt = issuedAt + lifetime - RenewalMargin };
    }
}
