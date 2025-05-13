#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpscaleVideoGenerationRequestGenerationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.UpscaleVideoGenerationRequestGenerationType>
    {
        /// <inheritdoc />
        public override global::Luma.UpscaleVideoGenerationRequestGenerationType Read(
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
                        return global::Luma.UpscaleVideoGenerationRequestGenerationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.UpscaleVideoGenerationRequestGenerationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Luma.UpscaleVideoGenerationRequestGenerationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.UpscaleVideoGenerationRequestGenerationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Luma.UpscaleVideoGenerationRequestGenerationTypeExtensions.ToValueString(value));
        }
    }
}
