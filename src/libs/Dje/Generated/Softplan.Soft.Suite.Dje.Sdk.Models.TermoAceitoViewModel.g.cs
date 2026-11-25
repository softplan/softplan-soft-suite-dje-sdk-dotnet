
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TermoAceitoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataAceite")]
        public string? DataAceite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versao")]
        public long? Versao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TermoAceitoViewModel" /> class.
        /// </summary>
        /// <param name="dataAceite"></param>
        /// <param name="descricao"></param>
        /// <param name="versao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TermoAceitoViewModel(
            string? dataAceite,
            string? descricao,
            long? versao)
        {
            this.DataAceite = dataAceite;
            this.Descricao = descricao;
            this.Versao = versao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermoAceitoViewModel" /> class.
        /// </summary>
        public TermoAceitoViewModel()
        {
        }

    }
}