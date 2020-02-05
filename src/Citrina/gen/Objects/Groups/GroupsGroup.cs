using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroup
    {
        public int? AdminLevel { get; set; } 

        /// <summary>
        /// Information whether community is banned.
        /// </summary>
        public string Deactivated { get; set; } 

        /// <summary>
        /// Finish date in Unixtime format.
        /// </summary>
        public int? FinishDate { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Information whether current user is administrator.
        /// </summary>
        public bool? IsAdmin { get; set; } 

        /// <summary>
        /// Information whether current user is advertiser.
        /// </summary>
        public bool? IsAdvertiser { get; set; } 

        public int? IsClosed { get; set; } 

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

        /// <summary>
        /// Start date in Unixtime format.
        /// </summary>
        public int? StartDate { get; set; } 

        public string Type { get; set; } 
    }
}
