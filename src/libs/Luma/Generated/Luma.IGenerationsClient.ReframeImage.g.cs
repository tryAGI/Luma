#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Reframe an image<br/>
        /// Reframe an image by its ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeImageAsync(

            global::Luma.ReframeImageRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image<br/>
        /// Reframe an image by its ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.AutoSDKHttpResponse<global::Luma.Generation>> ReframeImageAsResponseAsync(

            global::Luma.ReframeImageRequest request,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image<br/>
        /// Reframe an image by its ID
        /// </summary>
        /// <param name="generationType">
        /// Default Value: reframe_image
        /// </param>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="model">
        /// The model used for the reframe image
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="gridPositionX">
        /// The x position of the image in the grid
        /// </param>
        /// <param name="gridPositionY">
        /// The y position of the image in the grid
        /// </param>
        /// <param name="xStart">
        /// The x start of the crop bounds
        /// </param>
        /// <param name="xEnd">
        /// The x end of the crop bounds
        /// </param>
        /// <param name="yStart">
        /// The y start of the crop bounds
        /// </param>
        /// <param name="yEnd">
        /// The y end of the crop bounds
        /// </param>
        /// <param name="resizedWidth">
        /// Resized width of source image
        /// </param>
        /// <param name="resizedHeight">
        /// Resized height of source image
        /// </param>
        /// <param name="format">
        /// The format of the image<br/>
        /// Default Value: jpg
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeImageAsync(
            global::Luma.Media media,
            global::Luma.ReframeImageModels model,
            global::Luma.ReframeImageRequestGenerationType generationType = global::Luma.ReframeImageRequestGenerationType.ReframeImage,
            string? prompt = default,
            global::Luma.AspectRatio aspectRatio = global::Luma.AspectRatio.x16_9,
            int? gridPositionX = default,
            int? gridPositionY = default,
            int? xStart = default,
            int? xEnd = default,
            int? yStart = default,
            int? yEnd = default,
            int? resizedWidth = default,
            int? resizedHeight = default,
            global::Luma.ImageFormat? format = default,
            string? callbackUrl = default,
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}