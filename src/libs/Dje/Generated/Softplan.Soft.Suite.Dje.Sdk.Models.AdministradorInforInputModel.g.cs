
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdministradorInforInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funcao")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Funcao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeSocial")]
        public string? NomeSocial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oab")]
        public global::Softplan.Soft.Suite.Dje.Sdk.OABInputModel? Oab { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministradorInforInputModel" /> class.
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="funcao"></param>
        /// <param name="email"></param>
        /// <param name="matricula"></param>
        /// <param name="nomeSocial"></param>
        /// <param name="oab"></param>
        /// <param name="telefone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdministradorInforInputModel(
            string cpf,
            string funcao,
            string? email,
            string? matricula,
            string? nomeSocial,
            global::Softplan.Soft.Suite.Dje.Sdk.OABInputModel? oab,
            string? telefone)
        {
            this.Cpf = cpf ?? throw new global::System.ArgumentNullException(nameof(cpf));
            this.Email = email;
            this.Funcao = funcao ?? throw new global::System.ArgumentNullException(nameof(funcao));
            this.Matricula = matricula;
            this.NomeSocial = nomeSocial;
            this.Oab = oab;
            this.Telefone = telefone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministradorInforInputModel" /> class.
        /// </summary>
        public AdministradorInforInputModel()
        {
        }

    }
}