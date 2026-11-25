#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IColigadaClient
    {
        /// <summary>
        /// Recusar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Recusar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RecusarVinculoAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recusar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Recusar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RecusarVinculoAsStreamAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recusar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Recusar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> RecusarVinculoAsResponseAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}