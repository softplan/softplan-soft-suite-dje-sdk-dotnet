
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Input para inclusão de um novo termo de aceite.
    /// </summary>
    public sealed partial class TermoAceiteInputModel
    {
        /// <summary>
        /// Corpo do termo de aceite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Descricao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TermoAceiteInputModel" /> class.
        /// </summary>
        /// <param name="descricao">
        /// Corpo do termo de aceite
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TermoAceiteInputModel(
            string descricao)
        {
            this.Descricao = descricao ?? throw new global::System.ArgumentNullException(nameof(descricao));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermoAceiteInputModel" /> class.
        /// </summary>
        public TermoAceiteInputModel()
        {
        }

    }
}