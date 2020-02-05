using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetInvitesExtendedResponse
    {
        /// <summary>
        /// Total communities number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<GroupsGroupXtrInvitedBy> Items { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
