
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EmpresaPrivadaPorte
    {
        /// <summary>
        ///
        /// </summary>
        Demais,
        /// <summary>
        ///
        /// </summary>
        Epp,
        /// <summary>
        ///
        /// </summary>
        Me,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmpresaPrivadaPorteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmpresaPrivadaPorte value)
        {
            return value switch
            {
                EmpresaPrivadaPorte.Demais => "DEMAIS",
                EmpresaPrivadaPorte.Epp => "EPP",
                EmpresaPrivadaPorte.Me => "ME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmpresaPrivadaPorte? ToEnum(string value)
        {
            return value switch
            {
                "DEMAIS" => EmpresaPrivadaPorte.Demais,
                "EPP" => EmpresaPrivadaPorte.Epp,
                "ME" => EmpresaPrivadaPorte.Me,
                _ => null,
            };
        }
    }
}