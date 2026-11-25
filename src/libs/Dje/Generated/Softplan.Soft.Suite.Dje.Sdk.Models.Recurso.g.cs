
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Recurso
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Recurso" /> class.
        /// </summary>
        /// <param name="excluidoEm"></param>
        /// <param name="id"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="name"></param>
        /// <param name="nome"></param>
        /// <param name="notificacao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Recurso(
            global::System.DateTime? excluidoEm,
            long? id,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            string? name,
            string? nome,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao)
        {
            this.ExcluidoEm = excluidoEm;
            this.Id = id;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Name = name;
            this.Nome = nome;
            this.Notificacao = notificacao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recurso" /> class.
        /// </summary>
        public Recurso()
        {
        }

    }
}