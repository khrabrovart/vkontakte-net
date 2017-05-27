using System;

namespace Citrina
{
    /// <summary>
    /// Represents the VK user access token.
    /// </summary>
    public class UserAccessToken : IAccessToken
    {
        private readonly DateTime _createdOn;
        private readonly double _lifetime;

        /// <summary>
        /// Initializes a new instance of the AccessToken class that represents user access token.
        /// </summary>
        /// <param name="value">Access token value.</param>
        /// <param name="expiresIn">Access token expiration time.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="appId">Application identifier.</param>
        public UserAccessToken(string value, double expiresIn, int userId, int appId)
        {
            Value = value;
            UserId = userId;
            ApplicationId = appId;

            _lifetime = expiresIn;
            _createdOn = DateTime.Now;
        }

        /// <summary>
        /// Gets the access token value.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        public int ApplicationId { get; }

        /// <summary>
        /// Indicates whether this access token is valid or not according to its expiration time.
        /// </summary>
        public bool IsValid => _lifetime.Equals(0) || ExpiresIn > 0;

        /// <summary>
        /// Gets the access token expiration time in seconds.
        /// </summary>
        public int ExpiresIn
        {
            get
            {
                var lifeTimeSpan = TimeSpan.FromSeconds(_lifetime);
                var expiresIn = (int) _createdOn.Add(lifeTimeSpan).Subtract(DateTime.Now).TotalSeconds;

                return expiresIn < 0 ? 0 : expiresIn;
            }
        }
    }
}