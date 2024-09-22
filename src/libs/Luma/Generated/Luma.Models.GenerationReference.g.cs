
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation reference object
    /// </summary>
    public sealed partial class GenerationReference
    {
        /// <summary>
        /// Default Value: generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter))]
        public global::Luma.GenerationReferenceType Type { get; set; } = global::Luma.GenerationReferenceType.Generation;

        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}