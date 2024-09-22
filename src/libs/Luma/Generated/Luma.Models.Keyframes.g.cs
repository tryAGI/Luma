
#nullable enable

namespace Luma
{
    /// <summary>
    /// The keyframes of the generation
    /// </summary>
    public sealed partial class Keyframes
    {
        /// <summary>
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame0")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.KeyframeJsonConverter))]
        public global::Luma.Keyframe? Frame0 { get; set; }

        /// <summary>
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame1")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.KeyframeJsonConverter))]
        public global::Luma.Keyframe? Frame1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}