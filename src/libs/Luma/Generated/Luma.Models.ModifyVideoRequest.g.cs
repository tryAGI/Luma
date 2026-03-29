
#nullable enable

namespace Luma
{
    /// <summary>
    /// The modify video generation request object
    /// </summary>
    public sealed partial class ModifyVideoRequest
    {
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
        /// The image entity object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_frame")]
        public global::Luma.Media? FirstFrame { get; set; }

        /// <summary>
        /// The model used for the modify video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ModifyVideoModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.ModifyVideoModel Model { get; set; }

        /// <summary>
        /// The mode of the modify video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ModifyVideoModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.ModifyVideoMode Mode { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyVideoRequest" /> class.
        /// </summary>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="model">
        /// The model used for the modify video
        /// </param>
        /// <param name="mode">
        /// The mode of the modify video
        /// </param>
        /// <param name="firstFrame">
        /// The image entity object
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="generationType">
        /// Default Value: modify_video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyVideoRequest(
            global::Luma.Media media,
            global::Luma.ModifyVideoModel model,
            global::Luma.ModifyVideoMode mode,
            global::Luma.Media? firstFrame,
            string? prompt,
            string? callbackUrl,
            global::Luma.ModifyVideoRequestGenerationType generationType = global::Luma.ModifyVideoRequestGenerationType.ModifyVideo)
        {
            this.GenerationType = generationType;
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.FirstFrame = firstFrame;
            this.Model = model;
            this.Mode = mode;
            this.Prompt = prompt;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyVideoRequest" /> class.
        /// </summary>
        public ModifyVideoRequest()
        {
        }
    }
}