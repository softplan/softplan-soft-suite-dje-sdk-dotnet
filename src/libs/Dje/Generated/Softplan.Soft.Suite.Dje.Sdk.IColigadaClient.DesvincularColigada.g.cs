#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IColigadaClient
    {
        /// <summary>
        /// Inativar vinculo com coligada.<br/>
        /// Inativar vinculo com coligada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColiganda"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DesvincularColigadaAsync(
            global::System.Guid tenantId,
            long idColiganda,
            long idColigada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inativar vinculo com coligada.<br/>
        /// Inativar vinculo com coligada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColiganda"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DesvincularColigadaAsStreamAsync(
            global::System.Guid tenantId,
            long idColiganda,
            long idColigada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inativar vinculo com coligada.<br/>
        /// Inativar vinculo com coligada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColiganda"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> DesvincularColigadaAsResponseAsync(
            global::System.Guid tenantId,
            long idColiganda,
            long idColigada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}