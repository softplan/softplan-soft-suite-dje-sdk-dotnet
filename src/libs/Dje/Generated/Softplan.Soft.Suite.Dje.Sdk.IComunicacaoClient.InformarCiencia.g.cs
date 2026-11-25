#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IComunicacaoClient
    {
        /// <summary>
        /// Obter inteiro teor de uma comunicação.<br/>
        /// Obter inteiro teor de uma comunicação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroComunicacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ObterInteiroTeorModel> InformarCienciaAsync(
            global::System.Guid tenantId,
            string numeroProcesso,
            string numeroComunicacao,

            global::Softplan.Soft.Suite.Dje.Sdk.InformarCienciaInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter inteiro teor de uma comunicação.<br/>
        /// Obter inteiro teor de uma comunicação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroComunicacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ObterInteiroTeorModel>> InformarCienciaAsResponseAsync(
            global::System.Guid tenantId,
            string numeroProcesso,
            string numeroComunicacao,

            global::Softplan.Soft.Suite.Dje.Sdk.InformarCienciaInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter inteiro teor de uma comunicação.<br/>
        /// Obter inteiro teor de uma comunicação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroComunicacao"></param>
        /// <param name="nomeUsuarioCiencia"></param>
        /// <param name="serialVersionUID"></param>
        /// <param name="usuarioCiencia"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ObterInteiroTeorModel> InformarCienciaAsync(
            global::System.Guid tenantId,
            string numeroProcesso,
            string numeroComunicacao,
            string? nomeUsuarioCiencia = default,
            long? serialVersionUID = default,
            string? usuarioCiencia = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}