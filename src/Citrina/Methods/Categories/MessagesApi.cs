using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class MessagesApi : IMessagesApi
    {
        public Task<ApiRequest<MessagesGetResponse>> Get(UserAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["@out"] = RequestHelpers.ParseBoolean(@out),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter?.ToString(),
                ["time_offset"] = timeOffset?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["last_message_id"] = lastMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetResponse>> Get(GroupAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["@out"] = RequestHelpers.ParseBoolean(@out),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter?.ToString(),
                ["time_offset"] = timeOffset?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["last_message_id"] = lastMessageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(UserAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null)
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

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(GroupAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null)
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

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<int?> messageIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken, request);
        }

        public Task<ApiRequest<MessagesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null)
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

        public Task<ApiRequest<MessagesSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null)
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

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(UserAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null)
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

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(GroupAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null)
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

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(UserAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null)
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

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(GroupAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null)
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

        public Task<ApiRequest<int?>> Send(UserAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null)
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
                ["@long"] = @long?.ToString(),
                ["attachment"] = attachment,
                ["forward_messages"] = forwardMessages,
                ["sticker_id"] = stickerId?.ToString(),
                ["notification"] = RequestHelpers.ParseBoolean(notification),
            };

            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken, request);
        }

        public Task<ApiRequest<int?>> Send(GroupAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null)
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
                ["@long"] = @long?.ToString(),
                ["attachment"] = attachment,
                ["forward_messages"] = forwardMessages,
                ["sticker_id"] = stickerId?.ToString(),
                ["notification"] = RequestHelpers.ParseBoolean(notification),
            };

            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["spam"] = RequestHelpers.ParseBoolean(spam),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["spam"] = RequestHelpers.ParseBoolean(spam),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteDialog(UserAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null)
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

        public Task<ApiRequest<bool?>> DeleteDialog(GroupAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null)
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

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? messageId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_id"] = messageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(GroupAccessToken accessToken, int? messageId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_id"] = messageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsRead(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null)
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

        public Task<ApiRequest<bool?>> MarkAsRead(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null)
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

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsImportantDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = RequestHelpers.ParseEnumerable(peerId),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsImportantDialog", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsUnansweredDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["peer_id"] = RequestHelpers.ParseEnumerable(peerId),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsUnansweredDialog", accessToken, request);
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(UserAccessToken accessToken, int? lpVersion = null, bool? needPts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lp_version"] = lpVersion?.ToString(),
                ["need_pts"] = RequestHelpers.ParseBoolean(needPts),
            };

            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken, request);
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(GroupAccessToken accessToken, int? lpVersion = null, bool? needPts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lp_version"] = lpVersion?.ToString(),
                ["need_pts"] = RequestHelpers.ParseBoolean(needPts),
            };

            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken, request);
        }

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(UserAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null)
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

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(GroupAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null)
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

        public Task<ApiRequest<MessagesChat>> GetChat(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesChat>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<MessagesChatFull>> GetChatFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null)
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

        public Task<ApiRequest<IEnumerable<MessagesChat>>> GetChatChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null)
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

        public Task<ApiRequest<IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<MessagesChatFull>>("messages.getChat", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateChat(UserAccessToken accessToken, IEnumerable<int?> userIds = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("messages.createChat", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditChat(UserAccessToken accessToken, int? chatId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.editChat", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetChatUsers(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null)
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

        public Task<ApiRequest<MessagesGetChatUsersChatIdsResponse>> GetChatUsersChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null)
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

        public Task<ApiRequest<MessagesGetChatUsersChatIdsFieldsResponse>> GetChatUsersChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<MessagesGetChatUsersChatIdsFieldsResponse>("messages.getChatUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetActivity(UserAccessToken accessToken, string userId = null, string type = null, int? peerId = null)
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

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null)
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

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(GroupAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null)
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

        public Task<ApiRequest<bool?>> AddChatUser(UserAccessToken accessToken, int? chatId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.addChatUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveChatUser(UserAccessToken accessToken, int? chatId = null, string userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.removeChatUser", accessToken, request);
        }

        public Task<ApiRequest<MessagesLastActivity>> GetLastActivity(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesLastActivity>("messages.getLastActivity", accessToken, request);
        }

        public Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhoto(UserAccessToken accessToken, string file = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
            };

            return RequestManager.CreateRequestAsync<MessagesSetChatPhotoResponse>("messages.setChatPhoto", accessToken, request);
        }

        public Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(UserAccessToken accessToken, int? chatId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DenyMessagesFromGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.denyMessagesFromGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AllowMessagesFromGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.allowMessagesFromGroup", accessToken, request);
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", accessToken, request);
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(GroupAccessToken accessToken, int? groupId = null, int? userId = null)
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
