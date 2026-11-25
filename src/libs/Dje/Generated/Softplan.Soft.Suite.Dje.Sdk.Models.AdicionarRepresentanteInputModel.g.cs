
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdicionarRepresentanteInputModel
    {
        /// <summary>
        /// Email do usuário
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Função do usuário
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funcao")]
        public string? Funcao { get; set; }

        /// <summary>
        /// Matricula do usuário
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        /// Nome social do usuário
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeSocial")]
        public string? NomeSocial { get; set; }

        /// <summary>
        /// Telefone do usuário
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarRepresentanteInputModel" /> class.
        /// </summary>
        /// <param name="email">
        /// Email do usuário
        /// </param>
        /// <param name="funcao">
        /// Função do usuário
        /// </param>
        /// <param name="matricula">
        /// Matricula do usuário
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social do usuário
        /// </param>
        /// <param name="telefone">
        /// Telefone do usuário
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdicionarRepresentanteInputModel(
            string? email,
            string? funcao,
            string? matricula,
            string? nomeSocial,
            string? telefone)
        {
            this.Email = email;
            this.Funcao = funcao;
            this.Matricula = matricula;
            this.NomeSocial = nomeSocial;
            this.Telefone = telefone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionarRepresentanteInputModel" /> class.
        /// </summary>
        public AdicionarRepresentanteInputModel()
        {
        }

    }
}