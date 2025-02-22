
#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelOutputResolutionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x540p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelOutputResolutionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelOutputResolutionEnum value)
        {
            return value switch
            {
                VideoModelOutputResolutionEnum.x540p => "540p",
                VideoModelOutputResolutionEnum.x720p => "720p",
                VideoModelOutputResolutionEnum.x1080p => "1080p",
                VideoModelOutputResolutionEnum.x4k => "4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelOutputResolutionEnum? ToEnum(string value)
        {
            return value switch
            {
                "540p" => VideoModelOutputResolutionEnum.x540p,
                "720p" => VideoModelOutputResolutionEnum.x720p,
                "1080p" => VideoModelOutputResolutionEnum.x1080p,
                "4k" => VideoModelOutputResolutionEnum.x4k,
                _ => null,
            };
        }
    }
}