using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FaveGetExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<FaveBookmark> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
