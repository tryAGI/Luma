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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> UpscaleGenerationAsync(
            string id,

            global::Luma.UpscaleVideoGenerationRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale a generation<br/>
        /// Upscale a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.AutoSDKHttpResponse<global::Luma.Generation>> UpscaleGenerationAsResponseAsync(
            string id,

            global::Luma.UpscaleVideoGenerationRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale a generation<br/>
        /// Upscale a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="generationType">
        /// Default Value: upscale_video
        /// </param>
        /// <param name="resolution">
        /// The resolution of the upscale
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the upscale
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> UpscaleGenerationAsync(
            string id,
            global::Luma.UpscaleVideoGenerationRequestGenerationType? generationType = default,
            global::Luma.VideoModelOutputResolution? resolution = default,
            string? callbackUrl = default,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}