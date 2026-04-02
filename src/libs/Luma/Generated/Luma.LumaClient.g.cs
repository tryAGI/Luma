
#nullable enable

namespace Luma
{
    /// <summary>
    /// Generate videos using Dream Machine.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LumaClient : global::Luma.ILumaClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.lumalabs.ai/dream-machine/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Luma.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Luma.JsonConverters.StateJsonConverter(),
                    new global::Luma.JsonConverters.StateNullableJsonConverter(),
                    new global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter(),
                    new global::Luma.JsonConverters.GenerationReferenceTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ImageReferenceTypeJsonConverter(),
                    new global::Luma.JsonConverters.ImageReferenceTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.AspectRatioJsonConverter(),
                    new global::Luma.JsonConverters.AspectRatioNullableJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelNullableJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputResolutionEnumJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputResolutionEnumNullableJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputDurationEnumJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputDurationEnumNullableJsonConverter(),
                    new global::Luma.JsonConverters.GenerationRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.GenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ReframeImageModelsJsonConverter(),
                    new global::Luma.JsonConverters.ReframeImageModelsNullableJsonConverter(),
                    new global::Luma.JsonConverters.ReframeVideoModelsJsonConverter(),
                    new global::Luma.JsonConverters.ReframeVideoModelsNullableJsonConverter(),
                    new global::Luma.JsonConverters.ReframeImageRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.ReframeImageRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoModelJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoModelNullableJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoModeJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoModeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.GenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.GenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.KeyframeDiscriminatorTypeJsonConverter(),
                    new global::Luma.JsonConverters.KeyframeDiscriminatorTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.ImageModelJsonConverter(),
                    new global::Luma.JsonConverters.ImageModelNullableJsonConverter(),
                    new global::Luma.JsonConverters.ImageFormatJsonConverter(),
                    new global::Luma.JsonConverters.ImageFormatNullableJsonConverter(),
                    new global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeJsonConverter(),
                    new global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter(),
                    new global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter(),
                    new global::Luma.JsonConverters.KeyframeJsonConverter(),
                    new global::Luma.JsonConverters.OneOfJsonConverter<global::Luma.GenerationRequest, global::Luma.ImageGenerationRequest, global::Luma.UpscaleVideoGenerationRequest, global::Luma.AudioGenerationRequest, global::Luma.ReframeImageRequest, global::Luma.ReframeVideoRequest, global::Luma.ModifyVideoRequest>(),
                    new global::Luma.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationsClient Generations => new GenerationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PingClient Ping => new PingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the LumaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LumaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Luma.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Luma.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}