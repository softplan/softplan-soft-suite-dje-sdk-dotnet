
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Pessoa
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpfCnpj")]
        public string? CpfCnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHabilitacao")]
        public global::System.DateTime? DataHabilitacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataUltimaDesabiltiacao")]
        public global::System.DateTime? DataUltimaDesabiltiacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluidoEm")]
        public global::System.DateTime? ExcluidoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitador")]
        public string? Habilitador { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashTermoAceite")]
        public string? HashTermoAceite { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfilRepresentante")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Perfil? PerfilRepresentante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termoAceito")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ITermoAceite>? TermoAceito { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEspecializacao")]
        public long? TipoEspecializacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaTipoPessoaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.PessoaTipoPessoa TipoPessoa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuario")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Usuario? Usuario { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorPerfilInfoInput")]
        public global::Softplan.Soft.Suite.Dje.Sdk.ValidatorPerfilInfoInput? ValidatorPerfilInfoInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pessoa" /> class.
        /// </summary>
        /// <param name="tipoPessoa"></param>
        /// <param name="ativo"></param>
        /// <param name="cpfCnpj"></param>
        /// <param name="dataHabilitacao"></param>
        /// <param name="dataUltimaDesabiltiacao"></param>
        /// <param name="excluidoEm"></param>
        /// <param name="habilitada"></param>
        /// <param name="habilitador"></param>
        /// <param name="hashTermoAceite"></param>
        /// <param name="id"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="notificacao"></param>
        /// <param name="perfilRepresentante"></param>
        /// <param name="tenantId"></param>
        /// <param name="termoAceito"></param>
        /// <param name="tipoEspecializacao"></param>
        /// <param name="usuario"></param>
        /// <param name="validatorPerfilInfoInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pessoa(
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaTipoPessoa tipoPessoa,
            bool? ativo,
            string? cpfCnpj,
            global::System.DateTime? dataHabilitacao,
            global::System.DateTime? dataUltimaDesabiltiacao,
            global::System.DateTime? excluidoEm,
            bool? habilitada,
            string? habilitador,
            string? hashTermoAceite,
            long? id,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao,
            global::Softplan.Soft.Suite.Dje.Sdk.Perfil? perfilRepresentante,
            global::System.Guid? tenantId,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ITermoAceite>? termoAceito,
            long? tipoEspecializacao,
            global::Softplan.Soft.Suite.Dje.Sdk.Usuario? usuario,
            global::Softplan.Soft.Suite.Dje.Sdk.ValidatorPerfilInfoInput? validatorPerfilInfoInput)
        {
            this.Ativo = ativo;
            this.CpfCnpj = cpfCnpj;
            this.DataHabilitacao = dataHabilitacao;
            this.DataUltimaDesabiltiacao = dataUltimaDesabiltiacao;
            this.ExcluidoEm = excluidoEm;
            this.Habilitada = habilitada;
            this.Habilitador = habilitador;
            this.HashTermoAceite = hashTermoAceite;
            this.Id = id;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Notificacao = notificacao;
            this.PerfilRepresentante = perfilRepresentante;
            this.TenantId = tenantId;
            this.TermoAceito = termoAceito;
            this.TipoEspecializacao = tipoEspecializacao;
            this.TipoPessoa = tipoPessoa;
            this.Usuario = usuario;
            this.ValidatorPerfilInfoInput = validatorPerfilInfoInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pessoa" /> class.
        /// </summary>
        public Pessoa()
        {
        }

    }
}