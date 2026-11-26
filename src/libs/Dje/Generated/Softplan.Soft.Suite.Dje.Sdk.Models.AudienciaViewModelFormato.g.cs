
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Virtual ou presencial
    /// </summary>
    public enum AudienciaViewModelFormato
    {
        /// <summary>
        ///
        /// </summary>
        Presencial,
        /// <summary>
        ///
        /// </summary>
        Virtual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudienciaViewModelFormatoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudienciaViewModelFormato value)
        {
            return value switch
            {
                AudienciaViewModelFormato.Presencial => "PRESENCIAL",
                AudienciaViewModelFormato.Virtual => "VIRTUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudienciaViewModelFormato? ToEnum(string value)
        {
            return value switch
            {
                "PRESENCIAL" => AudienciaViewModelFormato.Presencial,
                "VIRTUAL" => AudienciaViewModelFormato.Virtual,
                _ => null,
            };
        }
    }
}