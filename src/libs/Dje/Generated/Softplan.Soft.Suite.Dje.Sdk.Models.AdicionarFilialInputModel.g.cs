
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para inclusão de uma filial
    /// </summary>
    public sealed partial class AdicionarFilialInputModel
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
        /// Endereço da pessoa jurídica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endereco")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EditarEnderecoInputModel? Endereco { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarFilialInputModel" /> class.
        /// </summary>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="endereco">
        /// Endereço da pessoa jurídica
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdicionarFilialInputModel(
            string cnpj,
            string? email,
            global::Softplan.Soft.Suite.Dje.Sdk.EditarEnderecoInputModel? endereco)
        {
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
            this.Email = email;
            this.Endereco = endereco;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarFilialInputModel" /> class.
        /// </summary>
        public AdicionarFilialInputModel()
        {
        }

    }
}