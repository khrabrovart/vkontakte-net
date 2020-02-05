using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetRequestsFieldsResponse
    {
        /// <summary>
        /// Total communities number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<UsersUserFull> Items { get; set; } 
    }
}
