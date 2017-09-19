namespace Citrina
{
    public class CodeAuthRequest
    {
        public IAccessToken AccessToken { get; set; }
        public CodeAuthError Error { get; set; }
        public bool IsError { get; set; }
    }
}
