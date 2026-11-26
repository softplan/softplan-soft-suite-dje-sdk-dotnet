
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaginaUsuarioPessoaJuridicaViewModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeEmpresa")]
        public string? NomeEmpresa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginaUsuarioPessoaJuridicaViewModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="identificador"></param>
        /// <param name="nomeEmpresa"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginaUsuarioPessoaJuridicaViewModel(
            string? cnpj,
            string? identificador,
            string? nomeEmpresa)
        {
            this.Cnpj = cnpj;
            this.Identificador = identificador;
            this.NomeEmpresa = nomeEmpresa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginaUsuarioPessoaJuridicaViewModel" /> class.
        /// </summary>
        public PaginaUsuarioPessoaJuridicaViewModel()
        {
        }

    }
}