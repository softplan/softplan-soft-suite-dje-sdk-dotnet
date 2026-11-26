
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObterInteiroTeorModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linksDocumentos")]
        public global::System.Collections.Generic.IList<string>? LinksDocumentos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linksDocumentosAdicionais")]
        public global::System.Collections.Generic.IList<string>? LinksDocumentosAdicionais { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterInteiroTeorModel" /> class.
        /// </summary>
        /// <param name="linksDocumentos"></param>
        /// <param name="linksDocumentosAdicionais"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObterInteiroTeorModel(
            global::System.Collections.Generic.IList<string>? linksDocumentos,
            global::System.Collections.Generic.IList<string>? linksDocumentosAdicionais)
        {
            this.LinksDocumentos = linksDocumentos;
            this.LinksDocumentosAdicionais = linksDocumentosAdicionais;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterInteiroTeorModel" /> class.
        /// </summary>
        public ObterInteiroTeorModel()
        {
        }

    }
}