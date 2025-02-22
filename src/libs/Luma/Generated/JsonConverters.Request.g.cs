#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Luma.JsonConverters
{
    /// <inheritdoc />
    public class RequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Luma.Request>
    {
        /// <inheritdoc />
        public override global::Luma.Request Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.GenerationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.GenerationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.GenerationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Luma.GenerationRequest? video = default;
            if (discriminator?.GenerationType == global::Luma.GenerationRequestDiscriminatorGenerationType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.GenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.GenerationRequest)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Luma.ImageGenerationRequest? image = default;
            if (discriminator?.GenerationType == global::Luma.GenerationRequestDiscriminatorGenerationType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.ImageGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.ImageGenerationRequest)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Luma.UpscaleVideoGenerationRequest? upscaleVideo = default;
            if (discriminator?.GenerationType == global::Luma.GenerationRequestDiscriminatorGenerationType.UpscaleVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.UpscaleVideoGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.UpscaleVideoGenerationRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Luma.UpscaleVideoGenerationRequest)}");
                upscaleVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Luma.Request(
                discriminator?.GenerationType,
                video,
                image,
                upscaleVideo
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.GenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.GenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.ImageGenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.ImageGenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsUpscaleVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Luma.UpscaleVideoGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Luma.UpscaleVideoGenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Luma.UpscaleVideoGenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpscaleVideo, typeInfo);
            }
        }
    }
}