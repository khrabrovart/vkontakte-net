using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Citrina.StandardApi.Core;

namespace Citrina.CallbackApi
{
    internal class CallbackEventHandler : ICallbackEventHandler
    {
        private static readonly Dictionary<string, CallbackEventType> EventMap = new Dictionary<string, CallbackEventType>
        {
            ["confirmation"] = CallbackEventType.Confirmation,
            ["wall_reply_new"] = CallbackEventType.WallReplyNew,
            ["wall_reply_edit"] = CallbackEventType.WallReplyEdit,
            ["wall_post_new"] = CallbackEventType.WallPostNew,
            ["audio_new"] = CallbackEventType.AudioNew,
            ["photo_new"] = CallbackEventType.PhotoNew,
            ["photo_comment_new"] = CallbackEventType.PhotoCommentNew,
            ["video_new"] = CallbackEventType.VideoNew,
            ["video_comment_new"] = CallbackEventType.VideoCommentNew,
            ["message_new"] = CallbackEventType.MessageNew,
            ["message_allow"] = CallbackEventType.MessageAllow,
            ["message_deny"] = CallbackEventType.MessageDeny,
            ["group_leave"] = CallbackEventType.GroupLeave,
            ["group_join"] = CallbackEventType.GroupJoin,
            ["board_post_new"] = CallbackEventType.BoardPostNew,
            ["board_post_edit"] = CallbackEventType.BoardPostEdit,
            ["board_post_restore"] = CallbackEventType.BoardPostRestore,
            ["board_post_delete"] = CallbackEventType.BoardPostDelete,
            ["market_comment_new"] = CallbackEventType.MarketCommentNew
        };

        public CallbackEventType GetEventType(CallbackEvent e)
        {
            if (!EventMap.TryGetValue(e.Type, out CallbackEventType type))
            {
                return CallbackEventType.Undefined;
            }

            return type;
        }

        public T GetEventObject<T>(CallbackEvent e)
            where T : ICallbackModel
        {
            try
            {
                return JsonCore.Deserialize<T>(JsonCore.Serialize(e.Object));
            }
            catch
            {
                return default(T);
            }
        }

        public HttpResponseMessage GetEventResponse(string confirmationCode, CallbackEvent e)
        {
            var type = GetEventType(e);
            if (type != CallbackEventType.Confirmation)
            {
                confirmationCode = "ok";
            }

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(confirmationCode, Encoding.UTF8, "text/plain")
            };

            return response;
        }

        public HttpResponseMessage GetEventResponse(Dictionary<int, string> communityToCodesMap, CallbackEvent e)
        {
            string code;
            var type = GetEventType(e);
            if (type != CallbackEventType.Confirmation)
            {
                code = "ok";
            }
            else
            {
                if (!communityToCodesMap.TryGetValue(e.GroupId, out code))
                {
                    throw new ArgumentException($"Community with id {e.GroupId} not found in dictionary.", nameof(communityToCodesMap));
                }
            }

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(code, Encoding.UTF8, "text/plain")
            };

            return response;
        }
    }
}
