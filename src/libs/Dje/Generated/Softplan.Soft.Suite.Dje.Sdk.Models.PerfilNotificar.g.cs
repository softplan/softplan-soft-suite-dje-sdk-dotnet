
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PerfilNotificar
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
    public static class PerfilNotificarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerfilNotificar value)
        {
            return value switch
            {
                PerfilNotificar.Nenhuma => "NENHUMA",
                PerfilNotificar.Resumo => "RESUMO",
                PerfilNotificar.Todas => "TODAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerfilNotificar? ToEnum(string value)
        {
            return value switch
            {
                "NENHUMA" => PerfilNotificar.Nenhuma,
                "RESUMO" => PerfilNotificar.Resumo,
                "TODAS" => PerfilNotificar.Todas,
                _ => null,
            };
        }
    }
}