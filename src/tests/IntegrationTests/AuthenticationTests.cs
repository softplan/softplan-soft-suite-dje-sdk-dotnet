using System.Net;
using System.Text;
using System.Web;

namespace Softplan.Soft.Suite.Dje.Sdk.IntegrationTests;

[TestClass]
public sealed class AuthenticationTests
{
    private const string UserAgent = "my-app/1.2.3/my-org";
    private static readonly Uri TokenUrl = new("https://sso.example.com/token");
    private static readonly Guid TenantId = Guid.Parse("0f6b2f0e-5d6e-4a3a-9a1c-2d2f2d1a7c11");

    [TestMethod]
    public async Task TwoCalls_FetchTheTokenOnceAndSendItAsBearer()
    {
        var server = new FakeServer();
        using var client = CreateClient(server);

        await ListAsync(client);
        await ListAsync(client);

        server.TokenRequests.Should().ContainSingle();
        server.ApiRequests.Should().HaveCount(2);
        server.ApiRequests.Should().OnlyContain(request => request.Authorization == "Bearer token-1");
    }

    [TestMethod]
    public async Task TokenRequest_PostsTheClientCredentialsForm()
    {
        var server = new FakeServer();
        using var client = CreateClient(server, scope: "dje.read");

        await ListAsync(client);

        var request = server.TokenRequests.Should().ContainSingle().Which;
        request.Method.Should().Be(HttpMethod.Post);
        request.ContentType.Should().Be("application/x-www-form-urlencoded");
        var form = HttpUtility.ParseQueryString(request.Body!);
        form.AllKeys.Should().BeEquivalentTo("grant_type", "client_id", "client_secret", "scope");
        form["grant_type"].Should().Be("client_credentials");
        form["client_id"].Should().Be("my-client");
        form["client_secret"].Should().Be("my-secret");
        form["scope"].Should().Be("dje.read");
    }

    [TestMethod]
    public async Task TokenRequest_OmitsTheScopeWhenNotSet()
    {
        var server = new FakeServer();
        using var client = CreateClient(server);

        await ListAsync(client);

        var form = HttpUtility.ParseQueryString(server.TokenRequests.Single().Body!);
        form.AllKeys.Should().BeEquivalentTo("grant_type", "client_id", "client_secret");
    }

    [TestMethod]
    public async Task UserAgent_IsSentOnTokenAndApiCalls()
    {
        var server = new FakeServer();
        using var client = CreateClient(server);

        await ListAsync(client);

        server.Requests.Should().HaveCount(2);
        server.Requests.Should().OnlyContain(request => request.UserAgent == UserAgent);
    }

    [TestMethod]
    public async Task Unauthorized_RenewsTheTokenOnceAndResendsTheRequest()
    {
        var server = new FakeServer { ApiStatus = authorization => authorization == "Bearer token-1" ? HttpStatusCode.Unauthorized : HttpStatusCode.OK };
        using var client = CreateClient(server);

        await ListAsync(client);

        server.TokenRequests.Should().HaveCount(2);
        var requests = server.ApiRequests;
        requests.Should().HaveCount(2);
        var (first, second) = (requests[0], requests[1]);
        first.Authorization.Should().Be("Bearer token-1");
        second.Authorization.Should().Be("Bearer token-2");
        second.Method.Should().Be(first.Method);
        second.Uri.Should().Be(first.Uri);
        second.TenantId.Should().Be(TenantId.ToString());
        second.UserAgent.Should().Be(UserAgent);
    }

    [TestMethod]
    public async Task Unauthorized_ResendsTheRequestBody()
    {
        var server = new FakeServer { ApiStatus = authorization => authorization == "Bearer token-1" ? HttpStatusCode.Unauthorized : HttpStatusCode.OK };
        using var client = CreateClient(server);

        await client.Ticket.SolicitaAberturaTicketAsync(
            TenantId,
            SolicitarAberturaTicketInputModelClassificacao.x1,
            numeroComunicacao: "12345",
            numeroProcesso: "0001234-56.2026.8.26.0100",
            motivo: "unreadable document");

        var requests = server.ApiRequests;
        requests.Should().HaveCount(2);
        var (first, second) = (requests[0], requests[1]);
        first.Body.Should().Contain("0001234-56.2026.8.26.0100").And.Contain("unreadable document");
        second.Body.Should().Be(first.Body);
        second.ContentType.Should().Be(first.ContentType);
        second.Authorization.Should().Be("Bearer token-2");
    }

    [TestMethod]
    public async Task SecondUnauthorized_IsReturnedWithoutAnotherRenewal()
    {
        var server = new FakeServer { ApiStatus = _ => HttpStatusCode.Unauthorized };
        using var client = CreateClient(server);

        var call = () => ListAsync(client);

        var exception = (await call.Should().ThrowAsync<ApiException>()).Which;
        exception.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        server.TokenRequests.Should().HaveCount(2);
        server.ApiRequests.Should().HaveCount(2);
    }

