using System.Diagnostics.CodeAnalysis;

namespace Softplan.Soft.Suite.Dje.Sdk;

public sealed partial class DjeClient
{
    // The generated operations refuse to build a request without a Bearer authorization.
    private const string ManagedBearerToken = "managed-by-dje-authentication-handler";

    /// <summary>
    /// Creates a client that gets its own access token with the OAuth2 client credentials grant, renews it before it
    /// expires, and sends the credentials' User-Agent on every request.
    /// </summary>
    /// <param name="credentials">The client credentials and the User-Agent the CNJ requires.</param>
    /// <param name="baseUri">The base URL for the API. If not provided, the default base URL from the OpenAPI spec is used.</param>
    /// <param name="innerHandler">The handler that sends the requests. If not provided, a new <see cref="SocketsHttpHandler"/> is used. The returned client disposes it.</param>
    /// <param name="timeProvider">The clock that decides when the token expires. If not provided, <see cref="TimeProvider.System"/> is used.</param>
    /// <param name="tokenStore">Where the access token is kept. If not provided, the client keeps it in memory.</param>
    /// <returns>A client that disposes its <see cref="HttpClient"/> and handlers when it is disposed.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="credentials"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">A credential value is blank, the token URL is not absolute, or <paramref name="baseUri"/> is not absolute.</exception>
    [SuppressMessage(
        "Reliability",
        "CA2000:Dispose objects before losing scope",
        Justification = "The returned client owns the HttpClient and both handlers, and the catch block disposes them when construction fails.")]
    public static DjeClient CreateWithClientCredentials(
        DjeClientCredentials credentials,
        Uri? baseUri = null,
        HttpMessageHandler? innerHandler = null,
        TimeProvider? timeProvider = null,
        IDjeAccessTokenStore? tokenStore = null)
    {
        ArgumentNullException.ThrowIfNull(credentials);
        credentials.ThrowIfInvalid();

        var httpClient = new HttpClient(new DjeAuthenticationHandler(
            credentials,
            innerHandler ?? new SocketsHttpHandler(),
            timeProvider ?? TimeProvider.System,
            tokenStore ?? new InMemoryDjeAccessTokenStore()));
        try
        {
            return new DjeClient(ManagedBearerToken, httpClient, baseUri);
        }
        catch
        {
            httpClient.Dispose();
            throw;
        }
    }
}
