
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComunicacaoLogModel
    {
        /// <summary>
        /// Id do log<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </summary>
        /// <example>0800854512021820512320220001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroComunicacao")]
        public string? NumeroComunicacao { get; set; }

        /// <summary>
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </summary>
        /// <example>08008545120218205123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// payload log<br/>
        /// Example: { 'aceite': '2022-06-08T00:00:00Z' }
        /// </summary>
        /// <example>{ 'aceite': '2022-06-08T00:00:00Z' }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComunicacaoLogModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Id do log<br/>
        /// Example: 1
        /// </param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="payload">
        /// payload log<br/>
        /// Example: { 'aceite': '2022-06-08T00:00:00Z' }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComunicacaoLogModel(
            long? id,
            string? numeroComunicacao,
            string? numeroProcesso,
            object? payload)
        {
            this.Id = id;
            this.NumeroComunicacao = numeroComunicacao;
            this.NumeroProcesso = numeroProcesso;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComunicacaoLogModel" /> class.
        /// </summary>
        public ComunicacaoLogModel()
        {
        }

    }
}