
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaJuridicaViewModel
    {
        /// <summary>
        /// Atividade Economica pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atividadeEconomica")]
        public global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaViewModel? AtividadeEconomica { get; set; }

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
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Endereço pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endereco")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EnderecoViewModel? Endereco { get; set; }

        /// <summary>
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        /// Natureza Juridica pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturezaJuridica")]
        public global::Softplan.Soft.Suite.Dje.Sdk.NaturezaJuridicaViewModel? NaturezaJuridica { get; set; }

        /// <summary>
        /// Nome fantasia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeFantasia")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NomeFantasia { get; set; }

        /// <summary>
        /// Se é ou não um órgão público
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoPublico")]
        public bool? OrgaoPublico { get; set; }

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
        /// Informações representante juridico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representanteJuridico")]
        public global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoViewModel? RepresentanteJuridico { get; set; }

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
        /// Initializes a new instance of the <see cref="PessoaJuridicaViewModel" /> class.
        /// </summary>
        /// <param name="nomeFantasia">
        /// Nome fantasia
        /// </param>
        /// <param name="atividadeEconomica">
        /// Atividade Economica pessoa jurídica
        /// </param>
        /// <param name="ativo">
        /// Se ativo ou não
        /// </param>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="endereco">
        /// Endereço pessoa jurídica
        /// </param>
        /// <param name="habilitada">
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </param>
        /// <param name="naturezaJuridica">
        /// Natureza Juridica pessoa jurídica
        /// </param>
        /// <param name="orgaoPublico">
        /// Se é ou não um órgão público
        /// </param>
        /// <param name="porte">
        /// Porte da pessoa jurídica. Admite os valores ME, EPP e Demais, para MicroEmpresa, Empresa de Pequeno Porte, e Demais empresas, respectivamente.
        /// </param>
        /// <param name="razaoSocial">
        /// Razão social
        /// </param>
        /// <param name="representanteJuridico">
        /// Informações representante juridico
        /// </param>
        /// <param name="tipoEmpresa">
        /// No caso de empresas, o seu tipo. Admite os valores M, F e C, par Matriz, Filial e Coligada, respectivamente.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaJuridicaViewModel(
            string nomeFantasia,
            global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaViewModel? atividadeEconomica,
            bool? ativo,
            string? cnpj,
            string? email,
            global::Softplan.Soft.Suite.Dje.Sdk.EnderecoViewModel? endereco,
            bool? habilitada,
            global::Softplan.Soft.Suite.Dje.Sdk.NaturezaJuridicaViewModel? naturezaJuridica,
            bool? orgaoPublico,
            string? porte,
            string? razaoSocial,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoViewModel? representanteJuridico,
            string? tipoEmpresa)
        {
            this.AtividadeEconomica = atividadeEconomica;
            this.Ativo = ativo;
            this.Cnpj = cnpj;
            this.Email = email;
            this.Endereco = endereco;
            this.Habilitada = habilitada;
            this.NaturezaJuridica = naturezaJuridica;
            this.NomeFantasia = nomeFantasia ?? throw new global::System.ArgumentNullException(nameof(nomeFantasia));
            this.OrgaoPublico = orgaoPublico;
            this.Porte = porte;
            this.RazaoSocial = razaoSocial;
            this.RepresentanteJuridico = representanteJuridico;
            this.TipoEmpresa = tipoEmpresa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaViewModel" /> class.
        /// </summary>
        public PessoaJuridicaViewModel()
        {
        }

    }
}