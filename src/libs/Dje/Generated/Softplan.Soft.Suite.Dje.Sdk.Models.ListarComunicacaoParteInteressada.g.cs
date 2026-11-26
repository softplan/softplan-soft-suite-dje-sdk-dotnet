
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: 2
    /// </summary>
    public enum ListarComunicacaoParteInteressada
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
    public static class ListarComunicacaoParteInteressadaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListarComunicacaoParteInteressada value)
        {
            return value switch
            {
                ListarComunicacaoParteInteressada.x1 => "1",
                ListarComunicacaoParteInteressada.x2 => "2",
                ListarComunicacaoParteInteressada.x3 => "3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListarComunicacaoParteInteressada? ToEnum(string value)
        {
            return value switch
            {
                "1" => ListarComunicacaoParteInteressada.x1,
                "2" => ListarComunicacaoParteInteressada.x2,
                "3" => ListarComunicacaoParteInteressada.x3,
                _ => null,
            };
        }
    }
}