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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(
            global::Luma.GenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
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
        /// Example: ray-2
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(
            global::Luma.VideoModel model,
            global::Luma.AspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::System.Collections.Generic.IList<global::Luma.Concept>? concepts = default,
            global::Luma.VideoModelOutputDuration? duration = default,
            global::Luma.GenerationRequestGenerationType? generationType = default,
            global::Luma.Keyframes? keyframes = default,
            bool? loop = default,
            string? prompt = default,
            global::Luma.VideoModelOutputResolution? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}