
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum INotificationTypeNotification
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
    public static class INotificationTypeNotificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this INotificationTypeNotification value)
        {
            return value switch
            {
                INotificationTypeNotification.Error => "ERROR",
                INotificationTypeNotification.Info => "INFO",
                INotificationTypeNotification.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static INotificationTypeNotification? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => INotificationTypeNotification.Error,
                "INFO" => INotificationTypeNotification.Info,
                "WARNING" => INotificationTypeNotification.Warning,
                _ => null,
            };
        }
    }
}