using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Messages : IMessages
    {
        /// <summary>
        /// Adds a new user to a chat.
        /// </summary>
        public Task<ApiRequest<bool?>> AddChatUserApi(int? chatId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.addChatUser", null, request);
        }

        /// <summary>
        /// Allows sending messages from community to the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> AllowMessagesFromGroupApi(int? groupId = null, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.allowMessagesFromGroup", null, request);
        }

        /// <summary>
        /// Creates a chat with several participants.
        /// </summary>
        public Task<ApiRequest<int?>> CreateChatApi(IEnumerable<int> userIds = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("messages.createChat", null, request);
        }

        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        public Task<ApiRequest<MessagesDeleteResponse>> DeleteApi(IEnumerable<int> messageIds = null, bool? spam = null, int? groupId = null, bool? deleteForAll = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["spam"] = RequestHelpers.ParseBoolean(spam),
                ["group_id"] = groupId?.ToString(),
                ["delete_for_all"] = RequestHelpers.ParseBoolean(deleteForAll),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", null, request);
        }

        /// <summary>
        /// Deletes a chat's cover picture.
        /// </summary>
        public Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhotoApi(int? chatId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["chat_id"] = chatId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", null, request);
        }

        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        public Task<ApiRequest<MessagesDeleteConversationResponse>> DeleteConversationApi(int? userId = null, int? peerId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesDeleteConversationResponse>("messages.deleteConversation", null, request);
        }

        /// <summary>
        /// Denies sending message from community to the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> DenyMessagesFromGroupApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.denyMessagesFromGroup", null, request);
        }

        /// <summary>
        /// Edits the message.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? peerId = null, string message = null, int? messageId = null, double? lat = null, double? @long = null, string attachment = null, bool? keepForwardMessages = null, bool? keepSnippets = null, int? groupId = null, bool? dontParseLinks = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["message"] = message,
                ["message_id"] = messageId?.ToString(),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["attachment"] = attachment,
                ["keep_forward_messages"] = RequestHelpers.ParseBoolean(keepForwardMessages),
                ["keep_snippets"] = RequestHelpers.ParseBoolean(keepSnippets),
                ["group_id"] = groupId?.ToString(),
                ["dont_parse_links"] = RequestHelpers.ParseBoolean(dontParseLinks),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.edit", null, request);
        }

        /// <summary>
        /// Edits the title of a chat.
        /// </summary>
        public Task<ApiRequest<bool?>> EditChatApi(int? chatId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["chat_id"] = chatId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.editChat", null, request);
        }

        /// <summary>
        /// Returns messages by their IDs within the conversation.
        /// </summary>
        public Task<ApiRequest<MessagesGetByConversationMessageIdResponse>> GetByConversationMessageIdApi(int? peerId = null, IEnumerable<int> conversationMessageIds = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["conversation_message_ids"] = RequestHelpers.ParseEnumerable(conversationMessageIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByConversationMessageIdResponse>("messages.getByConversationMessageId", null, request);
        }

        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        public Task<ApiRequest<MessagesGetByIdResponse>> GetByIdApi(IEnumerable<int> messageIds = null, int? previewLength = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", null, request);
        }

        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        public Task<ApiRequest<MessagesGetByIdExtendedResponse>> GetByIdApi(IEnumerable<int> messageIds = null, int? previewLength = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetByIdExtendedResponse>("messages.getById", null, request);
        }

        public Task<ApiRequest<MessagesGetChatPreviewResponse>> GetChatPreviewApi(int? peerId = null, string link = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["link"] = link,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MessagesGetChatPreviewResponse>("messages.getChatPreview", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        public Task<ApiRequest<MessagesGetConversationMembersResponse>> GetConversationMembersApi(int? peerId = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetConversationMembersResponse>("messages.getConversationMembers", null, request);
        }

        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        public Task<ApiRequest<MessagesGetConversationsResponse>> GetConversationsApi(int? offset = null, int? count = null, string filter = null, bool? extended = null, int? startMessageId = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["start_message_id"] = startMessageId?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetConversationsResponse>("messages.getConversations", null, request);
        }

        /// <summary>
        /// Returns conversations by their IDs.
        /// </summary>
        public Task<ApiRequest<MessagesGetConversationsByIdResponse>> GetConversationsByIdApi(IEnumerable<int> peerIds = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_ids"] = RequestHelpers.ParseEnumerable(peerIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetConversationsByIdResponse>("messages.getConversationsById", null, request);
        }

        /// <summary>
        /// Returns conversations by their IDs.
        /// </summary>
        public Task<ApiRequest<MessagesGetConversationsByIdExtendedResponse>> GetConversationsByIdApi(IEnumerable<int> peerIds = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_ids"] = RequestHelpers.ParseEnumerable(peerIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetConversationsByIdExtendedResponse>("messages.getConversationsById", null, request);
        }

        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistoryApi(int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["rev"] = rev?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryResponse>("messages.getHistory", null, request);
        }

        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachmentsApi(int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<UsersFields> fields = null, int? groupId = null, bool? preserveOrder = null, int? maxForwardsLevel = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["media_type"] = mediaType,
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
                ["preserve_order"] = RequestHelpers.ParseBoolean(preserveOrder),
                ["max_forwards_level"] = maxForwardsLevel?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", null, request);
        }

        public Task<ApiRequest<MessagesGetInviteLinkResponse>> GetInviteLinkApi(int? peerId = null, bool? reset = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["reset"] = RequestHelpers.ParseBoolean(reset),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesGetInviteLinkResponse>("messages.getInviteLink", null, request);
        }

        /// <summary>
        /// Returns a user's current status and date of last activity.
        /// </summary>
        public Task<ApiRequest<MessagesLastActivity>> GetLastActivityApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesLastActivity>("messages.getLastActivity", null, request);
        }

        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistoryApi(int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<UsersFields> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null, int? groupId = null, int? lpVersion = null, int? lastN = null, bool? credentials = null)
        {
            var request = new Dictionary<string, string>
            {
                ["ts"] = ts?.ToString(),
                ["pts"] = pts?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["onlines"] = RequestHelpers.ParseBoolean(onlines),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["events_limit"] = eventsLimit?.ToString(),
                ["msgs_limit"] = msgsLimit?.ToString(),
                ["max_msg_id"] = maxMsgId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["lp_version"] = lpVersion?.ToString(),
                ["last_n"] = lastN?.ToString(),
                ["credentials"] = RequestHelpers.ParseBoolean(credentials),
            };

            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", null, request);
        }

        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServerApi(bool? needPts = null, int? groupId = null, int? lpVersion = null)
        {
            var request = new Dictionary<string, string>
            {
                ["need_pts"] = RequestHelpers.ParseBoolean(needPts),
                ["group_id"] = groupId?.ToString(),
                ["lp_version"] = lpVersion?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", null, request);
        }

        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowedApi(int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", null, request);
        }

        public Task<ApiRequest<MessagesJoinChatByInviteLinkResponse>> JoinChatByInviteLinkApi(string link = null)
        {
            var request = new Dictionary<string, string>
            {
                ["link"] = link,
            };

            return RequestManager.CreateRequestAsync<MessagesJoinChatByInviteLinkResponse>("messages.joinChatByInviteLink", null, request);
        }

        /// <summary>
        /// Marks and unmarks conversations as unanswered.
        /// </summary>
        public Task<ApiRequest<bool?>> MarkAsAnsweredConversationApi(int? peerId = null, bool? answered = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["answered"] = RequestHelpers.ParseBoolean(answered),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsAnsweredConversation", null, request);
        }

        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> MarkAsImportantApi(IEnumerable<int> messageIds = null, int? important = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["important"] = important?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("messages.markAsImportant", null, request);
        }

        /// <summary>
        /// Marks and unmarks conversations as important.
        /// </summary>
        public Task<ApiRequest<bool?>> MarkAsImportantConversationApi(int? peerId = null, bool? important = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["important"] = RequestHelpers.ParseBoolean(important),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsImportantConversation", null, request);
        }

        /// <summary>
        /// Marks messages as read.
        /// </summary>
        public Task<ApiRequest<bool?>> MarkAsReadApi(IEnumerable<int> messageIds = null, int? peerId = null, int? startMessageId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_ids"] = RequestHelpers.ParseEnumerable(messageIds),
                ["peer_id"] = peerId?.ToString(),
                ["start_message_id"] = startMessageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.markAsRead", null, request);
        }

        /// <summary>
        /// Pin a message.
        /// </summary>
        public Task<ApiRequest<MessagesPinnedMessage>> PinApi(int? peerId = null, int? messageId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["message_id"] = messageId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesPinnedMessage>("messages.pin", null, request);
        }

        /// <summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveChatUserApi(int? chatId = null, int? userId = null, int? memberId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["chat_id"] = chatId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["member_id"] = memberId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.removeChatUser", null, request);
        }

        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreApi(int? messageId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["message_id"] = messageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.restore", null, request);
        }

        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        public Task<ApiRequest<MessagesSearchResponse>> SearchApi(string q = null, int? peerId = null, int? date = null, int? previewLength = null, int? offset = null, int? count = null, bool? extended = null, IEnumerable<string> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["peer_id"] = peerId?.ToString(),
                ["date"] = date?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesSearchResponse>("messages.search", null, request);
        }

        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        public Task<ApiRequest<MessagesSearchConversationsResponse>> SearchConversationsApi(string q = null, int? count = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MessagesSearchConversationsResponse>("messages.searchConversations", null, request);
        }

        /// <summary>
        /// Sends a message.
        /// </summary>
        public Task<ApiRequest<int?>> SendApi(int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, int? replyTo = null, IEnumerable<int> forwardMessages = null, string forward = null, int? stickerId = null, int? groupId = null, string keyboard = null, string payload = null, bool? dontParseLinks = null, bool? disableMentions = null)
        {
            var request = new Dictionary<string, string>
            {
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
                ["reply_to"] = replyTo?.ToString(),
                ["forward_messages"] = RequestHelpers.ParseEnumerable(forwardMessages),
                ["forward"] = forward,
                ["sticker_id"] = stickerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["keyboard"] = keyboard,
                ["payload"] = payload,
                ["dont_parse_links"] = RequestHelpers.ParseBoolean(dontParseLinks),
                ["disable_mentions"] = RequestHelpers.ParseBoolean(disableMentions),
            };

            return RequestManager.CreateRequestAsync<int?>("messages.send", null, request);
        }

        /// <summary>
        /// Sends a message.
        /// </summary>
        public Task<ApiRequest<IEnumerable<object>>> SendApi(int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, int? replyTo = null, IEnumerable<int> forwardMessages = null, string forward = null, int? stickerId = null, int? groupId = null, string keyboard = null, string payload = null, bool? dontParseLinks = null, bool? disableMentions = null)
        {
            var request = new Dictionary<string, string>
            {
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
                ["reply_to"] = replyTo?.ToString(),
                ["forward_messages"] = RequestHelpers.ParseEnumerable(forwardMessages),
                ["forward"] = forward,
                ["sticker_id"] = stickerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["keyboard"] = keyboard,
                ["payload"] = payload,
                ["dont_parse_links"] = RequestHelpers.ParseBoolean(dontParseLinks),
                ["disable_mentions"] = RequestHelpers.ParseBoolean(disableMentions),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<object>>("messages.send", null, request);
        }

        /// <summary>
        /// Changes the status of a user as typing in a conversation.
        /// </summary>
        public Task<ApiRequest<bool?>> SetActivityApi(int? userId = null, string type = null, int? peerId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["peer_id"] = peerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.setActivity", null, request);
        }

        /// <summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        /// </summary>
        public Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhotoApi(string file = null)
        {
            var request = new Dictionary<string, string>
            {
                ["file"] = file,
            };

            return RequestManager.CreateRequestAsync<MessagesSetChatPhotoResponse>("messages.setChatPhoto", null, request);
        }

        public Task<ApiRequest<bool?>> UnpinApi(int? peerId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("messages.unpin", null, request);
        }
    }
}
