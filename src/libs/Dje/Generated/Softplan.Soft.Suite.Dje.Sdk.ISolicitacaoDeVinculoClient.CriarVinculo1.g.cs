#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface ISolicitacaoDeVinculoClient
    {
        /// <summary>
        /// Criar solicitação de coligação com a matriz informada.<br/>
        /// Criar solicitação de coligação com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CriarVinculo1Async(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarVinculoColigacaoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar solicitação de coligação com a matriz informada.<br/>
        /// Criar solicitação de coligação com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> CriarVinculo1AsResponseAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarVinculoColigacaoInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar solicitação de coligação com a matriz informada.<br/>
        /// Criar solicitação de coligação com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// Email
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CriarVinculo1Async(
            global::System.Guid tenantId,
            long id,
            string cnpj,
            string? email = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}