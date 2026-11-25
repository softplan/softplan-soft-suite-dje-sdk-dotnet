
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SolicitarEmpresaIncorporadaInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentos")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>? Documentos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitarEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="documentos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SolicitarEmpresaIncorporadaInputModel(
            string cnpj,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>? documentos)
        {
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
            this.Documentos = documentos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitarEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        public SolicitarEmpresaIncorporadaInputModel()
        {
        }

    }
}