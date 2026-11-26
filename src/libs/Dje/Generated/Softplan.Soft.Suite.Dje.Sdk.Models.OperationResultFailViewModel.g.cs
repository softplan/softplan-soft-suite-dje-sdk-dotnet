
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OperationResultFailViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erros")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Erros { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mensagem")]
        public string? Mensagem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResultFailViewModel" /> class.
        /// </summary>
        /// <param name="erros"></param>
        /// <param name="mensagem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationResultFailViewModel(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? erros,
            string? mensagem)
        {
            this.Erros = erros;
            this.Mensagem = mensagem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResultFailViewModel" /> class.
        /// </summary>
        public OperationResultFailViewModel()
        {
        }

    }
}