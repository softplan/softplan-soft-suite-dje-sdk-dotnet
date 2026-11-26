
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CriarMatrizViewModel
    {
        /// <summary>
        /// Se ativo ou não
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        /// Nome fantasia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeFantasia")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NomeFantasia { get; set; }

        /// <summary>
        /// Porte da pessoa jurídica. Admite os valores ME, EPP e Demais, para MicroEmpresa, Empresa de Pequeno Porte, e Demais empresas, respectivamente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("porte")]
        public string? Porte { get; set; }

        /// <summary>
        /// Razão social
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        /// No caso de empresas, o seu tipo. Admite os valores M, F e C, par Matriz, Filial e Coligada, respectivamente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEmpresa")]
        public string? TipoEmpresa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriarMatrizViewModel" /> class.
        /// </summary>
        /// <param name="nomeFantasia">
        /// Nome fantasia
        /// </param>
        /// <param name="ativo">
        /// Se ativo ou não
        /// </param>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="porte">
        /// Porte da pessoa jurídica. Admite os valores ME, EPP e Demais, para MicroEmpresa, Empresa de Pequeno Porte, e Demais empresas, respectivamente.
        /// </param>
        /// <param name="razaoSocial">
        /// Razão social
        /// </param>
        /// <param name="tipoEmpresa">
        /// No caso de empresas, o seu tipo. Admite os valores M, F e C, par Matriz, Filial e Coligada, respectivamente.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriarMatrizViewModel(
            string nomeFantasia,
            bool? ativo,
            string? cnpj,
            string? porte,
            string? razaoSocial,
            string? tipoEmpresa)
        {
            this.Ativo = ativo;
            this.Cnpj = cnpj;
            this.NomeFantasia = nomeFantasia ?? throw new global::System.ArgumentNullException(nameof(nomeFantasia));
            this.Porte = porte;
            this.RazaoSocial = razaoSocial;
            this.TipoEmpresa = tipoEmpresa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriarMatrizViewModel" /> class.
        /// </summary>
        public CriarMatrizViewModel()
        {
        }

    }
}