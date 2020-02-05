using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersGetFollowersFieldsResponse
    {
        /// <summary>
        /// Total number of available results.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<UsersUserFull> Items { get; set; } 
    }
}
