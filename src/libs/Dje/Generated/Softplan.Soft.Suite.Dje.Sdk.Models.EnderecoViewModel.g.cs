
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnderecoViewModel
    {
        /// <summary>
        /// CEP da pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cep")]
        public string? Cep { get; set; }

        /// <summary>
        /// Município da pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("municipio")]
        public string? Municipio { get; set; }

        /// <summary>
        /// Estado da pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoViewModel" /> class.
        /// </summary>
        /// <param name="cep">
        /// CEP da pessoa jurídica
        /// </param>
        /// <param name="municipio">
        /// Município da pessoa jurídica
        /// </param>
        /// <param name="uf">
        /// Estado da pessoa jurídica
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnderecoViewModel(
            string? cep,
            string? municipio,
            string? uf)
        {
            this.Cep = cep;
            this.Municipio = municipio;
            this.Uf = uf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoViewModel" /> class.
        /// </summary>
        public EnderecoViewModel()
        {
        }

    }
}