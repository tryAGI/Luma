
#nullable enable

namespace Luma
{
    /// <summary>
    /// The model used for the reframe video
    /// </summary>
    public enum ReframeVideoModels
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
    public static class ReframeVideoModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeVideoModels value)
        {
            return value switch
            {
                ReframeVideoModels.Ray2 => "ray-2",
                ReframeVideoModels.RayFlash2 => "ray-flash-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeVideoModels? ToEnum(string value)
        {
            return value switch
            {
                "ray-2" => ReframeVideoModels.Ray2,
                "ray-flash-2" => ReframeVideoModels.RayFlash2,
                _ => null,
            };
        }
    }
}