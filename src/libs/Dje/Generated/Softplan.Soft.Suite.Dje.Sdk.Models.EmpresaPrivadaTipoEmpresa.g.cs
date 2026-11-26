
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EmpresaPrivadaTipoEmpresa
    {
        /// <summary>
        ///
        /// </summary>
        Coligada,
        /// <summary>
        ///
        /// </summary>
        Filial,
        /// <summary>
        ///
        /// </summary>
        Incorporada,
        /// <summary>
        ///
        /// </summary>
        Matriz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmpresaPrivadaTipoEmpresaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmpresaPrivadaTipoEmpresa value)
        {
            return value switch
            {
                EmpresaPrivadaTipoEmpresa.Coligada => "COLIGADA",
                EmpresaPrivadaTipoEmpresa.Filial => "FILIAL",
                EmpresaPrivadaTipoEmpresa.Incorporada => "INCORPORADA",
                EmpresaPrivadaTipoEmpresa.Matriz => "MATRIZ",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmpresaPrivadaTipoEmpresa? ToEnum(string value)
        {
            return value switch
            {
                "COLIGADA" => EmpresaPrivadaTipoEmpresa.Coligada,
                "FILIAL" => EmpresaPrivadaTipoEmpresa.Filial,
                "INCORPORADA" => EmpresaPrivadaTipoEmpresa.Incorporada,
                "MATRIZ" => EmpresaPrivadaTipoEmpresa.Matriz,
                _ => null,
            };
        }
    }
}