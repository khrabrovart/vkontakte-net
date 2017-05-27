namespace Citrina
{
    /// <summary>
    /// Represents the VK group access token.
    /// </summary>
    public class GroupAccessToken : IAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the GroupAccessToken class that represents group access token. 
        /// Group access tokens has no time limit.
        /// </summary>
        /// <param name="value">Access token value.</param>
        /// <param name="groupId">Group identifier.</param>
        /// <param name="appId">Application identifier.</param>
        public GroupAccessToken(string value, int groupId, int appId)
        {
            Value = value;
            GroupId = groupId;
            ApplicationId = appId;
        }

        /// <summary>
        /// Gets the access token value.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Gets the group identifier.
        /// </summary>
        public int GroupId { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        public int ApplicationId { get; }
    }
}
