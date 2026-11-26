using System.Text;

namespace Softplan.Soft.Suite.Dje.Sdk;

/// <summary>
/// OAuth2 client credentials for the CNJ token endpoint and the User-Agent the CNJ requires on every request.
/// </summary>
public sealed record DjeClientCredentials
{
    /// <summary>
    /// Gets the OpenID Connect token endpoint that accepts the client credentials grant.
    /// </summary>
    public required Uri TokenUrl { get; init; }

    /// <summary>
    /// Gets the OAuth2 client identifier.
    /// </summary>
    public required string ClientId { get; init; }

    /// <summary>
    /// Gets the OAuth2 client secret.
    /// </summary>
    public required string ClientSecret { get; init; }

    /// <summary>
    /// Gets the User-Agent in the <c>application/version/organization</c> format. The CNJ answers 403 to any other value.
    /// </summary>
    public required string UserAgent { get; init; }

    /// <summary>
    /// Gets the optional OAuth2 scope sent with the token request.
    /// </summary>
    public string? Scope { get; init; }

    internal void ThrowIfInvalid()
    {
        ArgumentNullException.ThrowIfNull(TokenUrl);
        if (!TokenUrl.IsAbsoluteUri)
        {
            throw new ArgumentException("The token URL must be absolute.", nameof(TokenUrl));
        }

        ArgumentException.ThrowIfNullOrWhiteSpace(ClientId);
        ArgumentException.ThrowIfNullOrWhiteSpace(ClientSecret);
        ArgumentException.ThrowIfNullOrWhiteSpace(UserAgent);
    }

    private bool PrintMembers(StringBuilder builder)
    {
        builder.Append("TokenUrl = ").Append(TokenUrl)
            .Append(", ClientId = ").Append(ClientId)
            .Append(", UserAgent = ").Append(UserAgent)
            .Append(", Scope = ").Append(Scope);
        return true;
    }
}
