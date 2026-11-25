
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: 2
    /// </summary>
    public enum ObterComunicacoesParteInteressada
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
    public static class ObterComunicacoesParteInteressadaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesParteInteressada value)
        {
            return value switch
            {
                ObterComunicacoesParteInteressada.x1 => "1",
                ObterComunicacoesParteInteressada.x2 => "2",
                ObterComunicacoesParteInteressada.x3 => "3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesParteInteressada? ToEnum(string value)
        {
            return value switch
            {
                "1" => ObterComunicacoesParteInteressada.x1,
                "2" => ObterComunicacoesParteInteressada.x2,
                "3" => ObterComunicacoesParteInteressada.x3,
                _ => null,
            };
        }
    }
}