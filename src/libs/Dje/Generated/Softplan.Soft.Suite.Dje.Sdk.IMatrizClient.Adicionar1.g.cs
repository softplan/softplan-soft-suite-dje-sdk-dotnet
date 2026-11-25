#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IMatrizClient
    {
        /// <summary>
        /// Adicionar uma matriz.<br/>
        /// Adicionar uma matriz.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Adicionar1Async(

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarMatrizInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma matriz.<br/>
        /// Adicionar uma matriz.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Adicionar1AsStreamAsync(

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarMatrizInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma matriz.<br/>
        /// Adicionar uma matriz.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> Adicionar1AsResponseAsync(

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarMatrizInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma matriz.<br/>
        /// Adicionar uma matriz.
        /// </summary>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="hashTermo">
        /// Hash termo de aceite
        /// </param>
        /// <param name="representanteJuridico">
        /// Informações do representante júridico
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Adicionar1Async(
            string cnpj,
            string hashTermo,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoInputModel representanteJuridico,
            string? email = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}