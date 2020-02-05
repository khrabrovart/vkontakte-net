using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<WallWallComment> Items { get; set; } 

        public bool? ShowReplyButton { get; set; } 

        /// <summary>
        /// Information whether current user can comment the post.
        /// </summary>
        public bool? CanPost { get; set; } 

        /// <summary>
        /// Information whether groups can comment the post.
        /// </summary>
        public bool? GroupsCanPost { get; set; } 

        /// <summary>
        /// Count of replies of current level.
        /// </summary>
        public int? CurrentLevelCount { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
