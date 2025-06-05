#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReframeImageRequestGenerationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.ReframeImageRequestGenerationType>
    {
        /// <inheritdoc />
        public override global::Luma.ReframeImageRequestGenerationType Read(
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
                        return global::Luma.ReframeImageRequestGenerationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.ReframeImageRequestGenerationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Luma.ReframeImageRequestGenerationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.ReframeImageRequestGenerationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Luma.ReframeImageRequestGenerationTypeExtensions.ToValueString(value));
        }
    }
}
