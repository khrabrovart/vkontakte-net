namespace Citrina
{
    public interface IAccessToken
    {
        string Value { get; }
        int ApplicationId { get; }
    }
}
