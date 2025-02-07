
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
        /// <default>global::Luma.ImageReferenceType.Image</default>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReference" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: image
        /// </param>
        /// <param name="url">
        /// The URL of the image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageReference(
            string url,
            global::Luma.ImageReferenceType type = global::Luma.ImageReferenceType.Image)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReference" /> class.
        /// </summary>
        public ImageReference()
        {
        }
    }
}