
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PessoaTipoPessoa
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
    public static class PessoaTipoPessoaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaTipoPessoa value)
        {
            return value switch
            {
                PessoaTipoPessoa.Fisica => "FISICA",
                PessoaTipoPessoa.Juridica => "JURIDICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaTipoPessoa? ToEnum(string value)
        {
            return value switch
            {
                "FISICA" => PessoaTipoPessoa.Fisica,
                "JURIDICA" => PessoaTipoPessoa.Juridica,
                _ => null,
            };
        }
    }
}