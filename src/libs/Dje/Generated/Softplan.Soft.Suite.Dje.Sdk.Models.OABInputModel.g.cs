
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OABInputModel
    {
        /// <summary>
        /// Número AOB de representante júridico na empresa<br/>
        /// Example: 12234
        /// </summary>
        /// <example>12234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroOab")]
        public string? NumeroOab { get; set; }

        /// <summary>
        /// UF AOB de representante júridico na empresa<br/>
        /// Example: RJ
        /// </summary>
        /// <example>RJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OABInputModel" /> class.
        /// </summary>
        /// <param name="numeroOab">
        /// Número AOB de representante júridico na empresa<br/>
        /// Example: 12234
        /// </param>
        /// <param name="uf">
        /// UF AOB de representante júridico na empresa<br/>
        /// Example: RJ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OABInputModel(
            string? numeroOab,
            string? uf)
        {
            this.NumeroOab = numeroOab;
            this.Uf = uf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OABInputModel" /> class.
        /// </summary>
        public OABInputModel()
        {
        }

    }
}