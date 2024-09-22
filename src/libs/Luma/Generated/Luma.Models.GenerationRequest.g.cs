
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation request object
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.AspectRatioJsonConverter))]
        public global::Luma.AspectRatio? AspectRatio { get; set; } = global::Luma.AspectRatio.x16_9;

        /// <summary>
        /// Whether to loop the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// The keyframes of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::Luma.Keyframes? Keyframes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}