#nullable enable

namespace Softplan.Soft.Suite.Dje.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao>
    {
        /// <inheritdoc />
        public override global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Softplan.Soft.Suite.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoExtensions.ToValueString(value));
        }
    }
}
