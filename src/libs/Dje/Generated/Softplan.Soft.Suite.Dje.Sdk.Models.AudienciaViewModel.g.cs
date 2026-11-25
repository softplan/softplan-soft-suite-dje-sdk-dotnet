
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudienciaViewModel
    {
        /// <summary>
        /// Data da audiência agendada<br/>
        /// Example: 2023-01-01
        /// </summary>
        /// <example>2023-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Virtual ou presencial
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formato")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelFormatoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelFormato? Formato { get; set; }

        /// <summary>
        /// Hora da audiência agendada<br/>
        /// Example: 13:00:00Z
        /// </summary>
        /// <example>13:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hora")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hora { get; set; }

        /// <summary>
        /// Inicial, UNA, Instrução, Julgamento
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.Dje.Sdk.JsonConverters.AudienciaViewModelTipoJsonConverter))]
        public global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelTipo? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudienciaViewModel" /> class.
        /// </summary>
        /// <param name="data">
        /// Data da audiência agendada<br/>
        /// Example: 2023-01-01
        /// </param>
        /// <param name="hora">
        /// Hora da audiência agendada<br/>
        /// Example: 13:00:00Z
        /// </param>
        /// <param name="formato">
        /// Virtual ou presencial
        /// </param>
        /// <param name="tipo">
        /// Inicial, UNA, Instrução, Julgamento
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudienciaViewModel(
            string data,
            string hora,
            global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelFormato? formato,
            global::Softplan.Soft.Suite.Dje.Sdk.AudienciaViewModelTipo? tipo)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Formato = formato;
            this.Hora = hora ?? throw new global::System.ArgumentNullException(nameof(hora));
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudienciaViewModel" /> class.
        /// </summary>
        public AudienciaViewModel()
        {
        }

    }
}