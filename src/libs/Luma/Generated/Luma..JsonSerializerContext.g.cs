
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
            typeof(global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeNullableJsonConverter),
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
            typeof(global::Luma.JsonConverters.ImageFormatJsonConverter),
            typeof(global::Luma.JsonConverters.ImageFormatNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ImageModelJsonConverter),
            typeof(global::Luma.JsonConverters.ImageModelNullableJsonConverter),
            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeImageRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeImageRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeImageModelsJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeImageModelsNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeVideoModelsJsonConverter),
            typeof(global::Luma.JsonConverters.ReframeVideoModelsNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoModeJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoModeNullableJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoModelJsonConverter),
            typeof(global::Luma.JsonConverters.ModifyVideoModelNullableJsonConverter),
            typeof(global::Luma.JsonConverters.StateJsonConverter),
            typeof(global::Luma.JsonConverters.StateNullableJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter),
            typeof(global::Luma.JsonConverters.KeyframeJsonConverter),
            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter),
            typeof(global::Luma.JsonConverters.OneOfJsonConverter<global::Luma.GenerationRequest, global::Luma.ImageGenerationRequest, global::Luma.UpscaleVideoGenerationRequest, global::Luma.AudioGenerationRequest, global::Luma.ReframeImageRequest, global::Luma.ReframeVideoRequest, global::Luma.ModifyVideoRequest>),
            typeof(global::Luma.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}