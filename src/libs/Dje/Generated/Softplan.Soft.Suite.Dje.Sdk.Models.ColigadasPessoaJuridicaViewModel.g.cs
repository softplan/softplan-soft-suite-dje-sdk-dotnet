
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ColigadasPessoaJuridicaViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCriacao")]
        public string? DataCriacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idColigada")]
        public long? IdColigada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idSolicitacao")]
        public long? IdSolicitacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

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
        /// Initializes a new instance of the <see cref="ColigadasPessoaJuridicaViewModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="dataCriacao"></param>
        /// <param name="idColigada"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="razaoSocial"></param>
        /// <param name="situacao"></param>
        /// <param name="tipoEmpresa"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColigadasPessoaJuridicaViewModel(
            string? cnpj,
            string? dataCriacao,
            long? idColigada,
            long? idSolicitacao,
            string? razaoSocial,
            string? situacao,
            string? tipoEmpresa)
        {
            this.Cnpj = cnpj;
            this.DataCriacao = dataCriacao;
            this.IdColigada = idColigada;
            this.IdSolicitacao = idSolicitacao;
            this.RazaoSocial = razaoSocial;
            this.Situacao = situacao;
            this.TipoEmpresa = tipoEmpresa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColigadasPessoaJuridicaViewModel" /> class.
        /// </summary>
        public ColigadasPessoaJuridicaViewModel()
        {
        }

    }
}