
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum MensagemTipoMensagem
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
    public static class MensagemTipoMensagemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MensagemTipoMensagem value)
        {
            return value switch
            {
                MensagemTipoMensagem.Error => "ERROR",
                MensagemTipoMensagem.Info => "INFO",
                MensagemTipoMensagem.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MensagemTipoMensagem? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => MensagemTipoMensagem.Error,
                "INFO" => MensagemTipoMensagem.Info,
                "WARNING" => MensagemTipoMensagem.Warning,
                _ => null,
            };
        }
    }
}