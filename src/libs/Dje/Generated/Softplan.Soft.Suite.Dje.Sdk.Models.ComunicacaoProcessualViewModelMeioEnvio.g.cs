
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Meio de envio da comunicação<br/>
    /// Example: DOMICILIO_ELETRONICO
    /// </summary>
    public enum ComunicacaoProcessualViewModelMeioEnvio
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
    public static class ComunicacaoProcessualViewModelMeioEnvioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelMeioEnvio value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelMeioEnvio.Correios => "CORREIOS",
                ComunicacaoProcessualViewModelMeioEnvio.Djen => "DJEN",
                ComunicacaoProcessualViewModelMeioEnvio.DomicilioEletronico => "DOMICILIO_ELETRONICO",
                ComunicacaoProcessualViewModelMeioEnvio.OficialJustica => "OFICIAL_JUSTICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelMeioEnvio? ToEnum(string value)
        {
            return value switch
            {
                "CORREIOS" => ComunicacaoProcessualViewModelMeioEnvio.Correios,
                "DJEN" => ComunicacaoProcessualViewModelMeioEnvio.Djen,
                "DOMICILIO_ELETRONICO" => ComunicacaoProcessualViewModelMeioEnvio.DomicilioEletronico,
                "OFICIAL_JUSTICA" => ComunicacaoProcessualViewModelMeioEnvio.OficialJustica,
                _ => null,
            };
        }
    }
}