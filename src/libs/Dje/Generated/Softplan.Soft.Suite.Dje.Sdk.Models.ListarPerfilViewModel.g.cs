
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListarPerfilViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        public string? CriadoEm { get; set; }

        /// <summary>
        /// CPF da pessoa dona do perfil<br/>
        /// Example: 11122233355
        /// </summary>
        /// <example>11122233355</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Documento { get; set; }

        /// <summary>
        /// Função da pessoa dona do perfil<br/>
        /// Example: Assistente Administrativo
        /// </summary>
        /// <example>Assistente Administrativo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("funcao")]
        public string? Funcao { get; set; }

        /// <summary>
        /// Informação do gestor que criou o perfil
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gestor")]
        public global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModel? Gestor { get; set; }

        /// <summary>
        /// Id da pessoa dona do perfil<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("idPessoa")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long IdPessoa { get; set; }

        /// <summary>
        /// Nome da pessoa dona do perfil<br/>
        /// Example: Kamilly Mariane Mirella Figueiredo
        /// </summary>
        /// <example>Kamilly Mariane Mirella Figueiredo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListarPerfilViewModel" /> class.
        /// </summary>
        /// <param name="documento">
        /// CPF da pessoa dona do perfil<br/>
        /// Example: 11122233355
        /// </param>
        /// <param name="idPessoa">
        /// Id da pessoa dona do perfil<br/>
        /// Example: 1
        /// </param>
        /// <param name="nome">
        /// Nome da pessoa dona do perfil<br/>
        /// Example: Kamilly Mariane Mirella Figueiredo
        /// </param>
        /// <param name="criadoEm"></param>
        /// <param name="funcao">
        /// Função da pessoa dona do perfil<br/>
        /// Example: Assistente Administrativo
        /// </param>
        /// <param name="gestor">
        /// Informação do gestor que criou o perfil
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListarPerfilViewModel(
            string documento,
            long idPessoa,
            string nome,
            string? criadoEm,
            string? funcao,
            global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModel? gestor)
        {
            this.CriadoEm = criadoEm;
            this.Documento = documento ?? throw new global::System.ArgumentNullException(nameof(documento));
            this.Funcao = funcao;
            this.Gestor = gestor;
            this.IdPessoa = idPessoa;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListarPerfilViewModel" /> class.
        /// </summary>
        public ListarPerfilViewModel()
        {
        }

    }
}