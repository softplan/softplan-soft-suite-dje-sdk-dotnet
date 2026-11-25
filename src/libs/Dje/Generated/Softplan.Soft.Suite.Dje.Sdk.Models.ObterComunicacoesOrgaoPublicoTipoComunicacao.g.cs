
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: C
    /// </summary>
    public enum ObterComunicacoesOrgaoPublicoTipoComunicacao
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
    public static class ObterComunicacoesOrgaoPublicoTipoComunicacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesOrgaoPublicoTipoComunicacao value)
        {
            return value switch
            {
                ObterComunicacoesOrgaoPublicoTipoComunicacao.C => "C",
                ObterComunicacoesOrgaoPublicoTipoComunicacao.I => "I",
                ObterComunicacoesOrgaoPublicoTipoComunicacao.N => "N",
                ObterComunicacoesOrgaoPublicoTipoComunicacao.T => "T",
                ObterComunicacoesOrgaoPublicoTipoComunicacao.V => "V",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesOrgaoPublicoTipoComunicacao? ToEnum(string value)
        {
            return value switch
            {
                "C" => ObterComunicacoesOrgaoPublicoTipoComunicacao.C,
                "I" => ObterComunicacoesOrgaoPublicoTipoComunicacao.I,
                "N" => ObterComunicacoesOrgaoPublicoTipoComunicacao.N,
                "T" => ObterComunicacoesOrgaoPublicoTipoComunicacao.T,
                "V" => ObterComunicacoesOrgaoPublicoTipoComunicacao.V,
                _ => null,
            };
        }
    }
}