#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IOrgaoPublicoClient
    {
        /// <summary>
        /// Obter um orgãos públicos por id.<br/>
        /// Obter um orgãos públicos por id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> BuscarVinculosAsync(
            global::System.Guid tenantId,
            long id,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter um orgãos públicos por id.<br/>
        /// Obter um orgãos públicos por id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> BuscarVinculosAsStreamAsync(
            global::System.Guid tenantId,
            long id,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter um orgãos públicos por id.<br/>
        /// Obter um orgãos públicos por id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> BuscarVinculosAsResponseAsync(
            global::System.Guid tenantId,
            long id,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}