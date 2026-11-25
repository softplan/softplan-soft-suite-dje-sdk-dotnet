
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CriarSolicitacaoRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arquivos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Arquivos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriarSolicitacaoRequest" /> class.
        /// </summary>
        /// <param name="arquivos"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriarSolicitacaoRequest(
            global::System.Collections.Generic.IList<byte[]> arquivos,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel payload)
        {
            this.Arquivos = arquivos ?? throw new global::System.ArgumentNullException(nameof(arquivos));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriarSolicitacaoRequest" /> class.
        /// </summary>
        public CriarSolicitacaoRequest()
        {
        }

    }
}