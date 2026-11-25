
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// 1º ou 2º grau.<br/>
    /// Example: PRIMEIRO_GRAU
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelInstancia
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelInstanciaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelInstancia value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelInstancia.PrimeiroGrau => "PRIMEIRO_GRAU",
                ComunicacaoProcessualOrgaoPublicoViewModelInstancia.SegundoGrau => "SEGUNDO_GRAU",
                ComunicacaoProcessualOrgaoPublicoViewModelInstancia.TerceiroGrau => "TERCEIRO_GRAU",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelInstancia? ToEnum(string value)
        {
            return value switch
            {
                "PRIMEIRO_GRAU" => ComunicacaoProcessualOrgaoPublicoViewModelInstancia.PrimeiroGrau,
                "SEGUNDO_GRAU" => ComunicacaoProcessualOrgaoPublicoViewModelInstancia.SegundoGrau,
                "TERCEIRO_GRAU" => ComunicacaoProcessualOrgaoPublicoViewModelInstancia.TerceiroGrau,
                _ => null,
            };
        }
    }
}