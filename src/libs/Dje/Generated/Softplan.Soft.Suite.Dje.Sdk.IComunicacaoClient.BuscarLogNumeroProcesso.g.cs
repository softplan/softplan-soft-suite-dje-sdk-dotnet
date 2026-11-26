#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IComunicacaoClient
    {
        /// <summary>
        /// Obter logs de um processo especifico por numero de processo.<br/>
        /// Obter logs de um processo especifico por numero de processo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort">
        /// Default Value: [id,ASC]
        /// </param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroComunicacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel> BuscarLogNumeroProcessoAsync(
            global::System.Guid tenantId,
            object numeroProcesso,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            string? numeroComunicacao = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter logs de um processo especifico por numero de processo.<br/>
        /// Obter logs de um processo especifico por numero de processo.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort">
        /// Default Value: [id,ASC]
        /// </param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroComunicacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel>> BuscarLogNumeroProcessoAsResponseAsync(
            global::System.Guid tenantId,
            object numeroProcesso,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            string? numeroComunicacao = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}