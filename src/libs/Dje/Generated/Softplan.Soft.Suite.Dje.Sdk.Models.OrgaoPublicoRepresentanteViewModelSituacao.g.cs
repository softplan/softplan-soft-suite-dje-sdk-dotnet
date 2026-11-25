
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Situacao do vinculo
    /// </summary>
    public enum OrgaoPublicoRepresentanteViewModelSituacao
    {
        /// <summary>
        ///
        /// </summary>
        Aceito,
        /// <summary>
        ///
        /// </summary>
        Cancelado,
        /// <summary>
        ///
        /// </summary>
        Inativa,
        /// <summary>
        ///
        /// </summary>
        Pendente,
        /// <summary>
        ///
        /// </summary>
        Rejeitado,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgaoPublicoRepresentanteViewModelSituacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgaoPublicoRepresentanteViewModelSituacao value)
        {
            return value switch
            {
                OrgaoPublicoRepresentanteViewModelSituacao.Aceito => "ACEITO",
                OrgaoPublicoRepresentanteViewModelSituacao.Cancelado => "CANCELADO",
                OrgaoPublicoRepresentanteViewModelSituacao.Inativa => "INATIVA",
                OrgaoPublicoRepresentanteViewModelSituacao.Pendente => "PENDENTE",
                OrgaoPublicoRepresentanteViewModelSituacao.Rejeitado => "REJEITADO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgaoPublicoRepresentanteViewModelSituacao? ToEnum(string value)
        {
            return value switch
            {
                "ACEITO" => OrgaoPublicoRepresentanteViewModelSituacao.Aceito,
                "CANCELADO" => OrgaoPublicoRepresentanteViewModelSituacao.Cancelado,
                "INATIVA" => OrgaoPublicoRepresentanteViewModelSituacao.Inativa,
                "PENDENTE" => OrgaoPublicoRepresentanteViewModelSituacao.Pendente,
                "REJEITADO" => OrgaoPublicoRepresentanteViewModelSituacao.Rejeitado,
                _ => null,
            };
        }
    }
}