using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class MessagesAudioMessage
    {
        public string AccessKey { get; set; } 

        public int? Duration { get; set; } 

        public int? Id { get; set; } 

        public string LinkMp3 { get; set; } 

        public string LinkOgg { get; set; } 

        public int? OwnerId { get; set; } 

        public IEnumerable<object> Waveform { get; set; } 
    }

    public class MessagesChat
    {
        public int? AdminId { get; set; } 

        public int? Id { get; set; } 

        public bool? Kicked { get; set; } 

        public bool? Left { get; set; } 

        public string Photo100 { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo50 { get; set; } 

        public MessagesChatPushSettings PushSettings { get; set; } 

        public string Title { get; set; } 

        public string Type { get; set; } 

        public IEnumerable<object> Users { get; set; } 
    }

    public class MessagesChatFull
    {
        public int? AdminId { get; set; } 

        public int? Id { get; set; } 

        public bool? Kicked { get; set; } 

        public bool? Left { get; set; } 

        public string Photo100 { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo50 { get; set; } 

        public MessagesChatPushSettings PushSettings { get; set; } 

        public string Title { get; set; } 

        public string Type { get; set; } 

        public IEnumerable<object> Users { get; set; } 
    }

    public class MessagesChatPushSettings
    {
        public int? DisabledUntil { get; set; } 

        public bool? Sound { get; set; } 
    }

    public class MessagesChatRestrictions
    {
        public bool? AdminsPromoteUsers { get; set; } 

        public bool? OnlyAdminsEditInfo { get; set; } 

        public bool? OnlyAdminsEditPin { get; set; } 

        public bool? OnlyAdminsInvite { get; set; } 

        public bool? OnlyAdminsKick { get; set; } 
    }

    public class MessagesConversation
    {
        public MessagesKeyboard CurrentKeyboard { get; set; } 

        public bool? Important { get; set; } 

        public int? InRead { get; set; } 

        public int? LastMessageId { get; set; } 

        public IEnumerable<object> Mentions { get; set; } 

        public string MessageRequest { get; set; } 

        public int? OutRead { get; set; } 

        public MessagesConversationPeer Peer { get; set; } 

        public bool? Unanswered { get; set; } 

        public int? UnreadCount { get; set; } 
    }

    public class MessagesConversationMember
    {
        public bool? CanKick { get; set; } 

        public int? InvitedBy { get; set; } 

        public bool? IsAdmin { get; set; } 

        public bool? IsOwner { get; set; } 

        public int? JoinDate { get; set; } 

        public int? MemberId { get; set; } 
    }

    public class MessagesConversationPeer
    {
        public int? Id { get; set; } 

        public int? LocalId { get; set; } 

        public MessagesConversationPeerType Type { get; set; } 
    }

    public class MessagesConversationPeerType
    {
    }

    public class MessagesConversationWithMessage
    {
        public MessagesConversation Conversation { get; set; } 

        public MessagesMessage LastMessage { get; set; } 
    }

    public class MessagesForeignMessage
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? ConversationMessageId { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public IEnumerable<object> FwdMessages { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public int? PeerId { get; set; } 

        public MessagesForeignMessage ReplyMessage { get; set; } 

        public string Text { get; set; } 

        public int? UpdateTime { get; set; } 
    }

    public class MessagesGraffiti
    {
        public string AccessKey { get; set; } 

        public int? Height { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Url { get; set; } 

        public int? Width { get; set; } 
    }

    public class MessagesHistoryAttachment
    {
        public MessagesHistoryMessageAttachment Attachment { get; set; } 

        public int? MessageId { get; set; } 
    }

    public class MessagesHistoryMessageAttachment
    {
        public AudioAudioFull Audio { get; set; } 

        public MessagesAudioMessage AudioMessage { get; set; } 

        public DocsDoc Doc { get; set; } 

        public MessagesGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public BaseLink Market { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseLink Share { get; set; } 

        public MessagesHistoryMessageAttachmentType Type { get; set; } 

        public VideoVideo Video { get; set; } 

        public BaseLink Wall { get; set; } 
    }

    public class MessagesHistoryMessageAttachmentType
    {
    }

    public class MessagesKeyboard
    {
        public int? AuthorId { get; set; } 

        public IEnumerable<object> Buttons { get; set; } 

        public bool? OneTime { get; set; } 
    }

    public class MessagesKeyboardButton
    {
        public MessagesKeyboardButtonAction Action { get; set; } 

        public string Color { get; set; } 
    }

    public class MessagesKeyboardButtonAction
    {
        public int? AppId { get; set; } 

        public string Hash { get; set; } 

        public string Label { get; set; } 

        public int? OwnerId { get; set; } 

        public string Payload { get; set; } 

        public string Type { get; set; } 
    }

    public class MessagesLastActivity
    {
        public bool? Online { get; set; } 

        public int? Time { get; set; } 
    }

    public class MessagesLongpollMessages
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class MessagesLongpollParams
    {
        public string Key { get; set; } 

        public int? Pts { get; set; } 

        public string Server { get; set; } 

        public int? Ts { get; set; } 
    }

    public class MessagesMessage
    {
        public MessagesMessageAction Action { get; set; } 

        public int? AdminAuthorId { get; set; } 

        public IEnumerable<object> Attachments { get; set; } 

        public int? ConversationMessageId { get; set; } 

        public int? Date { get; set; } 

        public bool? Deleted { get; set; } 

        public int? FromId { get; set; } 

        public IEnumerable<object> FwdMessages { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public bool? Important { get; set; } 

        public bool? IsHidden { get; set; } 

        public MessagesKeyboard Keyboard { get; set; } 

        public int? MembersCount { get; set; } 

        public bool? Out { get; set; } 

        public string Payload { get; set; } 

        public int? PeerId { get; set; } 

        public int? RandomId { get; set; } 

        public MessagesForeignMessage ReplyMessage { get; set; } 

        public string Text { get; set; } 

        public int? UpdateTime { get; set; } 
    }

    public class MessagesMessageAction
    {
        public int? ConversationMessageId { get; set; } 

        public string Email { get; set; } 

        public int? MemberId { get; set; } 

        public string Message { get; set; } 

        public MessagesMessageActionPhoto Photo { get; set; } 

        public string Text { get; set; } 

        public MessagesMessageActionStatus Type { get; set; } 
    }

    public class MessagesMessageActionPhoto
    {
        public string Photo100 { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo50 { get; set; } 
    }

    public class MessagesMessageActionStatus
    {
    }

    public class MessagesMessageAttachment
    {
        public AudioAudioFull Audio { get; set; } 

        public MessagesAudioMessage AudioMessage { get; set; } 

        public DocsDoc Doc { get; set; } 

        public GiftsLayout Gift { get; set; } 

        public MessagesGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketMarketAlbum { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseSticker Sticker { get; set; } 

        public MessagesMessageAttachmentType Type { get; set; } 

        public VideoVideo Video { get; set; } 

        public WallWallpostFull Wall { get; set; } 

        public WallWallComment WallReply { get; set; } 
    }

    public class MessagesMessageAttachmentType
    {
    }

    public class MessagesPinnedMessage
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? ConversationMessageId { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public MessagesForeignMessage FwdMessages { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public int? PeerId { get; set; } 

        public MessagesForeignMessage ReplyMessage { get; set; } 

        public string Text { get; set; } 
    }

    public class MessagesUserXtrInvitedBy
    {
    }
}
