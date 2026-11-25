
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServidorViewModel
    {
        /// <summary>
        /// CPF do servidor responsável pela comunicação
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpf { get; set; }

        /// <summary>
        /// Nome do servidor responsável pela comunicação
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServidorViewModel" /> class.
        /// </summary>
        /// <param name="cpf">
        /// CPF do servidor responsável pela comunicação
        /// </param>
        /// <param name="nome">
        /// Nome do servidor responsável pela comunicação
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServidorViewModel(
            string cpf,
            string nome)
        {
            this.Cpf = cpf ?? throw new global::System.ArgumentNullException(nameof(cpf));
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServidorViewModel" /> class.
        /// </summary>
        public ServidorViewModel()
        {
        }

    }
}