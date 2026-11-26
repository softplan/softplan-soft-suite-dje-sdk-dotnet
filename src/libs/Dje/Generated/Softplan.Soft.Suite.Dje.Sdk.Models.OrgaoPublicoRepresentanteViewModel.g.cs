
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgaoPublicoRepresentanteViewModel
    {
        /// <summary>
        /// CNPJ do representante
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        /// Id do orgão público representante
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrgaoPublico")]
        public long? IdOrgaoPublico { get; set; }

        /// <summary>
        /// Id do vinculo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idVinculo")]
        public long? IdVinculo { get; set; }

        /// <summary>
        /// Razão social do representante
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        /// Situacao do vinculo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.OrgaoPublicoRepresentanteViewModelSituacaoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModelSituacao? Situacao { get; set; }

        /// <summary>
        /// Unidade federativa do representante
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Data de criação do vinculo em formato ISO8601<br/>
        /// Example: 2021-06-09T13:00:00Z
        /// </summary>
        /// <example>2021-06-09T13:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vinculadoEm")]
        public string? VinculadoEm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoPublicoRepresentanteViewModel" /> class.
        /// </summary>
        /// <param name="cnpj">
        /// CNPJ do representante
        /// </param>
        /// <param name="idOrgaoPublico">
        /// Id do orgão público representante
        /// </param>
        /// <param name="idVinculo">
        /// Id do vinculo
        /// </param>
        /// <param name="razaoSocial">
        /// Razão social do representante
        /// </param>
        /// <param name="situacao">
        /// Situacao do vinculo
        /// </param>
        /// <param name="uf">
        /// Unidade federativa do representante
        /// </param>
        /// <param name="vinculadoEm">
        /// Data de criação do vinculo em formato ISO8601<br/>
        /// Example: 2021-06-09T13:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoPublicoRepresentanteViewModel(
            string? cnpj,
            long? idOrgaoPublico,
            long? idVinculo,
            string? razaoSocial,
            global::Softplan.Soft.Suite.Dje.Sdk.OrgaoPublicoRepresentanteViewModelSituacao? situacao,
            string? uf,
            string? vinculadoEm)
        {
            this.Cnpj = cnpj;
            this.IdOrgaoPublico = idOrgaoPublico;
            this.IdVinculo = idVinculo;
            this.RazaoSocial = razaoSocial;
            this.Situacao = situacao;
            this.Uf = uf;
            this.VinculadoEm = vinculadoEm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoPublicoRepresentanteViewModel" /> class.
        /// </summary>
        public OrgaoPublicoRepresentanteViewModel()
        {
        }

    }
}