
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attemptValue")]
        public object? AttemptValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.ValidationMessageTypeJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage" /> class.
        /// </summary>
        /// <param name="attemptValue"></param>
        /// <param name="code"></param>
        /// <param name="description"></param>
        /// <param name="error"></param>
        /// <param name="field"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationMessage(
            object? attemptValue,
            string? code,
            string? description,
            bool? error,
            string? field,
            global::Softplan.Soft.Suite.Dje.Sdk.ValidationMessageType? type)
        {
            this.AttemptValue = attemptValue;
            this.Code = code;
            this.Description = description;
            this.Error = error;
            this.Field = field;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage" /> class.
        /// </summary>
        public ValidationMessage()
        {
        }

    }
}