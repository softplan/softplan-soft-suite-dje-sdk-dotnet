namespace Softplan.Soft.Suite.Dje.Sdk;

internal sealed class InMemoryDjeAccessTokenStore : IDjeAccessTokenStore
{
    private DjeAccessToken? _token;

    public ValueTask<DjeAccessToken?> GetAsync(CancellationToken cancellationToken) => ValueTask.FromResult(_token);

    public ValueTask SetAsync(DjeAccessToken token, CancellationToken cancellationToken)
    {
        _token = token;
        return ValueTask.CompletedTask;
    }
}
