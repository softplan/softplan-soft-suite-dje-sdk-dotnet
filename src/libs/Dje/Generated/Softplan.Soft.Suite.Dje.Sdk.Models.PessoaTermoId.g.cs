
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaTermoId
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idPessoa")]
        public long? IdPessoa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idTermo")]
        public long? IdTermo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaTermoId" /> class.
        /// </summary>
        /// <param name="idPessoa"></param>
        /// <param name="idTermo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaTermoId(
            long? idPessoa,
            long? idTermo)
        {
            this.IdPessoa = idPessoa;
            this.IdTermo = idTermo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaTermoId" /> class.
        /// </summary>
        public PessoaTermoId()
        {
        }

    }
}