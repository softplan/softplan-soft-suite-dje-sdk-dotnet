
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para vincular uma orgao solicitado
    /// </summary>
    public sealed partial class VincularOrgaoPublicoInputModel
    {
        /// <summary>
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cnpj { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VincularOrgaoPublicoInputModel" /> class.
        /// </summary>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VincularOrgaoPublicoInputModel(
            string cnpj)
        {
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VincularOrgaoPublicoInputModel" /> class.
        /// </summary>
        public VincularOrgaoPublicoInputModel()
        {
        }

    }
}