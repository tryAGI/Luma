#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationRequestGenerationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.ImageGenerationRequestGenerationType?>
    {
        /// <inheritdoc />
        public override global::Luma.ImageGenerationRequestGenerationType? Read(
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
                        return global::Luma.ImageGenerationRequestGenerationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.ImageGenerationRequestGenerationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Luma.ImageGenerationRequestGenerationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.ImageGenerationRequestGenerationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Luma.ImageGenerationRequestGenerationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
