#nullable enable

namespace Luma
{
    public partial interface IPingClient
    {
        /// <summary>
        /// Ping<br/>
        /// Check if the API is running
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Luma.PingResponse> PingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}