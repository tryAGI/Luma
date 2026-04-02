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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Luma.KeyframeDiscriminator>(ref readerCopy, options);

            global::Luma.GenerationReference? generation = default;
            if (discriminator?.Type == global::Luma.KeyframeDiscriminatorType.Generation)
            {
                generation = global::System.Text.Json.JsonSerializer.Deserialize<global::Luma.GenerationReference>(ref reader, options);
            }
            global::Luma.ImageReference? image = default;
            if (discriminator?.Type == global::Luma.KeyframeDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Luma.ImageReference>(ref reader, options);
            }

            var __value = new global::Luma.Keyframe(
                discriminator?.Type,
                generation,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Luma.Keyframe value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsGeneration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeof(global::Luma.GenerationReference), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Luma.ImageReference), options);
            }
        }
    }
}