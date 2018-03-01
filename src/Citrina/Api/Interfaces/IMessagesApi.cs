using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IMessagesApi
    {
        /// <summary>
        /// Returns a list of the current user's incoming or outgoing private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetResponse>> Get(UserAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null);
        /// <summary>
        /// Returns a list of the current user's incoming or outgoing private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetResponse>> Get(GroupAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null);
        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(UserAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null);
        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(GroupAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null);
        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<int?> messageIds = null);
        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdResponse>> GetById(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null);
        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(UserAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null);
        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(GroupAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null);
        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(UserAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(GroupAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null);
        
        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<int?>> Send(
            UserAccessToken accessToken,
            int? userId = null,
            int? randomId = null,
            int? peerId = null,
            string domain = null,
            int? chatId = null,
            IEnumerable<int?> userIds = null,
            string message = null,
            double? lat = null,
            double? @long = null,
            string attachment = null,
            string forwardMessages = null,
            int? stickerId = null,
            bool? notification = null);
        
        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<int?>> Send(
            GroupAccessToken accessToken,
            int? userId = null,
            int? randomId = null,
            int? peerId = null,
            string domain = null,
            int? chatId = null,
            IEnumerable<int?> userIds = null,
            string message = null,
            double? lat = null,
            double? @long = null,
            string attachment = null,
            string forwardMessages = null,
            int? stickerId = null,
            bool? notification = null);
        
        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        Task<ApiRequest<MessagesDeleteResponse>> Delete(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null);
        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        Task<ApiRequest<MessagesDeleteResponse>> Delete(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null);
        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteDialog(UserAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteDialog(GroupAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? messageId = null);
        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(GroupAccessToken accessToken, int? messageId = null);
        /// <summary>
        /// Marks messages as read.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsRead(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null);
        /// <summary>
        /// Marks messages as read.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsRead(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null);
        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null);
        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null);
        /// <summary>
        /// Marks and unmarks dialogs as important.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsImportantDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null);
        /// <summary>
        /// Marks and unmarks dialogs as unanswered.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsUnansweredDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null);
        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(UserAccessToken accessToken, int? lpVersion = null, bool? needPts = null);
        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(GroupAccessToken accessToken, int? lpVersion = null, bool? needPts = null);
        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(UserAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null);
        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(GroupAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<MessagesChat>> GetChat(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<MessagesChatFull>> GetChatFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesChat>>> GetChatChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Creates a chat with several participants.
        /// </summary>
        Task<ApiRequest<int?>> CreateChat(UserAccessToken accessToken, IEnumerable<int?> userIds = null, string title = null);
        /// <summary>
        /// Edits the title of a chat.
        /// </summary>
        Task<ApiRequest<bool?>> EditChat(UserAccessToken accessToken, int? chatId = null, string title = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetChatUsers(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<MessagesGetChatUsersChatIdsResponse>> GetChatUsersChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<MessagesGetChatUsersChatIdsFieldsResponse>> GetChatUsersChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Changes the status of a user as typing in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> SetActivity(UserAccessToken accessToken, string userId = null, string type = null, int? peerId = null);
        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> SearchDialogs(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> SearchDialogs(GroupAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Adds a new user to a chat.
        /// </summary>
        Task<ApiRequest<bool?>> AddChatUser(UserAccessToken accessToken, int? chatId = null, int? userId = null);
        /// <summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveChatUser(UserAccessToken accessToken, int? chatId = null, string userId = null);
        /// <summary>
        /// Returns a user's current status and date of last activity.
        /// </summary>
        Task<ApiRequest<MessagesLastActivity>> GetLastActivity(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        /// </summary>
        Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhoto(UserAccessToken accessToken, string file = null);
        /// <summary>
        /// Deletes a chat's cover picture.
        /// </summary>
        Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(UserAccessToken accessToken, int? chatId = null);
        /// <summary>
        /// Denies sending message from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DenyMessagesFromGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Allows sending messages from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> AllowMessagesFromGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(GroupAccessToken accessToken, int? groupId = null, int? userId = null);
    }
}
