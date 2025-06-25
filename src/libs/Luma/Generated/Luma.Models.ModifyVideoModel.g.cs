
#nullable enable

namespace Luma
{
    /// <summary>
    /// The model used for the modify video
    /// </summary>
    public enum ModifyVideoModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ray2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyVideoModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyVideoModel value)
        {
            return value switch
            {
                ModifyVideoModel.Ray2 => "ray-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyVideoModel? ToEnum(string value)
        {
            return value switch
            {
                "ray-2" => ModifyVideoModel.Ray2,
                _ => null,
            };
        }
    }
}