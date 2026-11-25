
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IProfile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documento")]
        public string? Documento { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public string? Job { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.IProfileRoleJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.IProfileRole? Role { get; set; }

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
        /// Initializes a new instance of the <see cref="IProfile" /> class.
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="id"></param>
        /// <param name="idGestor"></param>
        /// <param name="idMatriz"></param>
        /// <param name="infoAuditoria"></param>
        /// <param name="job"></param>
        /// <param name="orgaoPublico"></param>
        /// <param name="proprietarioId"></param>
        /// <param name="resources"></param>
        /// <param name="role"></param>
        /// <param name="tenantId"></param>
        /// <param name="tenantName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IProfile(
            string? documento,
            long? id,
            long? idGestor,
            long? idMatriz,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoria,
            string? job,
            bool? orgaoPublico,
            long? proprietarioId,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IResource>? resources,
            global::Softplan.Soft.Suite.Dje.Sdk.IProfileRole? role,
            global::System.Guid? tenantId,
            string? tenantName)
        {
            this.Documento = documento;
            this.Id = id;
            this.IdGestor = idGestor;
            this.IdMatriz = idMatriz;
            this.InfoAuditoria = infoAuditoria;
            this.Job = job;
            this.OrgaoPublico = orgaoPublico;
            this.ProprietarioId = proprietarioId;
            this.Resources = resources;
            this.Role = role;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IProfile" /> class.
        /// </summary>
        public IProfile()
        {
        }

    }
}