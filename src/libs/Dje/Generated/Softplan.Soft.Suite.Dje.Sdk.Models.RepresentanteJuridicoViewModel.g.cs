
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepresentanteJuridicoViewModel
    {
        /// <summary>
        /// Cargo representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public string? Cargo { get; set; }

        /// <summary>
        /// Email representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Email representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailAdicional")]
        public string? EmailAdicional { get; set; }

        /// <summary>
        /// Matrícula do representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        /// Nome representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Numero OAB representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroOAB")]
        public string? NumeroOAB { get; set; }

        /// <summary>
        /// Telefone representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// Uf OAB representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ufOAB")]
        public string? UfOAB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoViewModel" /> class.
        /// </summary>
        /// <param name="cargo">
        /// Cargo representante jurídico
        /// </param>
        /// <param name="email">
        /// Email representante jurídico
        /// </param>
        /// <param name="emailAdicional">
        /// Email representante jurídico
        /// </param>
        /// <param name="matricula">
        /// Matrícula do representante jurídico
        /// </param>
        /// <param name="nome">
        /// Nome representante jurídico
        /// </param>
        /// <param name="numeroOAB">
        /// Numero OAB representante jurídico
        /// </param>
        /// <param name="telefone">
        /// Telefone representante jurídico
        /// </param>
        /// <param name="ufOAB">
        /// Uf OAB representante jurídico
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepresentanteJuridicoViewModel(
            string? cargo,
            string? email,
            string? emailAdicional,
            string? matricula,
            string? nome,
            string? numeroOAB,
            string? telefone,
            string? ufOAB)
        {
            this.Cargo = cargo;
            this.Email = email;
            this.EmailAdicional = emailAdicional;
            this.Matricula = matricula;
            this.Nome = nome;
            this.NumeroOAB = numeroOAB;
            this.Telefone = telefone;
            this.UfOAB = ufOAB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoViewModel" /> class.
        /// </summary>
        public RepresentanteJuridicoViewModel()
        {
        }

    }
}