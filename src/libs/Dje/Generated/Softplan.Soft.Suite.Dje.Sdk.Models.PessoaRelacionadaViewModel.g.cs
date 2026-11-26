
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaRelacionadaViewModel
    {
        /// <summary>
        /// Valor do documento<br/>
        /// Example: 52194732047
        /// </summary>
        /// <example>52194732047</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        public string? Documento { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalidadeParticipacao")]
        public string? ModalidadeParticipacao { get; set; }

        /// <summary>
        /// Nome completo de cada envolvido no processo<br/>
        /// Example: GILBERTO PEREIRA
        /// </summary>
        /// <example>GILBERTO PEREIRA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Tipo de documento<br/>
        /// Example: CPF
        /// </summary>
        /// <example>CPF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoDocumento")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaRelacionadaViewModelTipoDocumentoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModelTipoDocumento? TipoDocumento { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaRelacionadaViewModel" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome completo de cada envolvido no processo<br/>
        /// Example: GILBERTO PEREIRA
        /// </param>
        /// <param name="documento">
        /// Valor do documento<br/>
        /// Example: 52194732047
        /// </param>
        /// <param name="modalidadeParticipacao"></param>
        /// <param name="tipoDocumento">
        /// Tipo de documento<br/>
        /// Example: CPF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaRelacionadaViewModel(
            string nome,
            string? documento,
            string? modalidadeParticipacao,
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModelTipoDocumento? tipoDocumento)
        {
            this.Documento = documento;
            this.ModalidadeParticipacao = modalidadeParticipacao;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.TipoDocumento = tipoDocumento;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaRelacionadaViewModel" /> class.
        /// </summary>
        public PessoaRelacionadaViewModel()
        {
        }

    }
}