
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsuarioPerfilViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfis")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PerfilViewModel>? Perfis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pessoa")]
        public global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModel? Pessoa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termo")]
        public global::Softplan.Soft.Suite.Dje.Sdk.UsuarioTermoViewModel? Termo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioPerfilViewModel" /> class.
        /// </summary>
        /// <param name="perfis"></param>
        /// <param name="pessoa"></param>
        /// <param name="termo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsuarioPerfilViewModel(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.PerfilViewModel>? perfis,
            global::Softplan.Soft.Suite.Dje.Sdk.PessoaPerfilViewModel? pessoa,
            global::Softplan.Soft.Suite.Dje.Sdk.UsuarioTermoViewModel? termo)
        {
            this.Perfis = perfis;
            this.Pessoa = pessoa;
            this.Termo = termo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioPerfilViewModel" /> class.
        /// </summary>
        public UsuarioPerfilViewModel()
        {
        }

    }
}