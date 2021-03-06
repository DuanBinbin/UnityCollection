/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestHTTP.Forms
{
    /// <summary>
    /// A HTTP Form implementation to send textual values.
    /// </summary>
    public sealed class HTTPUrlEncodedForm : HTTPFormBase
    {
        private byte[] CachedData;

        public override void PrepareRequest(HTTPRequest request)
        {
            request.SetHeader("Content-Type", "application/x-www-form-urlencoded");
        }

        public override byte[] GetData()
        {
            if (CachedData != null && !IsChanged)
                return CachedData;

            StringBuilder sb = new StringBuilder();

            // Create a "field1=value1&field2=value2" formatted string
            for (int i = 0; i < Fields.Count; ++i)
            {
                var field = Fields[i];

                if (i > 0)
                    sb.Append("&");

                sb.Append(Uri.EscapeDataString(field.Name));
                sb.Append("=");

                if (!string.IsNullOrEmpty(field.Text) || field.Binary == null)
                    sb.Append(Uri.EscapeDataString(field.Text));
                else
                    // If forced to this form type with binary data, we will create a string from the binary data first and encode this string.
                    sb.Append(Uri.EscapeDataString(Encoding.UTF8.GetString(field.Binary, 0, field.Binary.Length)));
            }

            IsChanged = false;
            return CachedData = Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}
