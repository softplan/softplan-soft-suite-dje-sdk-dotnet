#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IComunicacaoClient
    {
        /// <summary>
        /// Obter lista de comunicações.<br/>
        /// Obter lista de comunicações.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="tipoComunicacao">
        /// Example: C
        /// </param>
        /// <param name="assunto"></param>
        /// <param name="statusCiente">
        /// Example: A
        /// </param>
        /// <param name="parteInteressada">
        /// Example: 2
        /// </param>
        /// <param name="documentoRepresentanteDestinatario"></param>
        /// <param name="dataCiencia"></param>
        /// <param name="dataFinalCiencia"></param>
        /// <param name="jtrProprietario"></param>
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
        global::System.Threading.Tasks.Task<byte[]> ObterComunicacoesAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de comunicações.<br/>
        /// Obter lista de comunicações.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="tipoComunicacao">
        /// Example: C
        /// </param>
        /// <param name="assunto"></param>
        /// <param name="statusCiente">
        /// Example: A
        /// </param>
        /// <param name="parteInteressada">
        /// Example: 2
        /// </param>
        /// <param name="documentoRepresentanteDestinatario"></param>
        /// <param name="dataCiencia"></param>
        /// <param name="dataFinalCiencia"></param>
        /// <param name="jtrProprietario"></param>
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterComunicacoesAsStreamAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de comunicações.<br/>
        /// Obter lista de comunicações.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="tipoComunicacao">
        /// Example: C
        /// </param>
        /// <param name="assunto"></param>
        /// <param name="statusCiente">
        /// Example: A
        /// </param>
        /// <param name="parteInteressada">
        /// Example: 2
        /// </param>
        /// <param name="documentoRepresentanteDestinatario"></param>
        /// <param name="dataCiencia"></param>
        /// <param name="dataFinalCiencia"></param>
        /// <param name="jtrProprietario"></param>
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
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterComunicacoesAsResponseAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}