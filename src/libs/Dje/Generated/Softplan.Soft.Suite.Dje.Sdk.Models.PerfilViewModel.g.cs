
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PerfilViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoEm")]
        public string? AtualizadoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoPor")]
        public string? AtualizadoPor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public global::Softplan.Soft.Suite.Dje.Sdk.CargoPerfilViewModel? Cargo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        public string? CriadoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoPor")]
        public string? CriadoPor { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("escopoPermissao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoViewModel>? EscopoPermissao { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("idMatriz")]
        public long? IdMatriz { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("recursos")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RecursosViewModel>? Recursos { get; set; }

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
        /// Initializes a new instance of the <see cref="PerfilViewModel" /> class.
        /// </summary>
        /// <param name="atualizadoEm"></param>
        /// <param name="atualizadoPor"></param>
        /// <param name="cargo"></param>
        /// <param name="criadoEm"></param>
        /// <param name="criadoPor"></param>
        /// <param name="documento"></param>
        /// <param name="email"></param>
        /// <param name="escopoPermissao"></param>
        /// <param name="funcao"></param>
        /// <param name="id"></param>
        /// <param name="idMatriz"></param>
        /// <param name="matricula"></param>
        /// <param name="orgaoPublico"></param>
        /// <param name="proprietarioId"></param>
        /// <param name="recursos"></param>
        /// <param name="telefone"></param>
        /// <param name="tenantId"></param>
        /// <param name="tenantName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerfilViewModel(
            string? atualizadoEm,
            string? atualizadoPor,
            global::Softplan.Soft.Suite.Dje.Sdk.CargoPerfilViewModel? cargo,
            string? criadoEm,
            string? criadoPor,
            string? documento,
            string? email,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoViewModel>? escopoPermissao,
            string? funcao,
            long? id,
            long? idMatriz,
            string? matricula,
            bool? orgaoPublico,
            long? proprietarioId,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RecursosViewModel>? recursos,
            string? telefone,
            global::System.Guid? tenantId,
            string? tenantName)
        {
            this.AtualizadoEm = atualizadoEm;
            this.AtualizadoPor = atualizadoPor;
            this.Cargo = cargo;
            this.CriadoEm = criadoEm;
            this.CriadoPor = criadoPor;
            this.Documento = documento;
            this.Email = email;
            this.EscopoPermissao = escopoPermissao;
            this.Funcao = funcao;
            this.Id = id;
            this.IdMatriz = idMatriz;
            this.Matricula = matricula;
            this.OrgaoPublico = orgaoPublico;
            this.ProprietarioId = proprietarioId;
            this.Recursos = recursos;
            this.Telefone = telefone;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilViewModel" /> class.
        /// </summary>
        public PerfilViewModel()
        {
        }

    }
}