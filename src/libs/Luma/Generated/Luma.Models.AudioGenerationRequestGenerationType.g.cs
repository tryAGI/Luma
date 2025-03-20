
#nullable enable

namespace Luma
{
    /// <summary>
    /// Default Value: add_audio
    /// </summary>
    public enum AudioGenerationRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        AddAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioGenerationRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioGenerationRequestGenerationType value)
        {
            return value switch
            {
                AudioGenerationRequestGenerationType.AddAudio => "add_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioGenerationRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "add_audio" => AudioGenerationRequestGenerationType.AddAudio,
                _ => null,
            };
        }
    }
}