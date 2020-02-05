using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupXtrInvitedBy
    {
        public int? AdminLevel { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public string Id { get; set; } 

        /// <summary>
        /// Inviter ID.
        /// </summary>
        public int? InvitedBy { get; set; } 

        /// <summary>
        /// Information whether current user is manager.
        /// </summary>
        public bool? IsAdmin { get; set; } 

        /// <summary>
        /// Information whether current user is advertiser.
        /// </summary>
        public bool? IsAdvertiser { get; set; } 

        /// <summary>
        /// Information whether community is closed.
        /// </summary>
        public bool? IsClosed { get; set; } 

        /// <summary>
        /// Information whether current user is member.
        /// </summary>
        public bool? IsMember { get; set; } 

        /// <summary>
        /// Community name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 200 pixels in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// Domain of the community page.
        /// </summary>
        public string ScreenName { get; set; } 

        public string Type { get; set; } 
    }
}
