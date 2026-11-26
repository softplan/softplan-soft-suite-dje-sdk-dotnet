
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Situacao do vinculo
    /// </summary>
    public enum DetalheVinculoOrgaoPublicoViewModelSituacao
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
    public static class DetalheVinculoOrgaoPublicoViewModelSituacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetalheVinculoOrgaoPublicoViewModelSituacao value)
        {
            return value switch
            {
                DetalheVinculoOrgaoPublicoViewModelSituacao.Aceito => "ACEITO",
                DetalheVinculoOrgaoPublicoViewModelSituacao.Cancelado => "CANCELADO",
                DetalheVinculoOrgaoPublicoViewModelSituacao.Inativa => "INATIVA",
                DetalheVinculoOrgaoPublicoViewModelSituacao.Pendente => "PENDENTE",
                DetalheVinculoOrgaoPublicoViewModelSituacao.Rejeitado => "REJEITADO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetalheVinculoOrgaoPublicoViewModelSituacao? ToEnum(string value)
        {
            return value switch
            {
                "ACEITO" => DetalheVinculoOrgaoPublicoViewModelSituacao.Aceito,
                "CANCELADO" => DetalheVinculoOrgaoPublicoViewModelSituacao.Cancelado,
                "INATIVA" => DetalheVinculoOrgaoPublicoViewModelSituacao.Inativa,
                "PENDENTE" => DetalheVinculoOrgaoPublicoViewModelSituacao.Pendente,
                "REJEITADO" => DetalheVinculoOrgaoPublicoViewModelSituacao.Rejeitado,
                _ => null,
            };
        }
    }
}