namespace Citrina
{
    /// <summary>
    /// Sort order. Possible values: *'0' — default sorting (similar the full version of the site),, *'1' — by growth speed,, *'2'— by the "day attendance/members number" ratio,, *'3' — by the "Likes number/members number" ratio,, *'4' — by the "comments number/members number" ratio,, *'5' — by the "boards entries number/members number" ratio.
    /// </summary>
    public enum Groups_Search_sort
    {
        Default = 0,
        Growth = 1,
        Attendance = 2,
        Likes = 3,
        Comments = 4,
        Entries = 5,
    }
}
