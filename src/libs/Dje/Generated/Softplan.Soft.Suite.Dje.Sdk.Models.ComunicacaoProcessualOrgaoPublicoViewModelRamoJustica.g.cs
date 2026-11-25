
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Identifica o ramo de justiça da comunicação<br/>
    /// Example: JUSTIÇA COMUM
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica
    {
        /// <summary>
        ///
        /// </summary>
        JustiçaComum,
        /// <summary>
        ///
        /// </summary>
        JustiçaDoTrabalho,
        /// <summary>
        ///
        /// </summary>
        JustiçaEleitoral,
        /// <summary>
        ///
        /// </summary>
        JustiçaEstadual,
        /// <summary>
        ///
        /// </summary>
        JustiçaFederal,
        /// <summary>
        ///
        /// </summary>
        JustiçaMilitar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelRamoJusticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaComum => "JUSTIÇA COMUM",
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaDoTrabalho => "JUSTIÇA DO TRABALHO",
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaEleitoral => "JUSTIÇA ELEITORAL",
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaEstadual => "JUSTIÇA ESTADUAL",
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaFederal => "JUSTIÇA FEDERAL",
                ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaMilitar => "JUSTIÇA MILITAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica? ToEnum(string value)
        {
            return value switch
            {
                "JUSTIÇA COMUM" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaComum,
                "JUSTIÇA DO TRABALHO" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaDoTrabalho,
                "JUSTIÇA ELEITORAL" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaEleitoral,
                "JUSTIÇA ESTADUAL" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaEstadual,
                "JUSTIÇA FEDERAL" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaFederal,
                "JUSTIÇA MILITAR" => ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica.JustiçaMilitar,
                _ => null,
            };
        }
    }
}