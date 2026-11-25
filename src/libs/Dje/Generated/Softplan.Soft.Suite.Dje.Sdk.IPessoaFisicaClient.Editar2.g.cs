#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPessoaFisicaClient
    {
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task Editar2Async(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPessoaFisicaInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> Editar2AsResponseAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPessoaFisicaInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="habilitada">
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Editar2Async(
            global::System.Guid tenantId,
            long id,
            bool habilitada,
            string? email = default,
            string? nomeSocial = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}