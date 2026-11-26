
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TermoAceiteViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCriacao")]
        public string? DataCriacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricaoEDataCriacaoEmBytes")]
        public byte[]? DescricaoEDataCriacaoEmBytes { get; set; }

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
        /// Initializes a new instance of the <see cref="TermoAceiteViewModel" /> class.
        /// </summary>
        /// <param name="dataCriacao"></param>
        /// <param name="descricao"></param>
        /// <param name="descricaoEDataCriacaoEmBytes"></param>
        /// <param name="versao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TermoAceiteViewModel(
            string? dataCriacao,
            string? descricao,
            byte[]? descricaoEDataCriacaoEmBytes,
            long? versao)
        {
            this.DataCriacao = dataCriacao;
            this.Descricao = descricao;
            this.DescricaoEDataCriacaoEmBytes = descricaoEDataCriacaoEmBytes;
            this.Versao = versao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermoAceiteViewModel" /> class.
        /// </summary>
        public TermoAceiteViewModel()
        {
        }

    }
}