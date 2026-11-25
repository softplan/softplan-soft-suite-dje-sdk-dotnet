
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo da pessoa. Admite os valores F e J, para pessoa física e jurídica, respectivamente.
    /// </summary>
    public enum PessoaInfoViewModelTipoPessoa
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
    public static class PessoaInfoViewModelTipoPessoaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaInfoViewModelTipoPessoa value)
        {
            return value switch
            {
                PessoaInfoViewModelTipoPessoa.Fisica => "FISICA",
                PessoaInfoViewModelTipoPessoa.Juridica => "JURIDICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaInfoViewModelTipoPessoa? ToEnum(string value)
        {
            return value switch
            {
                "FISICA" => PessoaInfoViewModelTipoPessoa.Fisica,
                "JURIDICA" => PessoaInfoViewModelTipoPessoa.Juridica,
                _ => null,
            };
        }
    }
}