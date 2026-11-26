
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaHabilitadaViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ehPublico")]
        public bool? EhPublico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaHabilitadaViewModel" /> class.
        /// </summary>
        /// <param name="ehPublico"></param>
        /// <param name="email"></param>
        /// <param name="habilitada"></param>
        /// <param name="nome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaHabilitadaViewModel(
            bool? ehPublico,
            string? email,
            bool? habilitada,
            string? nome)
        {
            this.EhPublico = ehPublico;
            this.Email = email;
            this.Habilitada = habilitada;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaHabilitadaViewModel" /> class.
        /// </summary>
        public PessoaHabilitadaViewModel()
        {
        }

    }
}