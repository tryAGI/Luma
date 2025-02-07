
#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Luma.JsonConverters.GenerationRequestDiscriminatorGenerationTypeJsonConverter))]
        public global::Luma.GenerationRequestDiscriminatorGenerationType? GenerationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="generationType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequestDiscriminator(
            global::Luma.GenerationRequestDiscriminatorGenerationType? generationType)
        {
            this.GenerationType = generationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestDiscriminator" /> class.
        /// </summary>
        public GenerationRequestDiscriminator()
        {
        }
    }
}