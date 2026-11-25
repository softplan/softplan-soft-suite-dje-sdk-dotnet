using System.Text.Json;

namespace Softplan.Soft.Suite.Dje.Sdk.IntegrationTests;

[TestClass]
public sealed class LiveTests
{
    private const string StagingTokenUrl = "https://sso.stg.cloud.pje.jus.br/auth/realms/pje/protocol/openid-connect/token";

    [TestMethod]
    public async Task ObterComunicacoesOrgaoPublico_ReturnsTheListingFromTheLiveApi()
    {
        var credentials = new DjeClientCredentials
        {
            TokenUrl = new Uri(OptionalEnvironmentVariable("DJE_TOKEN_URL") ?? StagingTokenUrl),
            ClientId = RequireEnvironmentVariable("DJE_CLIENT_ID"),
            ClientSecret = RequireEnvironmentVariable("DJE_CLIENT_SECRET"),
            UserAgent = RequireEnvironmentVariable("DJE_USER_AGENT"),
            Scope = OptionalEnvironmentVariable("DJE_SCOPE"),
        };
        var tenantId = Guid.Parse(RequireEnvironmentVariable("DJE_TENANT_ID"));
        using var client = DjeClient.CreateWithClientCredentials(
            credentials,
            new Uri(OptionalEnvironmentVariable("DJE_BASE_URL") ?? DjeClient.DefaultBaseUrl));

        var body = await client.Comunicacao.ObterComunicacoesOrgaoPublicoAsync(
            tenantId,
            ObterComunicacoesOrgaoPublicoStatusCiente.N,
            page: 0,
            size: 1);

        using var listing = JsonDocument.Parse(body);
        listing.RootElement.TryGetProperty("data", out var data).Should().BeTrue();
        data.ValueKind.Should().Be(JsonValueKind.Array);
    }

    private static string? OptionalEnvironmentVariable(string name) =>
        Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : null;

    private static string RequireEnvironmentVariable(string name) =>
        OptionalEnvironmentVariable(name) ?? throw new AssertInconclusiveException($"{name} environment variable is not set.");
}
