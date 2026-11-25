#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IRepresentantesClient
    {
        /// <summary>
        /// Retorna a lista dos representados para o intervalo de datas especificado.<br/>
        /// Retorna a lista dos representados para o intervalo de datas especificado
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel> ListarRepresentadosAsync(
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retorna a lista dos representados para o intervalo de datas especificado.<br/>
        /// Retorna a lista dos representados para o intervalo de datas especificado
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>> ListarRepresentadosAsResponseAsync(
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}