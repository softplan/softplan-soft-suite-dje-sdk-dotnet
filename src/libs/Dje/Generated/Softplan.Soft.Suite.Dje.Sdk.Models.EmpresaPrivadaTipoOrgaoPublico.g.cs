
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EmpresaPrivadaTipoOrgaoPublico
    {
        /// <summary>
        ///
        /// </summary>
        Defensoria,
        /// <summary>
        ///
        /// </summary>
        Outros,
        /// <summary>
        ///
        /// </summary>
        Procuradoria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmpresaPrivadaTipoOrgaoPublicoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmpresaPrivadaTipoOrgaoPublico value)
        {
            return value switch
            {
                EmpresaPrivadaTipoOrgaoPublico.Defensoria => "DEFENSORIA",
                EmpresaPrivadaTipoOrgaoPublico.Outros => "OUTROS",
                EmpresaPrivadaTipoOrgaoPublico.Procuradoria => "PROCURADORIA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmpresaPrivadaTipoOrgaoPublico? ToEnum(string value)
        {
            return value switch
            {
                "DEFENSORIA" => EmpresaPrivadaTipoOrgaoPublico.Defensoria,
                "OUTROS" => EmpresaPrivadaTipoOrgaoPublico.Outros,
                "PROCURADORIA" => EmpresaPrivadaTipoOrgaoPublico.Procuradoria,
                _ => null,
            };
        }
    }
}