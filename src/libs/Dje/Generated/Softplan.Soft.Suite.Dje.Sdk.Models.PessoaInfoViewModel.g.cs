
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaInfoViewModel
    {
        /// <summary>
        /// Se ativo ou não
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// CPF ou CNPJ da pessoa (a depender se é física ou jurídica, respectivamente)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpfCnpj")]
        public string? CpfCnpj { get; set; }

        /// <summary>
        /// Data em que a pessoa passou a ser habilitada a receber citações/intimações pelo Domicílio Eletrônico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHabilitacao")]
        public string? DataHabilitacao { get; set; }

        /// <summary>
        /// Se pessoa é publica ou privada
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ehPublico")]
        public bool? EhPublico { get; set; }

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
        /// Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Nome pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Se a empresa é Filial, Coligada ou Matriz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEmpresa")]
        public string? TipoEmpresa { get; set; }

        /// <summary>
        /// Tipo da pessoa. Admite os valores F e J, para pessoa física e jurídica, respectivamente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaInfoViewModelTipoPessoaJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PessoaInfoViewModelTipoPessoa? TipoPessoa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaInfoViewModel" /> class.
        /// </summary>
        /// <param name="ativo">
        /// Se ativo ou não
        /// </param>
        /// <param name="cpfCnpj">
        /// CPF ou CNPJ da pessoa (a depender se é física ou jurídica, respectivamente)
        /// </param>
        /// <param name="dataHabilitacao">
        /// Data em que a pessoa passou a ser habilitada a receber citações/intimações pelo Domicílio Eletrônico
        /// </param>
        /// <param name="ehPublico">
        /// Se pessoa é publica ou privada
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
        /// <param name="id">
        /// Id
        /// </param>
        /// <param name="nome">
        /// Nome pessoa
        /// </param>
        /// <param name="tipoEmpresa">
        /// Se a empresa é Filial, Coligada ou Matriz
        /// </param>
        /// <param name="tipoPessoa">
        /// Tipo da pessoa. Admite os valores F e J, para pessoa física e jurídica, respectivamente.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaInfoViewModel(
            bool? ativo,
            string? cpfCnpj,
            string? dataHabilitacao,
            bool? ehPublico,
            string? email,
            bool? habilitada,
            string? habilitador,
            long? id,
            string? nome,
            string? tipoEmpresa,
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaInfoViewModelTipoPessoa? tipoPessoa)
        {
            this.Ativo = ativo;
            this.CpfCnpj = cpfCnpj;
            this.DataHabilitacao = dataHabilitacao;
            this.EhPublico = ehPublico;
            this.Email = email;
            this.Habilitada = habilitada;
            this.Habilitador = habilitador;
            this.Id = id;
            this.Nome = nome;
            this.TipoEmpresa = tipoEmpresa;
            this.TipoPessoa = tipoPessoa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaInfoViewModel" /> class.
        /// </summary>
        public PessoaInfoViewModel()
        {
        }

    }
}