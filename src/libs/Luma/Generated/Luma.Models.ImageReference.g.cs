
#nullable enable

namespace Luma
{
    /// <summary>
    /// The image object
    /// </summary>
    public sealed partial class ImageReference
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.ImageReferenceTypeJsonConverter))]
        public global::Luma.ImageReferenceType Type { get; set; } = global::Luma.ImageReferenceType.Image;

        /// <summary>
        /// The URL of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}