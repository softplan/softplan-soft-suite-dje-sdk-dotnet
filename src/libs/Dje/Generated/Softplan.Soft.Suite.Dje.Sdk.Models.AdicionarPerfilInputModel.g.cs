
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Input com os dados para inclusão de um usuario para uma pessoa
    /// </summary>
    public sealed partial class AdicionarPerfilInputModel
    {
        /// <summary>
        /// Id do cargo a ser atribuido para a pessoa.(ADMINISTRADOR_GERAL_CNJ - 1,<br/>
        /// ADMINISTRADOR_DA_EMPRESA - 2,<br/>
        /// ADMINISTRADOR_ORGAO_PUBLICO - 3,<br/>
        /// GESTOR_DE_CADASTRO_PRIVADO - 4,<br/>
        /// GESTOR_DE_CADASTRO_PUBLICO - 5,<br/>
        /// PREPOSTO_DA_COMUNICACAO_PRIVADO - 6,<br/>
        /// PREPOSTO_DA_COMUNICACAO_PUBLICO - 7)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelCargoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelCargo Cargo { get; set; }

        /// <summary>
        /// Número do Cadastro de Pessoas Físicas da Receita Federal<br/>
        /// Example: 20134750047
        /// </summary>
        /// <example>20134750047</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpf { get; set; }

        /// <summary>
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </summary>
        /// <example>TODAS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deveNotificar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelDeveNotificarJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelDeveNotificar DeveNotificar { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) adicional da pessoa<br/>
        /// Example: noah@gmail.com.br
        /// </summary>
        /// <example>noah@gmail.com.br</example>
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
        public string? Funcao { get; set; }

        /// <summary>
        /// Matriculas adicionais da pessoa. Ex.: SIAPE<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ<br/>
        /// Example: Noah Kevin
        /// </summary>
        /// <example>Noah Kevin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeSocial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NomeSocial { get; set; }

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
        /// Initializes a new instance of the <see cref="AdicionarPerfilInputModel" /> class.
        /// </summary>
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
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ<br/>
        /// Example: Noah Kevin
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
        public AdicionarPerfilInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelCargo cargo,
            string cpf,
            global::Softplan.Soft.Suite.Dje.Sdk.AdicionarPerfilInputModelDeveNotificar deveNotificar,
            string email,
            string nomeSocial,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModel>? escopoPermissao,
            string? funcao,
            string? matricula,
            string? numeroOAB,
            string? telefone,
            string? ufOAB)
        {
            this.Cargo = cargo;
            this.Cpf = cpf ?? throw new global::System.ArgumentNullException(nameof(cpf));
            this.DeveNotificar = deveNotificar;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.EscopoPermissao = escopoPermissao;
            this.Funcao = funcao;
            this.Matricula = matricula;
            this.NomeSocial = nomeSocial ?? throw new global::System.ArgumentNullException(nameof(nomeSocial));
            this.NumeroOAB = numeroOAB;
            this.Telefone = telefone;
            this.UfOAB = ufOAB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarPerfilInputModel" /> class.
        /// </summary>
        public AdicionarPerfilInputModel()
        {
        }

    }
}