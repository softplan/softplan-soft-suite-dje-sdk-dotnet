
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Input com os dados para edição de um usuario para uma pessoa
    /// </summary>
    public sealed partial class AtualizarPerfilInputModel
    {
        /// <summary>
        /// Id do cargo a ser atribuído para a pessoa<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public string? Cargo { get; set; }

        /// <summary>
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </summary>
        /// <example>TODAS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deveNotificar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelDeveNotificarJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelDeveNotificar DeveNotificar { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) opcional da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Escopo de autorização da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escopoPermissao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>? EscopoPermissao { get; set; }

        /// <summary>
        /// Função(Cargo) da pessoa na empresa<br/>
        /// Example: Assistente administrativo
        /// </summary>
        /// <example>Assistente administrativo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("funcao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Funcao { get; set; }

        /// <summary>
        /// Se deve adicionar o escopo de permissão para todos os perfis.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitarTodos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelHabilitarTodosJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelHabilitarTodos? HabilitarTodos { get; set; }

        /// <summary>
        /// Matriculas adicionais da pessoa. Ex.: SIAPE<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        /// Número AOB de representante júridico na empresa<br/>
        /// Example: 12234
        /// </summary>
        /// <example>12234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroOAB")]
        public string? NumeroOAB { get; set; }

        /// <summary>
        /// Telefone da pessoa, seguir padrão dd+número<br/>
        /// Example: 21999999999
        /// </summary>
        /// <example>21999999999</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// UF AOB de representante júridico na empresa<br/>
        /// Example: RJ
        /// </summary>
        /// <example>RJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ufOAB")]
        public string? UfOAB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AtualizarPerfilInputModel" /> class.
        /// </summary>
        /// <param name="deveNotificar">
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) opcional da pessoa
        /// </param>
        /// <param name="funcao">
        /// Função(Cargo) da pessoa na empresa<br/>
        /// Example: Assistente administrativo
        /// </param>
        /// <param name="cargo">
        /// Id do cargo a ser atribuído para a pessoa<br/>
        /// Example: 1
        /// </param>
        /// <param name="escopoPermissao">
        /// Escopo de autorização da pessoa
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AtualizarPerfilInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelDeveNotificar deveNotificar,
            string email,
            string funcao,
            string? cargo,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>? escopoPermissao,
            global::Softplan.Soft.Suite.Dje.Sdk.AtualizarPerfilInputModelHabilitarTodos? habilitarTodos,
            string? matricula,
            string? numeroOAB,
            string? telefone,
            string? ufOAB)
        {
            this.Cargo = cargo;
            this.DeveNotificar = deveNotificar;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.EscopoPermissao = escopoPermissao;
            this.Funcao = funcao ?? throw new global::System.ArgumentNullException(nameof(funcao));
            this.HabilitarTodos = habilitarTodos;
            this.Matricula = matricula;
            this.NumeroOAB = numeroOAB;
            this.Telefone = telefone;
            this.UfOAB = ufOAB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AtualizarPerfilInputModel" /> class.
        /// </summary>
        public AtualizarPerfilInputModel()
        {
        }

    }
}