    [TestMethod]
    public async Task Token_IsRefreshedOnlyAfterItExpires()
    {
        var clock = new ManualTimeProvider();
        var server = new FakeServer(expiresInSeconds: 300);
        using var client = CreateClient(server, clock);

        await ListAsync(client);
        clock.Advance(TimeSpan.FromSeconds(239));
        await ListAsync(client);
        server.TokenRequests.Should().ContainSingle();

        clock.Advance(TimeSpan.FromSeconds(2));
        await ListAsync(client);

        server.TokenRequests.Should().HaveCount(2);
        server.ApiRequests.Select(request => request.Authorization)
            .Should().Equal("Bearer token-1", "Bearer token-1", "Bearer token-2");
    }

    [TestMethod]
    public async Task ConcurrentCalls_ShareOneTokenRequest()
    {
        var release = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        var server = new FakeServer { TokenGate = release.Task };
        using var client = CreateClient(server);

        var calls = new[] { ListAsync(client), ListAsync(client) };
        while (server.TokenRequests.Count == 0)
        {
            await Task.Delay(10);
        }

        await Task.Delay(100);
        release.SetResult();
        await Task.WhenAll(calls);

        server.TokenRequests.Should().ContainSingle();
        server.ApiRequests.Should().OnlyContain(request => request.Authorization == "Bearer token-1");
    }

    [TestMethod]
    public async Task TokenEndpointFailure_ThrowsWithoutCallingTheApi()
    {
        var server = new FakeServer { TokenStatus = HttpStatusCode.Forbidden };
        using var client = CreateClient(server);

        var call = () => ListAsync(client);

        var exception = (await call.Should().ThrowAsync<HttpRequestException>()).Which;
        exception.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        server.ApiRequests.Should().BeEmpty();
    }

    [TestMethod]
    public void Credentials_ToStringOmitsTheClientSecret()
    {
        var credentials = CreateCredentials();

        credentials.ToString().Should().NotContain("my-secret").And.Contain("my-client");
    }

