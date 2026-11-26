
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se a pessoa deseja receber notificações por email<br/>
    /// Example: TODAS
    /// </summary>
    public enum AtualizarPerfilInputModelDeveNotificar
    {
        /// <summary>
        ///
        /// </summary>
        Nenhuma,
        /// <summary>
        ///
        /// </summary>
        Resumo,
        /// <summary>
        ///
        /// </summary>
        Todas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AtualizarPerfilInputModelDeveNotificarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AtualizarPerfilInputModelDeveNotificar value)
        {
            return value switch
            {
                AtualizarPerfilInputModelDeveNotificar.Nenhuma => "NENHUMA",
                AtualizarPerfilInputModelDeveNotificar.Resumo => "RESUMO",
                AtualizarPerfilInputModelDeveNotificar.Todas => "TODAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AtualizarPerfilInputModelDeveNotificar? ToEnum(string value)
        {
            return value switch
            {
                "NENHUMA" => AtualizarPerfilInputModelDeveNotificar.Nenhuma,
                "RESUMO" => AtualizarPerfilInputModelDeveNotificar.Resumo,
                "TODAS" => AtualizarPerfilInputModelDeveNotificar.Todas,
                _ => null,
            };
        }
    }
}