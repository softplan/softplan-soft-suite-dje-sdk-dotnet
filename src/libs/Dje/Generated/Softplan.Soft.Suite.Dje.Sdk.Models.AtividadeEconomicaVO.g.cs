
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AtividadeEconomicaVO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public string? Codigo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AtividadeEconomicaVO" /> class.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descricao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AtividadeEconomicaVO(
            string? codigo,
            string? descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AtividadeEconomicaVO" /> class.
        /// </summary>
        public AtividadeEconomicaVO()
        {
        }

    }
}