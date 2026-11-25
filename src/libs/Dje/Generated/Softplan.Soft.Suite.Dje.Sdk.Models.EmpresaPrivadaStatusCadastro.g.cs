
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EmpresaPrivadaStatusCadastro
    {
        /// <summary>
        ///
        /// </summary>
        Completo,
        /// <summary>
        ///
        /// </summary>
        EmProgresso,
        /// <summary>
        ///
        /// </summary>
        Pendente,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmpresaPrivadaStatusCadastroExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmpresaPrivadaStatusCadastro value)
        {
            return value switch
            {
                EmpresaPrivadaStatusCadastro.Completo => "COMPLETO",
                EmpresaPrivadaStatusCadastro.EmProgresso => "EM_PROGRESSO",
                EmpresaPrivadaStatusCadastro.Pendente => "PENDENTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmpresaPrivadaStatusCadastro? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETO" => EmpresaPrivadaStatusCadastro.Completo,
                "EM_PROGRESSO" => EmpresaPrivadaStatusCadastro.EmProgresso,
                "PENDENTE" => EmpresaPrivadaStatusCadastro.Pendente,
                _ => null,
            };
        }
    }
}