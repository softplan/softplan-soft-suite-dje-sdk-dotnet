
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Meio de envio da comunicação<br/>
    /// Example: DOMICILIO_ELETRONICO
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio
    {
        /// <summary>
        ///
        /// </summary>
        Correios,
        /// <summary>
        ///
        /// </summary>
        Djen,
        /// <summary>
        ///
        /// </summary>
        DomicilioEletronico,
        /// <summary>
        ///
        /// </summary>
        OficialJustica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.Correios => "CORREIOS",
                ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.Djen => "DJEN",
                ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.DomicilioEletronico => "DOMICILIO_ELETRONICO",
                ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.OficialJustica => "OFICIAL_JUSTICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio? ToEnum(string value)
        {
            return value switch
            {
                "CORREIOS" => ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.Correios,
                "DJEN" => ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.Djen,
                "DOMICILIO_ELETRONICO" => ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.DomicilioEletronico,
                "OFICIAL_JUSTICA" => ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio.OficialJustica,
                _ => null,
            };
        }
    }
}