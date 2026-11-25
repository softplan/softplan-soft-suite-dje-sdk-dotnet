#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IAdminEmpresaIncorporadaControllerClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="situacao"></param>
        /// <param name="tipoSolicitacao"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="idAdmin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ListarSolicitacoes1Async(
            string idAdmin,
            string? cnpj = default,
            string? situacao = default,
            string? tipoSolicitacao = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="situacao"></param>
        /// <param name="tipoSolicitacao"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="idAdmin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ListarSolicitacoes1AsStreamAsync(
            string idAdmin,
            string? cnpj = default,
            string? situacao = default,
            string? tipoSolicitacao = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="situacao"></param>
        /// <param name="tipoSolicitacao"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="idAdmin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ListarSolicitacoes1AsResponseAsync(
            string idAdmin,
            string? cnpj = default,
            string? situacao = default,
            string? tipoSolicitacao = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}