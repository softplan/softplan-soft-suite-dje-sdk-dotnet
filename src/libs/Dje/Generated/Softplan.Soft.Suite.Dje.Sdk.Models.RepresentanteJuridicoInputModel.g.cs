
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepresentanteJuridicoInputModel
    {
        /// <summary>
        /// Ocupação (cargo) do representante júridico na empresa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cargo { get; set; }

        /// <summary>
        /// E-mail (correio eletrônico) do representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) opcional do representante jurídico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailAdicional")]
        public string? EmailAdicional { get; set; }

        /// <summary>
        /// Número de matrícula do representante júridico na empresa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matricula")]
        public string? Matricula { get; set; }

        /// <summary>
        /// Nome do representante júridico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nome { get; set; }

        /// <summary>
        /// Número OAB de representante júridico na empresa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroOAB")]
        public string? NumeroOAB { get; set; }

        /// <summary>
        /// Telefone do representante júridico
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telefone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Telefone { get; set; }

        /// <summary>
        /// UF OAB de representante júridico na empresa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ufOAB")]
        public string? UfOAB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoInputModel" /> class.
        /// </summary>
        /// <param name="cargo">
        /// Ocupação (cargo) do representante júridico na empresa
        /// </param>
        /// <param name="nome">
        /// Nome do representante júridico
        /// </param>
        /// <param name="telefone">
        /// Telefone do representante júridico
        /// </param>
        /// <param name="email">
        /// E-mail (correio eletrônico) do representante jurídico
        /// </param>
        /// <param name="emailAdicional">
        /// E-mail (endereço eletrônico) opcional do representante jurídico
        /// </param>
        /// <param name="matricula">
        /// Número de matrícula do representante júridico na empresa
        /// </param>
        /// <param name="numeroOAB">
        /// Número OAB de representante júridico na empresa
        /// </param>
        /// <param name="ufOAB">
        /// UF OAB de representante júridico na empresa
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepresentanteJuridicoInputModel(
            string cargo,
            string nome,
            string telefone,
            string? email,
            string? emailAdicional,
            string? matricula,
            string? numeroOAB,
            string? ufOAB)
        {
            this.Cargo = cargo ?? throw new global::System.ArgumentNullException(nameof(cargo));
            this.Email = email;
            this.EmailAdicional = emailAdicional;
            this.Matricula = matricula;
            this.Nome = nome ?? throw new global::System.ArgumentNullException(nameof(nome));
            this.NumeroOAB = numeroOAB;
            this.Telefone = telefone ?? throw new global::System.ArgumentNullException(nameof(telefone));
            this.UfOAB = ufOAB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteJuridicoInputModel" /> class.
        /// </summary>
        public RepresentanteJuridicoInputModel()
        {
        }

    }
}