
#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationRequestDiscriminatorGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        UpscaleVideo,
        /// <summary>
        /// 
        /// </summary>
        AddAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestDiscriminatorGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestDiscriminatorGenerationType value)
        {
            return value switch
            {
                GenerationRequestDiscriminatorGenerationType.Video => "video",
                GenerationRequestDiscriminatorGenerationType.Image => "image",
                GenerationRequestDiscriminatorGenerationType.UpscaleVideo => "upscale_video",
                GenerationRequestDiscriminatorGenerationType.AddAudio => "add_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestDiscriminatorGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "video" => GenerationRequestDiscriminatorGenerationType.Video,
                "image" => GenerationRequestDiscriminatorGenerationType.Image,
                "upscale_video" => GenerationRequestDiscriminatorGenerationType.UpscaleVideo,
                "add_audio" => GenerationRequestDiscriminatorGenerationType.AddAudio,
                _ => null,
            };
        }
    }
}