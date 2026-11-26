#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IEmpresaIncorporadaClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CriarSolicitacaoAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.CriarSolicitacaoRequest request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CriarSolicitacaoAsStreamAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.CriarSolicitacaoRequest request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> CriarSolicitacaoAsResponseAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.CriarSolicitacaoRequest request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="arquivos"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CriarSolicitacaoAsync(
            global::System.Guid tenantId,
            long id,
            global::System.Collections.Generic.IList<byte[]> arquivos,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel payload,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="arquivos">
        /// The streams to send as multipart 'arquivos' file parts.
        /// </param>
        /// <param name="arquivosFileNames">
        /// Optional file names to use for the multipart 'arquivos' file parts.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CriarSolicitacaoAsync(
            global::System.Guid tenantId,
            long id,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> arquivos,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel payload,
            global::System.Collections.Generic.IReadOnlyList<string>? arquivosFileNames = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="arquivos">
        /// The streams to send as multipart 'arquivos' file parts.
        /// </param>
        /// <param name="arquivosFileNames">
        /// Optional file names to use for the multipart 'arquivos' file parts.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CriarSolicitacaoAsStreamAsync(
            global::System.Guid tenantId,
            long id,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> arquivos,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel payload,
            global::System.Collections.Generic.IReadOnlyList<string>? arquivosFileNames = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="arquivos">
        /// The streams to send as multipart 'arquivos' file parts.
        /// </param>
        /// <param name="arquivosFileNames">
        /// Optional file names to use for the multipart 'arquivos' file parts.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> CriarSolicitacaoAsResponseAsync(
            global::System.Guid tenantId,
            long id,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> arquivos,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel payload,
            global::System.Collections.Generic.IReadOnlyList<string>? arquivosFileNames = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}