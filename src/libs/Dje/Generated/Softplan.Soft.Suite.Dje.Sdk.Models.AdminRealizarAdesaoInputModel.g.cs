
#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminRealizarAdesaoInputModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administradorInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.AdministradorInforInputModel AdministradorInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrizInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Softplan.Soft.Suite.Dje.Sdk.MatrizInfoInputModel MatrizInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRealizarAdesaoInputModel" /> class.
        /// </summary>
        /// <param name="administradorInfo"></param>
        /// <param name="matrizInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminRealizarAdesaoInputModel(
            global::Softplan.Soft.Suite.Dje.Sdk.AdministradorInforInputModel administradorInfo,
            global::Softplan.Soft.Suite.Dje.Sdk.MatrizInfoInputModel matrizInfo)
        {
            this.AdministradorInfo = administradorInfo ?? throw new global::System.ArgumentNullException(nameof(administradorInfo));
            this.MatrizInfo = matrizInfo ?? throw new global::System.ArgumentNullException(nameof(matrizInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRealizarAdesaoInputModel" /> class.
        /// </summary>
        public AdminRealizarAdesaoInputModel()
        {
        }

    }
}