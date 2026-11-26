
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de documento<br/>
    /// Example: CPF
    /// </summary>
    public enum PessoaProcessualOrgaoPublicoViewModelTipoDocumento
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
    public static class PessoaProcessualOrgaoPublicoViewModelTipoDocumentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaProcessualOrgaoPublicoViewModelTipoDocumento value)
        {
            return value switch
            {
                PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Aob => "AOB",
                PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Cnpj => "CNPJ",
                PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Cpf => "CPF",
                PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Passaporte => "PASSAPORTE",
                PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Rne => "RNE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaProcessualOrgaoPublicoViewModelTipoDocumento? ToEnum(string value)
        {
            return value switch
            {
                "AOB" => PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Aob,
                "CNPJ" => PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Cnpj,
                "CPF" => PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Cpf,
                "PASSAPORTE" => PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Passaporte,
                "RNE" => PessoaProcessualOrgaoPublicoViewModelTipoDocumento.Rne,
                _ => null,
            };
        }
    }
}