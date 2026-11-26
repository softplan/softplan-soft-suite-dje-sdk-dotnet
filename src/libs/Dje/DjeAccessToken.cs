namespace Softplan.Soft.Suite.Dje.Sdk;

/// <summary>
/// An access token issued by the CNJ token endpoint.
/// </summary>
public sealed record DjeAccessToken
{
    /// <summary>
    /// Gets the bearer value sent in the <c>Authorization</c> header.
    /// </summary>
    public required string Value { get; init; }

    /// <summary>
    /// Gets the instant after which the SDK asks for a new token. It is 60 seconds before the expiry the CNJ declared.
    /// </summary>
    public required DateTimeOffset ExpiresAt { get; init; }
}
