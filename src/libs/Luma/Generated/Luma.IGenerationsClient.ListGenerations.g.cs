#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// List generations<br/>
        /// Retrieve a list of generations with optional filtering and sorting
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.ListGenerationResponse> ListGenerationsAsync(
            int? limit = 100,
            int? offset = 0,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}