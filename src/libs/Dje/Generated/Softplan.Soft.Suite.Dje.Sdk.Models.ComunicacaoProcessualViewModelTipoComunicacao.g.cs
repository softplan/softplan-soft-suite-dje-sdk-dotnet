
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Tipo de comunicação (Citação, Intimação, Notificação, Vista ou Ipta)<br/>
    /// Example: INTIMACAO
    /// </summary>
    public enum ComunicacaoProcessualViewModelTipoComunicacao
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
    public static class ComunicacaoProcessualViewModelTipoComunicacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelTipoComunicacao value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelTipoComunicacao.Citacao => "CITACAO",
                ComunicacaoProcessualViewModelTipoComunicacao.Intimacao => "INTIMACAO",
                ComunicacaoProcessualViewModelTipoComunicacao.Ipta => "IPTA",
                ComunicacaoProcessualViewModelTipoComunicacao.Notificacao => "NOTIFICACAO",
                ComunicacaoProcessualViewModelTipoComunicacao.Vista => "VISTA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelTipoComunicacao? ToEnum(string value)
        {
            return value switch
            {
                "CITACAO" => ComunicacaoProcessualViewModelTipoComunicacao.Citacao,
                "INTIMACAO" => ComunicacaoProcessualViewModelTipoComunicacao.Intimacao,
                "IPTA" => ComunicacaoProcessualViewModelTipoComunicacao.Ipta,
                "NOTIFICACAO" => ComunicacaoProcessualViewModelTipoComunicacao.Notificacao,
                "VISTA" => ComunicacaoProcessualViewModelTipoComunicacao.Vista,
                _ => null,
            };
        }
    }
}