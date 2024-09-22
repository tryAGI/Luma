using System.Linq;
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
        /// The generation reference object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.GenerationReference? GenerationReference { get; init; }
#else
        public global::Luma.GenerationReference? GenerationReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationReference))]
#endif
        public bool IsGenerationReference => GenerationReference != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Keyframe(global::Luma.GenerationReference value) => new Keyframe(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.GenerationReference?(Keyframe @this) => @this.GenerationReference;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::Luma.GenerationReference? value)
        {
            GenerationReference = value;
        }

        /// <summary>
        /// The image object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Luma.ImageReference? ImageReference { get; init; }
#else
        public global::Luma.ImageReference? ImageReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReference))]
#endif
        public bool IsImageReference => ImageReference != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Keyframe(global::Luma.ImageReference value) => new Keyframe(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Luma.ImageReference?(Keyframe @this) => @this.ImageReference;

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(global::Luma.ImageReference? value)
        {
            ImageReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Keyframe(
            global::Luma.GenerationReference? generationReference,
            global::Luma.ImageReference? imageReference
            )
        {
            GenerationReference = generationReference;
            ImageReference = imageReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReference as object ??
            GenerationReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationReference && !IsImageReference || !IsGenerationReference && IsImageReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationReference,
                typeof(global::Luma.GenerationReference),
                ImageReference,
                typeof(global::Luma.ImageReference),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Keyframe other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Luma.GenerationReference?>.Default.Equals(GenerationReference, other.GenerationReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Luma.ImageReference?>.Default.Equals(ImageReference, other.ImageReference) 
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
