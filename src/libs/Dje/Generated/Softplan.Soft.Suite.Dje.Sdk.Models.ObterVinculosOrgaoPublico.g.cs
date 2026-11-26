
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObterVinculosOrgaoPublico
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        /// Status do vinculo<br/>
        /// Example: P
        /// </summary>
        /// <example>P</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterVinculosOrgaoPublicoStatusJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublicoStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterVinculosOrgaoPublico" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="status">
        /// Status do vinculo<br/>
        /// Example: P
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObterVinculosOrgaoPublico(
            string? cnpj,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterVinculosOrgaoPublicoStatus? status)
        {
            this.Cnpj = cnpj;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterVinculosOrgaoPublico" /> class.
        /// </summary>
        public ObterVinculosOrgaoPublico()
        {
        }

    }
}