using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedGetCommentsResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 

        /// <summary>
        /// New from value.
        /// </summary>
        public string NextFrom { get; set; } 
    }
}
