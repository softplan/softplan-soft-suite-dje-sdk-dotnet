
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de prazo<br/>
    /// Example: DIAS
    /// </summary>
    public enum ComunicacaoProcessualViewModelTipoPrazo
    {
        /// <summary>
        ///
        /// </summary>
        Anos,
        /// <summary>
        ///
        /// </summary>
        Dias,
        /// <summary>
        ///
        /// </summary>
        Horas,
        /// <summary>
        ///
        /// </summary>
        Meses,
        /// <summary>
        ///
        /// </summary>
        SemPrazo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelTipoPrazoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelTipoPrazo value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelTipoPrazo.Anos => "ANOS",
                ComunicacaoProcessualViewModelTipoPrazo.Dias => "DIAS",
                ComunicacaoProcessualViewModelTipoPrazo.Horas => "HORAS",
                ComunicacaoProcessualViewModelTipoPrazo.Meses => "MESES",
                ComunicacaoProcessualViewModelTipoPrazo.SemPrazo => "SEM_PRAZO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelTipoPrazo? ToEnum(string value)
        {
            return value switch
            {
                "ANOS" => ComunicacaoProcessualViewModelTipoPrazo.Anos,
                "DIAS" => ComunicacaoProcessualViewModelTipoPrazo.Dias,
                "HORAS" => ComunicacaoProcessualViewModelTipoPrazo.Horas,
                "MESES" => ComunicacaoProcessualViewModelTipoPrazo.Meses,
                "SEM_PRAZO" => ComunicacaoProcessualViewModelTipoPrazo.SemPrazo,
                _ => null,
            };
        }
    }
}