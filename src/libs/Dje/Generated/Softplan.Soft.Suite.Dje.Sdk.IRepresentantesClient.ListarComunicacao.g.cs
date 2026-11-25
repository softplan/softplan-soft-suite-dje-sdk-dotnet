#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IRepresentantesClient
    {
        /// <summary>
        /// Retorna a lista das comunicações processuais de um representante.<br/>
        /// Retorna a lista das comunicações processuais de um representante.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="tipoComunicacao">
        /// Example: C
        /// </param>
        /// <param name="assunto"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="representado"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="ciente">
        /// Example: A
        /// </param>
        /// <param name="parteInteressada">
        /// Example: 2
        /// </param>
        /// <param name="documentoRepresentanteDestinatario"></param>
        /// <param name="dataCiencia"></param>
        /// <param name="dataFinalCiencia"></param>
        /// <param name="filtroDataCerta"></param>
        /// <param name="modalidadeComunicacaoProcessual">
        /// Example: A
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel> ListarComunicacaoAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoCiente ciente,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            string? dataInicio = default,
            string? dataFim = default,
            string? representado = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            bool? filtroDataCerta = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retorna a lista das comunicações processuais de um representante.<br/>
        /// Retorna a lista das comunicações processuais de um representante.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="tipoComunicacao">
        /// Example: C
        /// </param>
        /// <param name="assunto"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="representado"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="ciente">
        /// Example: A
        /// </param>
        /// <param name="parteInteressada">
        /// Example: 2
        /// </param>
        /// <param name="documentoRepresentanteDestinatario"></param>
        /// <param name="dataCiencia"></param>
        /// <param name="dataFinalCiencia"></param>
        /// <param name="filtroDataCerta"></param>
        /// <param name="modalidadeComunicacaoProcessual">
        /// Example: A
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>> ListarComunicacaoAsResponseAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoCiente ciente,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            string? dataInicio = default,
            string? dataFim = default,
            string? representado = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            bool? filtroDataCerta = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}