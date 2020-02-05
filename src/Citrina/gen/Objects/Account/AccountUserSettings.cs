using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountUserSettings
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

        public UsersUserConnections Connections { get; set; } 

        /// <summary>
        /// User's date of birth.
        /// </summary>
        public string Bdate { get; set; } 

        /// <summary>
        /// Information whether user's birthdate are hidden.
        /// </summary>
        public int? BdateVisibility { get; set; } 

        public BaseCity City { get; set; } 

        public BaseCountry Country { get; set; } 

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// User's hometown.
        /// </summary>
        public string HomeTown { get; set; } 

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; } 

        /// <summary>
        /// User maiden name.
        /// </summary>
        public string MaidenName { get; set; } 

        public AccountNameRequest NameRequest { get; set; } 

        public UsersPersonal Personal { get; set; } 

        /// <summary>
        /// User phone number with some hidden digits.
        /// </summary>
        public string Phone { get; set; } 

        /// <summary>
        /// User relationship status.
        /// </summary>
        public int? Relation { get; set; } 

        public UsersUserMin RelationPartner { get; set; } 

        /// <summary>
        /// Information whether relation status is pending.
        /// </summary>
        public bool? RelationPending { get; set; } 

        public IEnumerable<UsersUserMin> RelationRequests { get; set; } 

        /// <summary>
        /// Domain name of the user's page.
        /// </summary>
        public string ScreenName { get; set; } 

        /// <summary>
        /// User sex.
        /// </summary>
        public int? Sex { get; set; } 

        /// <summary>
        /// User status.
        /// </summary>
        public string Status { get; set; } 

        public AudioAudio StatusAudio { get; set; } 

        public AccountUserSettingsInterests Interests { get; set; } 

        public IEnumerable<string> Languages { get; set; } 
    }
}
