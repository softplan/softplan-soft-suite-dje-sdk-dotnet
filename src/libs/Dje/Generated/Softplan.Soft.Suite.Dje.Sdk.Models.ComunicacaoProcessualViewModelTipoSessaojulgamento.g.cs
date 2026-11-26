
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo da Sessão do Julgamento<br/>
    /// Example: O
    /// </summary>
    public enum ComunicacaoProcessualViewModelTipoSessaojulgamento
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
    public static class ComunicacaoProcessualViewModelTipoSessaojulgamentoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelTipoSessaojulgamento value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelTipoSessaojulgamento.EExtraordinária => "E - Extraordinária",
                ComunicacaoProcessualViewModelTipoSessaojulgamento.OOrdinária => "O - Ordinária",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelTipoSessaojulgamento? ToEnum(string value)
        {
            return value switch
            {
                "E - Extraordinária" => ComunicacaoProcessualViewModelTipoSessaojulgamento.EExtraordinária,
                "O - Ordinária" => ComunicacaoProcessualViewModelTipoSessaojulgamento.OOrdinária,
                _ => null,
            };
        }
    }
}