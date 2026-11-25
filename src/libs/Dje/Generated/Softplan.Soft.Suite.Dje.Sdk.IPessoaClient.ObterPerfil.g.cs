#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPessoaClient
    {
        /// <summary>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada.<br/>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada. (se ela existe no banco de dados do serviço, se está habilitada a receber comunicações, quais perfis possui, etc).
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterPerfilAsync(
            string documento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada.<br/>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada. (se ela existe no banco de dados do serviço, se está habilitada a receber comunicações, quais perfis possui, etc).
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterPerfilAsStreamAsync(
            string documento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada.<br/>
        /// Obter informações sobre a pessoa (Juridica ou Física) informada. (se ela existe no banco de dados do serviço, se está habilitada a receber comunicações, quais perfis possui, etc).
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterPerfilAsResponseAsync(
            string documento,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}