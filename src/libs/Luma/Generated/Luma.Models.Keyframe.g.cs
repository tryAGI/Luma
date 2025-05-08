#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Luma
{
    /// <summary>
    /// A keyframe can be either a Generation reference, an Image, or a Video
    /// </summary>
    public readonly partial struct Keyframe : global::System.IEquatable<Keyframe>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Luma.KeyframeDiscriminatorType? Type { get; }

        /// <summary>
        /// The generation reference object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.GenerationReference? Generation { get; init; }
#else
        public global::Luma.GenerationReference? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Keyframe(global::Luma.GenerationReference value) => new Keyframe((global::Luma.GenerationReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.GenerationReference?(Keyframe @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::Luma.GenerationReference? value)
        {
            Generation = value;
        }

        /// <summary>
        /// The image object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.ImageReference? Image { get; init; }
#else
        public global::Luma.ImageReference? Image { get; }
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
        public static implicit operator Keyframe(global::Luma.ImageReference value) => new Keyframe((global::Luma.ImageReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.ImageReference?(Keyframe @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::Luma.ImageReference? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(
            global::Luma.KeyframeDiscriminatorType? type,
            global::Luma.GenerationReference? generation,
            global::Luma.ImageReference? image
            )
        {
            Type = type;

            Generation = generation;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Generation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsImage || !IsGeneration && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Luma.GenerationReference?, TResult>? generation = null,
            global::System.Func<global::Luma.ImageReference?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration && generation != null)
            {
                return generation(Generation!);
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
            global::System.Action<global::Luma.GenerationReference?>? generation = null,
            global::System.Action<global::Luma.ImageReference?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration)
            {
                generation?.Invoke(Generation!);
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
                Generation,
                typeof(global::Luma.GenerationReference),
                Image,
                typeof(global::Luma.ImageReference),
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
        public bool Equals(Keyframe other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Luma.GenerationReference?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::Luma.ImageReference?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Keyframe obj1, Keyframe obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Keyframe>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Keyframe obj1, Keyframe obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Keyframe o && Equals(o);
        }
    }
}
