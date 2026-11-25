
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Formato da Sessão do Julgamento<br/>
    /// Example: P
    /// </summary>
    public enum ComunicacaoProcessualViewModelFormatoSessaojulgamento
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
    public static class ComunicacaoProcessualViewModelFormatoSessaojulgamentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelFormatoSessaojulgamento value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelFormatoSessaojulgamento.HHíbrida => "H - Híbrida",
                ComunicacaoProcessualViewModelFormatoSessaojulgamento.PPresencial => "P - Presencial",
                ComunicacaoProcessualViewModelFormatoSessaojulgamento.VVirtual => "V - Virtual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelFormatoSessaojulgamento? ToEnum(string value)
        {
            return value switch
            {
                "H - Híbrida" => ComunicacaoProcessualViewModelFormatoSessaojulgamento.HHíbrida,
                "P - Presencial" => ComunicacaoProcessualViewModelFormatoSessaojulgamento.PPresencial,
                "V - Virtual" => ComunicacaoProcessualViewModelFormatoSessaojulgamento.VVirtual,
                _ => null,
            };
        }
    }
}