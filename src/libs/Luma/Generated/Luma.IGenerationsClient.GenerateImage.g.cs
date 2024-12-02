#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Generate an image<br/>
        /// Generate an image with the provided prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> GenerateImageAsync(
            global::Luma.ImageGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate an image<br/>
        /// Generate an image with the provided prompt
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> GenerateImageAsync(
            global::Luma.AspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::Luma.ImageGenerationRequestCharacterRef? characterRef = default,
            global::Luma.ImageGenerationRequestGenerationType? generationType = default,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? imageRef = default,
            global::Luma.ImageModel? model = default,
            global::Luma.ModifyImageRef? modifyImageRef = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? styleRef = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}