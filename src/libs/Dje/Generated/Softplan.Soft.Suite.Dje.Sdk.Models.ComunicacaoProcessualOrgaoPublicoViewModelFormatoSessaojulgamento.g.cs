
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Formato da Sessão do Julgamento<br/>
    /// Example: P
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento
    {
        /// <summary>
        ///
        /// </summary>
        HHíbrida,
        /// <summary>
        ///
        /// </summary>
        PPresencial,
        /// <summary>
        ///
        /// </summary>
        VVirtual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.HHíbrida => "H - Híbrida",
                ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.PPresencial => "P - Presencial",
                ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.VVirtual => "V - Virtual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento? ToEnum(string value)
        {
            return value switch
            {
                "H - Híbrida" => ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.HHíbrida,
                "P - Presencial" => ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.PPresencial,
                "V - Virtual" => ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento.VVirtual,
                _ => null,
            };
        }
    }
}