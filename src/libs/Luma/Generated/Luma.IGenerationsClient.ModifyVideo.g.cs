#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Modify a video<br/>
        /// Modify a video with style transfer and prompt-based editing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ModifyVideoAsync(
            global::Luma.ModifyVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify a video<br/>
        /// Modify a video with style transfer and prompt-based editing
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="firstFrame">
        /// The image entity object
        /// </param>
        /// <param name="generationType">
        /// Default Value: modify_video
        /// </param>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="mode">
        /// The mode of the modify video
        /// </param>
        /// <param name="model">
        /// The model used for the modify video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> ModifyVideoAsync(
            global::Luma.Media media,
            global::Luma.ModifyVideoMode mode,
            global::Luma.ModifyVideoModel model,
            string? callbackUrl = default,
            global::Luma.Media? firstFrame = default,
            global::Luma.ModifyVideoRequestGenerationType generationType = global::Luma.ModifyVideoRequestGenerationType.ModifyVideo,
            string? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}