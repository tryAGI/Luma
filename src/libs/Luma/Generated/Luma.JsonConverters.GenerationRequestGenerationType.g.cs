#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationRequestGenerationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.GenerationRequestGenerationType>
    {
        /// <inheritdoc />
        public override global::Luma.GenerationRequestGenerationType Read(
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
                        return global::Luma.GenerationRequestGenerationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.GenerationRequestGenerationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Luma.GenerationRequestGenerationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.GenerationRequestGenerationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Luma.GenerationRequestGenerationTypeExtensions.ToValueString(value));
        }
    }
}
