
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RejeitarEmpresaIncorporadaInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motivo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Motivo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejeitarEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        /// <param name="motivo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejeitarEmpresaIncorporadaInputModel(
            string motivo)
        {
            this.Motivo = motivo ?? throw new global::System.ArgumentNullException(nameof(motivo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejeitarEmpresaIncorporadaInputModel" /> class.
        /// </summary>
        public RejeitarEmpresaIncorporadaInputModel()
        {
        }

    }
}