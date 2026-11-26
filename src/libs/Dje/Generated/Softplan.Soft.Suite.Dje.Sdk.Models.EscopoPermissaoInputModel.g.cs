
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscopoPermissaoInputModel
    {
        /// <summary>
        /// Ação a ser executada no registro<br/>
        /// Example: ADICIONAR
        /// </summary>
        /// <example>ADICIONAR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acao")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.EscopoPermissaoInputModelAcaoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModelAcao Acao { get; set; }

        /// <summary>
        /// CNPJ da empresa que a pessoa terá acesso<br/>
        /// Example: 42323176000124
        /// </summary>
        /// <example>42323176000124</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cnpj { get; set; }

        /// <summary>
        /// Se a pessoa poderá dar aceite(ciente) a uma comunicação do CNPJ acima<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeAceitar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PodeAceitar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoInputModel" /> class.
        /// </summary>
        /// <param name="acao">
        /// Ação a ser executada no registro<br/>
        /// Example: ADICIONAR
        /// </param>
        /// <param name="cnpj">
        /// CNPJ da empresa que a pessoa terá acesso<br/>
        /// Example: 42323176000124
        /// </param>
        /// <param name="podeAceitar">
        /// Se a pessoa poderá dar aceite(ciente) a uma comunicação do CNPJ acima<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscopoPermissaoInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.EscopoPermissaoInputModelAcao acao,
            string cnpj,
            bool podeAceitar)
        {
            this.Acao = acao;
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
            this.PodeAceitar = podeAceitar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoInputModel" /> class.
        /// </summary>
        public EscopoPermissaoInputModel()
        {
        }

    }
}