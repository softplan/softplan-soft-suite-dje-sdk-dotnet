
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PessoaPerfilViewModelStatusCadastro
    {
        /// <summary>
        ///
        /// </summary>
        Completo,
        /// <summary>
        ///
        /// </summary>
        EmProgresso,
        /// <summary>
        ///
        /// </summary>
        Pendente,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PessoaPerfilViewModelStatusCadastroExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PessoaPerfilViewModelStatusCadastro value)
        {
            return value switch
            {
                PessoaPerfilViewModelStatusCadastro.Completo => "COMPLETO",
                PessoaPerfilViewModelStatusCadastro.EmProgresso => "EM_PROGRESSO",
                PessoaPerfilViewModelStatusCadastro.Pendente => "PENDENTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PessoaPerfilViewModelStatusCadastro? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETO" => PessoaPerfilViewModelStatusCadastro.Completo,
                "EM_PROGRESSO" => PessoaPerfilViewModelStatusCadastro.EmProgresso,
                "PENDENTE" => PessoaPerfilViewModelStatusCadastro.Pendente,
                _ => null,
            };
        }
    }
}