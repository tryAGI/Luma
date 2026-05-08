#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VideoModelOutputResolution : global::System.IEquatable<VideoModelOutputResolution>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.VideoModelOutputResolutionEnum? Enum { get; init; }
#else
        public global::Luma.VideoModelOutputResolutionEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Luma.VideoModelOutputResolutionEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VideoModelOutputResolutionVariant2 { get; init; }
#else
        public string? VideoModelOutputResolutionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoModelOutputResolutionVariant2))]
#endif
        public bool IsVideoModelOutputResolutionVariant2 => VideoModelOutputResolutionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoModelOutputResolutionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = VideoModelOutputResolutionVariant2;
            return IsVideoModelOutputResolutionVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModelOutputResolution(global::Luma.VideoModelOutputResolutionEnum value) => new VideoModelOutputResolution((global::Luma.VideoModelOutputResolutionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.VideoModelOutputResolutionEnum?(VideoModelOutputResolution @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputResolution(global::Luma.VideoModelOutputResolutionEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModelOutputResolution(string value) => new VideoModelOutputResolution((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VideoModelOutputResolution @this) => @this.VideoModelOutputResolutionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputResolution(string? value)
        {
            VideoModelOutputResolutionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputResolution(
            global::Luma.VideoModelOutputResolutionEnum? @enum,
            string? videoModelOutputResolutionVariant2
            )
        {
            Enum = @enum;
            VideoModelOutputResolutionVariant2 = videoModelOutputResolutionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoModelOutputResolutionVariant2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            VideoModelOutputResolutionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsVideoModelOutputResolutionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Luma.VideoModelOutputResolutionEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? videoModelOutputResolutionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsVideoModelOutputResolutionVariant2 && videoModelOutputResolutionVariant2 != null)
            {
                return videoModelOutputResolutionVariant2(VideoModelOutputResolutionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Luma.VideoModelOutputResolutionEnum?>? @enum = null,

            global::System.Action<string>? videoModelOutputResolutionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsVideoModelOutputResolutionVariant2)
            {
                videoModelOutputResolutionVariant2?.Invoke(VideoModelOutputResolutionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Luma.VideoModelOutputResolutionEnum?>? @enum = null,
            global::System.Action<string>? videoModelOutputResolutionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsVideoModelOutputResolutionVariant2)
            {
                videoModelOutputResolutionVariant2?.Invoke(VideoModelOutputResolutionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::Luma.VideoModelOutputResolutionEnum),
                VideoModelOutputResolutionVariant2,
                typeof(string),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(VideoModelOutputResolution other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Luma.VideoModelOutputResolutionEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VideoModelOutputResolutionVariant2, other.VideoModelOutputResolutionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoModelOutputResolution obj1, VideoModelOutputResolution obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoModelOutputResolution>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoModelOutputResolution obj1, VideoModelOutputResolution obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoModelOutputResolution o && Equals(o);
        }
    }
}
