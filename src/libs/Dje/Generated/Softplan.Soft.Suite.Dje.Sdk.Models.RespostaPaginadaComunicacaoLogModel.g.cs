
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RespostaPaginadaComunicacaoLogModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel>? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public global::Softplan.Soft.Suite.Dje.Sdk.Paginacao? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaPaginadaComunicacaoLogModel" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="page"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RespostaPaginadaComunicacaoLogModel(
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoLogModel>? data,
            global::Softplan.Soft.Suite.Dje.Sdk.Paginacao? page)
        {
            this.Data = data;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaPaginadaComunicacaoLogModel" /> class.
        /// </summary>
        public RespostaPaginadaComunicacaoLogModel()
        {
        }

    }
}