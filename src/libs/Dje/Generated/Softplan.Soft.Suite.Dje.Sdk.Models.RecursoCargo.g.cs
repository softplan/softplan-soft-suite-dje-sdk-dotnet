
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecursoCargo
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
        [global::System.Text.Json.Serialization.JsonPropertyName("idCargo")]
        public long? IdCargo { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeDeletar")]
        public bool? PodeDeletar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeEditar")]
        public bool? PodeEditar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeEscrever")]
        public bool? PodeEscrever { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeLer")]
        public bool? PodeLer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurso")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Recurso? Recurso { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecursoCargo" /> class.
        /// </summary>
        /// <param name="excluidoEm"></param>
        /// <param name="id"></param>
        /// <param name="idCargo"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="name"></param>
        /// <param name="notificacao"></param>
        /// <param name="podeDeletar"></param>
        /// <param name="podeEditar"></param>
        /// <param name="podeEscrever"></param>
        /// <param name="podeLer"></param>
        /// <param name="recurso"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecursoCargo(
            global::System.DateTime? excluidoEm,
            long? id,
            long? idCargo,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Softplan.Soft.Suite.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            string? name,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.INotification>? notificacao,
            bool? podeDeletar,
            bool? podeEditar,
            bool? podeEscrever,
            bool? podeLer,
            global::Softplan.Soft.Suite.Dje.Sdk.Recurso? recurso)
        {
            this.ExcluidoEm = excluidoEm;
            this.Id = id;
            this.IdCargo = idCargo;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Name = name;
            this.Notificacao = notificacao;
            this.PodeDeletar = podeDeletar;
            this.PodeEditar = podeEditar;
            this.PodeEscrever = podeEscrever;
            this.PodeLer = podeLer;
            this.Recurso = recurso;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecursoCargo" /> class.
        /// </summary>
        public RecursoCargo()
        {
        }

    }
}