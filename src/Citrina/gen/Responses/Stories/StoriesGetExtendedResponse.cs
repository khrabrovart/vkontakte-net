using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesGetExtendedResponse
    {
        /// <summary>
        /// Stories count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<IEnumerable<StoriesStory>> Items { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
