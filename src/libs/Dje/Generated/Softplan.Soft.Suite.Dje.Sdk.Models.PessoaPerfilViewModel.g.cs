
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PessoaPerfilViewModel
    {
        /// <summary>
        /// Se ativo ou não
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpfCnpj")]
        public string? CpfCnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoPublico")]
        public bool? OrgaoPublico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCadastro")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.PessoaPerfilViewModelStatusCadastroJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModelStatusCadastro? StatusCadastro { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        public string? TipoPessoa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaPerfilViewModel" /> class.
        /// </summary>
        /// <param name="ativo">
        /// Se ativo ou não
        /// </param>
        /// <param name="cpfCnpj"></param>
        /// <param name="habilitada"></param>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="orgaoPublico"></param>
        /// <param name="statusCadastro"></param>
        /// <param name="tipoPessoa"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PessoaPerfilViewModel(
            bool? ativo,
            string? cpfCnpj,
            bool? habilitada,
            long? id,
            string? nome,
            bool? orgaoPublico,
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModelStatusCadastro? statusCadastro,
            string? tipoPessoa)
        {
            this.Ativo = ativo;
            this.CpfCnpj = cpfCnpj;
            this.Habilitada = habilitada;
            this.Id = id;
            this.Nome = nome;
            this.OrgaoPublico = orgaoPublico;
            this.StatusCadastro = statusCadastro;
            this.TipoPessoa = tipoPessoa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaPerfilViewModel" /> class.
        /// </summary>
        public PessoaPerfilViewModel()
        {
        }

    }
}