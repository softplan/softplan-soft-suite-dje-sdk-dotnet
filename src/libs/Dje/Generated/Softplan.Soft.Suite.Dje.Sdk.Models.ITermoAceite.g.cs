
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ITermoAceite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versaoTermo")]
        public long? VersaoTermo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ITermoAceite" /> class.
        /// </summary>
        /// <param name="versaoTermo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ITermoAceite(
            long? versaoTermo)
        {
            this.VersaoTermo = versaoTermo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITermoAceite" /> class.
        /// </summary>
        public ITermoAceite()
        {
        }

    }
}