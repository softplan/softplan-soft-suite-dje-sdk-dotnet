
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditarEnderecoInputModel
    {
        /// <summary>
        /// CEP
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cep")]
        public string? Cep { get; set; }

        /// <summary>
        /// Sigla do Estado<br/>
        /// Example: RJ
        /// </summary>
        /// <example>RJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("estado")]
        public string? Estado { get; set; }

        /// <summary>
        /// Município
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("municipio")]
        public string? Municipio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditarEnderecoInputModel" /> class.
        /// </summary>
        /// <param name="cep">
        /// CEP
        /// </param>
        /// <param name="estado">
        /// Sigla do Estado<br/>
        /// Example: RJ
        /// </param>
        /// <param name="municipio">
        /// Município
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditarEnderecoInputModel(
            string? cep,
            string? estado,
            string? municipio)
        {
            this.Cep = cep;
            this.Estado = estado;
            this.Municipio = municipio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditarEnderecoInputModel" /> class.
        /// </summary>
        public EditarEnderecoInputModel()
        {
        }

    }
}