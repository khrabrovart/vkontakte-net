namespace Citrina
{
    /// <summary>
    /// Action type. Possible values: *'0' — start,, *'1' — finish,, *'2' — blocking users,, *'3' — start in a test mode,, *'4' — finish in a test mode.
    /// </summary>
    public enum Leads_GetUsers_status
    {
        Start = 0,
        Finish = 1,
        BlockingUsers = 2,
        StartInTestMode = 3,
        FinishInTestMode = 4,
    }
}
