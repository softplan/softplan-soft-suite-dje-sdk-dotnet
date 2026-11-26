using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace Softplan.Soft.Suite.Dje.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    private static readonly Guid TenantId = Guid.Parse("0f6b2f0e-5d6e-4a3a-9a1c-2d2f2d1a7c11");

    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndBearerAuthentication()
    {
        using var client = new DjeClient("test-access-token");

        client.BaseUri.Should().Be(new Uri("https://gateway.stg.cloud.pje.jus.br/domicilio-eletronico-hml"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("Http");
        authorization.Name.Should().Be("Bearer");
        authorization.Value.Should().Be("test-access-token");
    }

    [TestMethod]
    public async Task ObterComunicacoesOrgaoPublico_SendsPathQueryTenantAndBearer()
    {
        var handler = new RecordingHandler(JsonResponse(HttpStatusCode.OK, "{}"));
        using var httpClient = new HttpClient(handler);
        using var client = new DjeClient(
            "test-access-token",
            httpClient,
            new Uri("https://dje.example.com/gateway"),
            disposeHttpClient: false);

        await client.Comunicacao.ObterComunicacoesOrgaoPublicoAsync(
            TenantId,
            ObterComunicacoesOrgaoPublicoStatusCiente.N,
            dataInicio: new DateTimeOffset(2026, 1, 2, 0, 4, 5, TimeSpan.FromHours(-3)),
            dataFim: new DateTimeOffset(2026, 1, 3, 3, 4, 5, 500, TimeSpan.Zero),
            page: 2,
            size: 50);

        var request = handler.Requests.Should().ContainSingle().Which;
        request.Method.Should().Be(HttpMethod.Get);
        request.Uri.GetLeftPart(UriPartial.Path).Should().Be("https://dje.example.com/gateway/api/v1/comunicacoes/orgaos-publicos");
        var query = HttpUtility.ParseQueryString(request.Uri.Query);
        query.AllKeys.Should().BeEquivalentTo("statusCiente", "dataInicio", "dataFim", "page", "size");
        query["statusCiente"].Should().Be("N");
        query["dataInicio"].Should().Be("2026-01-02T00:04:05-03:00");
        query["dataFim"].Should().Be("2026-01-03T03:04:05.5+00:00");
        query["page"].Should().Be("2");
        query["size"].Should().Be("50");
        request.Headers.GetValues("tenantId").Should().Equal(TenantId.ToString());
        request.Headers.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-access-token"));
    }

    [TestMethod]
    public async Task ObterComunicacoesOrgaoPublico_ThrowsApiExceptionWithStatusAndBodyOnForbidden()
    {
        var handler = new RecordingHandler(JsonResponse(HttpStatusCode.Forbidden, "{\"message\":\"denied\"}"));
        using var httpClient = new HttpClient(handler);
        using var client = new DjeClient("test-access-token", httpClient, disposeHttpClient: false);

        var call = () => client.Comunicacao.ObterComunicacoesOrgaoPublicoAsync(
            TenantId,
            ObterComunicacoesOrgaoPublicoStatusCiente.N);

        var exception = (await call.Should().ThrowAsync<ApiException>()).Which;
        exception.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        exception.ResponseBody.Should().Be("{\"message\":\"denied\"}");
    }

    private static HttpResponseMessage JsonResponse(HttpStatusCode status, string json) =>
        new(status) { Content = new StringContent(json, Encoding.UTF8, "application/json") };

    private sealed record RecordedRequest(HttpMethod Method, Uri Uri, HttpRequestHeaders Headers);

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public List<RecordedRequest> Requests { get; } = [];

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Requests.Add(new RecordedRequest(request.Method, request.RequestUri!, request.Headers));
            return Task.FromResult(response);
        }
    }
}
