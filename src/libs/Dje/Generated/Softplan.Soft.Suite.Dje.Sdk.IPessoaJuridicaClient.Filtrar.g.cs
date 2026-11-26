#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPessoaJuridicaClient
    {
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> FiltrarAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> FiltrarAsStreamAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> FiltrarAsResponseAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Softplan.Soft.Suite.Dje.Sdk.Pageable pageable,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}