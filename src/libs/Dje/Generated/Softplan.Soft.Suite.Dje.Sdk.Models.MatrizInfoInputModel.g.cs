
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MatrizInfoInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="MatrizInfoInputModel" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="email"></param>
        /// <param name="representanteJuridico"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatrizInfoInputModel(
            string cnpj,
            string email,
            global::Softplan.Soft.Suite.Dje.Sdk.RepresentanteJuridicoInputModel representanteJuridico)
        {
            this.Cnpj = cnpj ?? throw new global::System.ArgumentNullException(nameof(cnpj));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.RepresentanteJuridico = representanteJuridico ?? throw new global::System.ArgumentNullException(nameof(representanteJuridico));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrizInfoInputModel" /> class.
        /// </summary>
        public MatrizInfoInputModel()
        {
        }

    }
}