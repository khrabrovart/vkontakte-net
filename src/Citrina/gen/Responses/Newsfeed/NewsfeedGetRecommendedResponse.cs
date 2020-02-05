using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedGetRecommendedResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 

        /// <summary>
        /// New offset value.
        /// </summary>
        public string NewOffset { get; set; } 

        /// <summary>
        /// Next from value.
        /// </summary>
        public string NextFrom { get; set; } 
    }
}
