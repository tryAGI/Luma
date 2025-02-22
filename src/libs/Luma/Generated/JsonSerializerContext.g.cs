
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
            typeof(global::Luma.JsonConverters.AspectRatioJsonConverter),
            typeof(global::Luma.JsonConverters.AspectRatioNullableJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputDurationEnumJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputDurationEnumNullableJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationReferenceTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageReferenceTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ImageReferenceTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.KeyframeDiscriminatorTypeJsonConverter),
            typeof(global::Luma.JsonConverters.KeyframeDiscriminatorTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelNullableJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionEnumJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionEnumNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageModelJsonConverter),
            typeof(global::Luma.JsonConverters.ImageModelNullableJsonConverter),
            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationRequestDiscriminatorGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.GenerationRequestDiscriminatorGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.StateJsonConverter),
            typeof(global::Luma.JsonConverters.StateNullableJsonConverter),
            typeof(global::Luma.JsonConverters.RequestJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter),
            typeof(global::Luma.JsonConverters.KeyframeJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter),
            typeof(global::Luma.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}