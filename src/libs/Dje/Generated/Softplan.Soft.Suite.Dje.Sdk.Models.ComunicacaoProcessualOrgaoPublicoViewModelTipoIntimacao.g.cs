
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Liminar, obrigação de fazer, sentença, acórdão, trânsito em julgado, Ofício, Intimação de Pauta, Decisão, Despacho e Outros<br/>
    /// Example: LIMINAR
    /// </summary>
    public enum ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao
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
    public static class ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao value)
        {
            return value switch
            {
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Acordao => "ACORDAO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Decisao => "DECISAO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Despacho => "DESPACHO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.IntimacaoDePauta => "INTIMACAO_DE_PAUTA",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Liminar => "LIMINAR",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.ObrigacaoDeFazer => "OBRIGACAO_DE_FAZER",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Oficio => "OFICIO",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Outros => "OUTROS",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Sentenca => "SENTENCA",
                ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.TransitoEmJulgado => "TRANSITO_EM_JULGADO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao? ToEnum(string value)
        {
            return value switch
            {
                "ACORDAO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Acordao,
                "DECISAO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Decisao,
                "DESPACHO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Despacho,
                "INTIMACAO_DE_PAUTA" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.IntimacaoDePauta,
                "LIMINAR" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Liminar,
                "OBRIGACAO_DE_FAZER" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.ObrigacaoDeFazer,
                "OFICIO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Oficio,
                "OUTROS" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Outros,
                "SENTENCA" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.Sentenca,
                "TRANSITO_EM_JULGADO" => ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao.TransitoEmJulgado,
                _ => null,
            };
        }
    }
}