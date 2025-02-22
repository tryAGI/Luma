
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: upscale_video
    /// </summary>
    public enum UpscaleVideoGenerationRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        UpscaleVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleVideoGenerationRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleVideoGenerationRequestGenerationType value)
        {
            return value switch
            {
                UpscaleVideoGenerationRequestGenerationType.UpscaleVideo => "upscale_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleVideoGenerationRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "upscale_video" => UpscaleVideoGenerationRequestGenerationType.UpscaleVideo,
                _ => null,
            };
        }
    }
}