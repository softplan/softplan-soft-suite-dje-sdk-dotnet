
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EmpresaPrivadaTipoPessoa
    {
        /// <summary>
        ///
        /// </summary>
        Fisica,
        /// <summary>
        ///
        /// </summary>
        Juridica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmpresaPrivadaTipoPessoaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmpresaPrivadaTipoPessoa value)
        {
            return value switch
            {
                EmpresaPrivadaTipoPessoa.Fisica => "FISICA",
                EmpresaPrivadaTipoPessoa.Juridica => "JURIDICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmpresaPrivadaTipoPessoa? ToEnum(string value)
        {
            return value switch
            {
                "FISICA" => EmpresaPrivadaTipoPessoa.Fisica,
                "JURIDICA" => EmpresaPrivadaTipoPessoa.Juridica,
                _ => null,
            };
        }
    }
}