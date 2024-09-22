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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(
            global::Luma.GenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
        /// </summary>
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
        /// The keyframes of the generation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> CreateGenerationAsync(
            string? prompt = default,
            global::Luma.AspectRatio? aspectRatio = global::Luma.AspectRatio.x16_9,
            bool? loop = default,
            global::Luma.Keyframes? keyframes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}