
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para editar uma solicitação de vínculo.
    /// </summary>
    public sealed partial class EditarEmailSolicitacaoVinculoInputModel
    {
        /// <summary>
        /// E-mail da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditarEmailSolicitacaoVinculoInputModel" /> class.
        /// </summary>
        /// <param name="email">
        /// E-mail da pessoa
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditarEmailSolicitacaoVinculoInputModel(
            string? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditarEmailSolicitacaoVinculoInputModel" /> class.
        /// </summary>
        public EditarEmailSolicitacaoVinculoInputModel()
        {
        }

    }
}