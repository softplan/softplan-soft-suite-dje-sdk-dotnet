
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Status da comunicação.<br/>
    /// Example: EM_CURSO
    /// </summary>
    public enum ComunicacaoProcessualViewModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelada,
        /// <summary>
        ///
        /// </summary>
        CienciaAutomatica,
        /// <summary>
        ///
        /// </summary>
        Ciente,
        /// <summary>
        ///
        /// </summary>
        EmCurso,
        /// <summary>
        ///
        /// </summary>
        InteiroTeorObtido,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelStatus value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelStatus.Cancelada => "CANCELADA",
                ComunicacaoProcessualViewModelStatus.CienciaAutomatica => "CIENCIA_AUTOMATICA",
                ComunicacaoProcessualViewModelStatus.Ciente => "CIENTE",
                ComunicacaoProcessualViewModelStatus.EmCurso => "EM_CURSO",
                ComunicacaoProcessualViewModelStatus.InteiroTeorObtido => "INTEIRO_TEOR_OBTIDO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELADA" => ComunicacaoProcessualViewModelStatus.Cancelada,
                "CIENCIA_AUTOMATICA" => ComunicacaoProcessualViewModelStatus.CienciaAutomatica,
                "CIENTE" => ComunicacaoProcessualViewModelStatus.Ciente,
                "EM_CURSO" => ComunicacaoProcessualViewModelStatus.EmCurso,
                "INTEIRO_TEOR_OBTIDO" => ComunicacaoProcessualViewModelStatus.InteiroTeorObtido,
                _ => null,
            };
        }
    }
}