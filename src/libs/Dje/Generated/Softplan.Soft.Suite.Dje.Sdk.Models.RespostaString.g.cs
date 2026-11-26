
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RespostaString
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mensagens")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Mensagem>? Mensagens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaString" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mensagens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RespostaString(
            string? data,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Mensagem>? mensagens)
        {
            this.Data = data;
            this.Mensagens = mensagens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaString" /> class.
        /// </summary>
        public RespostaString()
        {
        }

    }
}