#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IOrgaoPublicoClient
    {
        /// <summary>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada.<br/>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="viaFormularioSem">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CriarVinculoAsync(
            global::System.Guid tenantId,
            string id,

            global::Softplan.Soft.Suite.Dje.Sdk.VincularOrgaoPublicoInputModel request,
            bool? viaFormularioSem = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada.<br/>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="viaFormularioSem">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> CriarVinculoAsResponseAsync(
            global::System.Guid tenantId,
            string id,

            global::Softplan.Soft.Suite.Dje.Sdk.VincularOrgaoPublicoInputModel request,
            bool? viaFormularioSem = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada.<br/>
        /// Criar solicitação de vinculo com orgao publico com a matriz informada. Ela deve confirmar/rejeitar o vínculo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="viaFormularioSem">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CriarVinculoAsync(
            global::System.Guid tenantId,
            string id,
            string cnpj,
            bool? viaFormularioSem = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}