
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoValidacaoValueObject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mensagens")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessage>? Mensagens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoValidacaoValueObject" /> class.
        /// </summary>
        /// <param name="mensagens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoValidacaoValueObject(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessage>? mensagens)
        {
            this.Mensagens = mensagens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoValidacaoValueObject" /> class.
        /// </summary>
        public InfoValidacaoValueObject()
        {
        }

    }
}