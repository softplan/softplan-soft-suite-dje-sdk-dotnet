
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: A
    /// </summary>
    public enum ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual
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
    public static class ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual value)
        {
            return value switch
            {
                ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.A => "A",
                ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.D => "D",
                ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.G => "G",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? ToEnum(string value)
        {
            return value switch
            {
                "A" => ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.A,
                "D" => ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.D,
                "G" => ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual.G,
                _ => null,
            };
        }
    }
}