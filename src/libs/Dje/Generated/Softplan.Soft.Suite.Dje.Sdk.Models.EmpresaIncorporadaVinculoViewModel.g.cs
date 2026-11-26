
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmpresaIncorporadaVinculoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpjIncorporada")]
        public string? CnpjIncorporada { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("idSolicitacaoOrigem")]
        public long? IdSolicitacaoOrigem { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocialIncorporada")]
        public string? RazaoSocialIncorporada { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaVinculoViewModel" /> class.
        /// </summary>
        /// <param name="cnpjIncorporada"></param>
        /// <param name="dataCriacao"></param>
        /// <param name="dataSituacao"></param>
        /// <param name="id"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idSolicitacaoOrigem"></param>
        /// <param name="razaoSocialIncorporada"></param>
        /// <param name="situacao"></param>
        /// <param name="situacaoCadastral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmpresaIncorporadaVinculoViewModel(
            string? cnpjIncorporada,
            global::System.DateTime? dataCriacao,
            global::System.DateTime? dataSituacao,
            long? id,
            long? idMatrizSolicitante,
            long? idSolicitacaoOrigem,
            string? razaoSocialIncorporada,
            string? situacao,
            int? situacaoCadastral)
        {
            this.CnpjIncorporada = cnpjIncorporada;
            this.DataCriacao = dataCriacao;
            this.DataSituacao = dataSituacao;
            this.Id = id;
            this.IdMatrizSolicitante = idMatrizSolicitante;
            this.IdSolicitacaoOrigem = idSolicitacaoOrigem;
            this.RazaoSocialIncorporada = razaoSocialIncorporada;
            this.Situacao = situacao;
            this.SituacaoCadastral = situacaoCadastral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaIncorporadaVinculoViewModel" /> class.
        /// </summary>
        public EmpresaIncorporadaVinculoViewModel()
        {
        }

    }
}