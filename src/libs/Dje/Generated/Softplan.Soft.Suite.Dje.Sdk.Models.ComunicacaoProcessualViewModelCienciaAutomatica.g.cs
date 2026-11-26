
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se houve ciência automática<br/>
    /// Example: S
    /// </summary>
    public enum ComunicacaoProcessualViewModelCienciaAutomatica
    {
        /// <summary>
        ///
        /// </summary>
        N,
        /// <summary>
        ///
        /// </summary>
        S,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelCienciaAutomaticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelCienciaAutomatica value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelCienciaAutomatica.N => "N",
                ComunicacaoProcessualViewModelCienciaAutomatica.S => "S",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelCienciaAutomatica? ToEnum(string value)
        {
            return value switch
            {
                "N" => ComunicacaoProcessualViewModelCienciaAutomatica.N,
                "S" => ComunicacaoProcessualViewModelCienciaAutomatica.S,
                _ => null,
            };
        }
    }
}