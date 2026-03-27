
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

            typeof(global::Luma.JsonConverters.GenerationReferenceTypeJsonConverter),

            typeof(global::Luma.JsonConverters.GenerationReferenceTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ImageReferenceTypeJsonConverter),

            typeof(global::Luma.JsonConverters.ImageReferenceTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.AspectRatioJsonConverter),

            typeof(global::Luma.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelNullableJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionEnumJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionEnumNullableJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputDurationEnumJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputDurationEnumNullableJsonConverter),

            typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.GenerationRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeImageModelsJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeImageModelsNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeVideoModelsJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeVideoModelsNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeImageRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeImageRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoModelJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoModelNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoModeJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoModeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.ModifyVideoRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.ReframeVideoRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.GenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.GenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.KeyframeDiscriminatorTypeJsonConverter),

            typeof(global::Luma.JsonConverters.KeyframeDiscriminatorTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ImageModelJsonConverter),

            typeof(global::Luma.JsonConverters.ImageModelNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ImageFormatJsonConverter),

            typeof(global::Luma.JsonConverters.ImageFormatNullableJsonConverter),

            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.ImageGenerationRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.UpscaleVideoGenerationRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeJsonConverter),

            typeof(global::Luma.JsonConverters.AudioGenerationRequestGenerationTypeNullableJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputResolutionJsonConverter),

            typeof(global::Luma.JsonConverters.VideoModelOutputDurationJsonConverter),

            typeof(global::Luma.JsonConverters.KeyframeJsonConverter),

            typeof(global::Luma.JsonConverters.OneOfJsonConverter<global::Luma.GenerationRequest, global::Luma.ImageGenerationRequest, global::Luma.UpscaleVideoGenerationRequest, global::Luma.AudioGenerationRequest, global::Luma.ReframeImageRequest, global::Luma.ReframeVideoRequest, global::Luma.ModifyVideoRequest>),

            typeof(global::Luma.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.State))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ListGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Luma.Generation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.GenerationReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.GenerationReferenceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageReferenceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Assets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.AspectRatio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.VideoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.VideoModelOutputResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.VideoModelOutputResolutionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.VideoModelOutputDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.VideoModelOutputDurationEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Concept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.GenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.GenerationRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Keyframes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Luma.Concept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Media))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeImageModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeVideoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeImageRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ModifyVideoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ModifyVideoMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ModifyVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ModifyVideoRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ReframeVideoRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.GenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.OneOf<global::Luma.GenerationRequest, global::Luma.ImageGenerationRequest, global::Luma.UpscaleVideoGenerationRequest, global::Luma.AudioGenerationRequest, global::Luma.ReframeImageRequest, global::Luma.ReframeVideoRequest, global::Luma.ModifyVideoRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.UpscaleVideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.AudioGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Keyframe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.KeyframeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.KeyframeDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.Credits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ModifyImageRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageGenerationRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Luma.ImageRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.ImageGenerationRequestCharacterRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.UpscaleVideoGenerationRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.AudioGenerationRequestGenerationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Luma.PingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Luma.Generation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Luma.Concept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Luma.ImageRef>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}