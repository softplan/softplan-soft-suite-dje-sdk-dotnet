
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepresentanteJuridicoVO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public string? Cargo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailAdicional")]
        public string? EmailAdicional { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailSpecification")]
        public global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? EmailSpecification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroOAB")]
        public string? NumeroOAB { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ufOAB")]
        public string? UfOAB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoVO" /> class.
        /// </summary>
        /// <param name="cargo"></param>
        /// <param name="email"></param>
        /// <param name="emailAdicional"></param>
        /// <param name="emailSpecification"></param>
        /// <param name="matricula"></param>
        /// <param name="nome"></param>
        /// <param name="numeroOAB"></param>
        /// <param name="telefone"></param>
        /// <param name="ufOAB"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepresentanteJuridicoVO(
            string? cargo,
            string? email,
            string? emailAdicional,
            global::Softplan.Soft.Suite.Dje.Sdk.EmailSpecification? emailSpecification,
            string? matricula,
            string? nome,
            string? numeroOAB,
            string? telefone,
            string? ufOAB)
        {
            this.Cargo = cargo;
            this.Email = email;
            this.EmailAdicional = emailAdicional;
            this.EmailSpecification = emailSpecification;
            this.Matricula = matricula;
            this.Nome = nome;
            this.NumeroOAB = numeroOAB;
            this.Telefone = telefone;
            this.UfOAB = ufOAB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoVO" /> class.
        /// </summary>
        public RepresentanteJuridicoVO()
        {
        }

    }
}