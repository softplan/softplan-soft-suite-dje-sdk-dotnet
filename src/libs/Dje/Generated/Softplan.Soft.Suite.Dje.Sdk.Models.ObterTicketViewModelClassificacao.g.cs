
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// A classificação do ticket<br/>
    /// Example: OUTROS
    /// </summary>
    public enum ObterTicketViewModelClassificacao
    {
        /// <summary>
        ///
        /// </summary>
        InteiroTeorComInformacaoIncompleta,
        /// <summary>
        ///
        /// </summary>
        InteiroTeorDistintoDoProcessoComunicacao,
        /// <summary>
        ///
        /// </summary>
        InteiroTeorEmBranco,
        /// <summary>
        ///
        /// </summary>
        InteiroTeorIndisponivel,
        /// <summary>
        ///
        /// </summary>
        Outros,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterTicketViewModelClassificacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterTicketViewModelClassificacao value)
        {
            return value switch
            {
                ObterTicketViewModelClassificacao.InteiroTeorComInformacaoIncompleta => "INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA",
                ObterTicketViewModelClassificacao.InteiroTeorDistintoDoProcessoComunicacao => "INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO",
                ObterTicketViewModelClassificacao.InteiroTeorEmBranco => "INTEIRO_TEOR_EM_BRANCO",
                ObterTicketViewModelClassificacao.InteiroTeorIndisponivel => "INTEIRO_TEOR_INDISPONIVEL",
                ObterTicketViewModelClassificacao.Outros => "OUTROS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterTicketViewModelClassificacao? ToEnum(string value)
        {
            return value switch
            {
                "INTEIRO_TEOR_COM_INFORMACAO_INCOMPLETA" => ObterTicketViewModelClassificacao.InteiroTeorComInformacaoIncompleta,
                "INTEIRO_TEOR_DISTINTO_DO_PROCESSO_COMUNICACAO" => ObterTicketViewModelClassificacao.InteiroTeorDistintoDoProcessoComunicacao,
                "INTEIRO_TEOR_EM_BRANCO" => ObterTicketViewModelClassificacao.InteiroTeorEmBranco,
                "INTEIRO_TEOR_INDISPONIVEL" => ObterTicketViewModelClassificacao.InteiroTeorIndisponivel,
                "OUTROS" => ObterTicketViewModelClassificacao.Outros,
                _ => null,
            };
        }
    }
}