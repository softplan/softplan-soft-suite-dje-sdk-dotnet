
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para alteração de uma pessoa física. Basta informar os campos que precisam ser editados.
    /// </summary>
    public sealed partial class AtualizarPessoaFisicaInputModel
    {
        /// <summary>
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Habilitada { get; set; }

        /// <summary>
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeSocial")]
        public string? NomeSocial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AtualizarPessoaFisicaInputModel" /> class.
        /// </summary>
        /// <param name="habilitada">
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AtualizarPessoaFisicaInputModel(
            bool habilitada,
            string? email,
            string? nomeSocial)
        {
            this.Email = email;
            this.Habilitada = habilitada;
            this.NomeSocial = nomeSocial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AtualizarPessoaFisicaInputModel" /> class.
        /// </summary>
        public AtualizarPessoaFisicaInputModel()
        {
        }

    }
}