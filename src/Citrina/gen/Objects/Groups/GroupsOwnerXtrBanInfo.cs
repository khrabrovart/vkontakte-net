using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsOwnerXtrBanInfo
    {
        public GroupsBanInfo BanInfo { get; set; } 

        /// <summary>
        /// Information about group if type = group.
        /// </summary>
        public GroupsGroup Group { get; set; } 

        /// <summary>
        /// Information about group if type = profile.
        /// </summary>
        public UsersUser Profile { get; set; } 

        public string Type { get; set; } 
    }
}
