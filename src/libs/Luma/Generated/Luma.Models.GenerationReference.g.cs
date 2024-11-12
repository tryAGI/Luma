
#nullable enable

namespace Luma
{
    /// <summary>
    /// The generation reference object
    /// </summary>
    public sealed partial class GenerationReference
    {
        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Default Value: generation
        /// </summary>
        /// <default>global::Luma.GenerationReferenceType.Generation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter))]
        public global::Luma.GenerationReferenceType Type { get; set; } = global::Luma.GenerationReferenceType.Generation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="type">
        /// Default Value: generation
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerationReference(
            global::System.Guid id,
            global::Luma.GenerationReferenceType type = global::Luma.GenerationReferenceType.Generation)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        public GenerationReference()
        {
        }
    }
}