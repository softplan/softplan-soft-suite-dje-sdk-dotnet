#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IRepresentantesClient
    {
        /// <summary>
        /// Adiciona perfil de representante, se pessoa for representante valido.<br/>
        /// Adiciona perfil de representante, se pessoa for representante valido.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task SeVerdadeiroAdicionarRepresentanteAsync(

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarRepresentanteInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adiciona perfil de representante, se pessoa for representante valido.<br/>
        /// Adiciona perfil de representante, se pessoa for representante valido.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> SeVerdadeiroAdicionarRepresentanteAsResponseAsync(

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarRepresentanteInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adiciona perfil de representante, se pessoa for representante valido.<br/>
        /// Adiciona perfil de representante, se pessoa for representante valido.
        /// </summary>
        /// <param name="email">
        /// Email do usuário
        /// </param>
        /// <param name="funcao">
        /// Função do usuário
        /// </param>
        /// <param name="matricula">
        /// Matricula do usuário
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social do usuário
        /// </param>
        /// <param name="telefone">
        /// Telefone do usuário
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SeVerdadeiroAdicionarRepresentanteAsync(
            string? email = default,
            string? funcao = default,
            string? matricula = default,
            string? nomeSocial = default,
            string? telefone = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}