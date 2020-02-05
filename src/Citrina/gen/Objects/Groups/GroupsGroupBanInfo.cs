using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupBanInfo
    {
        /// <summary>
        /// Ban comment.
        /// </summary>
        public string Comment { get; set; } 

        /// <summary>
        /// End date of ban in Unixtime.
        /// </summary>
        public int? EndDate { get; set; } 
    }
}
