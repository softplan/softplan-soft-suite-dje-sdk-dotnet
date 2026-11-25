
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Individual ou coletiva<br/>
    /// Example: INDIVIDUAL
    /// </summary>
    public enum ComunicacaoProcessualViewModelTipoAcao
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
    public static class ComunicacaoProcessualViewModelTipoAcaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelTipoAcao value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelTipoAcao.Coletiva => "COLETIVA",
                ComunicacaoProcessualViewModelTipoAcao.Individual => "INDIVIDUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelTipoAcao? ToEnum(string value)
        {
            return value switch
            {
                "COLETIVA" => ComunicacaoProcessualViewModelTipoAcao.Coletiva,
                "INDIVIDUAL" => ComunicacaoProcessualViewModelTipoAcao.Individual,
                _ => null,
            };
        }
    }
}