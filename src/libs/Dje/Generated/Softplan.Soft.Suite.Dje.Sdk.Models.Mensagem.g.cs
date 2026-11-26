
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Mensagem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public string? Codigo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mensagem")]
        public string? Mensagem1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoMensagem")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.MensagemTipoMensagemJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.MensagemTipoMensagem? TipoMensagem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mensagem" /> class.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="mensagem1"></param>
        /// <param name="tipoMensagem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mensagem(
            string? codigo,
            string? mensagem1,
            global::Softplan.Soft.Suite.Dje.Sdk.MensagemTipoMensagem? tipoMensagem)
        {
            this.Codigo = codigo;
            this.Mensagem1 = mensagem1;
            this.TipoMensagem = tipoMensagem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mensagem" /> class.
        /// </summary>
        public Mensagem()
        {
        }

    }
}