namespace Citrina
{
    /// <summary>
    /// Who can view the wiki page: '1' — only community members, '2' — all users can view the page, '0' — only community managers.
    /// </summary>
    public enum Pages_SaveAccess_view
    {
        Managers = 0,
        Members = 1,
        All = 2,
    }
}
