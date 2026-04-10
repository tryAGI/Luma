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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> GenerateImageAsync(

            global::Luma.ImageGenerationRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image<br/>
        /// Generate an image with the provided prompt
        /// </summary>
        /// <param name="generationType">
        /// Default Value: image
        /// </param>
        /// <param name="model">
        /// The model used for the generation<br/>
        /// Default Value: photon-1
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="format">
        /// The format of the image<br/>
        /// Default Value: jpg
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the generation
        /// </param>
        /// <param name="imageRef"></param>
        /// <param name="styleRef"></param>
        /// <param name="characterRef"></param>
        /// <param name="modifyImageRef">
        /// The modify image reference object
        /// </param>
        /// <param name="sync">
        /// Create image in synchronous mode and return complated image<br/>
        /// Default Value: false
        /// </param>
        /// <param name="syncTimeout">
        /// The timeout for the synchronous image generation<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> GenerateImageAsync(
            global::Luma.ImageGenerationRequestGenerationType? generationType = default,
            global::Luma.ImageModel model = global::Luma.ImageModel.Photon1,
            string? prompt = default,
            global::Luma.AspectRatio? aspectRatio = default,
            global::Luma.ImageFormat? format = default,
            string? callbackUrl = default,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? imageRef = default,
            global::System.Collections.Generic.IList<global::Luma.ImageRef>? styleRef = default,
            global::Luma.ImageGenerationRequestCharacterRef? characterRef = default,
            global::Luma.ModifyImageRef? modifyImageRef = default,
            bool? sync = default,
            double? syncTimeout = default,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}