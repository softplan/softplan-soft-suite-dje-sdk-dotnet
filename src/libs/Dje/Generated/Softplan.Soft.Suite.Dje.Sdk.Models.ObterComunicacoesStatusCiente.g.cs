
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ObterComunicacoesStatusCiente
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
    public static class ObterComunicacoesStatusCienteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesStatusCiente value)
        {
            return value switch
            {
                ObterComunicacoesStatusCiente.A => "A",
                ObterComunicacoesStatusCiente.L => "L",
                ObterComunicacoesStatusCiente.N => "N",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesStatusCiente? ToEnum(string value)
        {
            return value switch
            {
                "A" => ObterComunicacoesStatusCiente.A,
                "L" => ObterComunicacoesStatusCiente.L,
                "N" => ObterComunicacoesStatusCiente.N,
                _ => null,
            };
        }
    }
}