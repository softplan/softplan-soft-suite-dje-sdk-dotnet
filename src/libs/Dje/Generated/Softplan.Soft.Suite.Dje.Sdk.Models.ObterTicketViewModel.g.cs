
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObterTicketViewModel
    {
        /// <summary>
        /// A classificação do ticket<br/>
        /// Example: OUTROS
        /// </summary>
        /// <example>OUTROS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classificacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelClassificacaoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelClassificacao Classificacao { get; set; }

        /// <summary>
        /// Data e hora em que o ticket foi registrado no padrão ISO8601<br/>
        /// Example: 2023-10-11T19:15:00Z
        /// </summary>
        /// <example>2023-10-11T19:15:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriadoEm { get; set; }

        /// <summary>
        /// Identificação de quem solicitou a criação do ticket.<br/>
        /// Example: usuario-xpto
        /// </summary>
        /// <example>usuario-xpto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoPor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriadoPor { get; set; }

        /// <summary>
        /// Data e hora em que o ticket foi solicitado no padrão ISO8601<br/>
        /// Example: 2023-10-11T19:15:00Z
        /// </summary>
        /// <example>2023-10-11T19:15:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSolicitacao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataSolicitacao { get; set; }

        /// <summary>
        /// Documento(CPF/CNPJ) do destinatario da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: 07421906000129
        /// </summary>
        /// <example>07421906000129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentoDestinario")]
        public string? DocumentoDestinario { get; set; }

        /// <summary>
        /// Em casos de ocorrerem problemas durante o processo de geração do ticket será notificados através desta propriedade, caso essa propriedade esteja preenchida o status do ticket será "CANCELADO"<br/>
        /// Example: ['PROCESSAR_TICKET_PROCESSO_NAO_EXISTE' -&gt; 'O processo não foi encontrado']
        /// </summary>
        /// <example>['PROCESSAR_TICKET_PROCESSO_NAO_EXISTE' -&gt; 'O processo não foi encontrado']</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("erros")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Erros { get; set; }

        /// <summary>
        /// Hash-256 do certificado<br/>
        /// Example: 428e51ce81e70457b11e42a2af8e89ceb792bbd5dbb2ca89cd2826228a00008d
        /// </summary>
        /// <example>428e51ce81e70457b11e42a2af8e89ceb792bbd5dbb2ca89cd2826228a00008d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashCertificado")]
        public string? HashCertificado { get; set; }

        /// <summary>
        /// Identificador do ticket<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Link para acessar a certidão de inconsistencia da comunicação em pdf. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: https://servidor.org.br/certidao-xpto.pdf
        /// </summary>
        /// <example>https://servidor.org.br/certidao-xpto.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkCertificado")]
        public string? LinkCertificado { get; set; }

        /// <summary>
        /// Link de inteiro teor da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: https://servidor.org.br/inteiro-teor-xpto
        /// </summary>
        /// <example>https://servidor.org.br/inteiro-teor-xpto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkInteiroTeor")]
        public string? LinkInteiroTeor { get; set; }

        /// <summary>
        /// O motivo da abertura do ticket. Apenas quando classificação for igual a OUTROS<br/>
        /// Example: Estou recebendo 403 do servidor do tribunal
        /// </summary>
        /// <example>Estou recebendo 403 do servidor do tribunal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("motivo")]
        public string? Motivo { get; set; }

        /// <summary>
        /// Status do ticket<br/>
        /// Example: FINALIZADO
        /// </summary>
        /// <example>FINALIZADO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ObterTicketViewModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelStatus Status { get; set; }

        /// <summary>
        /// O tribunal de origem da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </summary>
        /// <example>Tribunal de Justiça do Estado do Rio Grande do Norte</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tribunal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterTicketViewModel" /> class.
        /// </summary>
        /// <param name="classificacao">
        /// A classificação do ticket<br/>
        /// Example: OUTROS
        /// </param>
        /// <param name="criadoEm">
        /// Data e hora em que o ticket foi registrado no padrão ISO8601<br/>
        /// Example: 2023-10-11T19:15:00Z
        /// </param>
        /// <param name="criadoPor">
        /// Identificação de quem solicitou a criação do ticket.<br/>
        /// Example: usuario-xpto
        /// </param>
        /// <param name="dataSolicitacao">
        /// Data e hora em que o ticket foi solicitado no padrão ISO8601<br/>
        /// Example: 2023-10-11T19:15:00Z
        /// </param>
        /// <param name="id">
        /// Identificador do ticket<br/>
        /// Example: 1
        /// </param>
        /// <param name="status">
        /// Status do ticket<br/>
        /// Example: FINALIZADO
        /// </param>
        /// <param name="tribunal">
        /// O tribunal de origem da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </param>
        /// <param name="documentoDestinario">
        /// Documento(CPF/CNPJ) do destinatario da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: 07421906000129
        /// </param>
        /// <param name="erros">
        /// Em casos de ocorrerem problemas durante o processo de geração do ticket será notificados através desta propriedade, caso essa propriedade esteja preenchida o status do ticket será "CANCELADO"<br/>
        /// Example: ['PROCESSAR_TICKET_PROCESSO_NAO_EXISTE' -&gt; 'O processo não foi encontrado']
        /// </param>
        /// <param name="hashCertificado">
        /// Hash-256 do certificado<br/>
        /// Example: 428e51ce81e70457b11e42a2af8e89ceb792bbd5dbb2ca89cd2826228a00008d
        /// </param>
        /// <param name="linkCertificado">
        /// Link para acessar a certidão de inconsistencia da comunicação em pdf. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: https://servidor.org.br/certidao-xpto.pdf
        /// </param>
        /// <param name="linkInteiroTeor">
        /// Link de inteiro teor da comunicação. Vazio enquanto valor do status for igual PROCESSANDO.<br/>
        /// Example: https://servidor.org.br/inteiro-teor-xpto
        /// </param>
        /// <param name="motivo">
        /// O motivo da abertura do ticket. Apenas quando classificação for igual a OUTROS<br/>
        /// Example: Estou recebendo 403 do servidor do tribunal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObterTicketViewModel(
            global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelClassificacao classificacao,
            string criadoEm,
            string criadoPor,
            string dataSolicitacao,
            long id,
            global::Softplan.Soft.Suite.Dje.Sdk.ObterTicketViewModelStatus status,
            string tribunal,
            string? documentoDestinario,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? erros,
            string? hashCertificado,
            string? linkCertificado,
            string? linkInteiroTeor,
            string? motivo)
        {
            this.Classificacao = classificacao;
            this.CriadoEm = criadoEm ?? throw new global::System.ArgumentNullException(nameof(criadoEm));
            this.CriadoPor = criadoPor ?? throw new global::System.ArgumentNullException(nameof(criadoPor));
            this.DataSolicitacao = dataSolicitacao ?? throw new global::System.ArgumentNullException(nameof(dataSolicitacao));
            this.DocumentoDestinario = documentoDestinario;
            this.Erros = erros;
            this.HashCertificado = hashCertificado;
            this.Id = id;
            this.LinkCertificado = linkCertificado;
            this.LinkInteiroTeor = linkInteiroTeor;
            this.Motivo = motivo;
            this.Status = status;
            this.Tribunal = tribunal ?? throw new global::System.ArgumentNullException(nameof(tribunal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObterTicketViewModel" /> class.
        /// </summary>
        public ObterTicketViewModel()
        {
        }

    }
}