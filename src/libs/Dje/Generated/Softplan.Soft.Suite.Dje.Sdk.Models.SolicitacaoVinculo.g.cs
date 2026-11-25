
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SolicitacaoVinculo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpjMatrizSolicitada")]
        public string? CnpjMatrizSolicitada { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("emailAdicional")]
        public string? EmailAdicional { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailSpecification")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? EmailSpecification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluidoEm")]
        public global::System.DateTime? ExcluidoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoAuditoriaVO")]
        public global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? InfoAuditoriaVO { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoValidacaoValueObject")]
        public global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? InfoValidacaoValueObject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrizSolicitante")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivada? MatrizSolicitante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocialSolicitada")]
        public string? RazaoSocialSolicitada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitacaoVinculo" /> class.
        /// </summary>
        /// <param name="cnpjMatrizSolicitada"></param>
        /// <param name="dataCriacao"></param>
        /// <param name="dataSituacao"></param>
        /// <param name="emailAdicional"></param>
        /// <param name="emailSpecification"></param>
        /// <param name="excluidoEm"></param>
        /// <param name="id"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="matrizSolicitante"></param>
        /// <param name="notificacao"></param>
        /// <param name="razaoSocialSolicitada"></param>
        /// <param name="situacao"></param>
        /// <param name="tenantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SolicitacaoVinculo(
            string? cnpjMatrizSolicitada,
            global::System.DateTime? dataCriacao,
            global::System.DateTime? dataSituacao,
            string? emailAdicional,
            global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? emailSpecification,
            global::System.DateTime? excluidoEm,
            long? id,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            global::Softplan.Soft.Suite.Dje.Sdk.EmpresaPrivada? matrizSolicitante,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao,
            string? razaoSocialSolicitada,
            string? situacao,
            global::System.Guid? tenantId)
        {
            this.CnpjMatrizSolicitada = cnpjMatrizSolicitada;
            this.DataCriacao = dataCriacao;
            this.DataSituacao = dataSituacao;
            this.EmailAdicional = emailAdicional;
            this.EmailSpecification = emailSpecification;
            this.ExcluidoEm = excluidoEm;
            this.Id = id;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.MatrizSolicitante = matrizSolicitante;
            this.Notificacao = notificacao;
            this.RazaoSocialSolicitada = razaoSocialSolicitada;
            this.Situacao = situacao;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitacaoVinculo" /> class.
        /// </summary>
        public SolicitacaoVinculo()
        {
        }

    }
}