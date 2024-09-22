
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Luma.JsonConverters.StateJsonConverter),
            typeof(global::Luma.JsonConverters.StateNullableJsonConverter),
            typeof(global::Luma.JsonConverters.AspectRatioJsonConverter),
            typeof(global::Luma.JsonConverters.AspectRatioNullableJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationReferenceTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageReferenceTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ImageReferenceTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.KeyframeJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}