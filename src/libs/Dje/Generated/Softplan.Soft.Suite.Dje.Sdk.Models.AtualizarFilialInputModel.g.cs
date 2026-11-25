
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// Propriedades alteraveis de filial
    /// </summary>
    public sealed partial class AtualizarFilialInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

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
        /// Initializes a new instance of the <see cref="AtualizarFilialInputModel" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="endereco">
        /// Endereço da pessoa jurídica
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AtualizarFilialInputModel(
            string email,
            global::Softplan.Soft.Suite.Dje.Sdk.EditarEnderecoInputModel? endereco)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Endereco = endereco;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AtualizarFilialInputModel" /> class.
        /// </summary>
        public AtualizarFilialInputModel()
        {
        }

    }
}