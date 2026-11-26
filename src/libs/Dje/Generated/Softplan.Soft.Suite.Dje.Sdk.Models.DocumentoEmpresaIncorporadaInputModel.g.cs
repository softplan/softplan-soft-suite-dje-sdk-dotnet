
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DocumentoEmpresaIncorporadaInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeDocumento")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NomeDocumento { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        /// <param name="nomeDocumento"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentoEmpresaIncorporadaInputModel(
            string nomeDocumento)
        {
            this.NomeDocumento = nomeDocumento ?? throw new global::System.ArgumentNullException(nameof(nomeDocumento));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        public DocumentoEmpresaIncorporadaInputModel()
        {
        }

    }
}