namespace Citrina
{
    /// <summary>
    /// Filter to apply: 'all' — all conversations, 'unread' — conversations with unread messages, 'important' — conversations, marked as important (only for community messages), 'unanswered' — conversations, marked as unanswered (only for community messages).
    /// </summary>
    public enum Messages_GetConversations_filter
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "business_notify")]
        BusinessNotify,
        [EnumMember(Value = "important")]
        Important,
        [EnumMember(Value = "message_request")]
        MessageRequest,
        [EnumMember(Value = "unanswered")]
        Unanswered,
        [EnumMember(Value = "unread")]
        Unread,
    }
}
