namespace Citrina
{
    /// <summary>
    /// Represents the VK community access token.
    /// </summary>
    public class CommunityAccessToken : IAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the CommunityAccessToken class that represents community access token. 
        /// Community access tokens has no time limit.
        /// </summary>
        /// <param name="value">Access token value.</param>
        /// <param name="communityId">Community identifier.</param>
        /// <param name="appId">Application identifier.</param>
        public CommunityAccessToken(string value, int communityId, int appId)
        {
            Value = value;
            CommunityId = communityId;
            ApplicationId = appId;
        }

        /// <summary>
        /// Gets the access token value.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Gets the community identifier.
        /// </summary>
        public int CommunityId { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        public int ApplicationId { get; }
    }
}
