
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PeticaoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peticionarUrl")]
        public string? PeticionarUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeExibir")]
        public bool? PodeExibir { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticaoViewModel" /> class.
        /// </summary>
        /// <param name="peticionarUrl"></param>
        /// <param name="podeExibir"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeticaoViewModel(
            string? peticionarUrl,
            bool? podeExibir)
        {
            this.PeticionarUrl = peticionarUrl;
            this.PodeExibir = podeExibir;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeticaoViewModel" /> class.
        /// </summary>
        public PeticaoViewModel()
        {
        }

    }
}