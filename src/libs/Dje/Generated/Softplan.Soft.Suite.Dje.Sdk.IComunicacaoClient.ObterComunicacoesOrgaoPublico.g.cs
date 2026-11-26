#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IComunicacaoClient
    {
        /// <summary>
        /// Obter lista de comunicações com informações de orgãos publicos.<br/>
        /// Obter lista de comunicações com informações de orgãos publicos.
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
        /// <param name="ramoJustica">
        /// Identifica o ramo de justica da comunicacao<br/>
        /// Example: 1-JUSTICA COMUM, 2-JUSTICA ESTADUAL, 3-JUSTICA FEDERAL, 4-JUSTICA MILITAR, 5-JUSTICA DO TRABALHO, 6-JUSTICA ELEITORAL
        /// </param>
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
        global::System.Threading.Tasks.Task<byte[]> ObterComunicacoesOrgaoPublicoAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica? ramoJustica = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de comunicações com informações de orgãos publicos.<br/>
        /// Obter lista de comunicações com informações de orgãos publicos.
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
        /// <param name="ramoJustica">
        /// Identifica o ramo de justica da comunicacao<br/>
        /// Example: 1-JUSTICA COMUM, 2-JUSTICA ESTADUAL, 3-JUSTICA FEDERAL, 4-JUSTICA MILITAR, 5-JUSTICA DO TRABALHO, 6-JUSTICA ELEITORAL
        /// </param>
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterComunicacoesOrgaoPublicoAsStreamAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica? ramoJustica = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de comunicações com informações de orgãos publicos.<br/>
        /// Obter lista de comunicações com informações de orgãos publicos.
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
        /// <param name="ramoJustica">
        /// Identifica o ramo de justica da comunicacao<br/>
        /// Example: 1-JUSTICA COMUM, 2-JUSTICA ESTADUAL, 3-JUSTICA FEDERAL, 4-JUSTICA MILITAR, 5-JUSTICA DO TRABALHO, 6-JUSTICA ELEITORAL
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterComunicacoesOrgaoPublicoAsResponseAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente statusCiente,
            global::System.DateTimeOffset? dataInicio = default,
            global::System.DateTimeOffset? dataFim = default,
            string? numeroProcesso = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao? tipoComunicacao = default,
            string? assunto = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada? parteInteressada = default,
            string? documentoRepresentanteDestinatario = default,
            global::System.DateTime? dataCiencia = default,
            global::System.DateTime? dataFinalCiencia = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica? ramoJustica = default,
            int? jtrProprietario = default,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}