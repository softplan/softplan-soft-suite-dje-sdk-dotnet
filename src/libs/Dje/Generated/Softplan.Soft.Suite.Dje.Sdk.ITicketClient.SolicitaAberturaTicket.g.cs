#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface ITicketClient
    {
        /// <summary>
        /// Solicita a abertura de chamado para comunicação com problema<br/>
        /// Solicita a abertura de chamado para comunicação com problema
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task SolicitaAberturaTicketAsync(
            global::System.Guid tenantId,

            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Solicita a abertura de chamado para comunicação com problema<br/>
        /// Solicita a abertura de chamado para comunicação com problema
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> SolicitaAberturaTicketAsResponseAsync(
            global::System.Guid tenantId,

            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Solicita a abertura de chamado para comunicação com problema<br/>
        /// Solicita a abertura de chamado para comunicação com problema
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="classificacao">
        /// A classificação do ticket. <br/>
        ///  (1 - INTEIRO_TEOR_EM_BRANCO, 2 - INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA, 3 - INTEIRO_TEOR_INDISPONIVEL, 4 - INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO, 5 - INTEIRO_TEOR_COM_AUTENTICACAO_PREVIA, 6 - OUTROS)<br/>
        /// Example: 5
        /// </param>
        /// <param name="motivo">
        /// O motivo da abertura do ticket. Apenas se o valor de classificacao for igual a 5 - OUTROS<br/>
        /// Example: Estou recebendo 403 ao tentar acessar inteiro teor.
        /// </param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SolicitaAberturaTicketAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModelClassificacao classificacao,
            string numeroComunicacao,
            string numeroProcesso,
            string? motivo = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}