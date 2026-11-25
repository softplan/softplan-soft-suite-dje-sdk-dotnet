
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmpresaIncorporadaSolicitacaoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpjIncorporada")]
        public string? CnpjIncorporada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpjSolicitante")]
        public string? CnpjSolicitante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCriacao")]
        public global::System.DateTime? DataCriacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSituacao")]
        public global::System.DateTime? DataSituacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentos")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>? Documentos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idMatrizSolicitante")]
        public long? IdMatrizSolicitante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idVinculoReferencia")]
        public long? IdVinculoReferencia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motivoRejeicao")]
        public string? MotivoRejeicao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocialIncorporada")]
        public string? RazaoSocialIncorporada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocialSolicitante")]
        public string? RazaoSocialSolicitante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoCadastral")]
        public int? SituacaoCadastral { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoSolicitacao")]
        public string? TipoSolicitacao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaSolicitacaoViewModel" /> class.
        /// </summary>
        /// <param name="cnpjIncorporada"></param>
        /// <param name="cnpjSolicitante"></param>
        /// <param name="dataCriacao"></param>
        /// <param name="dataSituacao"></param>
        /// <param name="documentos"></param>
        /// <param name="id"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idVinculoReferencia"></param>
        /// <param name="motivoRejeicao"></param>
        /// <param name="razaoSocialIncorporada"></param>
        /// <param name="razaoSocialSolicitante"></param>
        /// <param name="situacao"></param>
        /// <param name="situacaoCadastral"></param>
        /// <param name="tipoSolicitacao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmpresaIncorporadaSolicitacaoViewModel(
            string? cnpjIncorporada,
            string? cnpjSolicitante,
            global::System.DateTime? dataCriacao,
            global::System.DateTime? dataSituacao,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>? documentos,
            long? id,
            long? idMatrizSolicitante,
            long? idVinculoReferencia,
            string? motivoRejeicao,
            string? razaoSocialIncorporada,
            string? razaoSocialSolicitante,
            string? situacao,
            int? situacaoCadastral,
            string? tipoSolicitacao)
        {
            this.CnpjIncorporada = cnpjIncorporada;
            this.CnpjSolicitante = cnpjSolicitante;
            this.DataCriacao = dataCriacao;
            this.DataSituacao = dataSituacao;
            this.Documentos = documentos;
            this.Id = id;
            this.IdMatrizSolicitante = idMatrizSolicitante;
            this.IdVinculoReferencia = idVinculoReferencia;
            this.MotivoRejeicao = motivoRejeicao;
            this.RazaoSocialIncorporada = razaoSocialIncorporada;
            this.RazaoSocialSolicitante = razaoSocialSolicitante;
            this.Situacao = situacao;
            this.SituacaoCadastral = situacaoCadastral;
            this.TipoSolicitacao = tipoSolicitacao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaSolicitacaoViewModel" /> class.
        /// </summary>
        public EmpresaIncorporadaSolicitacaoViewModel()
        {
        }

    }
}