#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public class VideoModelOutputResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.VideoModelOutputResolution>
    {
        /// <inheritdoc />
        public override global::Luma.VideoModelOutputResolution Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Luma.VideoModelOutputResolutionEnum? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.VideoModelOutputResolutionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.VideoModelOutputResolutionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.VideoModelOutputResolutionEnum).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            string? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Luma.VideoModelOutputResolution(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.VideoModelOutputResolutionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.VideoModelOutputResolutionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.VideoModelOutputResolutionEnum).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.VideoModelOutputResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.VideoModelOutputResolutionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.VideoModelOutputResolutionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.VideoModelOutputResolutionEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}