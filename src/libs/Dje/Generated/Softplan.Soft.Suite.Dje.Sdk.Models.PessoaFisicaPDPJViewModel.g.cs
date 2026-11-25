
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaFisicaPDPJViewModel
    {
        /// <summary>
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        public string? Cpf { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Nome da pessoa física
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

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
        /// Initializes a new instance of the <see cref="PessoaFisicaPDPJViewModel" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome da pessoa física
        /// </param>
        /// <param name="cpf">
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaFisicaPDPJViewModel(
            string nome,
            string? cpf,
            string? email,
            string? nomeSocial)
        {
            this.Cpf = cpf;
            this.Email = email;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.NomeSocial = nomeSocial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaPDPJViewModel" /> class.
        /// </summary>
        public PessoaFisicaPDPJViewModel()
        {
        }

    }
}