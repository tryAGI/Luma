#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Luma
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VideoModelOutputDuration : global::System.IEquatable<VideoModelOutputDuration>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.VideoModelOutputDurationEnum? Enum { get; init; }
#else
        public global::Luma.VideoModelOutputDurationEnum? Enum { get; }
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
            out global::Luma.VideoModelOutputDurationEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VideoModelOutputDurationVariant2 { get; init; }
#else
        public string? VideoModelOutputDurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoModelOutputDurationVariant2))]
#endif
        public bool IsVideoModelOutputDurationVariant2 => VideoModelOutputDurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoModelOutputDurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = VideoModelOutputDurationVariant2;
            return IsVideoModelOutputDurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModelOutputDuration(global::Luma.VideoModelOutputDurationEnum value) => new VideoModelOutputDuration((global::Luma.VideoModelOutputDurationEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.VideoModelOutputDurationEnum?(VideoModelOutputDuration @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputDuration(global::Luma.VideoModelOutputDurationEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModelOutputDuration(string value) => new VideoModelOutputDuration((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VideoModelOutputDuration @this) => @this.VideoModelOutputDurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputDuration(string? value)
        {
            VideoModelOutputDurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VideoModelOutputDuration(
            global::Luma.VideoModelOutputDurationEnum? @enum,
            string? videoModelOutputDurationVariant2
            )
        {
            Enum = @enum;
            VideoModelOutputDurationVariant2 = videoModelOutputDurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoModelOutputDurationVariant2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            VideoModelOutputDurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsVideoModelOutputDurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Luma.VideoModelOutputDurationEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? videoModelOutputDurationVariant2 = null,
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
            else if (IsVideoModelOutputDurationVariant2 && videoModelOutputDurationVariant2 != null)
            {
                return videoModelOutputDurationVariant2(VideoModelOutputDurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Luma.VideoModelOutputDurationEnum?>? @enum = null,

            global::System.Action<string>? videoModelOutputDurationVariant2 = null,
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
            else if (IsVideoModelOutputDurationVariant2)
            {
                videoModelOutputDurationVariant2?.Invoke(VideoModelOutputDurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Luma.VideoModelOutputDurationEnum?>? @enum = null,
            global::System.Action<string>? videoModelOutputDurationVariant2 = null,
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
            else if (IsVideoModelOutputDurationVariant2)
            {
                videoModelOutputDurationVariant2?.Invoke(VideoModelOutputDurationVariant2!);
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
                typeof(global::Luma.VideoModelOutputDurationEnum),
                VideoModelOutputDurationVariant2,
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
        public bool Equals(VideoModelOutputDuration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Luma.VideoModelOutputDurationEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VideoModelOutputDurationVariant2, other.VideoModelOutputDurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoModelOutputDuration obj1, VideoModelOutputDuration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoModelOutputDuration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoModelOutputDuration obj1, VideoModelOutputDuration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoModelOutputDuration o && Equals(o);
        }
    }
}
