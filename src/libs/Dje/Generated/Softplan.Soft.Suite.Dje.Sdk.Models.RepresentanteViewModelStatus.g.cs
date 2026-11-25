
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Status do representante. (Ativo - A, Inativo - I)<br/>
    /// Example: A
    /// </summary>
    public enum RepresentanteViewModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        A,
        /// <summary>
        ///
        /// </summary>
        I,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepresentanteViewModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepresentanteViewModelStatus value)
        {
            return value switch
            {
                RepresentanteViewModelStatus.A => "A",
                RepresentanteViewModelStatus.I => "I",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepresentanteViewModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "A" => RepresentanteViewModelStatus.A,
                "I" => RepresentanteViewModelStatus.I,
                _ => null,
            };
        }
    }
}