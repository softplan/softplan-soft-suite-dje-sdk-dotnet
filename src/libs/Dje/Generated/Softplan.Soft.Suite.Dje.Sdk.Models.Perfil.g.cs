
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Perfil
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Cargo? Cargo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        public string? Documento { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailSpecification")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? EmailSpecification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escopoPermissao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoVO>? EscopoPermissao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluidoEm")]
        public global::System.DateTime? ExcluidoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funcao")]
        public string? Funcao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idGestor")]
        public long? IdGestor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idMatriz")]
        public long? IdMatriz { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoAuditoria")]
        public global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? InfoAuditoria { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public string? Job { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilNotificarJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PerfilNotificar? Notificar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoPublico")]
        public bool? OrgaoPublico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proprietarioId")]
        public long? ProprietarioId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IResource>? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PerfilRoleJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PerfilRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantName")]
        public string? TenantName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Perfil" /> class.
        /// </summary>
        /// <param name="cargo"></param>
        /// <param name="descricao"></param>
        /// <param name="documento"></param>
        /// <param name="email"></param>
        /// <param name="emailSpecification"></param>
        /// <param name="escopoPermissao"></param>
        /// <param name="excluidoEm"></param>
        /// <param name="funcao"></param>
        /// <param name="id"></param>
        /// <param name="idGestor"></param>
        /// <param name="idMatriz"></param>
        /// <param name="infoAuditoria"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="job"></param>
        /// <param name="matricula"></param>
        /// <param name="notificacao"></param>
        /// <param name="notificar"></param>
        /// <param name="orgaoPublico"></param>
        /// <param name="proprietarioId"></param>
        /// <param name="resources"></param>
        /// <param name="role"></param>
        /// <param name="telefone"></param>
        /// <param name="tenantId"></param>
        /// <param name="tenantName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Perfil(
            global::Softplan.Soft.Suite.Dje.Sdk.Cargo? cargo,
            string? descricao,
            string? documento,
            string? email,
            global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? emailSpecification,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoVO>? escopoPermissao,
            global::System.DateTime? excluidoEm,
            string? funcao,
            long? id,
            long? idGestor,
            long? idMatriz,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoria,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            string? job,
            string? matricula,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao,
            global::Softplan.Soft.Suite.Dje.Sdk.PerfilNotificar? notificar,
            bool? orgaoPublico,
            long? proprietarioId,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IResource>? resources,
            global::Softplan.Soft.Suite.Dje.Sdk.PerfilRole? role,
            string? telefone,
            global::System.Guid? tenantId,
            string? tenantName)
        {
            this.Cargo = cargo;
            this.Descricao = descricao;
            this.Documento = documento;
            this.Email = email;
            this.EmailSpecification = emailSpecification;
            this.EscopoPermissao = escopoPermissao;
            this.ExcluidoEm = excluidoEm;
            this.Funcao = funcao;
            this.Id = id;
            this.IdGestor = idGestor;
            this.IdMatriz = idMatriz;
            this.InfoAuditoria = infoAuditoria;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Job = job;
            this.Matricula = matricula;
            this.Notificacao = notificacao;
            this.Notificar = notificar;
            this.OrgaoPublico = orgaoPublico;
            this.ProprietarioId = proprietarioId;
            this.Resources = resources;
            this.Role = role;
            this.Telefone = telefone;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Perfil" /> class.
        /// </summary>
        public Perfil()
        {
        }

    }
}