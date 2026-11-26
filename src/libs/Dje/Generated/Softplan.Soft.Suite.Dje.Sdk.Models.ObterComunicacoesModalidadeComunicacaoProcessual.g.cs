
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ObterComunicacoesModalidadeComunicacaoProcessual
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
    public static class ObterComunicacoesModalidadeComunicacaoProcessualExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesModalidadeComunicacaoProcessual value)
        {
            return value switch
            {
                ObterComunicacoesModalidadeComunicacaoProcessual.A => "A",
                ObterComunicacoesModalidadeComunicacaoProcessual.D => "D",
                ObterComunicacoesModalidadeComunicacaoProcessual.G => "G",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesModalidadeComunicacaoProcessual? ToEnum(string value)
        {
            return value switch
            {
                "A" => ObterComunicacoesModalidadeComunicacaoProcessual.A,
                "D" => ObterComunicacoesModalidadeComunicacaoProcessual.D,
                "G" => ObterComunicacoesModalidadeComunicacaoProcessual.G,
                _ => null,
            };
        }
    }
}