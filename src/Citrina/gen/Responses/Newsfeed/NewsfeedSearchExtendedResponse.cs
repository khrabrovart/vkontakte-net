using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedSearchExtendedResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 

        /// <summary>
        /// Filtered number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Total number.
        /// </summary>
        public int? TotalCount { get; set; } 

        public string NextFrom { get; set; } 
    }
}
