#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    public partial interface IPerfilClient
    {
        /// <summary>
        /// Criar pessoa com o perfil/cargo informado.<br/>
        /// Criar pessoa com o perfil/cargo informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CriarAsync(
            global::System.Guid tenantId,

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar pessoa com o perfil/cargo informado.<br/>
        /// Criar pessoa com o perfil/cargo informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKHttpResponse> CriarAsResponseAsync(
            global::System.Guid tenantId,

            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModel request,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Criar pessoa com o perfil/cargo informado.<br/>
        /// Criar pessoa com o perfil/cargo informado.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cargo">
        /// Id do cargo a ser atribuido para a pessoa.(ADMINISTRADOR_GERAL_CNJ - 1,<br/>
        /// ADMINISTRADOR_DA_EMPRESA - 2,<br/>
        /// ADMINISTRADOR_ORGAO_PUBLICO - 3,<br/>
        /// GESTOR_DE_CADASTRO_PRIVADO - 4,<br/>
        /// GESTOR_DE_CADASTRO_PUBLICO - 5,<br/>
        /// PREPOSTO_DA_COMUNICACAO_PRIVADO - 6,<br/>
        /// PREPOSTO_DA_COMUNICACAO_PUBLICO - 7)<br/>
        /// Example: 1
        /// </param>
        /// <param name="cpf">
        /// Número do Cadastro de Pessoas Físicas da Receita Federal<br/>
        /// Example: 20134750047
        /// </param>
        /// <param name="deveNotificar">
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) adicional da pessoa<br/>
        /// Example: noah@gmail.com.br
        /// </param>
        /// <param name="escopoPermissao">
        /// Escopo de autorização da pessoa
        /// </param>
        /// <param name="funcao">
        /// Função(Cargo) da pessoa na empresa<br/>
        /// Example: Assistente administrativo
        /// </param>
        /// <param name="matricula">
        /// Matriculas adicionais da pessoa. Ex.: SIAPE<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ<br/>
        /// Example: Noah Kevin
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
        global::System.Threading.Tasks.Task CriarAsync(
            global::System.Guid tenantId,
            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelCargo cargo,
            string cpf,
            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelDeveNotificar deveNotificar,
            string email,
            string nomeSocial,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>? escopoPermissao = default,
            string? funcao = default,
            string? matricula = default,
            string? numeroOAB = default,
            string? telefone = default,
            string? ufOAB = default,
            global::Softplan.Soft.Suite.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}