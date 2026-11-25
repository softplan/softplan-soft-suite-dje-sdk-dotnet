
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Status da comunicação.<br/>
    /// Example: EM_CURSO
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelStatus
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelStatus value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelStatus.Cancelada => "CANCELADA",
                ComunicacaoProcessualOrgaoPublicoViewModelStatus.CienciaAutomatica => "CIENCIA_AUTOMATICA",
                ComunicacaoProcessualOrgaoPublicoViewModelStatus.Ciente => "CIENTE",
                ComunicacaoProcessualOrgaoPublicoViewModelStatus.EmCurso => "EM_CURSO",
                ComunicacaoProcessualOrgaoPublicoViewModelStatus.InteiroTeorObtido => "INTEIRO_TEOR_OBTIDO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELADA" => ComunicacaoProcessualOrgaoPublicoViewModelStatus.Cancelada,
                "CIENCIA_AUTOMATICA" => ComunicacaoProcessualOrgaoPublicoViewModelStatus.CienciaAutomatica,
                "CIENTE" => ComunicacaoProcessualOrgaoPublicoViewModelStatus.Ciente,
                "EM_CURSO" => ComunicacaoProcessualOrgaoPublicoViewModelStatus.EmCurso,
                "INTEIRO_TEOR_OBTIDO" => ComunicacaoProcessualOrgaoPublicoViewModelStatus.InteiroTeorObtido,
                _ => null,
            };
        }
    }
}