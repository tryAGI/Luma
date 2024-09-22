
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation response object
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The state of the generation<br/>
        /// Example: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.StateJsonConverter))]
        public global::Luma.State? State { get; set; }

        /// <summary>
        /// The reason for the state of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// The date and time when the generation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The assets of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        public global::Luma.Assets? Assets { get; set; }

        /// <summary>
        /// The model version used for the generation eg. v1.6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The generation request object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Luma.GenerationRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}