    [TestMethod]
    [DataRow("", "my-secret", UserAgent)]
    [DataRow("my-client", " ", UserAgent)]
    [DataRow("my-client", "my-secret", "")]
    public void CreateWithClientCredentials_RejectsBlankValues(string clientId, string clientSecret, string userAgent)
    {
        var credentials = CreateCredentials() with { ClientId = clientId, ClientSecret = clientSecret, UserAgent = userAgent };

        var create = () => DjeClient.CreateWithClientCredentials(credentials);

        create.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void CreateWithClientCredentials_RejectsARelativeTokenUrl()
    {
        var credentials = CreateCredentials() with { TokenUrl = new Uri("/token", UriKind.Relative) };

        var create = () => DjeClient.CreateWithClientCredentials(credentials);

        create.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void CreateWithClientCredentials_DisposesTheHandlerWhenTheBaseUriIsInvalid()
    {
        var server = new FakeServer();

        var create = () => DjeClient.CreateWithClientCredentials(
            CreateCredentials(),
            new Uri("/gateway", UriKind.Relative),
            server);

        create.Should().Throw<ArgumentException>();
        server.IsDisposed.Should().BeTrue();
    }

    [TestMethod]
    public async Task TwoClientsWithOneStore_ShareOneToken()
    {
        var server = new FakeServer();
        var store = new RecordingTokenStore();
        using var first = CreateClient(server, tokenStore: store);
        using var second = CreateClient(server, tokenStore: store);

        await ListAsync(first);
        await ListAsync(second);

        server.TokenRequests.Should().ContainSingle();
        server.ApiRequests.Should().OnlyContain(request => request.Authorization == "Bearer token-1");
    }

    [TestMethod]
    public async Task StoredValidToken_IsSentWithoutATokenRequest()
    {
        var server = new FakeServer();
        var clock = new ManualTimeProvider();
        var store = new RecordingTokenStore { Token = new DjeAccessToken { Value = "stored", ExpiresAt = clock.GetUtcNow().AddMinutes(1) } };
        using var client = CreateClient(server, clock, tokenStore: store);

        await ListAsync(client);

        server.TokenRequests.Should().BeEmpty();
        server.ApiRequests.Should().ContainSingle().Which.Authorization.Should().Be("Bearer stored");
    }

    [TestMethod]
    public async Task IssuedToken_IsStoredWithTheExpiryMinusSixtySeconds()
    {
        var server = new FakeServer(expiresInSeconds: 300);
        var clock = new ManualTimeProvider();
        var store = new RecordingTokenStore();
        using var client = CreateClient(server, clock, tokenStore: store);

        await ListAsync(client);

        store.Token.Should().Be(new DjeAccessToken { Value = "token-1", ExpiresAt = clock.GetUtcNow().AddSeconds(240) });
    }

    [TestMethod]
    public async Task UnauthorizedStoredToken_IsReplacedInTheStore()
    {
        var server = new FakeServer { ApiStatus = authorization => authorization == "Bearer stale" ? HttpStatusCode.Unauthorized : HttpStatusCode.OK };
        var clock = new ManualTimeProvider();
        var store = new RecordingTokenStore { Token = new DjeAccessToken { Value = "stale", ExpiresAt = clock.GetUtcNow().AddMinutes(1) } };
        using var client = CreateClient(server, clock, tokenStore: store);

        await ListAsync(client);

        server.TokenRequests.Should().ContainSingle();
        server.ApiRequests.Select(request => request.Authorization).Should().Equal("Bearer stale", "Bearer token-1");
        store.Token!.Value.Should().Be("token-1");
    }

    private static DjeClientCredentials CreateCredentials(string? scope = null) => new()
    {
        TokenUrl = TokenUrl,
        ClientId = "my-client",
        ClientSecret = "my-secret",
        UserAgent = UserAgent,
        Scope = scope,
    };

    private static DjeClient CreateClient(FakeServer server, TimeProvider? clock = null, string? scope = null, IDjeAccessTokenStore? tokenStore = null) =>
        DjeClient.CreateWithClientCredentials(
            CreateCredentials(scope),
            new Uri("https://dje.example.com/gateway"),
            server,
            clock,
            tokenStore);

    private static Task<byte[]> ListAsync(DjeClient client) =>
        client.Comunicacao.ObterComunicacoesOrgaoPublicoAsync(TenantId, ObterComunicacoesOrgaoPublicoStatusCiente.N);

    private sealed record RecordedRequest(
        HttpMethod Method,
        Uri Uri,
        string? Authorization,
        string? UserAgent,
        string? TenantId,
        string? ContentType,
        string? Body);

    private sealed class FakeServer(int expiresInSeconds = 300) : HttpMessageHandler
    {
        private readonly List<RecordedRequest> _requests = [];
        private int _tokensIssued;

        public Func<string?, HttpStatusCode> ApiStatus { get; init; } = _ => HttpStatusCode.OK;

        public HttpStatusCode TokenStatus { get; init; } = HttpStatusCode.OK;

        public Task? TokenGate { get; init; }

        public bool IsDisposed { get; private set; }

        public IReadOnlyList<RecordedRequest> Requests => Snapshot(_ => true);

        public IReadOnlyList<RecordedRequest> TokenRequests => Snapshot(request => request.Uri == TokenUrl);

        public IReadOnlyList<RecordedRequest> ApiRequests => Snapshot(request => request.Uri != TokenUrl);

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var recorded = new RecordedRequest(
                request.Method,
                request.RequestUri!,
                request.Headers.Authorization?.ToString(),
                request.Headers.TryGetValues("User-Agent", out var userAgent) ? string.Join(' ', userAgent) : null,
                request.Headers.TryGetValues("tenantId", out var tenantId) ? tenantId.Single() : null,
                request.Content?.Headers.ContentType?.ToString(),
                request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken));
            lock (_requests)
            {
                _requests.Add(recorded);
            }

            if (recorded.Uri != TokenUrl)
            {
                return Json(ApiStatus(recorded.Authorization), "{}");
            }

            if (TokenGate is not null)
            {
                await TokenGate;
            }

            var number = Interlocked.Increment(ref _tokensIssued);
            return Json(TokenStatus, $$"""{"access_token":"token-{{number}}","expires_in":{{expiresInSeconds}}}""");
        }

        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
            base.Dispose(disposing);
        }

        private List<RecordedRequest> Snapshot(Func<RecordedRequest, bool> filter)
        {
            lock (_requests)
            {
                return _requests.Where(filter).ToList();
            }
        }

        private static HttpResponseMessage Json(HttpStatusCode status, string json) =>
            new(status) { Content = new StringContent(json, Encoding.UTF8, "application/json") };
    }

    private sealed class RecordingTokenStore : IDjeAccessTokenStore
    {
        public DjeAccessToken? Token { get; set; }

        public ValueTask<DjeAccessToken?> GetAsync(CancellationToken cancellationToken) => ValueTask.FromResult(Token);

        public ValueTask SetAsync(DjeAccessToken token, CancellationToken cancellationToken)
        {
            Token = token;
            return ValueTask.CompletedTask;
        }
    }

    private sealed class ManualTimeProvider : TimeProvider
    {
        private long _ticks;

        public override long TimestampFrequency => TimeSpan.TicksPerSecond;

        public override long GetTimestamp() => _ticks;

        public override DateTimeOffset GetUtcNow() => DateTimeOffset.UnixEpoch.AddTicks(_ticks);

        public void Advance(TimeSpan elapsed) => _ticks += elapsed.Ticks;
    }
}
