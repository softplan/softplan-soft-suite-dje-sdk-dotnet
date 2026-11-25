
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de documento<br/>
    /// Example: CPF
    /// </summary>
    public enum PessoaViewModelTipoDocumento
    {
        /// <summary>
        ///
        /// </summary>
        Aob,
        /// <summary>
        ///
        /// </summary>
        Cnpj,
        /// <summary>
        ///
        /// </summary>
        Cpf,
        /// <summary>
        ///
        /// </summary>
        Passaporte,
        /// <summary>
        ///
        /// </summary>
        Rne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PessoaViewModelTipoDocumentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaViewModelTipoDocumento value)
        {
            return value switch
            {
                PessoaViewModelTipoDocumento.Aob => "AOB",
                PessoaViewModelTipoDocumento.Cnpj => "CNPJ",
                PessoaViewModelTipoDocumento.Cpf => "CPF",
                PessoaViewModelTipoDocumento.Passaporte => "PASSAPORTE",
                PessoaViewModelTipoDocumento.Rne => "RNE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaViewModelTipoDocumento? ToEnum(string value)
        {
            return value switch
            {
                "AOB" => PessoaViewModelTipoDocumento.Aob,
                "CNPJ" => PessoaViewModelTipoDocumento.Cnpj,
                "CPF" => PessoaViewModelTipoDocumento.Cpf,
                "PASSAPORTE" => PessoaViewModelTipoDocumento.Passaporte,
                "RNE" => PessoaViewModelTipoDocumento.Rne,
                _ => null,
            };
        }
    }
}