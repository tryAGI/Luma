#nullable enable

namespace Luma
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Get concepts<br/>
        /// Get all possible concepts
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetConceptsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}