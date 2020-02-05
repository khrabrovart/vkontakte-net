using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoSearchExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<VideoVideo> Items { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
