#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Add audio to a generation<br/>
        /// Add audio to a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> AddAudioToGenerationAsync(
            string id,
            global::Luma.AudioGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add audio to a generation<br/>
        /// Add audio to a generation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callbackUrl">
        /// The callback URL for the audio
        /// </param>
        /// <param name="generationType">
        /// Default Value: add_audio
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt of the audio
        /// </param>
        /// <param name="prompt">
        /// The prompt of the audio
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Generation> AddAudioToGenerationAsync(
            string id,
            string? callbackUrl = default,
            global::Luma.AudioGenerationRequestGenerationType? generationType = default,
            string? negativePrompt = default,
            string? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}