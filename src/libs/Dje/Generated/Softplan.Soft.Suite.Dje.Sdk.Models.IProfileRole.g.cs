
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum IProfileRole
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
        /// <summary>
        ///
        /// </summary>
        MatrizFilial,
        /// <summary>
        ///
        /// </summary>
        PessoaFisica,
        /// <summary>
        ///
        /// </summary>
        PrepostoDaComunicacaoPrivado,
        /// <summary>
        ///
        /// </summary>
        PrepostoDaComunicacaoPublico,
        /// <summary>
        ///
        /// </summary>
        Representante,
        /// <summary>
        ///
        /// </summary>
        RepresentanteOrgaoPublico,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IProfileRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IProfileRole value)
        {
            return value switch
            {
                IProfileRole.AdministradorDaEmpresa => "ADMINISTRADOR_DA_EMPRESA",
                IProfileRole.AdministradorGeralCnj => "ADMINISTRADOR_GERAL_CNJ",
                IProfileRole.AdministradorOrgaoPublico => "ADMINISTRADOR_ORGAO_PUBLICO",
                IProfileRole.GestorDeCadastroPrivado => "GESTOR_DE_CADASTRO_PRIVADO",
                IProfileRole.GestorDeCadastroPublico => "GESTOR_DE_CADASTRO_PUBLICO",
                IProfileRole.MatrizFilial => "MATRIZ_FILIAL",
                IProfileRole.PessoaFisica => "PESSOA_FISICA",
                IProfileRole.PrepostoDaComunicacaoPrivado => "PREPOSTO_DA_COMUNICACAO_PRIVADO",
                IProfileRole.PrepostoDaComunicacaoPublico => "PREPOSTO_DA_COMUNICACAO_PUBLICO",
                IProfileRole.Representante => "REPRESENTANTE",
                IProfileRole.RepresentanteOrgaoPublico => "REPRESENTANTE_ORGAO_PUBLICO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IProfileRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMINISTRADOR_DA_EMPRESA" => IProfileRole.AdministradorDaEmpresa,
                "ADMINISTRADOR_GERAL_CNJ" => IProfileRole.AdministradorGeralCnj,
                "ADMINISTRADOR_ORGAO_PUBLICO" => IProfileRole.AdministradorOrgaoPublico,
                "GESTOR_DE_CADASTRO_PRIVADO" => IProfileRole.GestorDeCadastroPrivado,
                "GESTOR_DE_CADASTRO_PUBLICO" => IProfileRole.GestorDeCadastroPublico,
                "MATRIZ_FILIAL" => IProfileRole.MatrizFilial,
                "PESSOA_FISICA" => IProfileRole.PessoaFisica,
                "PREPOSTO_DA_COMUNICACAO_PRIVADO" => IProfileRole.PrepostoDaComunicacaoPrivado,
                "PREPOSTO_DA_COMUNICACAO_PUBLICO" => IProfileRole.PrepostoDaComunicacaoPublico,
                "REPRESENTANTE" => IProfileRole.Representante,
                "REPRESENTANTE_ORGAO_PUBLICO" => IProfileRole.RepresentanteOrgaoPublico,
                _ => null,
            };
        }
    }
}