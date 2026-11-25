#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IAdesaoControllerClient
    {
        /// <summary>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.<br/>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterPessoaJuridicaPDPJ1Async(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.<br/>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterPessoaJuridicaPDPJ1AsStreamAsync(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.<br/>
        /// Obter informaÃ§Ãµes de uma pessoa jurÃ­dica a partir da base do PDPJ para uso administrativo.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterPessoaJuridicaPDPJ1AsResponseAsync(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}