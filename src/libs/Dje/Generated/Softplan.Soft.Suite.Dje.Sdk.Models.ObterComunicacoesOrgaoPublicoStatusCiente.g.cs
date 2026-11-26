
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ObterComunicacoesOrgaoPublicoStatusCiente
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
    public static class ObterComunicacoesOrgaoPublicoStatusCienteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesOrgaoPublicoStatusCiente value)
        {
            return value switch
            {
                ObterComunicacoesOrgaoPublicoStatusCiente.A => "A",
                ObterComunicacoesOrgaoPublicoStatusCiente.L => "L",
                ObterComunicacoesOrgaoPublicoStatusCiente.N => "N",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesOrgaoPublicoStatusCiente? ToEnum(string value)
        {
            return value switch
            {
                "A" => ObterComunicacoesOrgaoPublicoStatusCiente.A,
                "L" => ObterComunicacoesOrgaoPublicoStatusCiente.L,
                "N" => ObterComunicacoesOrgaoPublicoStatusCiente.N,
                _ => null,
            };
        }
    }
}