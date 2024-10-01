
#nullable enable

namespace Luma
{
    public sealed partial class LumaClient
    {
        /// <inheritdoc cref="LumaClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Luma.EndPointAuthorization?)"/>
        public LumaClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Luma.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}