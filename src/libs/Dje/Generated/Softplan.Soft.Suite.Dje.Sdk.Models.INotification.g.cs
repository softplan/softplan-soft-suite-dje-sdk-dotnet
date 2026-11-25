
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class INotification
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeNotification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.INotificationTypeNotificationJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.INotificationTypeNotification? TypeNotification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INotification" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="typeNotification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INotification(
            string? code,
            string? message,
            global::Softplan.Soft.Suite.Dje.Sdk.INotificationTypeNotification? typeNotification)
        {
            this.Code = code;
            this.Message = message;
            this.TypeNotification = typeNotification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INotification" /> class.
        /// </summary>
        public INotification()
        {
        }

    }
}