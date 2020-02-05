namespace Citrina
{
    /// <summary>
    /// User relationship status. Possible values: , * '1' – single,, * '2' – in a relationship,, * '3' – engaged,, * '4' – married,, * '5' – it's complicated,, * '6' – actively searching,, * '7' – in love,, * '0' – not specified.
    /// </summary>
    public enum RelationStatus
    {
        Single = 1,
        Relationship = 2,
        Engaged = 3,
        Married = 4,
        Complicated = 5,
        ActivelySearching = 6,
        InLove = 7,
        NotSpecified = 0,
    }
}
