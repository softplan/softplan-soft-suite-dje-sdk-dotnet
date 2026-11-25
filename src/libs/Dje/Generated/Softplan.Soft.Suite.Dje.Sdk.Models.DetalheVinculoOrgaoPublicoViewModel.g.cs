
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetalheVinculoOrgaoPublicoViewModel
    {
        /// <summary>
        /// Numero do Cadastro Nacional de Pessoas Juridicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpjSolicitada")]
        public string? CnpjSolicitada { get; set; }

        /// <summary>
        /// tenantId da pessoa juridica - Ativa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idSolicitada")]
        public long? IdSolicitada { get; set; }

        /// <summary>
        /// Id do vinculo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idVinculo")]
        public long? IdVinculo { get; set; }

        /// <summary>
        /// Razao social
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocialSolicitada")]
        public string? RazaoSocialSolicitada { get; set; }

        /// <summary>
        /// Indica se o CNPJ solicitado e Sociedade de Economia Mista
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semSolicitada")]
        public bool? SemSolicitada { get; set; }

        /// <summary>
        /// Situacao do vinculo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.DetalheVinculoOrgaoPublicoViewModelSituacaoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModelSituacao? Situacao { get; set; }

        /// <summary>
        /// tenantId da pessoa juridica - Ativa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantIdSolicitada")]
        public global::System.Guid? TenantIdSolicitada { get; set; }

        /// <summary>
        /// Unidade Federativa - UF do orgao publico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Data da criacao do vinculo, em formato ISO8601<br/>
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
        /// Initializes a new instance of the <see cref="DetalheVinculoOrgaoPublicoViewModel" /> class.
        /// </summary>
        /// <param name="cnpjSolicitada">
        /// Numero do Cadastro Nacional de Pessoas Juridicas da Receita Federal
        /// </param>
        /// <param name="idSolicitada">
        /// tenantId da pessoa juridica - Ativa
        /// </param>
        /// <param name="idVinculo">
        /// Id do vinculo
        /// </param>
        /// <param name="razaoSocialSolicitada">
        /// Razao social
        /// </param>
        /// <param name="semSolicitada">
        /// Indica se o CNPJ solicitado e Sociedade de Economia Mista
        /// </param>
        /// <param name="situacao">
        /// Situacao do vinculo
        /// </param>
        /// <param name="tenantIdSolicitada">
        /// tenantId da pessoa juridica - Ativa
        /// </param>
        /// <param name="uf">
        /// Unidade Federativa - UF do orgao publico
        /// </param>
        /// <param name="vinculadoEm">
        /// Data da criacao do vinculo, em formato ISO8601<br/>
        /// Example: 2021-06-09T13:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetalheVinculoOrgaoPublicoViewModel(
            string? cnpjSolicitada,
            long? idSolicitada,
            long? idVinculo,
            string? razaoSocialSolicitada,
            bool? semSolicitada,
            global::Softplan.Soft.Suite.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModelSituacao? situacao,
            global::System.Guid? tenantIdSolicitada,
            string? uf,
            string? vinculadoEm)
        {
            this.CnpjSolicitada = cnpjSolicitada;
            this.IdSolicitada = idSolicitada;
            this.IdVinculo = idVinculo;
            this.RazaoSocialSolicitada = razaoSocialSolicitada;
            this.SemSolicitada = semSolicitada;
            this.Situacao = situacao;
            this.TenantIdSolicitada = tenantIdSolicitada;
            this.Uf = uf;
            this.VinculadoEm = vinculadoEm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheVinculoOrgaoPublicoViewModel" /> class.
        /// </summary>
        public DetalheVinculoOrgaoPublicoViewModel()
        {
        }

    }
}