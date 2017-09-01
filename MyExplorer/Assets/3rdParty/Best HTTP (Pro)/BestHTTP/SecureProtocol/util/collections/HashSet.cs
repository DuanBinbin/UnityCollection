/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)

using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	public class HashSet
		: ISet
	{
		private readonly IDictionary impl = Platform.CreateHashtable();

		public HashSet()
		{
		}

		public HashSet(IEnumerable s)
		{
			foreach (object o in s)
			{
				Add(o);
			}
		}

		public virtual void Add(object o)
		{
			impl[o] = null;
		}

		public virtual void AddAll(IEnumerable e)
		{
			foreach (object o in e)
			{
				Add(o);
			}
		}

		public virtual void Clear()
		{
			impl.Clear();
		}

		public virtual bool Contains(object o)
		{
			return impl.Contains(o);
		}

		public virtual void CopyTo(Array array, int index)
		{
			impl.Keys.CopyTo(array, index);
		}

		public virtual int Count
		{
			get { return impl.Count; }
		}

		public virtual IEnumerator GetEnumerator()
		{
			return impl.Keys.GetEnumerator();
		}

		public virtual bool IsEmpty
		{
			get { return impl.Count == 0; }
		}

		public virtual bool IsFixedSize
		{
			get { return impl.IsFixedSize; }
		}

		public virtual bool IsReadOnly
		{
			get { return impl.IsReadOnly; }
		}

		public virtual bool IsSynchronized
		{
			get { return impl.IsSynchronized; }
		}

		public virtual void Remove(object o)
		{
			impl.Remove(o);
		}

		public virtual void RemoveAll(IEnumerable e)
		{
			foreach (object o in e)
			{
				Remove(o);
			}
		}

		public virtual object SyncRoot
		{
			get { return impl.SyncRoot; }
		}
	}
}

#endif
