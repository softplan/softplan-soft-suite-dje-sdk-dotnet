
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComunicacaoProcessualViewModel
    {
        /// <summary>
        /// Tipo da reclamação (indenizatória, revisional, reclamação trabalhista...)<br/>
        /// Example: Obrigação de Fazer / Não Fazer, Abono Pecuniário (Art. 78 Lei 8.112/1990)
        /// </summary>
        /// <example>Obrigação de Fazer / Não Fazer, Abono Pecuniário (Art. 78 Lei 8.112/1990)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assunto")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Assunto { get; set; }

        /// <summary>
        /// Assunto da comunicaÃ§Ã£o (snapshot do assunto vigente no momento do envio).<br/>
        /// Example: EmprÃ©stimo consignado
        /// </summary>
        /// <example>EmprÃ©stimo consignado</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assuntoComunicacao")]
        public string? AssuntoComunicacao { get; set; }

        /// <summary>
        /// Timestamp do ultimo momento que o registro foi atualizado<br/>
        /// Example: 2022-06-08T21:48:12.521084Z
        /// </summary>
        /// <example>2022-06-08T21:48:12.521084Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoEm")]
        public string? AtualizadoEm { get; set; }

        /// <summary>
        /// Identificação de ultimo que atualizou o registro<br/>
        /// Example: usuario_xpto
        /// </summary>
        /// <example>usuario_xpto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("atualizadoPor")]
        public string? AtualizadoPor { get; set; }

        /// <summary>
        /// Audiencia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audiencia")]
        public global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModel? Audiencia { get; set; }

        /// <summary>
        /// Dados dos autores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoresReclamantes")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>? AutoresReclamantes { get; set; }

        /// <summary>
        /// Se houve ciência automática<br/>
        /// Example: S
        /// </summary>
        /// <example>S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cienciaAutomatica")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelCienciaAutomaticaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelCienciaAutomatica CienciaAutomatica { get; set; }

        /// <summary>
        /// Ciente<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciente")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ciente { get; set; }

        /// <summary>
        /// Classe<br/>
        /// Example: PROCEDIMENTO DO JUIZADO ESPECIAL CÍVEL
        /// </summary>
        /// <example>PROCEDIMENTO DO JUIZADO ESPECIAL CÍVEL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Classe { get; set; }

        /// <summary>
        /// Codigo da classe processual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigoClasseProcessual")]
        public string? CodigoClasseProcessual { get; set; }

        /// <summary>
        /// Este codigo corresponde a identificação nacional do orgão julgador
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigoOrgaoJulgadorCorporativo")]
        public string? CodigoOrgaoJulgadorCorporativo { get; set; }

        /// <summary>
        /// Timestamp do momento da criação do registro<br/>
        /// Example: 2022-06-08T21:48:12.521084Z
        /// </summary>
        /// <example>2022-06-08T21:48:12.521084Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoEm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriadoEm { get; set; }

        /// <summary>
        /// Identificação de quem criou o registro<br/>
        /// Example: usuario_xpto
        /// </summary>
        /// <example>usuario_xpto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("criadoPor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriadoPor { get; set; }

        /// <summary>
        /// Data de propositura da ação<br/>
        /// Example: 2021-20-07
        /// </summary>
        /// <example>2021-20-07</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataAjuizamento")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataAjuizamento { get; set; }

        /// <summary>
        /// Data certa da comunicação, usa padrão ISO8601<br/>
        /// Example: 2024-01-04
        /// </summary>
        /// <example>2024-01-04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCerta")]
        public string? DataCerta { get; set; }

        /// <summary>
        /// Data da que foi executada a ciência da comuniacao<br/>
        /// Example: 2022-06-08T23:00:00Z
        /// </summary>
        /// <example>2022-06-08T23:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCiente")]
        public string? DataCiente { get; set; }

        /// <summary>
        /// Data de comunicação<br/>
        /// Example: 2022-06-08T00:00:00Z
        /// </summary>
        /// <example>2022-06-08T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataComunicacao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataComunicacao { get; set; }

        /// <summary>
        /// Data de fim da sessao de julgamento<br/>
        /// Example: 2025-05-01
        /// </summary>
        /// <example>2025-05-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataFimSessaoJulgamento")]
        public string? DataFimSessaoJulgamento { get; set; }

        /// <summary>
        /// Data final para ciência<br/>
        /// Example: 10-10-2021
        /// </summary>
        /// <example>10-10-2021</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataFinalCiencia")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataFinalCiencia { get; set; }

        /// <summary>
        /// Data de início da sessao de julgamento<br/>
        /// Example: 2025-05-01
        /// </summary>
        /// <example>2025-05-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataInicioSessaoJulgamento")]
        public string? DataInicioSessaoJulgamento { get; set; }

        /// <summary>
        /// Documento(CPF/CNPJ) do destinatario da comunicação<br/>
        /// Example: 07421906000129
        /// </summary>
        /// <example>07421906000129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentoDestinatario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentoDestinatario { get; set; }

        /// <summary>
        /// Indica se é ou não comunicação pessoal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ehComunicacaoPessoal")]
        public bool? EhComunicacaoPessoal { get; set; }

        /// <summary>
        /// Se a comunicação já foi encerrada ou ainda esta em curso, Obs: usar esse campo para validação apenas se consumir em real time<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emCurso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EmCurso { get; set; }

        /// <summary>
        /// Se foi ciente tácito<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("foiCienciaAutomatica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FoiCienciaAutomatica { get; set; }

        /// <summary>
        /// Formato da Sessão do Julgamento<br/>
        /// Example: P
        /// </summary>
        /// <example>P</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatoSessaojulgamento")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelFormatoSessaojulgamentoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelFormatoSessaojulgamento? FormatoSessaojulgamento { get; set; }

        /// <summary>
        /// Hora de fim da sessao de julgamento<br/>
        /// Example: 12:00
        /// </summary>
        /// <example>12:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horaFimSessaoJulgamento")]
        public string? HoraFimSessaoJulgamento { get; set; }

        /// <summary>
        /// Hora de início da sessao de julgamento<br/>
        /// Example: 10:00
        /// </summary>
        /// <example>10:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horaInicioSessaoJulgamento")]
        public string? HoraInicioSessaoJulgamento { get; set; }

        /// <summary>
        /// Id Aviso da comunicacao
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idAviso")]
        public string? IdAviso { get; set; }

        /// <summary>
        /// Id Movimento da comunicacao
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idMovimento")]
        public string? IdMovimento { get; set; }

        /// <summary>
        /// 1º ou 2º grau.<br/>
        /// Example: PRIMEIRO_GRAU
        /// </summary>
        /// <example>PRIMEIRO_GRAU</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelInstanciaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelInstancia Instancia { get; set; }

        /// <summary>
        /// Se o processo estiver tramitando pelo rito do Juízo 100% digital , indicar (sim) ou (não)<br/>
        /// Example: S
        /// </summary>
        /// <example>S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("juizoDigital")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JuizoDigital { get; set; }

        /// <summary>
        /// Leitores Autorizados<br/>
        /// Example: [Maria de Fátima Ferreira, Roberta Miranda de Jesus]
        /// </summary>
        /// <example>[Maria de Fátima Ferreira, Roberta Miranda de Jesus]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("leitoresAutorizados")]
        public global::System.Collections.Generic.IList<string>? LeitoresAutorizados { get; set; }

        /// <summary>
        /// Links dos inteiro teor<br/>
        /// Example: [https://pje1g.tjrn.jus.br/pje/Processo/ConsultaDocumento/listView.seam?x=21071916330504400000067586444]
        /// </summary>
        /// <example>[https://pje1g.tjrn.jus.br/pje/Processo/ConsultaDocumento/listView.seam?x=21071916330504400000067586444]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linksDocumentos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LinksDocumentos { get; set; }

        /// <summary>
        /// Lista contendo links dos documentos adicionais dos inteiro teor.<br/>
        /// Example: [https://xpto-um.gov.br/arquivo-complementar-1.pdf, https://xpto-dois.gov.br/arquivo-complementar-2.xml]
        /// </summary>
        /// <example>[https://xpto-um.gov.br/arquivo-complementar-1.pdf, https://xpto-dois.gov.br/arquivo-complementar-2.xml]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linksDocumentosAdicionais")]
        public global::System.Collections.Generic.IList<string>? LinksDocumentosAdicionais { get; set; }

        /// <summary>
        /// Local da sessão de julgamento<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </summary>
        /// <example>Tribunal de Justiça do Estado do Rio Grande do Norte</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("localSessaoJulgamento")]
        public string? LocalSessaoJulgamento { get; set; }

        /// <summary>
        /// Nome do juiz responsável pelo processo<br/>
        /// Example: José da Silva Moreira
        /// </summary>
        /// <example>José da Silva Moreira</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magistrado")]
        public string? Magistrado { get; set; }

        /// <summary>
        /// Meio de envio da comunicação<br/>
        /// Example: DOMICILIO_ELETRONICO
        /// </summary>
        /// <example>DOMICILIO_ELETRONICO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meioEnvio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelMeioEnvioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelMeioEnvio MeioEnvio { get; set; }

        /// <summary>
        /// Descrição do motivo da intimação que será enviado pelo tribunal/STJ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motivoIntimacao")]
        public string? MotivoIntimacao { get; set; }

        /// <summary>
        /// Nível de sigilo do processo<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nivelSigilo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelNivelSigiloJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelNivelSigilo? NivelSigilo { get; set; }

        /// <summary>
        /// Nome do destinatário da comunicação<br/>
        /// Example: José da Silva Santos
        /// </summary>
        /// <example>José da Silva Santos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeDestinatario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NomeDestinatario { get; set; }

        /// <summary>
        /// Nome do usuario do cliente que realizou a ciencia<br/>
        /// Example: Martin Bernardo Vicente Oliveira.
        /// </summary>
        /// <example>Martin Bernardo Vicente Oliveira.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeUsuarioCiente")]
        public string? NomeUsuarioCiente { get; set; }

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
        /// Número identificador do processo no formato antigo<br/>
        /// Example: [08238799320198230010]
        /// </summary>
        /// <example>[08238799320198230010]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcessoAntigo")]
        public global::System.Collections.Generic.IList<string>? NumeroProcessoAntigo { get; set; }

        /// <summary>
        /// Número do processo relacionado<br/>
        /// Example: [08238799320198230010]
        /// </summary>
        /// <example>[08238799320198230010]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcessoRelacionado")]
        public global::System.Collections.Generic.IList<string>? NumeroProcessoRelacionado { get; set; }

        /// <summary>
        /// Jurisdição (JEC, Vara Cível, CEJUSC, Vara Trabalhista)<br/>
        /// Example: JUIZADO ESPECIAL CÍVEL
        /// </summary>
        /// <example>JUIZADO ESPECIAL CÍVEL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoLegal")]
        public string? OrgaoLegal { get; set; }

        /// <summary>
        /// A parte interessada conforme destinatario.<br/>
        /// Example: REU
        /// </summary>
        /// <example>REU</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parteInteressada")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelParteInteressadaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelParteInteressada ParteInteressada { get; set; }

        /// <summary>
        /// Informação a respeito de petição
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peticao")]
        public global::Softplan.Soft.Suite.Dje.Sdk.PeticaoViewModel? Peticao { get; set; }

        /// <summary>
        /// Data limite para cumprimento da intimação<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prazo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Prazo { get; set; }

        /// <summary>
        /// Dado dos representantes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representantes")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModel>? Representantes { get; set; }

        /// <summary>
        /// Dados da empresa reclamada
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reus")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>? Reus { get; set; }

        /// <summary>
        /// Se o processo estiver tramitando em segredo de justiça, indicar (sim) ou (não)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segredoJustica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SegredoJustica { get; set; }

        /// <summary>
        /// Dados do servidor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("servidor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ServidorViewModel Servidor { get; set; }

        /// <summary>
        /// Sistema de processo utilizado<br/>
        /// Example: Pje
        /// </summary>
        /// <example>Pje</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sistemaProcesso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SistemaProcesso { get; set; }

        /// <summary>
        /// Status da comunicação.<br/>
        /// Example: EM_CURSO
        /// </summary>
        /// <example>EM_CURSO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelStatus Status { get; set; }

        /// <summary>
        /// Individual ou coletiva<br/>
        /// Example: INDIVIDUAL
        /// </summary>
        /// <example>INDIVIDUAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoAcao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoAcaoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoAcao? TipoAcao { get; set; }

        /// <summary>
        /// Tipo de comunicação (Citação, Intimação, Notificação, Vista ou Ipta)<br/>
        /// Example: INTIMACAO
        /// </summary>
        /// <example>INTIMACAO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoComunicacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoComunicacaoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoComunicacao TipoComunicacao { get; set; }

        /// <summary>
        /// Liminar, obrigação de fazer, sentença, acórdão, trânsito em julgado, Ofício, Intimação de Pauta, Decisão, Despacho e Outros<br/>
        /// Example: LIMINAR
        /// </summary>
        /// <example>LIMINAR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoIntimacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoIntimacaoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoIntimacao? TipoIntimacao { get; set; }

        /// <summary>
        /// Tipo de prazo<br/>
        /// Example: DIAS
        /// </summary>
        /// <example>DIAS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPrazo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoPrazoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoPrazo TipoPrazo { get; set; }

        /// <summary>
        /// Tipo da Sessão do Julgamento<br/>
        /// Example: O
        /// </summary>
        /// <example>O</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoSessaojulgamento")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoSessaojulgamentoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoSessaojulgamento? TipoSessaojulgamento { get; set; }

        /// <summary>
        /// Tribunal de origem<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </summary>
        /// <example>Tribunal de Justiça do Estado do Rio Grande do Norte</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunalOrigem")]
        public string? TribunalOrigem { get; set; }

        /// <summary>
        /// Tutelar de urgência<br/>
        /// Example: S
        /// </summary>
        /// <example>S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tutelaUrgencia")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TutelaUrgencia { get; set; }

        /// <summary>
        /// Estado de referência para o processo<br/>
        /// Example: RN
        /// </summary>
        /// <example>RN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uf { get; set; }

        /// <summary>
        /// Urgente<br/>
        /// Example: S
        /// </summary>
        /// <example>S</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urgente")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Urgente { get; set; }

        /// <summary>
        /// Usuario do cliente que realizou a ciencia.<br/>
        /// Example: martin.bernardo
        /// </summary>
        /// <example>martin.bernardo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuarioCiente")]
        public string? UsuarioCiente { get; set; }

        /// <summary>
        /// Valor da causa indicado na inicial<br/>
        /// Example: 999999999998,97 (formato: ############,##)
        /// </summary>
        /// <example>999999999998,97 (formato: ############,##)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valorCausa")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValorCausa { get; set; }

        /// <summary>
        /// Lotação do processo<br/>
        /// Example: Juizado Especial Cível, Criminal e da Fazenda Pública da Comarca de Parelhas
        /// </summary>
        /// <example>Juizado Especial Cível, Criminal e da Fazenda Pública da Comarca de Parelhas</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("varaJudicial")]
        public string? VaraJudicial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComunicacaoProcessualViewModel" /> class.
        /// </summary>
        /// <param name="assunto">
        /// Tipo da reclamação (indenizatória, revisional, reclamação trabalhista...)<br/>
        /// Example: Obrigação de Fazer / Não Fazer, Abono Pecuniário (Art. 78 Lei 8.112/1990)
        /// </param>
        /// <param name="cienciaAutomatica">
        /// Se houve ciência automática<br/>
        /// Example: S
        /// </param>
        /// <param name="ciente">
        /// Ciente<br/>
        /// Example: true
        /// </param>
        /// <param name="classe">
        /// Classe<br/>
        /// Example: PROCEDIMENTO DO JUIZADO ESPECIAL CÍVEL
        /// </param>
        /// <param name="criadoEm">
        /// Timestamp do momento da criação do registro<br/>
        /// Example: 2022-06-08T21:48:12.521084Z
        /// </param>
        /// <param name="criadoPor">
        /// Identificação de quem criou o registro<br/>
        /// Example: usuario_xpto
        /// </param>
        /// <param name="dataAjuizamento">
        /// Data de propositura da ação<br/>
        /// Example: 2021-20-07
        /// </param>
        /// <param name="dataComunicacao">
        /// Data de comunicação<br/>
        /// Example: 2022-06-08T00:00:00Z
        /// </param>
        /// <param name="dataFinalCiencia">
        /// Data final para ciência<br/>
        /// Example: 10-10-2021
        /// </param>
        /// <param name="documentoDestinatario">
        /// Documento(CPF/CNPJ) do destinatario da comunicação<br/>
        /// Example: 07421906000129
        /// </param>
        /// <param name="emCurso">
        /// Se a comunicação já foi encerrada ou ainda esta em curso, Obs: usar esse campo para validação apenas se consumir em real time<br/>
        /// Example: true
        /// </param>
        /// <param name="foiCienciaAutomatica">
        /// Se foi ciente tácito<br/>
        /// Example: true
        /// </param>
        /// <param name="instancia">
        /// 1º ou 2º grau.<br/>
        /// Example: PRIMEIRO_GRAU
        /// </param>
        /// <param name="juizoDigital">
        /// Se o processo estiver tramitando pelo rito do Juízo 100% digital , indicar (sim) ou (não)<br/>
        /// Example: S
        /// </param>
        /// <param name="linksDocumentos">
        /// Links dos inteiro teor<br/>
        /// Example: [https://pje1g.tjrn.jus.br/pje/Processo/ConsultaDocumento/listView.seam?x=21071916330504400000067586444]
        /// </param>
        /// <param name="meioEnvio">
        /// Meio de envio da comunicação<br/>
        /// Example: DOMICILIO_ELETRONICO
        /// </param>
        /// <param name="nomeDestinatario">
        /// Nome do destinatário da comunicação<br/>
        /// Example: José da Silva Santos
        /// </param>
        /// <param name="numeroComunicacao">
        /// Número identificador da comunicação<br/>
        /// Example: 0800854512021820512320220001
        /// </param>
        /// <param name="numeroProcesso">
        /// Número identificador do processo<br/>
        /// Example: 08008545120218205123
        /// </param>
        /// <param name="parteInteressada">
        /// A parte interessada conforme destinatario.<br/>
        /// Example: REU
        /// </param>
        /// <param name="prazo">
        /// Data limite para cumprimento da intimação<br/>
        /// Example: 20
        /// </param>
        /// <param name="segredoJustica">
        /// Se o processo estiver tramitando em segredo de justiça, indicar (sim) ou (não)<br/>
        /// Example: false
        /// </param>
        /// <param name="servidor">
        /// Dados do servidor
        /// </param>
        /// <param name="sistemaProcesso">
        /// Sistema de processo utilizado<br/>
        /// Example: Pje
        /// </param>
        /// <param name="status">
        /// Status da comunicação.<br/>
        /// Example: EM_CURSO
        /// </param>
        /// <param name="tipoComunicacao">
        /// Tipo de comunicação (Citação, Intimação, Notificação, Vista ou Ipta)<br/>
        /// Example: INTIMACAO
        /// </param>
        /// <param name="tipoPrazo">
        /// Tipo de prazo<br/>
        /// Example: DIAS
        /// </param>
        /// <param name="tutelaUrgencia">
        /// Tutelar de urgência<br/>
        /// Example: S
        /// </param>
        /// <param name="uf">
        /// Estado de referência para o processo<br/>
        /// Example: RN
        /// </param>
        /// <param name="urgente">
        /// Urgente<br/>
        /// Example: S
        /// </param>
        /// <param name="valorCausa">
        /// Valor da causa indicado na inicial<br/>
        /// Example: 999999999998,97 (formato: ############,##)
        /// </param>
        /// <param name="assuntoComunicacao">
        /// Assunto da comunicaÃ§Ã£o (snapshot do assunto vigente no momento do envio).<br/>
        /// Example: EmprÃ©stimo consignado
        /// </param>
        /// <param name="atualizadoEm">
        /// Timestamp do ultimo momento que o registro foi atualizado<br/>
        /// Example: 2022-06-08T21:48:12.521084Z
        /// </param>
        /// <param name="atualizadoPor">
        /// Identificação de ultimo que atualizou o registro<br/>
        /// Example: usuario_xpto
        /// </param>
        /// <param name="audiencia">
        /// Audiencia
        /// </param>
        /// <param name="autoresReclamantes">
        /// Dados dos autores
        /// </param>
        /// <param name="codigoClasseProcessual">
        /// Codigo da classe processual
        /// </param>
        /// <param name="codigoOrgaoJulgadorCorporativo">
        /// Este codigo corresponde a identificação nacional do orgão julgador
        /// </param>
        /// <param name="dataCerta">
        /// Data certa da comunicação, usa padrão ISO8601<br/>
        /// Example: 2024-01-04
        /// </param>
        /// <param name="dataCiente">
        /// Data da que foi executada a ciência da comuniacao<br/>
        /// Example: 2022-06-08T23:00:00Z
        /// </param>
        /// <param name="dataFimSessaoJulgamento">
        /// Data de fim da sessao de julgamento<br/>
        /// Example: 2025-05-01
        /// </param>
        /// <param name="dataInicioSessaoJulgamento">
        /// Data de início da sessao de julgamento<br/>
        /// Example: 2025-05-01
        /// </param>
        /// <param name="ehComunicacaoPessoal">
        /// Indica se é ou não comunicação pessoal
        /// </param>
        /// <param name="formatoSessaojulgamento">
        /// Formato da Sessão do Julgamento<br/>
        /// Example: P
        /// </param>
        /// <param name="horaFimSessaoJulgamento">
        /// Hora de fim da sessao de julgamento<br/>
        /// Example: 12:00
        /// </param>
        /// <param name="horaInicioSessaoJulgamento">
        /// Hora de início da sessao de julgamento<br/>
        /// Example: 10:00
        /// </param>
        /// <param name="idAviso">
        /// Id Aviso da comunicacao
        /// </param>
        /// <param name="idMovimento">
        /// Id Movimento da comunicacao
        /// </param>
        /// <param name="leitoresAutorizados">
        /// Leitores Autorizados<br/>
        /// Example: [Maria de Fátima Ferreira, Roberta Miranda de Jesus]
        /// </param>
        /// <param name="linksDocumentosAdicionais">
        /// Lista contendo links dos documentos adicionais dos inteiro teor.<br/>
        /// Example: [https://xpto-um.gov.br/arquivo-complementar-1.pdf, https://xpto-dois.gov.br/arquivo-complementar-2.xml]
        /// </param>
        /// <param name="localSessaoJulgamento">
        /// Local da sessão de julgamento<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </param>
        /// <param name="magistrado">
        /// Nome do juiz responsável pelo processo<br/>
        /// Example: José da Silva Moreira
        /// </param>
        /// <param name="motivoIntimacao">
        /// Descrição do motivo da intimação que será enviado pelo tribunal/STJ.
        /// </param>
        /// <param name="nivelSigilo">
        /// Nível de sigilo do processo<br/>
        /// Example: 0
        /// </param>
        /// <param name="nomeUsuarioCiente">
        /// Nome do usuario do cliente que realizou a ciencia<br/>
        /// Example: Martin Bernardo Vicente Oliveira.
        /// </param>
        /// <param name="numeroProcessoAntigo">
        /// Número identificador do processo no formato antigo<br/>
        /// Example: [08238799320198230010]
        /// </param>
        /// <param name="numeroProcessoRelacionado">
        /// Número do processo relacionado<br/>
        /// Example: [08238799320198230010]
        /// </param>
        /// <param name="orgaoLegal">
        /// Jurisdição (JEC, Vara Cível, CEJUSC, Vara Trabalhista)<br/>
        /// Example: JUIZADO ESPECIAL CÍVEL
        /// </param>
        /// <param name="peticao">
        /// Informação a respeito de petição
        /// </param>
        /// <param name="representantes">
        /// Dado dos representantes
        /// </param>
        /// <param name="reus">
        /// Dados da empresa reclamada
        /// </param>
        /// <param name="tipoAcao">
        /// Individual ou coletiva<br/>
        /// Example: INDIVIDUAL
        /// </param>
        /// <param name="tipoIntimacao">
        /// Liminar, obrigação de fazer, sentença, acórdão, trânsito em julgado, Ofício, Intimação de Pauta, Decisão, Despacho e Outros<br/>
        /// Example: LIMINAR
        /// </param>
        /// <param name="tipoSessaojulgamento">
        /// Tipo da Sessão do Julgamento<br/>
        /// Example: O
        /// </param>
        /// <param name="tribunalOrigem">
        /// Tribunal de origem<br/>
        /// Example: Tribunal de Justiça do Estado do Rio Grande do Norte
        /// </param>
        /// <param name="usuarioCiente">
        /// Usuario do cliente que realizou a ciencia.<br/>
        /// Example: martin.bernardo
        /// </param>
        /// <param name="varaJudicial">
        /// Lotação do processo<br/>
        /// Example: Juizado Especial Cível, Criminal e da Fazenda Pública da Comarca de Parelhas
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComunicacaoProcessualViewModel(
            string assunto,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelCienciaAutomatica cienciaAutomatica,
            bool ciente,
            string classe,
            string criadoEm,
            string criadoPor,
            string dataAjuizamento,
            string dataComunicacao,
            string dataFinalCiencia,
            string documentoDestinatario,
            bool emCurso,
            bool foiCienciaAutomatica,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelInstancia instancia,
            string juizoDigital,
            global::System.Collections.Generic.IList<string> linksDocumentos,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelMeioEnvio meioEnvio,
            string nomeDestinatario,
            string numeroComunicacao,
            string numeroProcesso,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelParteInteressada parteInteressada,
            int prazo,
            bool segredoJustica,
            global::Softplan.Soft.Suite.Dje.Sdk.ServidorViewModel servidor,
            string sistemaProcesso,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelStatus status,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoComunicacao tipoComunicacao,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoPrazo tipoPrazo,
            string tutelaUrgencia,
            string uf,
            string urgente,
            string valorCausa,
            string? assuntoComunicacao,
            string? atualizadoEm,
            string? atualizadoPor,
            global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModel? audiencia,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>? autoresReclamantes,
            string? codigoClasseProcessual,
            string? codigoOrgaoJulgadorCorporativo,
            string? dataCerta,
            string? dataCiente,
            string? dataFimSessaoJulgamento,
            string? dataInicioSessaoJulgamento,
            bool? ehComunicacaoPessoal,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelFormatoSessaojulgamento? formatoSessaojulgamento,
            string? horaFimSessaoJulgamento,
            string? horaInicioSessaoJulgamento,
            string? idAviso,
            string? idMovimento,
            global::System.Collections.Generic.IList<string>? leitoresAutorizados,
            global::System.Collections.Generic.IList<string>? linksDocumentosAdicionais,
            string? localSessaoJulgamento,
            string? magistrado,
            string? motivoIntimacao,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelNivelSigilo? nivelSigilo,
            string? nomeUsuarioCiente,
            global::System.Collections.Generic.IList<string>? numeroProcessoAntigo,
            global::System.Collections.Generic.IList<string>? numeroProcessoRelacionado,
            string? orgaoLegal,
            global::Softplan.Soft.Suite.Dje.Sdk.PeticaoViewModel? peticao,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteViewModel>? representantes,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PessoaViewModel>? reus,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoAcao? tipoAcao,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoIntimacao? tipoIntimacao,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualViewModelTipoSessaojulgamento? tipoSessaojulgamento,
            string? tribunalOrigem,
            string? usuarioCiente,
            string? varaJudicial)
        {
            this.Assunto = assunto ?? throw new global::System.ArgumentNullException(nameof(assunto));
            this.AssuntoComunicacao = assuntoComunicacao;
            this.AtualizadoEm = atualizadoEm;
            this.AtualizadoPor = atualizadoPor;
            this.Audiencia = audiencia;
            this.AutoresReclamantes = autoresReclamantes;
            this.CienciaAutomatica = cienciaAutomatica;
            this.Ciente = ciente;
            this.Classe = classe ?? throw new global::System.ArgumentNullException(nameof(classe));
            this.CodigoClasseProcessual = codigoClasseProcessual;
            this.CodigoOrgaoJulgadorCorporativo = codigoOrgaoJulgadorCorporativo;
            this.CriadoEm = criadoEm ?? throw new global::System.ArgumentNullException(nameof(criadoEm));
            this.CriadoPor = criadoPor ?? throw new global::System.ArgumentNullException(nameof(criadoPor));
            this.DataAjuizamento = dataAjuizamento ?? throw new global::System.ArgumentNullException(nameof(dataAjuizamento));
            this.DataCerta = dataCerta;
            this.DataCiente = dataCiente;
            this.DataComunicacao = dataComunicacao ?? throw new global::System.ArgumentNullException(nameof(dataComunicacao));
            this.DataFimSessaoJulgamento = dataFimSessaoJulgamento;
            this.DataFinalCiencia = dataFinalCiencia ?? throw new global::System.ArgumentNullException(nameof(dataFinalCiencia));
            this.DataInicioSessaoJulgamento = dataInicioSessaoJulgamento;
            this.DocumentoDestinatario = documentoDestinatario ?? throw new global::System.ArgumentNullException(nameof(documentoDestinatario));
            this.EhComunicacaoPessoal = ehComunicacaoPessoal;
            this.EmCurso = emCurso;
            this.FoiCienciaAutomatica = foiCienciaAutomatica;
            this.FormatoSessaojulgamento = formatoSessaojulgamento;
            this.HoraFimSessaoJulgamento = horaFimSessaoJulgamento;
            this.HoraInicioSessaoJulgamento = horaInicioSessaoJulgamento;
            this.IdAviso = idAviso;
            this.IdMovimento = idMovimento;
            this.Instancia = instancia;
            this.JuizoDigital = juizoDigital ?? throw new global::System.ArgumentNullException(nameof(juizoDigital));
            this.LeitoresAutorizados = leitoresAutorizados;
            this.LinksDocumentos = linksDocumentos ?? throw new global::System.ArgumentNullException(nameof(linksDocumentos));
            this.LinksDocumentosAdicionais = linksDocumentosAdicionais;
            this.LocalSessaoJulgamento = localSessaoJulgamento;
            this.Magistrado = magistrado;
            this.MeioEnvio = meioEnvio;
            this.MotivoIntimacao = motivoIntimacao;
            this.NivelSigilo = nivelSigilo;
            this.NomeDestinatario = nomeDestinatario ?? throw new global::System.ArgumentNullException(nameof(nomeDestinatario));
            this.NomeUsuarioCiente = nomeUsuarioCiente;
            this.NumeroComunicacao = numeroComunicacao ?? throw new global::System.ArgumentNullException(nameof(numeroComunicacao));
            this.NumeroProcesso = numeroProcesso ?? throw new global::System.ArgumentNullException(nameof(numeroProcesso));
            this.NumeroProcessoAntigo = numeroProcessoAntigo;
            this.NumeroProcessoRelacionado = numeroProcessoRelacionado;
            this.OrgaoLegal = orgaoLegal;
            this.ParteInteressada = parteInteressada;
            this.Peticao = peticao;
            this.Prazo = prazo;
            this.Representantes = representantes;
            this.Reus = reus;
            this.SegredoJustica = segredoJustica;
            this.Servidor = servidor ?? throw new global::System.ArgumentNullException(nameof(servidor));
            this.SistemaProcesso = sistemaProcesso ?? throw new global::System.ArgumentNullException(nameof(sistemaProcesso));
            this.Status = status;
            this.TipoAcao = tipoAcao;
            this.TipoComunicacao = tipoComunicacao;
            this.TipoIntimacao = tipoIntimacao;
            this.TipoPrazo = tipoPrazo;
            this.TipoSessaojulgamento = tipoSessaojulgamento;
            this.TribunalOrigem = tribunalOrigem;
            this.TutelaUrgencia = tutelaUrgencia ?? throw new global::System.ArgumentNullException(nameof(tutelaUrgencia));
            this.Uf = uf ?? throw new global::System.ArgumentNullException(nameof(uf));
            this.Urgente = urgente ?? throw new global::System.ArgumentNullException(nameof(urgente));
            this.UsuarioCiente = usuarioCiente;
            this.ValorCausa = valorCausa ?? throw new global::System.ArgumentNullException(nameof(valorCausa));
            this.VaraJudicial = varaJudicial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComunicacaoProcessualViewModel" /> class.
        /// </summary>
        public ComunicacaoProcessualViewModel()
        {
        }

    }
}