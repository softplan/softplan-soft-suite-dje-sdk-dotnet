
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de documento<br/>
    /// Example: CPF
    /// </summary>
    public enum PessoaRelacionadaViewModelTipoDocumento
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
    public static class PessoaRelacionadaViewModelTipoDocumentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaRelacionadaViewModelTipoDocumento value)
        {
            return value switch
            {
                PessoaRelacionadaViewModelTipoDocumento.Aob => "AOB",
                PessoaRelacionadaViewModelTipoDocumento.Cnpj => "CNPJ",
                PessoaRelacionadaViewModelTipoDocumento.Cpf => "CPF",
                PessoaRelacionadaViewModelTipoDocumento.Passaporte => "PASSAPORTE",
                PessoaRelacionadaViewModelTipoDocumento.Rne => "RNE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaRelacionadaViewModelTipoDocumento? ToEnum(string value)
        {
            return value switch
            {
                "AOB" => PessoaRelacionadaViewModelTipoDocumento.Aob,
                "CNPJ" => PessoaRelacionadaViewModelTipoDocumento.Cnpj,
                "CPF" => PessoaRelacionadaViewModelTipoDocumento.Cpf,
                "PASSAPORTE" => PessoaRelacionadaViewModelTipoDocumento.Passaporte,
                "RNE" => PessoaRelacionadaViewModelTipoDocumento.Rne,
                _ => null,
            };
        }
    }
}