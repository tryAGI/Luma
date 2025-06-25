
#nullable enable

namespace Luma
{
    /// <summary>
    /// The modify video generation request object
    /// </summary>
    public sealed partial class ModifyVideoRequest
    {
        /// <summary>
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// The image entity object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_frame")]
        public global::Luma.Media? FirstFrame { get; set; }

        /// <summary>
        /// Default Value: modify_video
        /// </summary>
        /// <default>global::Luma.ModifyVideoRequestGenerationType.ModifyVideo</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeJsonConverter))]
        public global::Luma.ModifyVideoRequestGenerationType GenerationType { get; set; } = global::Luma.ModifyVideoRequestGenerationType.ModifyVideo;

        /// <summary>
        /// The image entity object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.Media Media { get; set; }

        /// <summary>
        /// The mode of the modify video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ModifyVideoModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.ModifyVideoMode Mode { get; set; }

        /// <summary>
        /// The model used for the modify video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ModifyVideoModelJsonConverter))]
        public global::Luma.ModifyVideoModel Model { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyVideoRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="firstFrame">
        /// The image entity object
        /// </param>
        /// <param name="generationType">
        /// Default Value: modify_video
        /// </param>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="mode">
        /// The mode of the modify video
        /// </param>
        /// <param name="model">
        /// The model used for the modify video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyVideoRequest(
            global::Luma.Media media,
            global::Luma.ModifyVideoMode mode,
            string? callbackUrl,
            global::Luma.Media? firstFrame,
            global::Luma.ModifyVideoModel model,
            string? prompt,
            global::Luma.ModifyVideoRequestGenerationType generationType = global::Luma.ModifyVideoRequestGenerationType.ModifyVideo)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Mode = mode;
            this.CallbackUrl = callbackUrl;
            this.FirstFrame = firstFrame;
            this.GenerationType = generationType;
            this.Model = model;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyVideoRequest" /> class.
        /// </summary>
        public ModifyVideoRequest()
        {
        }
    }
}