#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public class KeyframeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.Keyframe>
    {
        /// <inheritdoc />
        public override global::Luma.Keyframe Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.KeyframeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.KeyframeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.KeyframeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Luma.GenerationReference? generation = default;
            if (discriminator?.Type == global::Luma.KeyframeDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.GenerationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.GenerationReference)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Luma.ImageReference? image = default;
            if (discriminator?.Type == global::Luma.KeyframeDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.ImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.ImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.ImageReference)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Luma.Keyframe(
                discriminator?.Type,
                generation,
                image
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.Keyframe value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.GenerationReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.GenerationReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.ImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.ImageReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.ImageReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}