
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial class RepresentantesClient
    {


        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement s_ListarComunicacaoSecurityRequirement0 =
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
        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[] s_ListarComunicacaoSecurityRequirements =
            new global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[]
            {                s_ListarComunicacaoSecurityRequirement0,
            };
        partial void PrepareListarComunicacaoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid tenantId,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoTipoComunicacao? tipoComunicacao,
            ref string? assunto,
            ref string? dataInicio,
            ref string? dataFim,
            ref string? representado,
            ref string? numeroProcesso,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoCiente ciente,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoParteInteressada? parteInteressada,
            ref string? documentoRepresentanteDestinatario,
            ref global::System.DateTime? dataCiencia,
            ref global::System.DateTime? dataFinalCiencia,
            ref bool? filtroDataCerta,
            ref global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual,
            ref int? page,
            ref int? size,
            global::System.Collections.Generic.IList<string>? sort);
        partial void PrepareListarComunicacaoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoTipoComunicacao? tipoComunicacao,
            string? assunto,
            string? dataInicio,
            string? dataFim,
            string? representado,
            string? numeroProcesso,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoCiente ciente,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoParteInteressada? parteInteressada,
            string? documentoRepresentanteDestinatario,
            global::System.DateTime? dataCiencia,
            global::System.DateTime? dataFinalCiencia,
            bool? filtroDataCerta,
            global::Softplan.Soft.Suite.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual? modalidadeComunicacaoProcessual,
            int? page,
            int? size,
            global::System.Collections.Generic.IList<string>? sort);
        partial void ProcessListarComunicacaoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListarComunicacaoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel> ListarComunicacaoAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListarComunicacaoAsResponseAsync(
                tenantId: tenantId,
                ciente: ciente,
                tipoComunicacao: tipoComunicacao,
                assunto: assunto,
                dataInicio: dataInicio,
                dataFim: dataFim,
                representado: representado,
                numeroProcesso: numeroProcesso,
                parteInteressada: parteInteressada,
                documentoRepresentanteDestinatario: documentoRepresentanteDestinatario,
                dataCiencia: dataCiencia,
                dataFinalCiencia: dataFinalCiencia,
                filtroDataCerta: filtroDataCerta,
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
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>> ListarComunicacaoAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListarComunicacaoArguments(
                httpClient: HttpClient,
                tenantId: ref tenantId,
                tipoComunicacao: ref tipoComunicacao,
                assunto: ref assunto,
                dataInicio: ref dataInicio,
                dataFim: ref dataFim,
                representado: ref representado,
                numeroProcesso: ref numeroProcesso,
                ciente: ref ciente,
                parteInteressada: ref parteInteressada,
                documentoRepresentanteDestinatario: ref documentoRepresentanteDestinatario,
                dataCiencia: ref dataCiencia,
                dataFinalCiencia: ref dataFinalCiencia,
                filtroDataCerta: ref filtroDataCerta,
                modalidadeComunicacaoProcessual: ref modalidadeComunicacaoProcessual,
                page: ref page,
                size: ref size,
                sort: sort);


            var __authorizations = global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListarComunicacaoSecurityRequirements,
                operationName: "ListarComunicacaoAsync");

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
                                path: "/api/v1/comunicacoes-representantes",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("tipoComunicacao", tipoComunicacao?.ToValueString())
                                .AddOptionalParameter("assunto", assunto)
                                .AddOptionalParameter("dataInicio", dataInicio)
                                .AddOptionalParameter("dataFim", dataFim)
                                .AddOptionalParameter("representado", representado)
                                .AddOptionalParameter("numeroProcesso", numeroProcesso)
                                .AddRequiredParameter("ciente", ciente.ToValueString())
                                .AddOptionalParameter("parteInteressada", parteInteressada?.ToValueString())
                                .AddOptionalParameter("documentoRepresentanteDestinatario", documentoRepresentanteDestinatario)
                                .AddOptionalParameter("dataCiencia", dataCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("dataFinalCiencia", dataFinalCiencia?.ToString("yyyy-MM-dd"))
                                .AddOptionalParameter("filtroDataCerta", filtroDataCerta?.ToString().ToLowerInvariant())
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
                PrepareListarComunicacaoRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tenantId: tenantId!,
                    tipoComunicacao: tipoComunicacao,
                    assunto: assunto,
                    dataInicio: dataInicio,
                    dataFim: dataFim,
                    representado: representado,
                    numeroProcesso: numeroProcesso,
                    ciente: ciente!,
                    parteInteressada: parteInteressada,
                    documentoRepresentanteDestinatario: documentoRepresentanteDestinatario,
                    dataCiencia: dataCiencia,
                    dataFinalCiencia: dataFinalCiencia,
                    filtroDataCerta: filtroDataCerta,
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
                                operationId: "ListarComunicacao",
                                methodName: "ListarComunicacaoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes-representantes\"",
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
                                operationId: "ListarComunicacao",
                                methodName: "ListarComunicacaoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes-representantes\"",
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
                                operationId: "ListarComunicacao",
                                methodName: "ListarComunicacaoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes-representantes\"",
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
                ProcessListarComunicacaoResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListarComunicacao",
                                methodName: "ListarComunicacaoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes-representantes\"",
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
                                operationId: "ListarComunicacao",
                                methodName: "ListarComunicacaoAsync",
                                pathTemplate: "\"/api/v1/comunicacoes-representantes\"",
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
                            //
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListarComunicacaoResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
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
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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