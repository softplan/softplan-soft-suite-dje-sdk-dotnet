
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Pageable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::System.Collections.Generic.IList<string>? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pageable" /> class.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="sort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pageable(
            int? page,
            int? size,
            global::System.Collections.Generic.IList<string>? sort)
        {
            this.Page = page;
            this.Size = size;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pageable" /> class.
        /// </summary>
        public Pageable()
        {
        }

    }
}