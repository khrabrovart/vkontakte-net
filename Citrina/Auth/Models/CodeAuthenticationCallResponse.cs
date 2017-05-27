namespace Citrina
{
    internal class CodeAuthenticationCallResponse
    {
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
        public int UserId { get; set; }
    }
}
