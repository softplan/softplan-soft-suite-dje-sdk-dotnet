
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PerfilRole
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
    public static class PerfilRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerfilRole value)
        {
            return value switch
            {
                PerfilRole.AdministradorDaEmpresa => "ADMINISTRADOR_DA_EMPRESA",
                PerfilRole.AdministradorGeralCnj => "ADMINISTRADOR_GERAL_CNJ",
                PerfilRole.AdministradorOrgaoPublico => "ADMINISTRADOR_ORGAO_PUBLICO",
                PerfilRole.GestorDeCadastroPrivado => "GESTOR_DE_CADASTRO_PRIVADO",
                PerfilRole.GestorDeCadastroPublico => "GESTOR_DE_CADASTRO_PUBLICO",
                PerfilRole.MatrizFilial => "MATRIZ_FILIAL",
                PerfilRole.PessoaFisica => "PESSOA_FISICA",
                PerfilRole.PrepostoDaComunicacaoPrivado => "PREPOSTO_DA_COMUNICACAO_PRIVADO",
                PerfilRole.PrepostoDaComunicacaoPublico => "PREPOSTO_DA_COMUNICACAO_PUBLICO",
                PerfilRole.Representante => "REPRESENTANTE",
                PerfilRole.RepresentanteOrgaoPublico => "REPRESENTANTE_ORGAO_PUBLICO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerfilRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMINISTRADOR_DA_EMPRESA" => PerfilRole.AdministradorDaEmpresa,
                "ADMINISTRADOR_GERAL_CNJ" => PerfilRole.AdministradorGeralCnj,
                "ADMINISTRADOR_ORGAO_PUBLICO" => PerfilRole.AdministradorOrgaoPublico,
                "GESTOR_DE_CADASTRO_PRIVADO" => PerfilRole.GestorDeCadastroPrivado,
                "GESTOR_DE_CADASTRO_PUBLICO" => PerfilRole.GestorDeCadastroPublico,
                "MATRIZ_FILIAL" => PerfilRole.MatrizFilial,
                "PESSOA_FISICA" => PerfilRole.PessoaFisica,
                "PREPOSTO_DA_COMUNICACAO_PRIVADO" => PerfilRole.PrepostoDaComunicacaoPrivado,
                "PREPOSTO_DA_COMUNICACAO_PUBLICO" => PerfilRole.PrepostoDaComunicacaoPublico,
                "REPRESENTANTE" => PerfilRole.Representante,
                "REPRESENTANTE_ORGAO_PUBLICO" => PerfilRole.RepresentanteOrgaoPublico,
                _ => null,
            };
        }
    }
}