
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InformarCienciaInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeUsuarioCiencia")]
        public string? NomeUsuarioCiencia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialVersionUID")]
        public long? SerialVersionUID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuarioCiencia")]
        public string? UsuarioCiencia { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InformarCienciaInputModel" /> class.
        /// </summary>
        /// <param name="nomeUsuarioCiencia"></param>
        /// <param name="serialVersionUID"></param>
        /// <param name="usuarioCiencia"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InformarCienciaInputModel(
            string? nomeUsuarioCiencia,
            long? serialVersionUID,
            string? usuarioCiencia)
        {
            this.NomeUsuarioCiencia = nomeUsuarioCiencia;
            this.SerialVersionUID = serialVersionUID;
            this.UsuarioCiencia = usuarioCiencia;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformarCienciaInputModel" /> class.
        /// </summary>
        public InformarCienciaInputModel()
        {
        }

    }
}