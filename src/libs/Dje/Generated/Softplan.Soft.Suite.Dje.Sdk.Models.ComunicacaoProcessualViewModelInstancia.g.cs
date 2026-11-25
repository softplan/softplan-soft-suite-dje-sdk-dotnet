
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// 1º ou 2º grau.<br/>
    /// Example: PRIMEIRO_GRAU
    /// </summary>
    public enum ComunicacaoProcessualViewModelInstancia
    {
        /// <summary>
        ///
        /// </summary>
        PrimeiroGrau,
        /// <summary>
        ///
        /// </summary>
        SegundoGrau,
        /// <summary>
        ///
        /// </summary>
        TerceiroGrau,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelInstanciaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelInstancia value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelInstancia.PrimeiroGrau => "PRIMEIRO_GRAU",
                ComunicacaoProcessualViewModelInstancia.SegundoGrau => "SEGUNDO_GRAU",
                ComunicacaoProcessualViewModelInstancia.TerceiroGrau => "TERCEIRO_GRAU",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelInstancia? ToEnum(string value)
        {
            return value switch
            {
                "PRIMEIRO_GRAU" => ComunicacaoProcessualViewModelInstancia.PrimeiroGrau,
                "SEGUNDO_GRAU" => ComunicacaoProcessualViewModelInstancia.SegundoGrau,
                "TERCEIRO_GRAU" => ComunicacaoProcessualViewModelInstancia.TerceiroGrau,
                _ => null,
            };
        }
    }
}