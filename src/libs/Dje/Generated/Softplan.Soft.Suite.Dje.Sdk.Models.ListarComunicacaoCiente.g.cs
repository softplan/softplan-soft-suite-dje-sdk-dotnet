
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ListarComunicacaoCiente
    {
        /// <summary>
        ///
        /// </summary>
        A,
        /// <summary>
        ///
        /// </summary>
        L,
        /// <summary>
        ///
        /// </summary>
        N,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListarComunicacaoCienteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListarComunicacaoCiente value)
        {
            return value switch
            {
                ListarComunicacaoCiente.A => "A",
                ListarComunicacaoCiente.L => "L",
                ListarComunicacaoCiente.N => "N",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListarComunicacaoCiente? ToEnum(string value)
        {
            return value switch
            {
                "A" => ListarComunicacaoCiente.A,
                "L" => ListarComunicacaoCiente.L,
                "N" => ListarComunicacaoCiente.N,
                _ => null,
            };
        }
    }
}