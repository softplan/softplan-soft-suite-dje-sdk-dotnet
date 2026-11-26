#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface ITicketClient
    {
        /// <summary>
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterTicketAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterTicketAsStreamAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterTicketAsResponseAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}