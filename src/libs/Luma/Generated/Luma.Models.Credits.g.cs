
#nullable enable

namespace Luma
{
    /// <summary>
    /// The credits object
    /// </summary>
    public sealed partial class Credits
    {
        /// <summary>
        /// Available credits balance in USD cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CreditBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}