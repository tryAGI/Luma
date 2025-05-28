
#nullable enable

namespace Luma
{
    /// <summary>
    /// The model used for the reframe image
    /// </summary>
    public enum ReframeImageModels
    {
        /// <summary>
        /// 
        /// </summary>
        Photon1,
        /// <summary>
        /// 
        /// </summary>
        PhotonFlash1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReframeImageModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeImageModels value)
        {
            return value switch
            {
                ReframeImageModels.Photon1 => "photon-1",
                ReframeImageModels.PhotonFlash1 => "photon-flash-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeImageModels? ToEnum(string value)
        {
            return value switch
            {
                "photon-1" => ReframeImageModels.Photon1,
                "photon-flash-1" => ReframeImageModels.PhotonFlash1,
                _ => null,
            };
        }
    }
}