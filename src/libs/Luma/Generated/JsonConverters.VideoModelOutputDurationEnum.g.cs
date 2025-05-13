#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoModelOutputDurationEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.VideoModelOutputDurationEnum>
    {
        /// <inheritdoc />
        public override global::Luma.VideoModelOutputDurationEnum Read(
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
                        return global::Luma.VideoModelOutputDurationEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.VideoModelOutputDurationEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Luma.VideoModelOutputDurationEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.VideoModelOutputDurationEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Luma.VideoModelOutputDurationEnumExtensions.ToValueString(value));
        }
    }
}
