
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    public enum ImageReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageReferenceType value)
        {
            return value switch
            {
                ImageReferenceType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageReferenceType.Image,
                _ => null,
            };
        }
    }
}