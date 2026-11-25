#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IColigadaClient
    {
        /// <summary>
        /// Desvincular uma coligada de uma matriz.<br/>
        /// Desvincular uma coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColigada"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DesvincularColigandoAsync(
            global::System.Guid tenantId,
            long idColigada,
            long idMatrizSolicitante,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Desvincular uma coligada de uma matriz.<br/>
        /// Desvincular uma coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColigada"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DesvincularColigandoAsStreamAsync(
            global::System.Guid tenantId,
            long idColigada,
            long idMatrizSolicitante,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Desvincular uma coligada de uma matriz.<br/>
        /// Desvincular uma coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idColigada"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> DesvincularColigandoAsResponseAsync(
            global::System.Guid tenantId,
            long idColigada,
            long idMatrizSolicitante,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}