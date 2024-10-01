
#nullable enable

namespace Luma
{
    public sealed partial class LumaClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Luma.EndPointAuthorization
            {
                Name = "Bearer",
                Value = apiKey,
            };
        }
    }
}