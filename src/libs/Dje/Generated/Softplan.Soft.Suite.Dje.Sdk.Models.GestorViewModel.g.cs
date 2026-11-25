
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GestorViewModel
    {
        /// <summary>
        /// Cargo do gestor<br/>
        /// Example: GESTOR_DE_CADASTRO_PRIVADO
        /// </summary>
        /// <example>GESTOR_DE_CADASTRO_PRIVADO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.GestorViewModelCargoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModelCargo Cargo { get; set; }

        /// <summary>
        /// Documento(CPF) do gestor do perfil<br/>
        /// Example: 11122233344
        /// </summary>
        /// <example>11122233344</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Documento { get; set; }

        /// <summary>
        /// Nome do gestor do perfil<br/>
        /// Example: Juliana Letícia Ester Souza
        /// </summary>
        /// <example>Juliana Letícia Ester Souza</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GestorViewModel" /> class.
        /// </summary>
        /// <param name="cargo">
        /// Cargo do gestor<br/>
        /// Example: GESTOR_DE_CADASTRO_PRIVADO
        /// </param>
        /// <param name="documento">
        /// Documento(CPF) do gestor do perfil<br/>
        /// Example: 11122233344
        /// </param>
        /// <param name="nome">
        /// Nome do gestor do perfil<br/>
        /// Example: Juliana Letícia Ester Souza
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GestorViewModel(
            global::Softplan.Soft.Suite.Dje.Sdk.GestorViewModelCargo cargo,
            string documento,
            string nome)
        {
            this.Cargo = cargo;
            this.Documento = documento ?? throw new global::System.ArgumentNullException(nameof(documento));
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GestorViewModel" /> class.
        /// </summary>
        public GestorViewModel()
        {
        }

    }
}