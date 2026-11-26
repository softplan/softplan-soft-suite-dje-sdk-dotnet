
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: 2
    /// </summary>
    public enum ObterComunicacoesOrgaoPublicoParteInteressada
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        x2,
        /// <summary>
        ///
        /// </summary>
        x3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterComunicacoesOrgaoPublicoParteInteressadaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesOrgaoPublicoParteInteressada value)
        {
            return value switch
            {
                ObterComunicacoesOrgaoPublicoParteInteressada.x1 => "1",
                ObterComunicacoesOrgaoPublicoParteInteressada.x2 => "2",
                ObterComunicacoesOrgaoPublicoParteInteressada.x3 => "3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesOrgaoPublicoParteInteressada? ToEnum(string value)
        {
            return value switch
            {
                "1" => ObterComunicacoesOrgaoPublicoParteInteressada.x1,
                "2" => ObterComunicacoesOrgaoPublicoParteInteressada.x2,
                "3" => ObterComunicacoesOrgaoPublicoParteInteressada.x3,
                _ => null,
            };
        }
    }
}