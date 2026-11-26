
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para inclusão de uma pessoa jurídica
    /// </summary>
    public sealed partial class AdicionarMatrizInputModel
    {
        /// <summary>
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cnpj { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Hash termo de aceite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashTermo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashTermo { get; set; }

        /// <summary>
        /// Informações do representante júridico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representanteJuridico")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoInputModel RepresentanteJuridico { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarMatrizInputModel" /> class.
        /// </summary>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="hashTermo">
        /// Hash termo de aceite
        /// </param>
        /// <param name="representanteJuridico">
        /// Informações do representante júridico
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdicionarMatrizInputModel(
            string cnpj,
            string hashTermo,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoInputModel representanteJuridico,
            string? email)
        {
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
            this.Email = email;
            this.HashTermo = hashTermo ?? throw new global::System.ArgumentNullException(nameof(hashTermo));
            this.RepresentanteJuridico = representanteJuridico ?? throw new global::System.ArgumentNullException(nameof(representanteJuridico));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarMatrizInputModel" /> class.
        /// </summary>
        public AdicionarMatrizInputModel()
        {
        }

    }
}