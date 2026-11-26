
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilialBCnpjViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilialBCnpjViewModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="nome"></param>
        /// <param name="tipo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilialBCnpjViewModel(
            string? cnpj,
            string? nome,
            string? tipo)
        {
            this.Cnpj = cnpj;
            this.Nome = nome;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilialBCnpjViewModel" /> class.
        /// </summary>
        public FilialBCnpjViewModel()
        {
        }

    }
}