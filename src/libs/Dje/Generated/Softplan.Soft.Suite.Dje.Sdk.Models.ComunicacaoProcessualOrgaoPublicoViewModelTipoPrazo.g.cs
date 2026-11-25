
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de prazo<br/>
    /// Example: DIAS
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Anos => "ANOS",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Dias => "DIAS",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Horas => "HORAS",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Meses => "MESES",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.SemPrazo => "SEM_PRAZO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo? ToEnum(string value)
        {
            return value switch
            {
                "ANOS" => ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Anos,
                "DIAS" => ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Dias,
                "HORAS" => ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Horas,
                "MESES" => ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.Meses,
                "SEM_PRAZO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo.SemPrazo,
                _ => null,
            };
        }
    }
}