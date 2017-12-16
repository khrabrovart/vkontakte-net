using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class MessagesApi : IMessagesApi
    {
        public Task<ApiRequest<MessagesGetResponse>> Get(UserAccessToken accessToken, bool? @out, int? offset, int? count, int? filter, int? timeOffset, int? previewLength, int? lastMessageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter?.ToString(),
                ["time_offset"] = timeOffset?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["last_message_id"] = lastMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetResponse>> Get(GroupAccessToken accessToken, bool? @out, int? offset, int? count, int? filter, int? timeOffset, int? previewLength, int? lastMessageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter?.ToString(),
                ["time_offset"] = timeOffset?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["last_message_id"] = lastMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(UserAccessToken accessToken, int? offset, int? count, int? startMessageId, int? previewLength, bool? unread, bool? important, bool? unanswered)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["unread"] = RequestHelpers.ParseBoolean(unread),
                ["important"] = RequestHelpers.ParseBoolean(important),
                ["unanswered"] = RequestHelpers.ParseBoolean(unanswered),
            };

            return RequestManager.CreateRequestAsync<MessagesGetDialogsResponse>("messages.getDialogs", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(GroupAccessToken accessToken, int? offset, int? count, int? startMessageId, int? previewLength, bool? unread, bool? important, bool? unanswered)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["unread"] = RequestHelpers.ParseBoolean(unread),
                ["important"] = RequestHelpers.ParseBoolean(important),
                ["unanswered"] = RequestHelpers.ParseBoolean(unanswered),
            };

            return RequestManager.CreateRequestAsync<MessagesGetDialogsResponse>("messages.getDialogs", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<int?> messageIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(GroupAccessToken accessToken, IEnumerable<int?> messageIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken, request);
        }

        public Task<ApiRequest<MessagesSearchResponse>> Search(UserAccessToken accessToken, string q, int? peerId, DateTime? date, int? previewLength, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["peer_id"] = peerId?.ToString(),
                ["date"] = RequestHelpers.ParseDateTime(date),
                ["preview_length"] = previewLength?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesSearchResponse>("messages.search", accessToken, request);
        }

        public Task<ApiRequest<MessagesSearchResponse>> Search(GroupAccessToken accessToken, string q, int? peerId, DateTime? date, int? previewLength, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["peer_id"] = peerId?.ToString(),
                ["date"] = RequestHelpers.ParseDateTime(date),
                ["preview_length"] = previewLength?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesSearchResponse>("messages.search", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(UserAccessToken accessToken, int? offset, int? count, int? userId, int? peerId, int? startMessageId, int? rev)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["rev"] = rev?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryResponse>("messages.getHistory", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(GroupAccessToken accessToken, int? offset, int? count, int? userId, int? peerId, int? startMessageId, int? rev)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["rev"] = rev?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryResponse>("messages.getHistory", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(UserAccessToken accessToken, int? peerId, string mediaType, string startFrom, int? count, bool? photoSizes, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = peerId?.ToString(),
                ["media_type"] = mediaType,
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(GroupAccessToken accessToken, int? peerId, string mediaType, string startFrom, int? count, bool? photoSizes, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = peerId?.ToString(),
                ["media_type"] = mediaType,
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", accessToken, request);
        }

        // Verified signature / response
        public Task<ApiRequest<int?>> Send(
            UserAccessToken accessToken,
            int? userId,
            int? randomId,
            int? peerId,
            string domain,
            int? chatId,
            IEnumerable<int?> userIds,
            string message,
            double? lat,
            double? @long,
            string attachment,
            string forwardMessages,
            int? stickerId,
            bool? notification)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["random_id"] = randomId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["domain"] = domain,
                ["chat_id"] = chatId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["message"] = message,
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["attachment"] = attachment,
                ["forward_messages"] = forwardMessages,
                ["sticker_id"] = stickerId?.ToString(),
                ["notification"] = RequestHelpers.ParseBoolean(notification),
            };

            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken, request);
        }

        // Verified signature / response
        public Task<ApiRequest<int?>> Send(
            GroupAccessToken accessToken,
            int? userId,
            int? randomId,
            int? peerId,
            string domain,
            int? chatId,
            IEnumerable<int?> userIds,
            string message,
            double? lat,
            double? @long,
            string attachment,
            string forwardMessages,
            int? stickerId,
            bool? notification)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["random_id"] = randomId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["domain"] = domain,
                ["chat_id"] = chatId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["message"] = message,
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["attachment"] = attachment,
                ["forward_messages"] = forwardMessages,
                ["sticker_id"] = stickerId?.ToString(),
                ["notification"] = RequestHelpers.ParseBoolean(notification),
            };

            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(UserAccessToken accessToken, IEnumerable<int?> messageIds, bool? spam)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["spam"] = RequestHelpers.ParseBoolean(spam),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(GroupAccessToken accessToken, IEnumerable<int?> messageIds, bool? spam)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["spam"] = RequestHelpers.ParseBoolean(spam),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteDialog(UserAccessToken accessToken, string userId, int? peerId, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId,
                ["peer_id"] = peerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.deleteDialog", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteDialog(GroupAccessToken accessToken, string userId, int? peerId, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId,
                ["peer_id"] = peerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.deleteDialog", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? messageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_id"] = messageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(GroupAccessToken accessToken, int? messageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_id"] = messageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsRead(UserAccessToken accessToken, IEnumerable<int?> messageIds, string peerId, int? startMessageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["peer_id"] = peerId,
                ["start_message_id"] = startMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsRead", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsRead(GroupAccessToken accessToken, IEnumerable<int?> messageIds, string peerId, int? startMessageId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["peer_id"] = peerId,
                ["start_message_id"] = startMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsRead", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(UserAccessToken accessToken, IEnumerable<int?> messageIds, int? important)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(GroupAccessToken accessToken, IEnumerable<int?> messageIds, int? important)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsImportantDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId, int? important)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = RequestHelpers.ParseEnumerable(peerId),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsImportantDialog", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsUnansweredDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId, int? important)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = RequestHelpers.ParseEnumerable(peerId),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsUnansweredDialog", accessToken, request);
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(UserAccessToken accessToken, int? lpVersion, bool? needPts)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lp_version"] = lpVersion?.ToString(),
                ["need_pts"] = RequestHelpers.ParseBoolean(needPts),
            };

            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken, request);
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(GroupAccessToken accessToken, int? lpVersion, bool? needPts)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lp_version"] = lpVersion?.ToString(),
                ["need_pts"] = RequestHelpers.ParseBoolean(needPts),
            };

            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(UserAccessToken accessToken, int? ts, int? pts, int? previewLength, bool? onlines, IEnumerable<string> fields, int? eventsLimit, int? msgsLimit, int? maxMsgId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["ts"] = ts?.ToString(),
                ["pts"] = pts?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["onlines"] = RequestHelpers.ParseBoolean(onlines),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["events_limit"] = eventsLimit?.ToString(),
                ["msgs_limit"] = msgsLimit?.ToString(),
                ["max_msg_id"] = maxMsgId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(GroupAccessToken accessToken, int? ts, int? pts, int? previewLength, bool? onlines, IEnumerable<string> fields, int? eventsLimit, int? msgsLimit, int? maxMsgId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["ts"] = ts?.ToString(),
                ["pts"] = pts?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["onlines"] = RequestHelpers.ParseBoolean(onlines),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["events_limit"] = eventsLimit?.ToString(),
                ["msgs_limit"] = msgsLimit?.ToString(),
                ["max_msg_id"] = maxMsgId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", accessToken, request);
        }

        public Task<ApiRequest<MessagesChat>> GetChat(UserAccessToken accessToken, int? chatId, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesChat>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<MessagesChatFull>> GetChatFields(UserAccessToken accessToken, int? chatId, IEnumerable<string> fields, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesChatFull>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<MessagesChat>>> GetChatChatIds(UserAccessToken accessToken, int? chatId, IEnumerable<int?> chatIds, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["chat_ids"] = RequestHelpers.ParseEnumerable(chatIds),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<MessagesChat>>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(UserAccessToken accessToken, int? chatId, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<MessagesChatFull>>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateChat(UserAccessToken accessToken, IEnumerable<int?> userIds, string title)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("messages.createChat", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditChat(UserAccessToken accessToken, int? chatId, string title)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.editChat", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetChatUsers(UserAccessToken accessToken, int? chatId, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(UserAccessToken accessToken, int? chatId, IEnumerable<string> fields, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<MessagesUserXtrInvitedBy>>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetChatUsersChatIdsResponse>> GetChatUsersChatIds(UserAccessToken accessToken, int? chatId, IEnumerable<int?> chatIds, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["chat_ids"] = RequestHelpers.ParseEnumerable(chatIds),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesGetChatUsersChatIdsResponse>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetChatUsersChatIdsFieldsResponse>> GetChatUsersChatIdsFields(UserAccessToken accessToken, int? chatId, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesGetChatUsersChatIdsFieldsResponse>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetActivity(UserAccessToken accessToken, string userId, string type, int? peerId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId,
                ["type"] = type,
                ["peer_id"] = peerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.setActivity", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(UserAccessToken accessToken, string q, int? limit, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["limit"] = limit?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<string>>("messages.searchDialogs", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(GroupAccessToken accessToken, string q, int? limit, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["limit"] = limit?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<string>>("messages.searchDialogs", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddChatUser(UserAccessToken accessToken, int? chatId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.addChatUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveChatUser(UserAccessToken accessToken, int? chatId, string userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.removeChatUser", accessToken, request);
        }

        public Task<ApiRequest<MessagesLastActivity>> GetLastActivity(UserAccessToken accessToken, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesLastActivity>("messages.getLastActivity", accessToken, request);
        }

        public Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhoto(UserAccessToken accessToken, string file)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
            };

            return RequestManager.CreateRequestAsync<MessagesSetChatPhotoResponse>("messages.setChatPhoto", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(UserAccessToken accessToken, int? chatId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DenyMessagesFromGroup(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.denyMessagesFromGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AllowMessagesFromGroup(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.allowMessagesFromGroup", accessToken, request);
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(UserAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", accessToken, request);
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(GroupAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", accessToken, request);
        }
    }
}
