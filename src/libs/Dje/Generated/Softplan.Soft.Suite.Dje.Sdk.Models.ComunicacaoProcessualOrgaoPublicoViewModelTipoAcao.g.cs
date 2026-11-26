
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Individual ou coletiva<br/>
    /// Example: INDIVIDUAL
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao
    {
        /// <summary>
        ///
        /// </summary>
        Coletiva,
        /// <summary>
        ///
        /// </summary>
        Individual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao.Coletiva => "COLETIVA",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao.Individual => "INDIVIDUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao? ToEnum(string value)
        {
            return value switch
            {
                "COLETIVA" => ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao.Coletiva,
                "INDIVIDUAL" => ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao.Individual,
                _ => null,
            };
        }
    }
}