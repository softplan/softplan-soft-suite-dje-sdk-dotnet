#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPerfilClient
    {
        /// <summary>
        /// Atualizar perfil informado.<br/>
        /// Atualizar perfil informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task EditarAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Atualizar perfil informado.<br/>
        /// Atualizar perfil informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> EditarAsResponseAsync(
            global::System.Guid tenantId,
            long id,

            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Atualizar perfil informado.<br/>
        /// Atualizar perfil informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="cargo">
        /// Id do cargo a ser atribuído para a pessoa<br/>
        /// Example: 1
        /// </param>
        /// <param name="deveNotificar">
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) opcional da pessoa
        /// </param>
        /// <param name="escopoPermissao">
        /// Escopo de autorização da pessoa
        /// </param>
        /// <param name="funcao">
        /// Função(Cargo) da pessoa na empresa<br/>
        /// Example: Assistente administrativo
        /// </param>
        /// <param name="habilitarTodos">
        /// Se deve adicionar o escopo de permissão para todos os perfis.<br/>
        /// Example: true
        /// </param>
        /// <param name="matricula">
        /// Matriculas adicionais da pessoa. Ex.: SIAPE<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="numeroOAB">
        /// Número AOB de representante júridico na empresa<br/>
        /// Example: 12234
        /// </param>
        /// <param name="telefone">
        /// Telefone da pessoa, seguir padrão dd+número<br/>
        /// Example: 21999999999
        /// </param>
        /// <param name="ufOAB">
        /// UF AOB de representante júridico na empresa<br/>
        /// Example: RJ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditarAsync(
            global::System.Guid tenantId,
            long id,
            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelDeveNotificar deveNotificar,
            string email,
            string funcao,
            string? cargo = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>? escopoPermissao = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelHabilitarTodos? habilitarTodos = default,
            string? matricula = default,
            string? numeroOAB = default,
            string? telefone = default,
            string? ufOAB = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}