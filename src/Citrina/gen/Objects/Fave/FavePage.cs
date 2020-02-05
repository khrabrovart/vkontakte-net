using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FavePage
    {
        /// <summary>
        /// Some info about user or group.
        /// </summary>
        public string Description { get; set; } 

        public GroupsGroupFull Group { get; set; } 

        public IEnumerable<FaveTag> Tags { get; set; } 

        /// <summary>
        /// Item type.
        /// </summary>
        public string Type { get; set; } 

        /// <summary>
        /// Timestamp, when this page was bookmarked.
        /// </summary>
        public int? UpdatedDate { get; set; } 

        public UsersUserFull User { get; set; } 
    }
}
