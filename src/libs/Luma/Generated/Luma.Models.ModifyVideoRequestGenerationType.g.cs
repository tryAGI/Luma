
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: modify_video
    /// </summary>
    public enum ModifyVideoRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        ModifyVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyVideoRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyVideoRequestGenerationType value)
        {
            return value switch
            {
                ModifyVideoRequestGenerationType.ModifyVideo => "modify_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyVideoRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "modify_video" => ModifyVideoRequestGenerationType.ModifyVideo,
                _ => null,
            };
        }
    }
}