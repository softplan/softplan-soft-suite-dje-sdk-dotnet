
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// A classificação do ticket. <br/>
    ///  (1 - INTEIRO_TEOR_EM_BRANCO, 2 - INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA, 3 - INTEIRO_TEOR_INDISPONIVEL, 4 - INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO, 5 - INTEIRO_TEOR_COM_AUTENTICACAO_PREVIA, 6 - OUTROS)<br/>
    /// Example: 5
    /// </summary>
    public enum SolicitarAberturaTicketInputModelClassificacao
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        x2,
        /// <summary>
        ///
        /// </summary>
        x3,
        /// <summary>
        ///
        /// </summary>
        x4,
        /// <summary>
        ///
        /// </summary>
        x5,
        /// <summary>
        ///
        /// </summary>
        x6,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SolicitarAberturaTicketInputModelClassificacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SolicitarAberturaTicketInputModelClassificacao value)
        {
            return value switch
            {
                SolicitarAberturaTicketInputModelClassificacao.x1 => "1",
                SolicitarAberturaTicketInputModelClassificacao.x2 => "2",
                SolicitarAberturaTicketInputModelClassificacao.x3 => "3",
                SolicitarAberturaTicketInputModelClassificacao.x4 => "4",
                SolicitarAberturaTicketInputModelClassificacao.x5 => "5",
                SolicitarAberturaTicketInputModelClassificacao.x6 => "6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SolicitarAberturaTicketInputModelClassificacao? ToEnum(string value)
        {
            return value switch
            {
                "1" => SolicitarAberturaTicketInputModelClassificacao.x1,
                "2" => SolicitarAberturaTicketInputModelClassificacao.x2,
                "3" => SolicitarAberturaTicketInputModelClassificacao.x3,
                "4" => SolicitarAberturaTicketInputModelClassificacao.x4,
                "5" => SolicitarAberturaTicketInputModelClassificacao.x5,
                "6" => SolicitarAberturaTicketInputModelClassificacao.x6,
                _ => null,
            };
        }
    }
}