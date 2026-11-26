#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IAdminEmpresaIncorporadaControllerClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="idDocumento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> BaixarDocumentoAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,
            long idDocumento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="idDocumento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> BaixarDocumentoAsStreamAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,
            long idDocumento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="idDocumento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> BaixarDocumentoAsResponseAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,
            long idDocumento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}