using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IMessagesApi
    {
        /// <summary>
        /// Adds a new user to a chat.
        /// </summary>
        Task<ApiRequest<bool?>> AddChatUserApi(int? chatId = null, int? userId = null);

        /// <summary>
        /// Allows sending messages from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> AllowMessagesFromGroupApi(int? groupId = null, string key = null);

        /// <summary>
        /// Creates a chat with several participants.
        /// </summary>
        Task<ApiRequest<int?>> CreateChatApi(IEnumerable<int> userIds = null, string title = null);

        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        Task<ApiRequest<MessagesDeleteResponse>> DeleteApi(IEnumerable<int> messageIds = null, bool? spam = null, int? groupId = null, bool? deleteForAll = null);

        /// <summary>
        /// Deletes a chat's cover picture.
        /// </summary>
        Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhotoApi(int? chatId = null, int? groupId = null);

        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        Task<ApiRequest<MessagesDeleteConversationResponse>> DeleteConversationApi(int? userId = null, int? peerId = null, int? groupId = null);

        /// <summary>
        /// Denies sending message from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DenyMessagesFromGroupApi(int? groupId = null);

        /// <summary>
        /// Edits the message.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? peerId = null, string message = null, int? messageId = null, double? lat = null, double? @long = null, string attachment = null, bool? keepForwardMessages = null, bool? keepSnippets = null, int? groupId = null, bool? dontParseLinks = null);

        /// <summary>
        /// Edits the title of a chat.
        /// </summary>
        Task<ApiRequest<bool?>> EditChatApi(int? chatId = null, string title = null);

        /// <summary>
        /// Returns messages by their IDs within the conversation.
        /// </summary>
        Task<ApiRequest<MessagesGetByConversationMessageIdResponse>> GetByConversationMessageIdApi(int? peerId = null, IEnumerable<int> conversationMessageIds = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdResponse>> GetByIdApi(IEnumerable<int> messageIds = null, int? previewLength = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdExtendedResponse>> GetByIdApi(IEnumerable<int> messageIds = null, int? previewLength = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        Task<ApiRequest<MessagesGetChatPreviewResponse>> GetChatPreviewApi(int? peerId = null, string link = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<MessagesGetConversationMembersResponse>> GetConversationMembersApi(int? peerId = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        Task<ApiRequest<MessagesGetConversationsResponse>> GetConversationsApi(int? offset = null, int? count = null, string filter = null, bool? extended = null, int? startMessageId = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns conversations by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetConversationsByIdResponse>> GetConversationsByIdApi(IEnumerable<int> peerIds = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns conversations by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetConversationsByIdExtendedResponse>> GetConversationsByIdApi(IEnumerable<int> peerIds = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryResponse>> GetHistoryApi(int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachmentsApi(int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<UsersFields> fields = null, int? groupId = null, bool? preserveOrder = null, int? maxForwardsLevel = null);

        Task<ApiRequest<MessagesGetInviteLinkResponse>> GetInviteLinkApi(int? peerId = null, bool? reset = null, int? groupId = null);

        /// <summary>
        /// Returns a user's current status and date of last activity.
        /// </summary>
        Task<ApiRequest<MessagesLastActivity>> GetLastActivityApi(int? userId = null);

        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistoryApi(int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<UsersFields> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null, int? groupId = null, int? lpVersion = null, int? lastN = null, bool? credentials = null);

        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        Task<ApiRequest<MessagesLongpollParams>> GetLongPollServerApi(bool? needPts = null, int? groupId = null, int? lpVersion = null);

        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowedApi(int? groupId = null, int? userId = null);

        Task<ApiRequest<MessagesJoinChatByInviteLinkResponse>> JoinChatByInviteLinkApi(string link = null);

        /// <summary>
        /// Marks and unmarks conversations as unanswered.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsAnsweredConversationApi(int? peerId = null, bool? answered = null, int? groupId = null);

        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> MarkAsImportantApi(IEnumerable<int> messageIds = null, int? important = null);

        /// <summary>
        /// Marks and unmarks conversations as important.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsImportantConversationApi(int? peerId = null, bool? important = null, int? groupId = null);

        /// <summary>
        /// Marks messages as read.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsReadApi(IEnumerable<int> messageIds = null, int? peerId = null, int? startMessageId = null, int? groupId = null);

        /// <summary>
        /// Pin a message.
        /// </summary>
        Task<ApiRequest<MessagesPinnedMessage>> PinApi(int? peerId = null, int? messageId = null);

        /// <summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveChatUserApi(int? chatId = null, int? userId = null, int? memberId = null);

        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreApi(int? messageId = null, int? groupId = null);

        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchResponse>> SearchApi(string q = null, int? peerId = null, int? date = null, int? previewLength = null, int? offset = null, int? count = null, bool? extended = null, IEnumerable<string> fields = null, int? groupId = null);

        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchConversationsResponse>> SearchConversationsApi(string q = null, int? count = null, bool? extended = null, IEnumerable<UsersFields> fields = null, int? groupId = null);

        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<int?>> SendApi(int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, int? replyTo = null, IEnumerable<int> forwardMessages = null, string forward = null, int? stickerId = null, int? groupId = null, string keyboard = null, string payload = null, bool? dontParseLinks = null, bool? disableMentions = null);

        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<IEnumerable<object>>> SendApi(int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, int? replyTo = null, IEnumerable<int> forwardMessages = null, string forward = null, int? stickerId = null, int? groupId = null, string keyboard = null, string payload = null, bool? dontParseLinks = null, bool? disableMentions = null);

        /// <summary>
        /// Changes the status of a user as typing in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> SetActivityApi(int? userId = null, string type = null, int? peerId = null, int? groupId = null);

        /// <summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        /// </summary>
        Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhotoApi(string file = null);

        Task<ApiRequest<bool?>> UnpinApi(int? peerId = null, int? groupId = null);
    }
}
