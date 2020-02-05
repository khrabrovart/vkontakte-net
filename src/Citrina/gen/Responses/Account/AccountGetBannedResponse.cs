using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountGetBannedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
