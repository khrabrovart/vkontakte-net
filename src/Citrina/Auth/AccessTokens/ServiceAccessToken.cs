namespace Citrina
{
    /// <summary>
    /// Represents the VK service access token.
    /// </summary>
    public class ServiceAccessToken : IAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the AccessToken class that represents service access token for use in public API methods. 
        /// Service access tokens has no user id and no time limit.
        /// </summary>
        /// <param name="value">Access token value.</param>
        /// <param name="appId">Application identifier.</param>
        public ServiceAccessToken(string value, int appId)
        {
            Value = value;
            ApplicationId = appId;
        }

        /// <summary>
        /// Gets the access token value.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        public int ApplicationId { get; }

        /// <summary>
        /// Indicates whether this access token is limited or not according to official VK documentation.
        /// Requests with limited access tokens go through the queue.
        /// </summary>
        public bool IsLimited { get; } = false;
    }
}
