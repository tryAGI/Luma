
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation request object
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeJsonConverter))]
        public global::Luma.GenerationRequestGenerationType? GenerationType { get; set; }

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
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.AspectRatioJsonConverter))]
        public global::Luma.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Whether to loop the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// The keyframes of the generation<br/>
        /// Example: {"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}
        /// </summary>
        /// <example>{"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::Luma.Keyframes? Keyframes { get; set; }

        /// <summary>
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// The model used for the generation<br/>
        /// Example: ray-2
        /// </summary>
        /// <example>ray-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Luma.VideoModel Model { get; set; } = default!;

        /// <summary>
        /// The resolution of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter))]
        public global::Luma.VideoModelOutputResolution? Resolution { get; set; }

        /// <summary>
        /// The duration of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter))]
        public global::Luma.VideoModelOutputDuration? Duration { get; set; }

        /// <summary>
        /// The concepts of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concepts")]
        public global::System.Collections.Generic.IList<global::Luma.Concept>? Concepts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="generationType">
        /// Default Value: video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="loop">
        /// Whether to loop the video
        /// </param>
        /// <param name="keyframes">
        /// The keyframes of the generation<br/>
        /// Example: {"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="model">
        /// The model used for the generation<br/>
        /// Example: ray-2
        /// </param>
        /// <param name="resolution">
        /// The resolution of the generation
        /// </param>
        /// <param name="duration">
        /// The duration of the generation
        /// </param>
        /// <param name="concepts">
        /// The concepts of the generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequest(
            global::Luma.VideoModel model,
            global::Luma.GenerationRequestGenerationType? generationType,
            string? prompt,
            global::Luma.AspectRatio? aspectRatio,
            bool? loop,
            global::Luma.Keyframes? keyframes,
            string? callbackUrl,
            global::Luma.VideoModelOutputResolution? resolution,
            global::Luma.VideoModelOutputDuration? duration,
            global::System.Collections.Generic.IList<global::Luma.Concept>? concepts)
        {
            this.Model = model;
            this.GenerationType = generationType;
            this.Prompt = prompt;
            this.AspectRatio = aspectRatio;
            this.Loop = loop;
            this.Keyframes = keyframes;
            this.CallbackUrl = callbackUrl;
            this.Resolution = resolution;
            this.Duration = duration;
            this.Concepts = concepts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }
    }
}