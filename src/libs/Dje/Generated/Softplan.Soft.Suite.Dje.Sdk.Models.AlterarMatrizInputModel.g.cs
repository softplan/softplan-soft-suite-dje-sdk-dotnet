
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlterarMatrizInputModel
    {
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
        /// Informações do representante júridico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representanteJuridico")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.EditarRepresentanteJuridicoInputModel RepresentanteJuridico { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlterarMatrizInputModel" /> class.
        /// </summary>
        /// <param name="representanteJuridico">
        /// Informações do representante júridico
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
        public AlterarMatrizInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.EditarRepresentanteJuridicoInputModel representanteJuridico,
            string? email,
            global::Softplan.Soft.Suite.Dje.Sdk.EditarEnderecoInputModel? endereco)
        {
            this.Email = email;
            this.Endereco = endereco;
            this.RepresentanteJuridico = representanteJuridico ?? throw new global::System.ArgumentNullException(nameof(representanteJuridico));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlterarMatrizInputModel" /> class.
        /// </summary>
        public AlterarMatrizInputModel()
        {
        }

    }
}