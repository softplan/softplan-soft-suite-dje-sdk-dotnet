#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPessoaFisicaRestControllerClient
    {
        /// <summary>
        /// Desativar o próprio cadastro de pessoa física.<br/>
        /// Desativar o próprio cadastro de pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DesativarAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Desativar o próprio cadastro de pessoa física.<br/>
        /// Desativar o próprio cadastro de pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DesativarAsStreamAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Desativar o próprio cadastro de pessoa física.<br/>
        /// Desativar o próprio cadastro de pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> DesativarAsResponseAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}