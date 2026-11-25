
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Ação a ser executada no registro<br/>
    /// Example: ADICIONAR
    /// </summary>
    public enum EscopoPermissaoInputModelAcao
    {
        /// <summary>
        ///
        /// </summary>
        Adicionar,
        /// <summary>
        ///
        /// </summary>
        Atualizar,
        /// <summary>
        ///
        /// </summary>
        Nada,
        /// <summary>
        ///
        /// </summary>
        Remover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EscopoPermissaoInputModelAcaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EscopoPermissaoInputModelAcao value)
        {
            return value switch
            {
                EscopoPermissaoInputModelAcao.Adicionar => "ADICIONAR",
                EscopoPermissaoInputModelAcao.Atualizar => "ATUALIZAR",
                EscopoPermissaoInputModelAcao.Nada => "NADA",
                EscopoPermissaoInputModelAcao.Remover => "REMOVER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EscopoPermissaoInputModelAcao? ToEnum(string value)
        {
            return value switch
            {
                "ADICIONAR" => EscopoPermissaoInputModelAcao.Adicionar,
                "ATUALIZAR" => EscopoPermissaoInputModelAcao.Atualizar,
                "NADA" => EscopoPermissaoInputModelAcao.Nada,
                "REMOVER" => EscopoPermissaoInputModelAcao.Remover,
                _ => null,
            };
        }
    }
}