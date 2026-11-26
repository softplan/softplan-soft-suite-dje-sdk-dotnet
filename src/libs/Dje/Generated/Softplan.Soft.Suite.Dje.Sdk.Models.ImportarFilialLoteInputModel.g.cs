
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImportarFilialLoteInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deveImportarDesativadas")]
        public bool? DeveImportarDesativadas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportarFilialLoteInputModel" /> class.
        /// </summary>
        /// <param name="deveImportarDesativadas"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportarFilialLoteInputModel(
            bool? deveImportarDesativadas,
            string? email)
        {
            this.DeveImportarDesativadas = deveImportarDesativadas;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportarFilialLoteInputModel" /> class.
        /// </summary>
        public ImportarFilialLoteInputModel()
        {
        }

    }
}