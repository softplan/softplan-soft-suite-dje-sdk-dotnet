
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FiliaisMatrizPorBCnpjViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filiais")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.FilialBCnpjViewModel>? Filiais { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FiliaisMatrizPorBCnpjViewModel" /> class.
        /// </summary>
        /// <param name="filiais"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FiliaisMatrizPorBCnpjViewModel(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.FilialBCnpjViewModel>? filiais)
        {
            this.Filiais = filiais;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FiliaisMatrizPorBCnpjViewModel" /> class.
        /// </summary>
        public FiliaisMatrizPorBCnpjViewModel()
        {
        }

    }
}