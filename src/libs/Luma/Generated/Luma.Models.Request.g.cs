#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Luma
{
    /// <summary>
    /// The request of the generation
    /// </summary>
    public readonly partial struct Request : global::System.IEquatable<Request>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Luma.GenerationRequestDiscriminatorGeneration_type? Generation_type { get; }

        /// <summary>
        /// The generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.GenerationRequest? Video { get; init; }
#else
        public global::Luma.GenerationRequest? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::Luma.GenerationRequest value) => new Request(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.GenerationRequest?(Request @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::Luma.GenerationRequest? value)
        {
            Video = value;
        }

        /// <summary>
        /// The image generation request object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.ImageGenerationRequest? Image { get; init; }
#else
        public global::Luma.ImageGenerationRequest? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::Luma.ImageGenerationRequest value) => new Request(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.ImageGenerationRequest?(Request @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::Luma.ImageGenerationRequest? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Request(
            global::Luma.GenerationRequestDiscriminatorGeneration_type? generation_type,
            global::Luma.GenerationRequest? video,
            global::Luma.ImageGenerationRequest? image
            )
        {
            Generation_type = generation_type;

            Video = video;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsImage || !IsVideo && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Luma.GenerationRequest?, TResult>? video = null,
            global::System.Func<global::Luma.ImageGenerationRequest?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Luma.GenerationRequest?>? video = null,
            global::System.Action<global::Luma.ImageGenerationRequest?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::Luma.GenerationRequest),
                Image,
                typeof(global::Luma.ImageGenerationRequest),
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
        public bool Equals(Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Luma.GenerationRequest?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Luma.ImageGenerationRequest?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request obj1, Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request obj1, Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request o && Equals(o);
        }
    }
}
