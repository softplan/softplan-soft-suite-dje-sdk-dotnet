
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaProcessualOrgaoPublicoViewModel
    {
        /// <summary>
        /// Indica se necessita de assistencia judiciaria
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistenciaJudiciaria")]
        public bool? AssistenciaJudiciaria { get; set; }

        /// <summary>
        /// Valor do documento<br/>
        /// Example: 52194732047
        /// </summary>
        /// <example>52194732047</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        public string? Documento { get; set; }

        /// <summary>
        /// Indica se é de interesse publico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interessePublico")]
        public bool? InteressePublico { get; set; }

        /// <summary>
        /// Nome completo de cada envolvido no processo<br/>
        /// Example: GILBERTO PEREIRA
        /// </summary>
        /// <example>GILBERTO PEREIRA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Pessoas relacionadas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pessoaProcessualRelacionada")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModel>? PessoaProcessualRelacionada { get; set; }

        /// <summary>
        /// Tipo de documento<br/>
        /// Example: CPF
        /// </summary>
        /// <example>CPF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoDocumento")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaProcessualOrgaoPublicoViewModelTipoDocumentoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModelTipoDocumento? TipoDocumento { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaProcessualOrgaoPublicoViewModel" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome completo de cada envolvido no processo<br/>
        /// Example: GILBERTO PEREIRA
        /// </param>
        /// <param name="assistenciaJudiciaria">
        /// Indica se necessita de assistencia judiciaria
        /// </param>
        /// <param name="documento">
        /// Valor do documento<br/>
        /// Example: 52194732047
        /// </param>
        /// <param name="interessePublico">
        /// Indica se é de interesse publico
        /// </param>
        /// <param name="pessoaProcessualRelacionada">
        /// Pessoas relacionadas
        /// </param>
        /// <param name="tipoDocumento">
        /// Tipo de documento<br/>
        /// Example: CPF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaProcessualOrgaoPublicoViewModel(
            string nome,
            bool? assistenciaJudiciaria,
            string? documento,
            bool? interessePublico,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaRelacionadaViewModel>? pessoaProcessualRelacionada,
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModelTipoDocumento? tipoDocumento)
        {
            this.AssistenciaJudiciaria = assistenciaJudiciaria;
            this.Documento = documento;
            this.InteressePublico = interessePublico;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.PessoaProcessualRelacionada = pessoaProcessualRelacionada;
            this.TipoDocumento = tipoDocumento;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaProcessualOrgaoPublicoViewModel" /> class.
        /// </summary>
        public PessoaProcessualOrgaoPublicoViewModel()
        {
        }

    }
}