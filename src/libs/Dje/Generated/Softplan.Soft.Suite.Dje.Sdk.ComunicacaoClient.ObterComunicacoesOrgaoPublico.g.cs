
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial class ComunicacaoClient
    {


        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement s_ObterComunicacoesOrgaoPublicoSecurityRequirement0 =
            new global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Softplan.Soft.Suite.Dje.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Softplan.Soft.Suite.Dje.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[] s_ObterComunicacoesOrgaoPublicoSecurityRequirements =
            new global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[]
            {                s_ObterComunicacoesOrgaoPublicoSecurityRequirement0,
            };
        partial void PrepareObterComunicacoesOrgaoPublicoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid tenantId,
            ref global::System.DateTimeOffset? dataInicio,
            ref global::System.DateTimeOffset? dataFim,
            ref string? numeroProcesso,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao? tipoComunicacao,
            ref string? assunto,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente statusCiente,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada? parteInteressada,
            ref string? documentoRepresentanteDestinatario,
            ref global::System.DateTime? dataCiencia,
            ref global::System.DateTime? dataFinalCiencia,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica? ramoJustica,
            ref int? jtrProprietario,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual,
            ref int? page,
            ref int? size,
            global::System.Collections.Generic.IList<string>? sort);
        partial void PrepareObterComunicacoesOrgaoPublicoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid tenantId,
            global::System.DateTimeOffset? dataInicio,
            global::System.DateTimeOffset? dataFim,
            string? numeroProcesso,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao? tipoComunicacao,
            string? assunto,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente statusCiente,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada? parteInteressada,
            string? documentoRepresentanteDestinatario,
            global::System.DateTime? dataCiencia,
            global::System.DateTime? dataFinalCiencia,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica? ramoJustica,
            int? jtrProprietario,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual,
            int? page,
            int? size,
            global::System.Collections.Generic.IList<string>? sort);
        partial void ProcessObterComunicacoesOrgaoPublicoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObterComunicacoesOrgaoPublicoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

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
        public async global::System.Threading.Tasks.Task<byte[]> ObterComunicacoesOrgaoPublicoAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ObterComunicacoesOrgaoPublicoAsResponseAsync(
                tenantId: tenantId,
                statusCiente: statusCiente,
                dataInicio: dataInicio,
                dataFim: dataFim,
                numeroProcesso: numeroProcesso,
                tipoComunicacao: tipoComunicacao,
                assunto: assunto,
                parteInteressada: parteInteressada,
                documentoRepresentanteDestinatario: documentoRepresentanteDestinatario,
                dataCiencia: dataCiencia,
                dataFinalCiencia: dataFinalCiencia,
                ramoJustica: ramoJustica,
                jtrProprietario: jtrProprietario,
                modalidadeComunicacaoProcessual: modalidadeComunicacaoProcessual,
                page: page,
                size: size,
                sort: sort,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterComunicacoesOrgaoPublicoAsStreamAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObterComunicacoesOrgaoPublicoArguments(
                httpClient: HttpClient,
                tenantId: ref tenantId,
                dataInicio: ref dataInicio,
                dataFim: ref dataFim,
                numeroProcesso: ref numeroProcesso,
                tipoComunicacao: ref tipoComunicacao,
                assunto: ref assunto,
                statusCiente: ref statusCiente,
                parteInteressada: ref parteInteressada,
                documentoRepresentanteDestinatario: ref documentoRepresentanteDestinatario,
                dataCiencia: ref dataCiencia,
                dataFinalCiencia: ref dataFinalCiencia,
                ramoJustica: ref ramoJustica,
                jtrProprietario: ref jtrProprietario,
                modalidadeComunicacaoProcessual: ref modalidadeComunicacaoProcessual,
                page: ref page,
                size: ref size,
                sort: sort);


            var __authorizations = global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ObterComunicacoesOrgaoPublicoSecurityRequirements,
                operationName: "ObterComunicacoesOrgaoPublicoAsync");

            using var __timeoutCancellationTokenSource = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Softplan.Soft.Suite.Dje.Sdk.PathBuilder(
                                path: "/api/v1/comunicacoes/orgaos-publicos",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("dataInicio", dataInicio?.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFzzz", global::System.Globalization.CultureInfo.InvariantCulture))
                                .AddOptionalParameter("dataFim", dataFim?.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFzzz", global::System.Globalization.CultureInfo.InvariantCulture))
                                .AddOptionalParameter("numeroProcesso", numeroProcesso)
                                .AddOptionalParameter("tipoComunicacao", tipoComunicacao?.ToValueString())
                                .AddOptionalParameter("assunto", assunto)
                                .AddRequiredParameter("statusCiente", statusCiente.ToValueString())
                                .AddOptionalParameter("parteInteressada", parteInteressada?.ToValueString())
                                .AddOptionalParameter("documentoRepresentanteDestinatario", documentoRepresentanteDestinatario)
                                .AddOptionalParameter("dataCiencia", dataCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("dataFinalCiencia", dataFinalCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("ramoJustica", ramoJustica?.ToValueString())
                                .AddOptionalParameter("jtrProprietario", jtrProprietario?.ToString())
                                .AddOptionalParameter("modalidadeComunicacaoProcessual", modalidadeComunicacaoProcessual?.ToValueString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("size", size?.ToString())
                                .AddOptionalParameter("sort", sort, delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                __httpRequest.Headers.TryAddWithoutValidation("tenantId", tenantId.ToString());

                global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareObterComunicacoesOrgaoPublicoRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tenantId: tenantId!,
                    dataInicio: dataInicio,
                    dataFim: dataFim,
                    numeroProcesso: numeroProcesso,
                    tipoComunicacao: tipoComunicacao,
                    assunto: assunto,
                    statusCiente: statusCiente!,
                    parteInteressada: parteInteressada,
                    documentoRepresentanteDestinatario: documentoRepresentanteDestinatario,
                    dataCiencia: dataCiencia,
                    dataFinalCiencia: dataFinalCiencia,
                    ramoJustica: ramoJustica,
                    jtrProprietario: jtrProprietario,
                    modalidadeComunicacaoProcessual: modalidadeComunicacaoProcessual,
                    page: page,
                    size: size,
                    sort: sort);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessObterComunicacoesOrgaoPublicoResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Ocorreu um erro negocial (por exemplo, de validação)
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Ocorreu um erro inesperado. O erro foi logado e será investigado pela equipe técnica
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                byte[]? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Usuário não autenticado
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                byte[]? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Acesso negado
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                byte[]? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Entidade inexistente
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                byte[]? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            try
                            {
                                __response.EnsureSuccessStatusCode();

                                var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                return new global::Softplan.Soft.Suite.Dje.Sdk.ResponseStream(__response, __content);
                            }
                            catch (global::System.Exception __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                }
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterComunicacoesOrgaoPublicoAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObterComunicacoesOrgaoPublicoArguments(
                httpClient: HttpClient,
                tenantId: ref tenantId,
                dataInicio: ref dataInicio,
                dataFim: ref dataFim,
                numeroProcesso: ref numeroProcesso,
                tipoComunicacao: ref tipoComunicacao,
                assunto: ref assunto,
                statusCiente: ref statusCiente,
                parteInteressada: ref parteInteressada,
                documentoRepresentanteDestinatario: ref documentoRepresentanteDestinatario,
                dataCiencia: ref dataCiencia,
                dataFinalCiencia: ref dataFinalCiencia,
                ramoJustica: ref ramoJustica,
                jtrProprietario: ref jtrProprietario,
                modalidadeComunicacaoProcessual: ref modalidadeComunicacaoProcessual,
                page: ref page,
                size: ref size,
                sort: sort);


            var __authorizations = global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ObterComunicacoesOrgaoPublicoSecurityRequirements,
                operationName: "ObterComunicacoesOrgaoPublicoAsync");

            using var __timeoutCancellationTokenSource = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Softplan.Soft.Suite.Dje.Sdk.PathBuilder(
                                path: "/api/v1/comunicacoes/orgaos-publicos",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("dataInicio", dataInicio?.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFzzz", global::System.Globalization.CultureInfo.InvariantCulture))
                                .AddOptionalParameter("dataFim", dataFim?.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFzzz", global::System.Globalization.CultureInfo.InvariantCulture))
                                .AddOptionalParameter("numeroProcesso", numeroProcesso)
                                .AddOptionalParameter("tipoComunicacao", tipoComunicacao?.ToValueString())
                                .AddOptionalParameter("assunto", assunto)
                                .AddRequiredParameter("statusCiente", statusCiente.ToValueString())
                                .AddOptionalParameter("parteInteressada", parteInteressada?.ToValueString())
                                .AddOptionalParameter("documentoRepresentanteDestinatario", documentoRepresentanteDestinatario)
                                .AddOptionalParameter("dataCiencia", dataCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("dataFinalCiencia", dataFinalCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("ramoJustica", ramoJustica?.ToValueString())
                                .AddOptionalParameter("jtrProprietario", jtrProprietario?.ToString())
                                .AddOptionalParameter("modalidadeComunicacaoProcessual", modalidadeComunicacaoProcessual?.ToValueString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("size", size?.ToString())
                                .AddOptionalParameter("sort", sort, delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                __httpRequest.Headers.TryAddWithoutValidation("tenantId", tenantId.ToString());

                global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareObterComunicacoesOrgaoPublicoRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tenantId: tenantId!,
                    dataInicio: dataInicio,
                    dataFim: dataFim,
                    numeroProcesso: numeroProcesso,
                    tipoComunicacao: tipoComunicacao,
                    assunto: assunto,
                    statusCiente: statusCiente!,
                    parteInteressada: parteInteressada,
                    documentoRepresentanteDestinatario: documentoRepresentanteDestinatario,
                    dataCiencia: dataCiencia,
                    dataFinalCiencia: dataFinalCiencia,
                    ramoJustica: ramoJustica,
                    jtrProprietario: jtrProprietario,
                    modalidadeComunicacaoProcessual: modalidadeComunicacaoProcessual,
                    page: page,
                    size: size,
                    sort: sort);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessObterComunicacoesOrgaoPublicoResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterComunicacoesOrgaoPublico",
                                methodName: "ObterComunicacoesOrgaoPublicoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes/orgaos-publicos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Ocorreu um erro negocial (por exemplo, de validação)
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<global::Softplan.Soft.Suite.Dje.Sdk.OperationResultFailViewModel>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Ocorreu um erro inesperado. O erro foi logado e será investigado pela equipe técnica
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                byte[]? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_500, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Usuário não autenticado
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                byte[]? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Acesso negado
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                byte[]? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Entidade inexistente
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                byte[]? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessObterComunicacoesOrgaoPublicoResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: null,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}