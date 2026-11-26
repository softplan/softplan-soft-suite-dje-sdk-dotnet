
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeDeletar")]
        public bool? PodeDeletar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeEditar")]
        public bool? PodeEditar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeEscrever")]
        public bool? PodeEscrever { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podeLer")]
        public bool? PodeLer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="podeDeletar"></param>
        /// <param name="podeEditar"></param>
        /// <param name="podeEscrever"></param>
        /// <param name="podeLer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IResource(
            long? id,
            string? name,
            bool? podeDeletar,
            bool? podeEditar,
            bool? podeEscrever,
            bool? podeLer)
        {
            this.Id = id;
            this.Name = name;
            this.PodeDeletar = podeDeletar;
            this.PodeEditar = podeEditar;
            this.PodeEscrever = podeEscrever;
            this.PodeLer = podeLer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IResource" /> class.
        /// </summary>
        public IResource()
        {
        }

    }
}