/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class DerSequence
		: Asn1Sequence
	{
		public static readonly DerSequence Empty = new DerSequence();

		public static DerSequence FromVector(
			Asn1EncodableVector v)
		{
			return v.Count < 1 ? Empty : new DerSequence(v);
		}

		/**
		 * create an empty sequence
		 */
		public DerSequence()
			: base(0)
		{
		}

		/**
		 * create a sequence containing one object
		 */
		public DerSequence(
			Asn1Encodable obj)
			: base(1)
		{
			AddObject(obj);
		}

		public DerSequence(
			params Asn1Encodable[] v)
			: base(v.Length)
		{
			foreach (Asn1Encodable ae in v)
			{
				AddObject(ae);
			}
		}

		/**
		 * create a sequence containing a vector of objects.
		 */
		public DerSequence(
			Asn1EncodableVector v)
			: base(v.Count)
		{
			foreach (Asn1Encodable ae in v)
			{
				AddObject(ae);
			}
		}

		/*
		 * A note on the implementation:
		 * <p>
		 * As Der requires the constructed, definite-length model to
		 * be used for structured types, this varies slightly from the
		 * ASN.1 descriptions given. Rather than just outputing Sequence,
		 * we also have to specify Constructed, and the objects length.
		 */
		internal override void Encode(
			DerOutputStream derOut)
		{
			// TODO Intermediate buffer could be avoided if we could calculate expected length
			MemoryStream bOut = new MemoryStream();
			DerOutputStream dOut = new DerOutputStream(bOut);

			foreach (Asn1Encodable obj in this)
			{
				dOut.WriteObject(obj);
			}

			dOut.Dispose();

			byte[] bytes = bOut.ToArray();

			derOut.WriteEncoded(Asn1Tags.Sequence | Asn1Tags.Constructed, bytes);
		}
	}
}

#endif
