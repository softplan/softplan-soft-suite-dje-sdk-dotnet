
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoAuditoriaVO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoEm")]
        public global::System.DateTime? AtualizadoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoPor")]
        public string? AtualizadoPor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        public global::System.DateTime? CriadoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoPor")]
        public string? CriadoPor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modificadoEm")]
        public string? ModificadoEm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoAuditoriaVO" /> class.
        /// </summary>
        /// <param name="atualizadoEm"></param>
        /// <param name="atualizadoPor"></param>
        /// <param name="criadoEm"></param>
        /// <param name="criadoPor"></param>
        /// <param name="modificadoEm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoAuditoriaVO(
            global::System.DateTime? atualizadoEm,
            string? atualizadoPor,
            global::System.DateTime? criadoEm,
            string? criadoPor,
            string? modificadoEm)
        {
            this.AtualizadoEm = atualizadoEm;
            this.AtualizadoPor = atualizadoPor;
            this.CriadoEm = criadoEm;
            this.CriadoPor = criadoPor;
            this.ModificadoEm = modificadoEm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoAuditoriaVO" /> class.
        /// </summary>
        public InfoAuditoriaVO()
        {
        }

    }
}