
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Example: C
    /// </summary>
    public enum ListarComunicacaoTipoComunicacao
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListarComunicacaoTipoComunicacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListarComunicacaoTipoComunicacao value)
        {
            return value switch
            {
                ListarComunicacaoTipoComunicacao.C => "C",
                ListarComunicacaoTipoComunicacao.I => "I",
                ListarComunicacaoTipoComunicacao.N => "N",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListarComunicacaoTipoComunicacao? ToEnum(string value)
        {
            return value switch
            {
                "C" => ListarComunicacaoTipoComunicacao.C,
                "I" => ListarComunicacaoTipoComunicacao.I,
                "N" => ListarComunicacaoTipoComunicacao.N,
                _ => null,
            };
        }
    }
}