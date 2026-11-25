
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial class TicketClient
    {


        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement s_ObterTicketSecurityRequirement0 =
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
        private static readonly global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[] s_ObterTicketSecurityRequirements =
            new global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityRequirement[]
            {                s_ObterTicketSecurityRequirement0,
            };
        partial void PrepareObterTicketArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid tenantId,
            ref string numeroComunicacao,
            ref string numeroProcesso,
            ref string numeroProcesso2,
            ref string numeroComunicacao2);
        partial void PrepareObterTicketRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2);
        partial void ProcessObterTicketResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObterTicketResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> ObterTicketAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ObterTicketAsResponseAsync(
                tenantId: tenantId,
                numeroComunicacao: numeroComunicacao,
                numeroProcesso: numeroProcesso,
                numeroProcesso2: numeroProcesso2,
                numeroComunicacao2: numeroComunicacao2,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterTicketAsStreamAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObterTicketArguments(
                httpClient: HttpClient,
                tenantId: ref tenantId,
                numeroComunicacao: ref numeroComunicacao,
                numeroProcesso: ref numeroProcesso,
                numeroProcesso2: ref numeroProcesso2,
                numeroComunicacao2: ref numeroComunicacao2);


            var __authorizations = global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ObterTicketSecurityRequirements,
                operationName: "ObterTicketAsync");

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
                                path: $"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("numeroComunicacao", numeroComunicacao)
                                .AddRequiredParameter("numeroProcesso", numeroProcesso)
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
                PrepareObterTicketRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tenantId: tenantId!,
                    numeroComunicacao: numeroComunicacao!,
                    numeroProcesso: numeroProcesso!,
                    numeroProcesso2: numeroProcesso2!,
                    numeroComunicacao2: numeroComunicacao2!);

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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                ProcessObterTicketResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                            // O payload foi enviado de forma incorreta.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                byte[]? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
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
        /// Obter Ticket com certidao<br/>
        /// Obter Ticket com certidao
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="numeroProcesso2"></param>
        /// <param name="numeroComunicacao2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterTicketAsResponseAsync(
            global::System.Guid tenantId,
            string numeroComunicacao,
            string numeroProcesso,
            string numeroProcesso2,
            string numeroComunicacao2,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObterTicketArguments(
                httpClient: HttpClient,
                tenantId: ref tenantId,
                numeroComunicacao: ref numeroComunicacao,
                numeroProcesso: ref numeroProcesso,
                numeroProcesso2: ref numeroProcesso2,
                numeroComunicacao2: ref numeroComunicacao2);


            var __authorizations = global::Softplan.Soft.Suite.Dje.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ObterTicketSecurityRequirements,
                operationName: "ObterTicketAsync");

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
                                path: $"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("numeroComunicacao", numeroComunicacao)
                                .AddRequiredParameter("numeroProcesso", numeroProcesso)
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
                PrepareObterTicketRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    tenantId: tenantId!,
                    numeroComunicacao: numeroComunicacao!,
                    numeroProcesso: numeroProcesso!,
                    numeroProcesso2: numeroProcesso2!,
                    numeroComunicacao2: numeroComunicacao2!);

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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                ProcessObterTicketResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                                operationId: "ObterTicket",
                                methodName: "ObterTicketAsync",
                                pathTemplate: "$\"/api/v1/processo/{numeroProcesso2}/comunicacao/{numeroComunicacao2}/ticket\"",
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
                            // O payload foi enviado de forma incorreta.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                byte[]? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(byte[]), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = (byte[]?)global::System.Text.Json.JsonSerializer.Deserialize(__content_400, typeof(byte[]), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.Dje.Sdk.ApiException<byte[]>.Create(
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
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessObterTicketResponseContent(
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