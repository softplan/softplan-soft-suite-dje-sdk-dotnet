
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ColigadaNotificacaoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColigadaNotificacaoViewModel" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="tipo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColigadaNotificacaoViewModel(
            object? data,
            string? tipo)
        {
            this.Data = data;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColigadaNotificacaoViewModel" /> class.
        /// </summary>
        public ColigadaNotificacaoViewModel()
        {
        }

    }
}