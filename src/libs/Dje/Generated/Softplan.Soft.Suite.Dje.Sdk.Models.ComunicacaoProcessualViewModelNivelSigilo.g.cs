
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Nível de sigilo do processo<br/>
    /// Example: 0
    /// </summary>
    public enum ComunicacaoProcessualViewModelNivelSigilo
    {
        /// <summary>
        ///
        /// </summary>
        x0Público,
        /// <summary>
        ///
        /// </summary>
        x1Segredo,
        /// <summary>
        ///
        /// </summary>
        x2SigiloMínimo,
        /// <summary>
        ///
        /// </summary>
        x3SigiloMédio,
        /// <summary>
        ///
        /// </summary>
        x4SigiloIntenso,
        /// <summary>
        ///
        /// </summary>
        x5SigiloAbsoluto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelNivelSigiloExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelNivelSigilo value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelNivelSigilo.x0Público => "0 - Público",
                ComunicacaoProcessualViewModelNivelSigilo.x1Segredo => "1 - Segredo",
                ComunicacaoProcessualViewModelNivelSigilo.x2SigiloMínimo => "2 - Sigilo Mínimo",
                ComunicacaoProcessualViewModelNivelSigilo.x3SigiloMédio => "3 - Sigilo Médio",
                ComunicacaoProcessualViewModelNivelSigilo.x4SigiloIntenso => "4 - Sigilo Intenso",
                ComunicacaoProcessualViewModelNivelSigilo.x5SigiloAbsoluto => "5 - Sigilo Absoluto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelNivelSigilo? ToEnum(string value)
        {
            return value switch
            {
                "0 - Público" => ComunicacaoProcessualViewModelNivelSigilo.x0Público,
                "1 - Segredo" => ComunicacaoProcessualViewModelNivelSigilo.x1Segredo,
                "2 - Sigilo Mínimo" => ComunicacaoProcessualViewModelNivelSigilo.x2SigiloMínimo,
                "3 - Sigilo Médio" => ComunicacaoProcessualViewModelNivelSigilo.x3SigiloMédio,
                "4 - Sigilo Intenso" => ComunicacaoProcessualViewModelNivelSigilo.x4SigiloIntenso,
                "5 - Sigilo Absoluto" => ComunicacaoProcessualViewModelNivelSigilo.x5SigiloAbsoluto,
                _ => null,
            };
        }
    }
}