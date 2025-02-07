
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationTypeJsonConverter))]
        public global::Luma.GenerationType? GenerationType { get; set; }

        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The model used for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The request of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.RequestJsonConverter))]
        public global::Luma.Request? Request { get; set; }

        /// <summary>
        /// The state of the generation<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.StateJsonConverter))]
        public global::Luma.State? State { get; set; }

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
        /// <param name="generationType"></param>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="model">
        /// The model used for the generation
        /// </param>
        /// <param name="request">
        /// The request of the generation
        /// </param>
        /// <param name="state">
        /// The state of the generation<br/>
        /// Example: completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Generation(
            global::Luma.Assets? assets,
            global::System.DateTime? createdAt,
            string? failureReason,
            global::Luma.GenerationType? generationType,
            global::System.Guid? id,
            string? model,
            global::Luma.Request? request,
            global::Luma.State? state)
        {
            this.Assets = assets;
            this.CreatedAt = createdAt;
            this.FailureReason = failureReason;
            this.GenerationType = generationType;
            this.Id = id;
            this.Model = model;
            this.Request = request;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}