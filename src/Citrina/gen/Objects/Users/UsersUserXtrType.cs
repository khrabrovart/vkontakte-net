using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersUserXtrType
    {
        /// <summary>
        /// Returns if a profile is deleted or blocked.
        /// </summary>
        public string Deactivated { get; set; } 

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        public int? Hidden { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; } 

        public bool? CanAccessClosed { get; set; } 

        public bool? IsClosed { get; set; } 

        /// <summary>
        /// User sex.
        /// </summary>
        public int? Sex { get; set; } 

        /// <summary>
        /// Domain name of the user's page.
        /// </summary>
        public string ScreenName { get; set; } 

        /// <summary>
        /// URL of square photo of the user with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// URL of square photo of the user with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// Information whether the user is online.
        /// </summary>
        public bool? Online { get; set; } 

        /// <summary>
        /// Information whether the user is online in mobile site or application.
        /// </summary>
        public bool? OnlineMobile { get; set; } 

        /// <summary>
        /// Application ID.
        /// </summary>
        public int? OnlineApp { get; set; } 

        /// <summary>
        /// Information whether the user is verified.
        /// </summary>
        public bool? Verified { get; set; } 

        /// <summary>
        /// Information whether the user has a "fire" pictogram.
        /// </summary>
        public bool? Trending { get; set; } 

        public int? FriendStatus { get; set; } 

        public FriendsRequestsMutual Mutual { get; set; } 

        public string Type { get; set; } 
    }
}
