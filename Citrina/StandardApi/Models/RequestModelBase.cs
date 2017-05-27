namespace Citrina.StandardApi.Models
{
    public abstract class RequestModelBase : IRequestModel
    {
        public bool? Https { get; set; }

        public IAccessToken AccessToken { get; set; }
    }
}