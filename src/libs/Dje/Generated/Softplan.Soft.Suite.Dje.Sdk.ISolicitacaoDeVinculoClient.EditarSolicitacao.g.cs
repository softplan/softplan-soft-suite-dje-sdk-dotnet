#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface ISolicitacaoDeVinculoClient
    {
        /// <summary>
        /// Alterar solicitação de coligação.<br/>
        /// Alterar solicitação de coligação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> EditarSolicitacaoAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idSolicitacao,

            global::Softplan.Soft.Suite.Dje.Sdk.EditarEmailSolicitacaoVinculoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar solicitação de coligação.<br/>
        /// Alterar solicitação de coligação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> EditarSolicitacaoAsStreamAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idSolicitacao,

            global::Softplan.Soft.Suite.Dje.Sdk.EditarEmailSolicitacaoVinculoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar solicitação de coligação.<br/>
        /// Alterar solicitação de coligação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> EditarSolicitacaoAsResponseAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idSolicitacao,

            global::Softplan.Soft.Suite.Dje.Sdk.EditarEmailSolicitacaoVinculoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar solicitação de coligação.<br/>
        /// Alterar solicitação de coligação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="email">
        /// E-mail da pessoa
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> EditarSolicitacaoAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idSolicitacao,
            string? email = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}