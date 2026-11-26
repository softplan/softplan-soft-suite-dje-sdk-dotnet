
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Status do vinculo<br/>
    /// Example: P
    /// </summary>
    public enum ObterVinculosOrgaoPublicoStatus
    {
        /// <summary>
        ///
        /// </summary>
        AceitoA,
        /// <summary>
        ///
        /// </summary>
        CanceladoC,
        /// <summary>
        ///
        /// </summary>
        InativaI,
        /// <summary>
        ///
        /// </summary>
        PendenteP,
        /// <summary>
        ///
        /// </summary>
        RejeitadoR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObterVinculosOrgaoPublicoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObterVinculosOrgaoPublicoStatus value)
        {
            return value switch
            {
                ObterVinculosOrgaoPublicoStatus.AceitoA => "ACEITO - A",
                ObterVinculosOrgaoPublicoStatus.CanceladoC => "CANCELADO - C",
                ObterVinculosOrgaoPublicoStatus.InativaI => "INATIVA - I",
                ObterVinculosOrgaoPublicoStatus.PendenteP => "PENDENTE - P",
                ObterVinculosOrgaoPublicoStatus.RejeitadoR => "REJEITADO - R",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObterVinculosOrgaoPublicoStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACEITO - A" => ObterVinculosOrgaoPublicoStatus.AceitoA,
                "CANCELADO - C" => ObterVinculosOrgaoPublicoStatus.CanceladoC,
                "INATIVA - I" => ObterVinculosOrgaoPublicoStatus.InativaI,
                "PENDENTE - P" => ObterVinculosOrgaoPublicoStatus.PendenteP,
                "REJEITADO - R" => ObterVinculosOrgaoPublicoStatus.RejeitadoR,
                _ => null,
            };
        }
    }
}