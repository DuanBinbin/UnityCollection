/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !BESTHTTP_DISABLE_SIGNALR

using BestHTTP.JSON;
using System.Collections.Generic;

namespace BestHTTP.SignalR.JsonEncoders
{
    public sealed class DefaultJsonEncoder : IJsonEncoder
    {
        public string Encode(object obj)
        {
            return Json.Encode(obj);
        }

        public IDictionary<string, object> DecodeMessage(string json)
        {
            bool ok = false;
            IDictionary<string, object> result = Json.Decode(json, ref ok) as IDictionary<string, object>;
            return ok ? result : null;
        }
    }
}

#endif