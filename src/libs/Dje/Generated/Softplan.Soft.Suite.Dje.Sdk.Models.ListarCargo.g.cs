
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum ListarCargo
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        x10,
        /// <summary>
        ///
        /// </summary>
        x11,
        /// <summary>
        ///
        /// </summary>
        x2,
        /// <summary>
        ///
        /// </summary>
        x3,
        /// <summary>
        ///
        /// </summary>
        x4,
        /// <summary>
        ///
        /// </summary>
        x5,
        /// <summary>
        ///
        /// </summary>
        x6,
        /// <summary>
        ///
        /// </summary>
        x7,
        /// <summary>
        ///
        /// </summary>
        x8,
        /// <summary>
        ///
        /// </summary>
        x9,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListarCargoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListarCargo value)
        {
            return value switch
            {
                ListarCargo.x1 => "1",
                ListarCargo.x10 => "10",
                ListarCargo.x11 => "11",
                ListarCargo.x2 => "2",
                ListarCargo.x3 => "3",
                ListarCargo.x4 => "4",
                ListarCargo.x5 => "5",
                ListarCargo.x6 => "6",
                ListarCargo.x7 => "7",
                ListarCargo.x8 => "8",
                ListarCargo.x9 => "9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListarCargo? ToEnum(string value)
        {
            return value switch
            {
                "1" => ListarCargo.x1,
                "10" => ListarCargo.x10,
                "11" => ListarCargo.x11,
                "2" => ListarCargo.x2,
                "3" => ListarCargo.x3,
                "4" => ListarCargo.x4,
                "5" => ListarCargo.x5,
                "6" => ListarCargo.x6,
                "7" => ListarCargo.x7,
                "8" => ListarCargo.x8,
                "9" => ListarCargo.x9,
                _ => null,
            };
        }
    }
}