
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaFisicaViewModel
    {
        /// <summary>
        /// Se ativo ou não
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        public string? Cpf { get; set; }

        /// <summary>
        /// Data em que a pessoa passou a ser habilitada a receber citações/intimações pelo Domicílio Eletrônico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHabilitacao")]
        public string? DataHabilitacao { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Nome da pessoa física
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeSocial")]
        public string? NomeSocial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaViewModel" /> class.
        /// </summary>
        /// <param name="ativo">
        /// Se ativo ou não
        /// </param>
        /// <param name="cpf">
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </param>
        /// <param name="dataHabilitacao">
        /// Data em que a pessoa passou a ser habilitada a receber citações/intimações pelo Domicílio Eletrônico
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="nome">
        /// Nome da pessoa física
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaFisicaViewModel(
            bool? ativo,
            string? cpf,
            string? dataHabilitacao,
            string? email,
            string? nome,
            string? nomeSocial)
        {
            this.Ativo = ativo;
            this.Cpf = cpf;
            this.DataHabilitacao = dataHabilitacao;
            this.Email = email;
            this.Nome = nome;
            this.NomeSocial = nomeSocial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaViewModel" /> class.
        /// </summary>
        public PessoaFisicaViewModel()
        {
        }

    }
}