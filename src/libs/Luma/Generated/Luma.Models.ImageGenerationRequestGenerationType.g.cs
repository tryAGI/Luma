
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    public enum ImageGenerationRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestGenerationType value)
        {
            return value switch
            {
                ImageGenerationRequestGenerationType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageGenerationRequestGenerationType.Image,
                _ => null,
            };
        }
    }
}