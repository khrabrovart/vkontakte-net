namespace Citrina
{
    public class CodeAuthenticationCall
    {
        public IAccessToken AccessToken { get; set; }
        public CodeAuthenticationCallError Error { get; set; }
        public bool IsError { get; set; }
    }
}
