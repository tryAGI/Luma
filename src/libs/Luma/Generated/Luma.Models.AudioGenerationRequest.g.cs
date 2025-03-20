
#nullable enable

namespace Luma
{
    /// <summary>
    /// The audio generation request object
    /// </summary>
    public sealed partial class AudioGenerationRequest
    {
        /// <summary>
        /// The callback URL for the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Default Value: add_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeJsonConverter))]
        public global::Luma.AudioGenerationRequestGenerationType? GenerationType { get; set; }

        /// <summary>
        /// The negative prompt of the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The prompt of the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioGenerationRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL for the audio
        /// </param>
        /// <param name="generationType">
        /// Default Value: add_audio
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt of the audio
        /// </param>
        /// <param name="prompt">
        /// The prompt of the audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioGenerationRequest(
            string? callbackUrl,
            global::Luma.AudioGenerationRequestGenerationType? generationType,
            string? negativePrompt,
            string? prompt)
        {
            this.CallbackUrl = callbackUrl;
            this.GenerationType = generationType;
            this.NegativePrompt = negativePrompt;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioGenerationRequest" /> class.
        /// </summary>
        public AudioGenerationRequest()
        {
        }
    }
}