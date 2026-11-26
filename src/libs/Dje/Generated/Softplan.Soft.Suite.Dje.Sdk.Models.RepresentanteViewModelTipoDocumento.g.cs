
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo do documento do representante<br/>
    /// Example: CPF
    /// </summary>
    public enum RepresentanteViewModelTipoDocumento
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
    public static class RepresentanteViewModelTipoDocumentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepresentanteViewModelTipoDocumento value)
        {
            return value switch
            {
                RepresentanteViewModelTipoDocumento.Aob => "AOB",
                RepresentanteViewModelTipoDocumento.Cnpj => "CNPJ",
                RepresentanteViewModelTipoDocumento.Cpf => "CPF",
                RepresentanteViewModelTipoDocumento.Passaporte => "PASSAPORTE",
                RepresentanteViewModelTipoDocumento.Rne => "RNE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepresentanteViewModelTipoDocumento? ToEnum(string value)
        {
            return value switch
            {
                "AOB" => RepresentanteViewModelTipoDocumento.Aob,
                "CNPJ" => RepresentanteViewModelTipoDocumento.Cnpj,
                "CPF" => RepresentanteViewModelTipoDocumento.Cpf,
                "PASSAPORTE" => RepresentanteViewModelTipoDocumento.Passaporte,
                "RNE" => RepresentanteViewModelTipoDocumento.Rne,
                _ => null,
            };
        }
    }
}