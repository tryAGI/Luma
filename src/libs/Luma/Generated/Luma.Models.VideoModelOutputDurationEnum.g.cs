
#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelOutputDurationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x5s,
        /// <summary>
        /// 
        /// </summary>
        x9s,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelOutputDurationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelOutputDurationEnum value)
        {
            return value switch
            {
                VideoModelOutputDurationEnum.x5s => "5s",
                VideoModelOutputDurationEnum.x9s => "9s",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelOutputDurationEnum? ToEnum(string value)
        {
            return value switch
            {
                "5s" => VideoModelOutputDurationEnum.x5s,
                "9s" => VideoModelOutputDurationEnum.x9s,
                _ => null,
            };
        }
    }
}