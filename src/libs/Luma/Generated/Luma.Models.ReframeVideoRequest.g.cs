
#nullable enable

namespace Luma
{
    /// <summary>
    /// The reframe video generation request object
    /// </summary>
    public sealed partial class ReframeVideoRequest
    {
        /// <summary>
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </summary>
        /// <default>global::Luma.AspectRatio.x16_9</default>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.AspectRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.AspectRatio AspectRatio { get; set; } = global::Luma.AspectRatio.x16_9;

        /// <summary>
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// The image entity object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_frame")]
        public global::Luma.Media? FirstFrame { get; set; }

        /// <summary>
        /// Default Value: reframe_video
        /// </summary>
        /// <default>global::Luma.ReframeVideoRequestGenerationType.ReframeVideo</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeJsonConverter))]
        public global::Luma.ReframeVideoRequestGenerationType GenerationType { get; set; } = global::Luma.ReframeVideoRequestGenerationType.ReframeVideo;

        /// <summary>
        /// The x position of the image in the grid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grid_position_x")]
        public int? GridPositionX { get; set; }

        /// <summary>
        /// The y position of the image in the grid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grid_position_y")]
        public int? GridPositionY { get; set; }

        /// <summary>
        /// The image entity object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.Media Media { get; set; }

        /// <summary>
        /// The model used for the reframe video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ReframeVideoModelsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Luma.ReframeVideoModels Model { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Resized height of source video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resized_height")]
        public int? ResizedHeight { get; set; }

        /// <summary>
        /// Resized width of source video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resized_width")]
        public int? ResizedWidth { get; set; }

        /// <summary>
        /// The x end of the crop bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_end")]
        public int? XEnd { get; set; }

        /// <summary>
        /// The x start of the crop bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_start")]
        public int? XStart { get; set; }

        /// <summary>
        /// The y end of the crop bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_end")]
        public int? YEnd { get; set; }

        /// <summary>
        /// The y start of the crop bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_start")]
        public int? YStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeVideoRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReframeVideoRequest(
            global::Luma.AspectRatio aspectRatio,
            global::Luma.Media media,
            global::Luma.ReframeVideoModels model,
            string? callbackUrl,
            global::Luma.Media? firstFrame,
            int? gridPositionX,
            int? gridPositionY,
            string? prompt,
            int? resizedHeight,
            int? resizedWidth,
            int? xEnd,
            int? xStart,
            int? yEnd,
            int? yStart,
            global::Luma.ReframeVideoRequestGenerationType generationType = global::Luma.ReframeVideoRequestGenerationType.ReframeVideo)
        {
            this.AspectRatio = aspectRatio;
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Model = model;
            this.CallbackUrl = callbackUrl;
            this.FirstFrame = firstFrame;
            this.GenerationType = generationType;
            this.GridPositionX = gridPositionX;
            this.GridPositionY = gridPositionY;
            this.Prompt = prompt;
            this.ResizedHeight = resizedHeight;
            this.ResizedWidth = resizedWidth;
            this.XEnd = xEnd;
            this.XStart = xStart;
            this.YEnd = yEnd;
            this.YStart = yStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeVideoRequest" /> class.
        /// </summary>
        public ReframeVideoRequest()
        {
        }
    }
}