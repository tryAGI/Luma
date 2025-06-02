#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Reframe a video<br/>
        /// Reframe a video by its ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeVideoAsync(
            global::Luma.ReframeVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reframe a video<br/>
        /// Reframe a video by its ID
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="firstFrame">
        /// The image entity object
        /// </param>
        /// <param name="generationType">
        /// Default Value: reframe_video
        /// </param>
        /// <param name="gridPositionX">
        /// The x position of the image in the grid
        /// </param>
        /// <param name="gridPositionY">
        /// The y position of the image in the grid
        /// </param>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="model">
        /// The model used for the reframe video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="resizedHeight">
        /// Resized height of source video
        /// </param>
        /// <param name="resizedWidth">
        /// Resized width of source video
        /// </param>
        /// <param name="xEnd">
        /// The x end of the crop bounds
        /// </param>
        /// <param name="xStart">
        /// The x start of the crop bounds
        /// </param>
        /// <param name="yEnd">
        /// The y end of the crop bounds
        /// </param>
        /// <param name="yStart">
        /// The y start of the crop bounds
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeVideoAsync(
            global::Luma.AspectRatio aspectRatio,
            global::Luma.Media media,
            global::Luma.ReframeVideoModels model,
            string? callbackUrl = default,
            global::Luma.Media? firstFrame = default,
            global::Luma.ReframeVideoRequestGenerationType generationType = global::Luma.ReframeVideoRequestGenerationType.ReframeVideo,
            int? gridPositionX = default,
            int? gridPositionY = default,
            string? prompt = default,
            int? resizedHeight = default,
            int? resizedWidth = default,
            int? xEnd = default,
            int? xStart = default,
            int? yEnd = default,
            int? yStart = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}