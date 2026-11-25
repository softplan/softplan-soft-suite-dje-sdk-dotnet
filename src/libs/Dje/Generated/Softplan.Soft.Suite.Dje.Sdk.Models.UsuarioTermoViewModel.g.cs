
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsuarioTermoViewModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existeNovaVersao")]
        public bool? ExisteNovaVersao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("novaVersaoTermo")]
        public string? NovaVersaoTermo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termoAindaNaoAceito")]
        public string? TermoAindaNaoAceito { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ultimaVersao")]
        public string? UltimaVersao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTermoViewModel" /> class.
        /// </summary>
        /// <param name="existeNovaVersao"></param>
        /// <param name="novaVersaoTermo"></param>
        /// <param name="termoAindaNaoAceito"></param>
        /// <param name="ultimaVersao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsuarioTermoViewModel(
            bool? existeNovaVersao,
            string? novaVersaoTermo,
            string? termoAindaNaoAceito,
            string? ultimaVersao)
        {
            this.ExisteNovaVersao = existeNovaVersao;
            this.NovaVersaoTermo = novaVersaoTermo;
            this.TermoAindaNaoAceito = termoAindaNaoAceito;
            this.UltimaVersao = ultimaVersao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTermoViewModel" /> class.
        /// </summary>
        public UsuarioTermoViewModel()
        {
        }

    }
}