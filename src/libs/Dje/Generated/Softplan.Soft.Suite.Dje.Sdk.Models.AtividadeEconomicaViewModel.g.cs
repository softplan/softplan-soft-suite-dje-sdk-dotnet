
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AtividadeEconomicaViewModel
    {
        /// <summary>
        /// Código da atividade
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public string? Codigo { get; set; }

        /// <summary>
        /// Descrição da atividade economica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AtividadeEconomicaViewModel" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código da atividade
        /// </param>
        /// <param name="descricao">
        /// Descrição da atividade economica
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AtividadeEconomicaViewModel(
            string? codigo,
            string? descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AtividadeEconomicaViewModel" /> class.
        /// </summary>
        public AtividadeEconomicaViewModel()
        {
        }

    }
}