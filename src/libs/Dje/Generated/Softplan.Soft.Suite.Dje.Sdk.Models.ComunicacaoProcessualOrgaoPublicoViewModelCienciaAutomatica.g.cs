
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se houve ciência automática<br/>
    /// Example: S
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomaticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica.N => "N",
                ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica.S => "S",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica? ToEnum(string value)
        {
            return value switch
            {
                "N" => ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica.N,
                "S" => ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica.S,
                _ => null,
            };
        }
    }
}