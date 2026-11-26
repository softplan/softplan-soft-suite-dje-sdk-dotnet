
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Cargo do gestor<br/>
    /// Example: GESTOR_DE_CADASTRO_PRIVADO
    /// </summary>
    public enum GestorViewModelCargo
    {
        /// <summary>
        ///
        /// </summary>
        AdministradorDaEmpresa,
        /// <summary>
        ///
        /// </summary>
        AdministradorGeralCnj,
        /// <summary>
        ///
        /// </summary>
        AdministradorOrgaoPublico,
        /// <summary>
        ///
        /// </summary>
        GestorDeCadastroPrivado,
        /// <summary>
        ///
        /// </summary>
        GestorDeCadastroPublico,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GestorViewModelCargoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GestorViewModelCargo value)
        {
            return value switch
            {
                GestorViewModelCargo.AdministradorDaEmpresa => "ADMINISTRADOR_DA_EMPRESA",
                GestorViewModelCargo.AdministradorGeralCnj => "ADMINISTRADOR_GERAL_CNJ",
                GestorViewModelCargo.AdministradorOrgaoPublico => "ADMINISTRADOR_ORGAO_PUBLICO",
                GestorViewModelCargo.GestorDeCadastroPrivado => "GESTOR_DE_CADASTRO_PRIVADO",
                GestorViewModelCargo.GestorDeCadastroPublico => "GESTOR_DE_CADASTRO_PUBLICO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GestorViewModelCargo? ToEnum(string value)
        {
            return value switch
            {
                "ADMINISTRADOR_DA_EMPRESA" => GestorViewModelCargo.AdministradorDaEmpresa,
                "ADMINISTRADOR_GERAL_CNJ" => GestorViewModelCargo.AdministradorGeralCnj,
                "ADMINISTRADOR_ORGAO_PUBLICO" => GestorViewModelCargo.AdministradorOrgaoPublico,
                "GESTOR_DE_CADASTRO_PRIVADO" => GestorViewModelCargo.GestorDeCadastroPrivado,
                "GESTOR_DE_CADASTRO_PUBLICO" => GestorViewModelCargo.GestorDeCadastroPublico,
                _ => null,
            };
        }
    }
}