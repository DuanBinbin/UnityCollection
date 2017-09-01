/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)

using System;
using System.Diagnostics;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
    public abstract class BaseOutputStream : Stream
    {
		private bool closed;

		public sealed override bool CanRead { get { return false; } }
        public sealed override bool CanSeek { get { return false; } }
        public sealed override bool CanWrite { get { return !closed; } }
		protected override void Dispose(bool isDisposing) {
            try
            {
                closed = true;
            }
            finally
            {
                base.Dispose(isDisposing);
            }
        }
        public override void Flush() {}
        public sealed override long Length { get { throw new NotSupportedException(); } }
        public sealed override long Position
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }
        public sealed override int Read(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
        public sealed override long Seek(long offset, SeekOrigin origin) { throw new NotSupportedException(); }
        public sealed override void SetLength(long value) { throw new NotSupportedException(); }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Debug.Assert(buffer != null);
            Debug.Assert(0 <= offset && offset <= buffer.Length);
            Debug.Assert(count >= 0);

            int end = offset + count;

            Debug.Assert(0 <= end && end <= buffer.Length);

            for (int i = offset; i < end; ++i)
            {
                this.WriteByte(buffer[i]);
            }
        }

		public virtual void Write(params byte[] buffer)
		{
			Write(buffer, 0, buffer.Length);
		}
	}
}

#endif
