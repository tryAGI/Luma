#nullable enable

namespace Luma
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get credits<br/>
        /// Get the credits information for the api user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.Credits> GetCreditsAsync(
            global::Luma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}