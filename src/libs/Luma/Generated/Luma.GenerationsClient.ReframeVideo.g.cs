
#nullable enable

namespace Luma
{
    public partial class GenerationsClient
    {
        partial void PrepareReframeVideoArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Luma.ReframeVideoRequest request);
        partial void PrepareReframeVideoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Luma.ReframeVideoRequest request);
        partial void ProcessReframeVideoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReframeVideoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reframe a video<br/>
        /// Reframe a video by its ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeVideoAsync(
            global::Luma.ReframeVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReframeVideoArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/generations/video/reframe",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReframeVideoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReframeVideoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::Luma.Error? __value_default = null;
                if (ReadResponseAsString)
                {
                    __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = global::Luma.Error.FromJson(__content_default, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_default = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = await global::Luma.Error.FromJsonStreamAsync(__contentStream_default, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Luma.ApiException<global::Luma.Error>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReframeVideoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Luma.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Luma.Generation.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Luma.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Luma.Generation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

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
        public async global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeVideoAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Luma.ReframeVideoRequest
            {
                AspectRatio = aspectRatio,
                CallbackUrl = callbackUrl,
                FirstFrame = firstFrame,
                GenerationType = generationType,
                GridPositionX = gridPositionX,
                GridPositionY = gridPositionY,
                Media = media,
                Model = model,
                Prompt = prompt,
                ResizedHeight = resizedHeight,
                ResizedWidth = resizedWidth,
                XEnd = xEnd,
                XStart = xStart,
                YEnd = yEnd,
                YStart = yStart,
            };

            return await ReframeVideoAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}