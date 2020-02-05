using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Real offset of the comments.
        /// </summary>
        public int? RealOffset { get; set; } 

        public IEnumerable<WallWallComment> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
