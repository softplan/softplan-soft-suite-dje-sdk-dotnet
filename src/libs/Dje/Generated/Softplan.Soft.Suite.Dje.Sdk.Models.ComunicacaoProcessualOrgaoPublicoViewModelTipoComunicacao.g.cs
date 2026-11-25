
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de comunicação (Citação, Intimação, Notificação, Vista ou Ipta)<br/>
    /// Example: INTIMACAO
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao
    {
        /// <summary>
        ///
        /// </summary>
        Citacao,
        /// <summary>
        ///
        /// </summary>
        Intimacao,
        /// <summary>
        ///
        /// </summary>
        Ipta,
        /// <summary>
        ///
        /// </summary>
        Notificacao,
        /// <summary>
        ///
        /// </summary>
        Vista,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Citacao => "CITACAO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Intimacao => "INTIMACAO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Ipta => "IPTA",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Notificacao => "NOTIFICACAO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Vista => "VISTA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao? ToEnum(string value)
        {
            return value switch
            {
                "CITACAO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Citacao,
                "INTIMACAO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Intimacao,
                "IPTA" => ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Ipta,
                "NOTIFICACAO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Notificacao,
                "VISTA" => ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao.Vista,
                _ => null,
            };
        }
    }
}