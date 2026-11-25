#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPdpjClient
    {
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterPessoaJuridicaPDPJAsync(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterPessoaJuridicaPDPJAsStreamAsync(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterPessoaJuridicaPDPJAsResponseAsync(
            string cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}