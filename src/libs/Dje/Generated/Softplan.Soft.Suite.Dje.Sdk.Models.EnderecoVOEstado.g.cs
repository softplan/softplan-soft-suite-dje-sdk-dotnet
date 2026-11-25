
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum EnderecoVOEstado
    {
        /// <summary>
        ///
        /// </summary>
        Acre,
        /// <summary>
        ///
        /// </summary>
        Alagoas,
        /// <summary>
        ///
        /// </summary>
        Amapa,
        /// <summary>
        ///
        /// </summary>
        Amazonas,
        /// <summary>
        ///
        /// </summary>
        Bahia,
        /// <summary>
        ///
        /// </summary>
        Ceara,
        /// <summary>
        ///
        /// </summary>
        DistritoFederal,
        /// <summary>
        ///
        /// </summary>
        EspiritoSanto,
        /// <summary>
        ///
        /// </summary>
        Goias,
        /// <summary>
        ///
        /// </summary>
        Maranhao,
        /// <summary>
        ///
        /// </summary>
        MatoGrosso,
        /// <summary>
        ///
        /// </summary>
        MatoGrossoDoSul,
        /// <summary>
        ///
        /// </summary>
        MinasGerais,
        /// <summary>
        ///
        /// </summary>
        Para,
        /// <summary>
        ///
        /// </summary>
        Paraiba,
        /// <summary>
        ///
        /// </summary>
        Parana,
        /// <summary>
        ///
        /// </summary>
        Pernambuco,
        /// <summary>
        ///
        /// </summary>
        Piaui,
        /// <summary>
        ///
        /// </summary>
        RioDeJaneiro,
        /// <summary>
        ///
        /// </summary>
        RioGrandeDoNorte,
        /// <summary>
        ///
        /// </summary>
        RioGrandeDoSul,
        /// <summary>
        ///
        /// </summary>
        Rondonia,
        /// <summary>
        ///
        /// </summary>
        Roraima,
        /// <summary>
        ///
        /// </summary>
        SantaCatarina,
        /// <summary>
        ///
        /// </summary>
        SaoPaulo,
        /// <summary>
        ///
        /// </summary>
        Sergipe,
        /// <summary>
        ///
        /// </summary>
        Tocantins,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnderecoVOEstadoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnderecoVOEstado value)
        {
            return value switch
            {
                EnderecoVOEstado.Acre => "ACRE",
                EnderecoVOEstado.Alagoas => "ALAGOAS",
                EnderecoVOEstado.Amapa => "AMAPA",
                EnderecoVOEstado.Amazonas => "AMAZONAS",
                EnderecoVOEstado.Bahia => "BAHIA",
                EnderecoVOEstado.Ceara => "CEARA",
                EnderecoVOEstado.DistritoFederal => "DISTRITO_FEDERAL",
                EnderecoVOEstado.EspiritoSanto => "ESPIRITO_SANTO",
                EnderecoVOEstado.Goias => "GOIAS",
                EnderecoVOEstado.Maranhao => "MARANHAO",
                EnderecoVOEstado.MatoGrosso => "MATO_GROSSO",
                EnderecoVOEstado.MatoGrossoDoSul => "MATO_GROSSO_DO_SUL",
                EnderecoVOEstado.MinasGerais => "MINAS_GERAIS",
                EnderecoVOEstado.Para => "PARA",
                EnderecoVOEstado.Paraiba => "PARAIBA",
                EnderecoVOEstado.Parana => "PARANA",
                EnderecoVOEstado.Pernambuco => "PERNAMBUCO",
                EnderecoVOEstado.Piaui => "PIAUI",
                EnderecoVOEstado.RioDeJaneiro => "RIO_DE_JANEIRO",
                EnderecoVOEstado.RioGrandeDoNorte => "RIO_GRANDE_DO_NORTE",
                EnderecoVOEstado.RioGrandeDoSul => "RIO_GRANDE_DO_SUL",
                EnderecoVOEstado.Rondonia => "RONDONIA",
                EnderecoVOEstado.Roraima => "RORAIMA",
                EnderecoVOEstado.SantaCatarina => "SANTA_CATARINA",
                EnderecoVOEstado.SaoPaulo => "SAO_PAULO",
                EnderecoVOEstado.Sergipe => "SERGIPE",
                EnderecoVOEstado.Tocantins => "TOCANTINS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnderecoVOEstado? ToEnum(string value)
        {
            return value switch
            {
                "ACRE" => EnderecoVOEstado.Acre,
                "ALAGOAS" => EnderecoVOEstado.Alagoas,
                "AMAPA" => EnderecoVOEstado.Amapa,
                "AMAZONAS" => EnderecoVOEstado.Amazonas,
                "BAHIA" => EnderecoVOEstado.Bahia,
                "CEARA" => EnderecoVOEstado.Ceara,
                "DISTRITO_FEDERAL" => EnderecoVOEstado.DistritoFederal,
                "ESPIRITO_SANTO" => EnderecoVOEstado.EspiritoSanto,
                "GOIAS" => EnderecoVOEstado.Goias,
                "MARANHAO" => EnderecoVOEstado.Maranhao,
                "MATO_GROSSO" => EnderecoVOEstado.MatoGrosso,
                "MATO_GROSSO_DO_SUL" => EnderecoVOEstado.MatoGrossoDoSul,
                "MINAS_GERAIS" => EnderecoVOEstado.MinasGerais,
                "PARA" => EnderecoVOEstado.Para,
                "PARAIBA" => EnderecoVOEstado.Paraiba,
                "PARANA" => EnderecoVOEstado.Parana,
                "PERNAMBUCO" => EnderecoVOEstado.Pernambuco,
                "PIAUI" => EnderecoVOEstado.Piaui,
                "RIO_DE_JANEIRO" => EnderecoVOEstado.RioDeJaneiro,
                "RIO_GRANDE_DO_NORTE" => EnderecoVOEstado.RioGrandeDoNorte,
                "RIO_GRANDE_DO_SUL" => EnderecoVOEstado.RioGrandeDoSul,
                "RONDONIA" => EnderecoVOEstado.Rondonia,
                "RORAIMA" => EnderecoVOEstado.Roraima,
                "SANTA_CATARINA" => EnderecoVOEstado.SantaCatarina,
                "SAO_PAULO" => EnderecoVOEstado.SaoPaulo,
                "SERGIPE" => EnderecoVOEstado.Sergipe,
                "TOCANTINS" => EnderecoVOEstado.Tocantins,
                _ => null,
            };
        }
    }
}