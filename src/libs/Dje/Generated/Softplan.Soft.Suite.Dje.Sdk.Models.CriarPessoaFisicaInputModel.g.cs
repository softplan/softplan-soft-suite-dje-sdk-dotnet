
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    /// DTO com os dados para inclusão de uma pessoa física
    /// </summary>
    public sealed partial class CriarPessoaFisicaInputModel
    {
        /// <summary>
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cpf { get; set; }

        /// <summary>
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </summary>
        /// <example>TODAS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deveNotificar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.CriarPessoaFisicaInputModelDeveNotificarJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.CriarPessoaFisicaInputModelDeveNotificar? DeveNotificar { get; set; }

        /// <summary>
        /// E-mail (endereço eletrônico) da pessoa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Hash do termo de aceite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashTermo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashTermo { get; set; }

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
        /// Initializes a new instance of the <see cref="CriarPessoaFisicaInputModel" /> class.
        /// </summary>
        /// <param name="cpf">
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </param>
        /// <param name="hashTermo">
        /// Hash do termo de aceite
        /// </param>
        /// <param name="deveNotificar">
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
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
        public CriarPessoaFisicaInputModel(
            string cpf,
            string hashTermo,
            global::Softplan.Soft.Suite.Dje.Sdk.CriarPessoaFisicaInputModelDeveNotificar? deveNotificar,
            string? email,
            string? nomeSocial)
        {
            this.Cpf = cpf ?? throw new global::System.ArgumentNullException(nameof(cpf));
            this.DeveNotificar = deveNotificar;
            this.Email = email;
            this.HashTermo = hashTermo ?? throw new global::System.ArgumentNullException(nameof(hashTermo));
            this.NomeSocial = nomeSocial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriarPessoaFisicaInputModel" /> class.
        /// </summary>
        public CriarPessoaFisicaInputModel()
        {
        }

    }
}