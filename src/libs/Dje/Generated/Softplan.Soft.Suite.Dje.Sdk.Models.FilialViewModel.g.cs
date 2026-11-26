
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilialViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        public string? CriadoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEmpresa")]
        public string? TipoEmpresa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilialViewModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="criadoEm"></param>
        /// <param name="id"></param>
        /// <param name="razaoSocial"></param>
        /// <param name="tipoEmpresa"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilialViewModel(
            string? cnpj,
            string? criadoEm,
            long? id,
            string? razaoSocial,
            string? tipoEmpresa)
        {
            this.Cnpj = cnpj;
            this.CriadoEm = criadoEm;
            this.Id = id;
            this.RazaoSocial = razaoSocial;
            this.TipoEmpresa = tipoEmpresa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilialViewModel" /> class.
        /// </summary>
        public FilialViewModel()
        {
        }

    }
}