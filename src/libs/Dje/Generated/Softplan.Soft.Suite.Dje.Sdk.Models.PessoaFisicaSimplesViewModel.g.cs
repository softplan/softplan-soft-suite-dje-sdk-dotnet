
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaFisicaSimplesViewModel
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
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        /// Quem realizou a habilitação desta pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitador")]
        public string? Habilitador { get; set; }

        /// <summary>
        /// Hash do tipo SHA-1 do documento do termo de aceite de uso do sistema, armazenado no repositório de binários da PDPJ
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashTermoAceite")]
        public string? HashTermoAceite { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        /// Tipo da pessoa. Admite os valores F e J, para pessoa física e jurídica, respectivamente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        public string? TipoPessoa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaSimplesViewModel" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome da pessoa física
        /// </param>
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
        /// <param name="habilitada">
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </param>
        /// <param name="habilitador">
        /// Quem realizou a habilitação desta pessoa
        /// </param>
        /// <param name="hashTermoAceite">
        /// Hash do tipo SHA-1 do documento do termo de aceite de uso do sistema, armazenado no repositório de binários da PDPJ
        /// </param>
        /// <param name="id">
        /// Id
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
        /// <param name="tipoPessoa">
        /// Tipo da pessoa. Admite os valores F e J, para pessoa física e jurídica, respectivamente.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaFisicaSimplesViewModel(
            string nome,
            bool? ativo,
            string? cpf,
            string? dataHabilitacao,
            string? email,
            bool? habilitada,
            string? habilitador,
            string? hashTermoAceite,
            long? id,
            string? nomeSocial,
            string? tipoPessoa)
        {
            this.Ativo = ativo;
            this.Cpf = cpf;
            this.DataHabilitacao = dataHabilitacao;
            this.Email = email;
            this.Habilitada = habilitada;
            this.Habilitador = habilitador;
            this.HashTermoAceite = hashTermoAceite;
            this.Id = id;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.NomeSocial = nomeSocial;
            this.TipoPessoa = tipoPessoa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaSimplesViewModel" /> class.
        /// </summary>
        public PessoaFisicaSimplesViewModel()
        {
        }

    }
}