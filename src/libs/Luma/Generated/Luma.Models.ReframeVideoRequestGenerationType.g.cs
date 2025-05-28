
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: reframe_video
    /// </summary>
    public enum ReframeVideoRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        ReframeVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReframeVideoRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeVideoRequestGenerationType value)
        {
            return value switch
            {
                ReframeVideoRequestGenerationType.ReframeVideo => "reframe_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeVideoRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "reframe_video" => ReframeVideoRequestGenerationType.ReframeVideo,
                _ => null,
            };
        }
    }
}