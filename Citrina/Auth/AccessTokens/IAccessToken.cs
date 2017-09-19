namespace Citrina
{
    /// <summary>
    /// Represents the VK access token.
    /// Different access token types have different purpose and behavior.
    /// </summary>
    public interface IAccessToken
    {
        /// <summary>
        /// Gets the access token value.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        int ApplicationId { get; }

        /// <summary>
        /// Indicates whether this access token is limited or not according to official VK documentation.
        /// Requests with limited access tokens go through the queue.
        /// </summary>
        bool IsLimited { get; }
    }
}
