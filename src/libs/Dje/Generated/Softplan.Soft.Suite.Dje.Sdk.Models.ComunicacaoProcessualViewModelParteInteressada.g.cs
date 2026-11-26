
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// A parte interessada conforme destinatario.<br/>
    /// Example: REU
    /// </summary>
    public enum ComunicacaoProcessualViewModelParteInteressada
    {
        /// <summary>
        ///
        /// </summary>
        Reclamante,
        /// <summary>
        ///
        /// </summary>
        Reu,
        /// <summary>
        ///
        /// </summary>
        Terceiro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelParteInteressadaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelParteInteressada value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelParteInteressada.Reclamante => "RECLAMANTE",
                ComunicacaoProcessualViewModelParteInteressada.Reu => "REU",
                ComunicacaoProcessualViewModelParteInteressada.Terceiro => "TERCEIRO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelParteInteressada? ToEnum(string value)
        {
            return value switch
            {
                "RECLAMANTE" => ComunicacaoProcessualViewModelParteInteressada.Reclamante,
                "REU" => ComunicacaoProcessualViewModelParteInteressada.Reu,
                "TERCEIRO" => ComunicacaoProcessualViewModelParteInteressada.Terceiro,
                _ => null,
            };
        }
    }
}