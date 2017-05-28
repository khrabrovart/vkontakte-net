namespace Citrina
{
    public class CodeAuthCall
    {
        public IAccessToken AccessToken { get; set; }
        public CodeAuthCallError Error { get; set; }
        public bool IsError { get; set; }
    }
}
