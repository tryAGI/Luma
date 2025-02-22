
#nullable enable

namespace Luma
{
    /// <summary>
    /// The upscale generation request object
    /// </summary>
    public sealed partial class UpscaleVideoGenerationRequest
    {
        /// <summary>
        /// The callback URL for the upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Default Value: upscale_video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeJsonConverter))]
        public global::Luma.UpscaleVideoGenerationRequestGenerationType? GenerationType { get; set; }

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
        /// Initializes a new instance of the <see cref="UpscaleVideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL for the upscale
        /// </param>
        /// <param name="generationType">
        /// Default Value: upscale_video
        /// </param>
        /// <param name="resolution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpscaleVideoGenerationRequest(
            string? callbackUrl,
            global::Luma.UpscaleVideoGenerationRequestGenerationType? generationType,
            global::Luma.VideoModelOutputResolution? resolution)
        {
            this.CallbackUrl = callbackUrl;
            this.GenerationType = generationType;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleVideoGenerationRequest" /> class.
        /// </summary>
        public UpscaleVideoGenerationRequest()
        {
        }
    }
}