
#nullable enable

namespace Luma
{
    /// <summary>
    /// The video model used for the generation<br/>
    /// Example: ray-2
    /// </summary>
    public enum VideoModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ray2,
        /// <summary>
        /// 
        /// </summary>
        RayFlash2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModel value)
        {
            return value switch
            {
                VideoModel.Ray2 => "ray-2",
                VideoModel.RayFlash2 => "ray-flash-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModel? ToEnum(string value)
        {
            return value switch
            {
                "ray-2" => VideoModel.Ray2,
                "ray-flash-2" => VideoModel.RayFlash2,
                _ => null,
            };
        }
    }
}