
#nullable enable

namespace Luma
{
    /// <summary>
    /// The assets of the generation
    /// </summary>
    public sealed partial class Assets
    {
        /// <summary>
        /// The URL of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public string? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}