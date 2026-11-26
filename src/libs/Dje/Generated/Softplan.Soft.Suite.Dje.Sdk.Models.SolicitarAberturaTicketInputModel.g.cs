
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SolicitarAberturaTicketInputModel
    {
        /// <summary>
        /// A classificação do ticket. <br/>
        ///  (1 - INTEIRO_TEOR_EM_BRANCO, 2 - INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA, 3 - INTEIRO_TEOR_INDISPONIVEL, 4 - INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO, 5 - INTEIRO_TEOR_COM_AUTENTICACAO_PREVIA, 6 - OUTROS)<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classificacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.SolicitarAberturaTicketInputModelClassificacaoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModelClassificacao Classificacao { get; set; }

        /// <summary>
        /// O motivo da abertura do ticket. Apenas se o valor de classificacao for igual a 5 - OUTROS<br/>
        /// Example: Estou recebendo 403 ao tentar acessar inteiro teor.
        /// </summary>
        /// <example>Estou recebendo 403 ao tentar acessar inteiro teor.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("motivo")]
        public string? Motivo { get; set; }

        /// <summary>
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </summary>
        /// <example>0800854512021820512320220001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroComunicacao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumeroComunicacao { get; set; }

        /// <summary>
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </summary>
        /// <example>08008545120218205123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumeroProcesso { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitarAberturaTicketInputModel" /> class.
        /// </summary>
        /// <param name="classificacao">
        /// A classificação do ticket. <br/>
        ///  (1 - INTEIRO_TEOR_EM_BRANCO, 2 - INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA, 3 - INTEIRO_TEOR_INDISPONIVEL, 4 - INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO, 5 - INTEIRO_TEOR_COM_AUTENTICACAO_PREVIA, 6 - OUTROS)<br/>
        /// Example: 5
        /// </param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="motivo">
        /// O motivo da abertura do ticket. Apenas se o valor de classificacao for igual a 5 - OUTROS<br/>
        /// Example: Estou recebendo 403 ao tentar acessar inteiro teor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SolicitarAberturaTicketInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.SolicitarAberturaTicketInputModelClassificacao classificacao,
            string numeroComunicacao,
            string numeroProcesso,
            string? motivo)
        {
            this.Classificacao = classificacao;
            this.Motivo = motivo;
            this.NumeroComunicacao = numeroComunicacao ?? throw new global::System.ArgumentNullException(nameof(numeroComunicacao));
            this.NumeroProcesso = numeroProcesso ?? throw new global::System.ArgumentNullException(nameof(numeroProcesso));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitarAberturaTicketInputModel" /> class.
        /// </summary>
        public SolicitarAberturaTicketInputModel()
        {
        }

    }
}