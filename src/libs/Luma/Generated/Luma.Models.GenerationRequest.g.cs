
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation request object
    /// </summary>
    public sealed partial class GenerationRequest
    {
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
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// The concepts of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concepts")]
        public global::System.Collections.Generic.IList<global::Luma.Concept>? Concepts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter))]
        public global::Luma.VideoModelOutputDuration? Duration { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeJsonConverter))]
        public global::Luma.GenerationRequestGenerationType? GenerationType { get; set; }

        /// <summary>
        /// The keyframes of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::Luma.Keyframes? Keyframes { get; set; }

        /// <summary>
        /// Whether to loop the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// The video model used for the generation<br/>
        /// Default Value: ray-1-6<br/>
        /// Example: ray-1-6
        /// </summary>
        /// <default>global::Luma.VideoModel.Ray16</default>
        /// <example>ray-1-6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.VideoModel Model { get; set; } = global::Luma.VideoModel.Ray16;

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter))]
        public global::Luma.VideoModelOutputResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="concepts">
        /// The concepts of the generation
        /// </param>
        /// <param name="duration"></param>
        /// <param name="generationType">
        /// Default Value: video
        /// </param>
        /// <param name="keyframes">
        /// The keyframes of the generation
        /// </param>
        /// <param name="loop">
        /// Whether to loop the video
        /// </param>
        /// <param name="model">
        /// The video model used for the generation<br/>
        /// Default Value: ray-1-6<br/>
        /// Example: ray-1-6
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="resolution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequest(
            global::Luma.VideoModel model,
            global::Luma.AspectRatio? aspectRatio,
            string? callbackUrl,
            global::System.Collections.Generic.IList<global::Luma.Concept>? concepts,
            global::Luma.VideoModelOutputDuration? duration,
            global::Luma.GenerationRequestGenerationType? generationType,
            global::Luma.Keyframes? keyframes,
            bool? loop,
            string? prompt,
            global::Luma.VideoModelOutputResolution? resolution)
        {
            this.Model = model;
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
            this.Concepts = concepts;
            this.Duration = duration;
            this.GenerationType = generationType;
            this.Keyframes = keyframes;
            this.Loop = loop;
            this.Prompt = prompt;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }
    }
}