
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NaturezaJuridicaViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigoReceita")]
        public string? CodigoReceita { get; set; }

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
        /// Initializes a new instance of the <see cref="NaturezaJuridicaViewModel" /> class.
        /// </summary>
        /// <param name="ativo"></param>
        /// <param name="codigoReceita"></param>
        /// <param name="nome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NaturezaJuridicaViewModel(
            bool? ativo,
            string? codigoReceita,
            string? nome)
        {
            this.Ativo = ativo;
            this.CodigoReceita = codigoReceita;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaturezaJuridicaViewModel" /> class.
        /// </summary>
        public NaturezaJuridicaViewModel()
        {
        }

    }
}