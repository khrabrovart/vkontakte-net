namespace Citrina
{
    /// <summary>
    /// Who can edit the wiki page: '1' — only community members, '2' — all users can edit the page, '0' — only community managers.
    /// </summary>
    public enum Pages_SaveAccess_edit
    {
        Managers = 0,
        Members = 1,
        All = 2,
    }
}
