#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Upscale a generation<br/>
        /// Upscale a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> UpscaleGenerationAsync(
            string id,
            global::Luma.UpscaleVideoGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upscale a generation<br/>
        /// Upscale a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callbackUrl">
        /// The callback URL for the upscale
        /// </param>
        /// <param name="generationType">
        /// Default Value: upscale_video
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> UpscaleGenerationAsync(
            string id,
            string? callbackUrl = default,
            global::Luma.UpscaleVideoGenerationRequestGenerationType? generationType = default,
            global::Luma.VideoModelOutputResolution? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}