
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation response object
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// The assets of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        public global::Luma.Assets? Assets { get; set; }

        /// <summary>
        /// The date and time when the generation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The reason for the state of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The generation request object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Luma.GenerationRequest? Request { get; set; }

        /// <summary>
        /// The state of the generation<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.StateJsonConverter))]
        public global::Luma.State? State { get; set; }

        /// <summary>
        /// The model version used for the generation eg. v1.6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="assets">
        /// The assets of the generation
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the generation was created
        /// </param>
        /// <param name="failureReason">
        /// The reason for the state of the generation
        /// </param>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="request">
        /// The generation request object
        /// </param>
        /// <param name="state">
        /// The state of the generation<br/>
        /// Example: completed
        /// </param>
        /// <param name="version">
        /// The model version used for the generation eg. v1.6
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Generation(
            global::Luma.Assets? assets,
            global::System.DateTime? createdAt,
            string? failureReason,
            global::System.Guid? id,
            global::Luma.GenerationRequest? request,
            global::Luma.State? state,
            string? version)
        {
            this.Assets = assets;
            this.CreatedAt = createdAt;
            this.FailureReason = failureReason;
            this.Id = id;
            this.Request = request;
            this.State = state;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}