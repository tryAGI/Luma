#nullable enable

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoModelOutputResolutionEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.VideoModelOutputResolutionEnum>
    {
        /// <inheritdoc />
        public override global::Luma.VideoModelOutputResolutionEnum Read(
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
                        return global::Luma.VideoModelOutputResolutionEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Luma.VideoModelOutputResolutionEnum)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.VideoModelOutputResolutionEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Luma.VideoModelOutputResolutionEnumExtensions.ToValueString(value));
        }
    }
}
