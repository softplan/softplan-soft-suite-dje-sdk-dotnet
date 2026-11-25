
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// A parte interessada conforme destinatario.<br/>
    /// Example: REU
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelParteInteressadaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Reclamante => "RECLAMANTE",
                ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Reu => "REU",
                ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Terceiro => "TERCEIRO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada? ToEnum(string value)
        {
            return value switch
            {
                "RECLAMANTE" => ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Reclamante,
                "REU" => ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Reu,
                "TERCEIRO" => ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada.Terceiro,
                _ => null,
            };
        }
    }
}