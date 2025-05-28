
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: reframe_image
    /// </summary>
    public enum ReframeImageRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        ReframeImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReframeImageRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeImageRequestGenerationType value)
        {
            return value switch
            {
                ReframeImageRequestGenerationType.ReframeImage => "reframe_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeImageRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "reframe_image" => ReframeImageRequestGenerationType.ReframeImage,
                _ => null,
            };
        }
    }
}