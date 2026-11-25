using System.Text.Json.Serialization;

namespace Softplan.Soft.Suite.Dje.Sdk;

internal sealed record DjeTokenResponse(
    [property: JsonPropertyName("access_token")] string? AccessToken,
    [property: JsonPropertyName("expires_in")] int? ExpiresIn);

[JsonSerializable(typeof(DjeTokenResponse))]
internal sealed partial class DjeTokenJsonContext : JsonSerializerContext;
