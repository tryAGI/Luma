
#nullable enable

namespace Luma
{
    /// <summary>
    /// The image generation request object
    /// </summary>
    public sealed partial class ImageGenerationRequest
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
        /// The callback URL for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_ref")]
        public global::Luma.ImageGenerationRequestCharacterRef? CharacterRef { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter))]
        public global::Luma.ImageGenerationRequestGenerationType? GenerationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_ref")]
        public global::System.Collections.Generic.IList<global::Luma.ImageRef>? ImageRef { get; set; }

        /// <summary>
        /// The image model used for the generation<br/>
        /// Default Value: photon-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ImageModelJsonConverter))]
        public global::Luma.ImageModel? Model { get; set; }

        /// <summary>
        /// The modify image reference object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modify_image_ref")]
        public global::Luma.ModifyImageRef? ModifyImageRef { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_ref")]
        public global::System.Collections.Generic.IList<global::Luma.ImageRef>? StyleRef { get; set; }

        /// <summary>
        /// Create image in synchronous mode and return complated image<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync")]
        public bool? Sync { get; set; }

        /// <summary>
        /// The timeout for the synchronous image generation<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_timeout")]
        public double? SyncTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the generation
        /// </param>
        /// <param name="characterRef"></param>
        /// <param name="generationType">
        /// Default Value: image
        /// </param>
        /// <param name="imageRef"></param>
        /// <param name="model">
        /// The image model used for the generation<br/>
        /// Default Value: photon-1
        /// </param>
        /// <param name="modifyImageRef">
        /// The modify image reference object
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="styleRef"></param>
        /// <param name="sync">
        /// Create image in synchronous mode and return complated image<br/>
        /// Default Value: false
        /// </param>
        /// <param name="syncTimeout">
        /// The timeout for the synchronous image generation<br/>
        /// Default Value: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            global::Luma.AspectRatio? aspectRatio,
            string? callbackUrl,
            global::Luma.ImageGenerationRequestCharacterRef? characterRef,
            global::Luma.ImageGenerationRequestGenerationType? generationType,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? imageRef,
            global::Luma.ImageModel? model,
            global::Luma.ModifyImageRef? modifyImageRef,
            string? prompt,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? styleRef,
            bool? sync,
            double? syncTimeout)
        {
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
            this.CharacterRef = characterRef;
            this.GenerationType = generationType;
            this.ImageRef = imageRef;
            this.Model = model;
            this.ModifyImageRef = modifyImageRef;
            this.Prompt = prompt;
            this.StyleRef = styleRef;
            this.Sync = sync;
            this.SyncTimeout = syncTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }
    }
}