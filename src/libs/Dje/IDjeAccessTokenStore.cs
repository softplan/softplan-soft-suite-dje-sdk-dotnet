namespace Softplan.Soft.Suite.Dje.Sdk;

/// <summary>
/// Keeps the access token of one set of client credentials, so several clients and processes can share it.
/// </summary>
/// <remarks>
/// The SDK reads the token before each request and writes a new one when the stored token is missing, expired, or
/// rejected with 401. Without a store, each client keeps its token in memory.
/// </remarks>
public interface IDjeAccessTokenStore
{
    /// <summary>
    /// Reads the stored token.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the read.</param>
    /// <returns>The stored token, or <see langword="null"/> when there is none.</returns>
    ValueTask<DjeAccessToken?> GetAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Stores a new token in place of the current one.
    /// </summary>
    /// <param name="token">The token to store. Store it at least until <see cref="DjeAccessToken.ExpiresAt"/>.</param>
    /// <param name="cancellationToken">The token to cancel the write.</param>
    /// <returns>A task that completes when the token is stored.</returns>
    ValueTask SetAsync(DjeAccessToken token, CancellationToken cancellationToken);
}
