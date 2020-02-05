using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<WallWallComment> Items { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
