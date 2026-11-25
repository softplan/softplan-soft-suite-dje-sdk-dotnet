
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ListarComunicacaoModalidadeComunicacaoProcessual
    {
        /// <summary>
        ///
        /// </summary>
        A,
        /// <summary>
        ///
        /// </summary>
        D,
        /// <summary>
        ///
        /// </summary>
        G,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListarComunicacaoModalidadeComunicacaoProcessualExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListarComunicacaoModalidadeComunicacaoProcessual value)
        {
            return value switch
            {
                ListarComunicacaoModalidadeComunicacaoProcessual.A => "A",
                ListarComunicacaoModalidadeComunicacaoProcessual.D => "D",
                ListarComunicacaoModalidadeComunicacaoProcessual.G => "G",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListarComunicacaoModalidadeComunicacaoProcessual? ToEnum(string value)
        {
            return value switch
            {
                "A" => ListarComunicacaoModalidadeComunicacaoProcessual.A,
                "D" => ListarComunicacaoModalidadeComunicacaoProcessual.D,
                "G" => ListarComunicacaoModalidadeComunicacaoProcessual.G,
                _ => null,
            };
        }
    }
}