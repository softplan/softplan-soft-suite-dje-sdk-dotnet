
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo da Sessão do Julgamento<br/>
    /// Example: O
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento
    {
        /// <summary>
        ///
        /// </summary>
        EExtraordinária,
        /// <summary>
        ///
        /// </summary>
        OOrdinária,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento.EExtraordinária => "E - Extraordinária",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento.OOrdinária => "O - Ordinária",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento? ToEnum(string value)
        {
            return value switch
            {
                "E - Extraordinária" => ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento.EExtraordinária,
                "O - Ordinária" => ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento.OOrdinária,
                _ => null,
            };
        }
    }
}