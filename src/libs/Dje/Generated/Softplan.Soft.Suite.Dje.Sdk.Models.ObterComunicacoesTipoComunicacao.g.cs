
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: C
    /// </summary>
    public enum ObterComunicacoesTipoComunicacao
    {
        /// <summary>
        ///
        /// </summary>
        C,
        /// <summary>
        ///
        /// </summary>
        I,
        /// <summary>
        ///
        /// </summary>
        N,
        /// <summary>
        ///
        /// </summary>
        T,
        /// <summary>
        ///
        /// </summary>
        V,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterComunicacoesTipoComunicacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesTipoComunicacao value)
        {
            return value switch
            {
                ObterComunicacoesTipoComunicacao.C => "C",
                ObterComunicacoesTipoComunicacao.I => "I",
                ObterComunicacoesTipoComunicacao.N => "N",
                ObterComunicacoesTipoComunicacao.T => "T",
                ObterComunicacoesTipoComunicacao.V => "V",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesTipoComunicacao? ToEnum(string value)
        {
            return value switch
            {
                "C" => ObterComunicacoesTipoComunicacao.C,
                "I" => ObterComunicacoesTipoComunicacao.I,
                "N" => ObterComunicacoesTipoComunicacao.N,
                "T" => ObterComunicacoesTipoComunicacao.T,
                "V" => ObterComunicacoesTipoComunicacao.V,
                _ => null,
            };
        }
    }
}