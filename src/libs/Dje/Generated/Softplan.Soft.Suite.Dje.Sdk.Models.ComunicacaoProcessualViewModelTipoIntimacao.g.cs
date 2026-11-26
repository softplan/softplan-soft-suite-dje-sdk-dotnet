
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Liminar, obrigação de fazer, sentença, acórdão, trânsito em julgado, Ofício, Intimação de Pauta, Decisão, Despacho e Outros<br/>
    /// Example: LIMINAR
    /// </summary>
    public enum ComunicacaoProcessualViewModelTipoIntimacao
    {
        /// <summary>
        ///
        /// </summary>
        Acordao,
        /// <summary>
        ///
        /// </summary>
        Decisao,
        /// <summary>
        ///
        /// </summary>
        Despacho,
        /// <summary>
        ///
        /// </summary>
        IntimacaoDePauta,
        /// <summary>
        ///
        /// </summary>
        Liminar,
        /// <summary>
        ///
        /// </summary>
        ObrigacaoDeFazer,
        /// <summary>
        ///
        /// </summary>
        Oficio,
        /// <summary>
        ///
        /// </summary>
        Outros,
        /// <summary>
        ///
        /// </summary>
        Sentenca,
        /// <summary>
        ///
        /// </summary>
        TransitoEmJulgado,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComunicacaoProcessualViewModelTipoIntimacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualViewModelTipoIntimacao value)
        {
            return value switch
            {
                ComunicacaoProcessualViewModelTipoIntimacao.Acordao => "ACORDAO",
                ComunicacaoProcessualViewModelTipoIntimacao.Decisao => "DECISAO",
                ComunicacaoProcessualViewModelTipoIntimacao.Despacho => "DESPACHO",
                ComunicacaoProcessualViewModelTipoIntimacao.IntimacaoDePauta => "INTIMACAO_DE_PAUTA",
                ComunicacaoProcessualViewModelTipoIntimacao.Liminar => "LIMINAR",
                ComunicacaoProcessualViewModelTipoIntimacao.ObrigacaoDeFazer => "OBRIGACAO_DE_FAZER",
                ComunicacaoProcessualViewModelTipoIntimacao.Oficio => "OFICIO",
                ComunicacaoProcessualViewModelTipoIntimacao.Outros => "OUTROS",
                ComunicacaoProcessualViewModelTipoIntimacao.Sentenca => "SENTENCA",
                ComunicacaoProcessualViewModelTipoIntimacao.TransitoEmJulgado => "TRANSITO_EM_JULGADO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualViewModelTipoIntimacao? ToEnum(string value)
        {
            return value switch
            {
                "ACORDAO" => ComunicacaoProcessualViewModelTipoIntimacao.Acordao,
                "DECISAO" => ComunicacaoProcessualViewModelTipoIntimacao.Decisao,
                "DESPACHO" => ComunicacaoProcessualViewModelTipoIntimacao.Despacho,
                "INTIMACAO_DE_PAUTA" => ComunicacaoProcessualViewModelTipoIntimacao.IntimacaoDePauta,
                "LIMINAR" => ComunicacaoProcessualViewModelTipoIntimacao.Liminar,
                "OBRIGACAO_DE_FAZER" => ComunicacaoProcessualViewModelTipoIntimacao.ObrigacaoDeFazer,
                "OFICIO" => ComunicacaoProcessualViewModelTipoIntimacao.Oficio,
                "OUTROS" => ComunicacaoProcessualViewModelTipoIntimacao.Outros,
                "SENTENCA" => ComunicacaoProcessualViewModelTipoIntimacao.Sentenca,
                "TRANSITO_EM_JULGADO" => ComunicacaoProcessualViewModelTipoIntimacao.TransitoEmJulgado,
                _ => null,
            };
        }
    }
}