namespace Citrina
{
    /// <summary>
    /// Type of complaint: 'porn' – pornography, 'spam' – spamming, 'insult' – abusive behavior, 'advertisement' – disruptive advertisements.
    /// </summary>
    public enum Users_Report_type
    {
        [EnumMember(Value = "porn")]
        Porn,
        [EnumMember(Value = "spam")]
        Spam,
        [EnumMember(Value = "insult")]
        Insult,
        [EnumMember(Value = "advertisement")]
        Advertisement,
    }
}
