
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscopoPermissaoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identificador")]
        public string? Identificador { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeAceitar")]
        public bool? PodeAceitar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoViewModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="identificador"></param>
        /// <param name="podeAceitar"></param>
        /// <param name="razaoSocial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscopoPermissaoViewModel(
            string? cnpj,
            string? identificador,
            bool? podeAceitar,
            string? razaoSocial)
        {
            this.Cnpj = cnpj;
            this.Identificador = identificador;
            this.PodeAceitar = podeAceitar;
            this.RazaoSocial = razaoSocial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoViewModel" /> class.
        /// </summary>
        public EscopoPermissaoViewModel()
        {
        }

    }
}