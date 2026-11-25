
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscopoPermissaoVO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeAceitar")]
        public bool? PodeAceitar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoVO" /> class.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="podeAceitar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscopoPermissaoVO(
            string? cnpj,
            bool? podeAceitar)
        {
            this.Cnpj = cnpj;
            this.PodeAceitar = podeAceitar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscopoPermissaoVO" /> class.
        /// </summary>
        public EscopoPermissaoVO()
        {
        }

    }
}