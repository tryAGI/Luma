#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(

            global::Luma.GenerationRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(
            global::Luma.VideoModel model,
            global::Luma.GenerationRequestGenerationType? generationType = default,
            string? prompt = default,
            global::Luma.AspectRatio? aspectRatio = default,
            bool? loop = default,
            global::Luma.Keyframes? keyframes = default,
            string? callbackUrl = default,
            global::Luma.VideoModelOutputResolution? resolution = default,
            global::Luma.VideoModelOutputDuration? duration = default,
            global::System.Collections.Generic.IList<global::Luma.Concept>? concepts = default,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}