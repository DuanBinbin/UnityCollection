/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。



daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)

using System;

namespace Org.BouncyCastle.Crypto.Tls
{
    /*
     * RFC 6520 3.
     */
    public abstract class HeartbeatMessageType
    {
        public const byte heartbeat_request = 1;
        public const byte heartbeat_response = 2;

        public static bool IsValid(byte heartbeatMessageType)
        {
            return heartbeatMessageType >= heartbeat_request && heartbeatMessageType <= heartbeat_response;
        }
    }
}

#endif
