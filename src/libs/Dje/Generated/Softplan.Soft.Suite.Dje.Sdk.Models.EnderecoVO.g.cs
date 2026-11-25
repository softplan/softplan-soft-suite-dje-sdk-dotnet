
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnderecoVO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cep")]
        public string? Cep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estado")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EnderecoVOEstadoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.EnderecoVOEstado? Estado { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("municipio")]
        public string? Municipio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoVO" /> class.
        /// </summary>
        /// <param name="cep"></param>
        /// <param name="estado"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnderecoVO(
            string? cep,
            global::Softplan.Soft.Suite.Dje.Sdk.EnderecoVOEstado? estado,
            string? municipio,
            string? uf)
        {
            this.Cep = cep;
            this.Estado = estado;
            this.Municipio = municipio;
            this.Uf = uf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoVO" /> class.
        /// </summary>
        public EnderecoVO()
        {
        }

    }
}