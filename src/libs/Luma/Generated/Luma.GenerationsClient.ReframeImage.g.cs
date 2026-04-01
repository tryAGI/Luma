
#nullable enable

namespace Luma
{
    public partial class GenerationsClient
    {
        partial void PrepareReframeImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Luma.ReframeImageRequest request);
        partial void PrepareReframeImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Luma.ReframeImageRequest request);
        partial void ProcessReframeImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReframeImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reframe an image<br/>
        /// Reframe an image by its ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Luma.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeImageAsync(

            global::Luma.ReframeImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReframeImageArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Luma.PathBuilder(
                path: "/generations/image/reframe",
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
            PrepareReframeImageRequest(
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
            ProcessReframeImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::Luma.Error? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Luma.Error.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Luma.Error.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Luma.ApiException<global::Luma.Error>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
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
                ProcessReframeImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Luma.Generation.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Luma.Generation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
        /// <summary>
        /// Reframe an image<br/>
        /// Reframe an image by its ID
        /// </summary>
        /// <param name="generationType">
        /// Default Value: reframe_image
        /// </param>
        /// <param name="media">
        /// The image entity object
        /// </param>
        /// <param name="model">
        /// The model used for the reframe image
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="gridPositionX">
        /// The x position of the image in the grid
        /// </param>
        /// <param name="gridPositionY">
        /// The y position of the image in the grid
        /// </param>
        /// <param name="xStart">
        /// The x start of the crop bounds
        /// </param>
        /// <param name="xEnd">
        /// The x end of the crop bounds
        /// </param>
        /// <param name="yStart">
        /// The y start of the crop bounds
        /// </param>
        /// <param name="yEnd">
        /// The y end of the crop bounds
        /// </param>
        /// <param name="resizedWidth">
        /// Resized width of source image
        /// </param>
        /// <param name="resizedHeight">
        /// Resized height of source image
        /// </param>
        /// <param name="format">
        /// The format of the image<br/>
        /// Default Value: jpg
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Luma.Generation> ReframeImageAsync(
            global::Luma.Media media,
            global::Luma.ReframeImageModels model,
            global::Luma.ReframeImageRequestGenerationType generationType = global::Luma.ReframeImageRequestGenerationType.ReframeImage,
            string? prompt = default,
            global::Luma.AspectRatio aspectRatio = global::Luma.AspectRatio.x16_9,
            int? gridPositionX = default,
            int? gridPositionY = default,
            int? xStart = default,
            int? xEnd = default,
            int? yStart = default,
            int? yEnd = default,
            int? resizedWidth = default,
            int? resizedHeight = default,
            global::Luma.ImageFormat? format = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Luma.ReframeImageRequest
            {
                GenerationType = generationType,
                Media = media,
                Model = model,
                Prompt = prompt,
                AspectRatio = aspectRatio,
                GridPositionX = gridPositionX,
                GridPositionY = gridPositionY,
                XStart = xStart,
                XEnd = xEnd,
                YStart = yStart,
                YEnd = yEnd,
                ResizedWidth = resizedWidth,
                ResizedHeight = resizedHeight,
                Format = format,
                CallbackUrl = callbackUrl,
            };

            return await ReframeImageAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}