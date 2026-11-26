
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Inicial, UNA, Instrução, Julgamento
    /// </summary>
    public enum AudienciaViewModelTipo
    {
        /// <summary>
        ///
        /// </summary>
        Inicial,
        /// <summary>
        ///
        /// </summary>
        Instrucao,
        /// <summary>
        ///
        /// </summary>
        Julgamento,
        /// <summary>
        ///
        /// </summary>
        Justificacao,
        /// <summary>
        ///
        /// </summary>
        Una,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudienciaViewModelTipoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudienciaViewModelTipo value)
        {
            return value switch
            {
                AudienciaViewModelTipo.Inicial => "INICIAL",
                AudienciaViewModelTipo.Instrucao => "INSTRUCAO",
                AudienciaViewModelTipo.Julgamento => "JULGAMENTO",
                AudienciaViewModelTipo.Justificacao => "JUSTIFICACAO",
                AudienciaViewModelTipo.Una => "UNA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudienciaViewModelTipo? ToEnum(string value)
        {
            return value switch
            {
                "INICIAL" => AudienciaViewModelTipo.Inicial,
                "INSTRUCAO" => AudienciaViewModelTipo.Instrucao,
                "JULGAMENTO" => AudienciaViewModelTipo.Julgamento,
                "JUSTIFICACAO" => AudienciaViewModelTipo.Justificacao,
                "UNA" => AudienciaViewModelTipo.Una,
                _ => null,
            };
        }
    }
}