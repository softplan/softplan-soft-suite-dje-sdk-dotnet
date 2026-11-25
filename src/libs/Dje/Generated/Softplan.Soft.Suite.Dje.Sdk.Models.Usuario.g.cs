
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Usuario
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfil")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>? Perfil { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfilRepresentante")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Perfil? PerfilRepresentante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfis")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>? Perfis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IProfile>? Profiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario" /> class.
        /// </summary>
        /// <param name="excluidoEm"></param>
        /// <param name="id"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="notificacao"></param>
        /// <param name="perfil">
        /// Included only in requests
        /// </param>
        /// <param name="perfilRepresentante"></param>
        /// <param name="perfis"></param>
        /// <param name="profiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usuario(
            global::System.DateTime? excluidoEm,
            long? id,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>? perfil,
            global::Softplan.Soft.Suite.Dje.Sdk.Perfil? perfilRepresentante,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.Perfil>? perfis,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.IProfile>? profiles)
        {
            this.ExcluidoEm = excluidoEm;
            this.Id = id;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Notificacao = notificacao;
            this.Perfil = perfil;
            this.PerfilRepresentante = perfilRepresentante;
            this.Perfis = perfis;
            this.Profiles = profiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario" /> class.
        /// </summary>
        public Usuario()
        {
        }

    }
}