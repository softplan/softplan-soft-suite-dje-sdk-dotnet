
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepresentanteViewModel
    {
        /// <summary>
        /// Documento do representado<br/>
        /// Example: 11122233344
        /// </summary>
        /// <example>11122233344</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentoRepresentado")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentoRepresentado { get; set; }

        /// <summary>
        /// Nome do representante<br/>
        /// Example: Maria de Fátima Ferreira
        /// </summary>
        /// <example>Maria de Fátima Ferreira</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Valor do documento do representante<br/>
        /// Example: 11122233344
        /// </summary>
        /// <example>11122233344</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroDocumento")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumeroDocumento { get; set; }

        /// <summary>
        /// Status do representante. (Ativo - A, Inativo - I)<br/>
        /// Example: A
        /// </summary>
        /// <example>A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelStatus Status { get; set; }

        /// <summary>
        /// Tipo do documento do representante<br/>
        /// Example: CPF
        /// </summary>
        /// <example>CPF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoDocumento")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.RepresentanteViewModelTipoDocumentoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelTipoDocumento TipoDocumento { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteViewModel" /> class.
        /// </summary>
        /// <param name="documentoRepresentado">
        /// Documento do representado<br/>
        /// Example: 11122233344
        /// </param>
        /// <param name="nome">
        /// Nome do representante<br/>
        /// Example: Maria de Fátima Ferreira
        /// </param>
        /// <param name="numeroDocumento">
        /// Valor do documento do representante<br/>
        /// Example: 11122233344
        /// </param>
        /// <param name="status">
        /// Status do representante. (Ativo - A, Inativo - I)<br/>
        /// Example: A
        /// </param>
        /// <param name="tipoDocumento">
        /// Tipo do documento do representante<br/>
        /// Example: CPF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepresentanteViewModel(
            string documentoRepresentado,
            string nome,
            string numeroDocumento,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelStatus status,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModelTipoDocumento tipoDocumento)
        {
            this.DocumentoRepresentado = documentoRepresentado ?? throw new global::System.ArgumentNullException(nameof(documentoRepresentado));
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.NumeroDocumento = numeroDocumento ?? throw new global::System.ArgumentNullException(nameof(numeroDocumento));
            this.Status = status;
            this.TipoDocumento = tipoDocumento;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteViewModel" /> class.
        /// </summary>
        public RepresentanteViewModel()
        {
        }

    }
}