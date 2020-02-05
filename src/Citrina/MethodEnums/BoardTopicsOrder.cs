namespace Citrina
{
    /// <summary>
    /// Sort order: '1' — by date updated in reverse chronological order. '2' — by date created in reverse chronological order. '-1' — by date updated in chronological order. '-2' — by date created in chronological order. If no sort order is specified, topics are returned in the order specified by the group administrator. Pinned topics are returned first, regardless of the sorting.
    /// </summary>
    public enum BoardTopicsOrder
    {
        UpdatedDesc = 1,
        CreatedDesc = 2,
        UpdatedAsc = -1,
        CreatedAsc = -2,
        AsByAdministrator = 0,
    }
}
