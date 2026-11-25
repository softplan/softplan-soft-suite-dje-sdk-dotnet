
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmpresaIncorporadaDocumentoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeArquivo")]
        public string? NomeArquivo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeDocumento")]
        public string? NomeDocumento { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tamanhoBytes")]
        public long? TamanhoBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaDocumentoViewModel" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="id"></param>
        /// <param name="nomeArquivo"></param>
        /// <param name="nomeDocumento"></param>
        /// <param name="tamanhoBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmpresaIncorporadaDocumentoViewModel(
            string? contentType,
            long? id,
            string? nomeArquivo,
            string? nomeDocumento,
            long? tamanhoBytes)
        {
            this.ContentType = contentType;
            this.Id = id;
            this.NomeArquivo = nomeArquivo;
            this.NomeDocumento = nomeDocumento;
            this.TamanhoBytes = tamanhoBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaDocumentoViewModel" /> class.
        /// </summary>
        public EmpresaIncorporadaDocumentoViewModel()
        {
        }

    }
}