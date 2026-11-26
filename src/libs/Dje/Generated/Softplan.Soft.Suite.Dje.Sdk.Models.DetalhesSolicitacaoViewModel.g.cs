
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetalhesSolicitacaoViewModel
    {
        /// <summary>
        /// Atividade Economica pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atividadeEconomica")]
        public global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaViewModel? AtividadeEconomica { get; set; }

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
        /// Informações solicitação de vínculo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("solicitacao")]
        public global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculoViewModel? Solicitacao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetalhesSolicitacaoViewModel" /> class.
        /// </summary>
        /// <param name="nomeFantasia">
        /// Nome fantasia
        /// </param>
        /// <param name="atividadeEconomica">
        /// Atividade Economica pessoa jurídica
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
        /// <param name="solicitacao">
        /// Informações solicitação de vínculo
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetalhesSolicitacaoViewModel(
            string nomeFantasia,
            global::Softplan.Soft.Suite.Dje.Sdk.AtividadeEconomicaViewModel? atividadeEconomica,
            string? cnpj,
            string? email,
            global::Softplan.Soft.Suite.Dje.Sdk.EnderecoViewModel? endereco,
            global::Softplan.Soft.Suite.Dje.Sdk.NaturezaJuridicaViewModel? naturezaJuridica,
            bool? orgaoPublico,
            string? porte,
            string? razaoSocial,
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitacaoVinculoViewModel? solicitacao)
        {
            this.AtividadeEconomica = atividadeEconomica;
            this.Cnpj = cnpj;
            this.Email = email;
            this.Endereco = endereco;
            this.NaturezaJuridica = naturezaJuridica;
            this.NomeFantasia = nomeFantasia ?? throw new global::System.ArgumentNullException(nameof(nomeFantasia));
            this.OrgaoPublico = orgaoPublico;
            this.Porte = porte;
            this.RazaoSocial = razaoSocial;
            this.Solicitacao = solicitacao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetalhesSolicitacaoViewModel" /> class.
        /// </summary>
        public DetalhesSolicitacaoViewModel()
        {
        }

    }
}