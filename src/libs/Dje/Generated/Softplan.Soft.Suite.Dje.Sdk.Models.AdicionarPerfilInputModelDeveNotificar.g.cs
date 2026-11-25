
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Se a pessoa deseja receber notificações por email<br/>
    /// Example: TODAS
    /// </summary>
    public enum AdicionarPerfilInputModelDeveNotificar
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
    public static class AdicionarPerfilInputModelDeveNotificarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdicionarPerfilInputModelDeveNotificar value)
        {
            return value switch
            {
                AdicionarPerfilInputModelDeveNotificar.Nenhuma => "NENHUMA",
                AdicionarPerfilInputModelDeveNotificar.Resumo => "RESUMO",
                AdicionarPerfilInputModelDeveNotificar.Todas => "TODAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdicionarPerfilInputModelDeveNotificar? ToEnum(string value)
        {
            return value switch
            {
                "NENHUMA" => AdicionarPerfilInputModelDeveNotificar.Nenhuma,
                "RESUMO" => AdicionarPerfilInputModelDeveNotificar.Resumo,
                "TODAS" => AdicionarPerfilInputModelDeveNotificar.Todas,
                _ => null,
            };
        }
    }
}