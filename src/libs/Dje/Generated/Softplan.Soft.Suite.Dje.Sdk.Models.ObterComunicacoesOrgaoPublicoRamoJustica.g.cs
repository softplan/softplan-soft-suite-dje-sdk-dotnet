
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Identifica o ramo de justica da comunicacao<br/>
    /// Example: 1-JUSTICA COMUM, 2-JUSTICA ESTADUAL, 3-JUSTICA FEDERAL, 4-JUSTICA MILITAR, 5-JUSTICA DO TRABALHO, 6-JUSTICA ELEITORAL
    /// </summary>
    public enum ObterComunicacoesOrgaoPublicoRamoJustica
    {
        /// <summary>
        ///
        /// </summary>
        x1,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterComunicacoesOrgaoPublicoRamoJusticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterComunicacoesOrgaoPublicoRamoJustica value)
        {
            return value switch
            {
                ObterComunicacoesOrgaoPublicoRamoJustica.x1 => "1",
                ObterComunicacoesOrgaoPublicoRamoJustica.x2 => "2",
                ObterComunicacoesOrgaoPublicoRamoJustica.x3 => "3",
                ObterComunicacoesOrgaoPublicoRamoJustica.x4 => "4",
                ObterComunicacoesOrgaoPublicoRamoJustica.x5 => "5",
                ObterComunicacoesOrgaoPublicoRamoJustica.x6 => "6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterComunicacoesOrgaoPublicoRamoJustica? ToEnum(string value)
        {
            return value switch
            {
                "1" => ObterComunicacoesOrgaoPublicoRamoJustica.x1,
                "2" => ObterComunicacoesOrgaoPublicoRamoJustica.x2,
                "3" => ObterComunicacoesOrgaoPublicoRamoJustica.x3,
                "4" => ObterComunicacoesOrgaoPublicoRamoJustica.x4,
                "5" => ObterComunicacoesOrgaoPublicoRamoJustica.x5,
                "6" => ObterComunicacoesOrgaoPublicoRamoJustica.x6,
                _ => null,
            };
        }
    }
}