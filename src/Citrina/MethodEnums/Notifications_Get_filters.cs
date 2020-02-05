namespace Citrina
{
    public enum Notifications_Get_filters
    {
        [EnumMember(Value = "wall")]
        Wall,
        [EnumMember(Value = "mentions")]
        Mentions,
        [EnumMember(Value = "comments")]
        Comments,
        [EnumMember(Value = "likes")]
        Likes,
        [EnumMember(Value = "reposted")]
        Reposted,
        [EnumMember(Value = "followers")]
        Followers,
        [EnumMember(Value = "friends")]
        Friends,
    }
}
