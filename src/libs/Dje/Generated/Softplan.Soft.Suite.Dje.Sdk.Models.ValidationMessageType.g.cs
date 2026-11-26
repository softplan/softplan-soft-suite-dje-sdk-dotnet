
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum ValidationMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationMessageType value)
        {
            return value switch
            {
                ValidationMessageType.Error => "ERROR",
                ValidationMessageType.Info => "INFO",
                ValidationMessageType.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationMessageType? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => ValidationMessageType.Error,
                "INFO" => ValidationMessageType.Info,
                "WARNING" => ValidationMessageType.Warning,
                _ => null,
            };
        }
    }
}