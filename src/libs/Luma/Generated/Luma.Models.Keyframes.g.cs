
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Keyframes" /> class.
        /// </summary>
        /// <param name="frame0">
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </param>
        /// <param name="frame1">
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Keyframes(
            global::Luma.Keyframe? frame0,
            global::Luma.Keyframe? frame1)
        {
            this.Frame0 = frame0;
            this.Frame1 = frame1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keyframes" /> class.
        /// </summary>
        public Keyframes()
        {
        }
    }
}