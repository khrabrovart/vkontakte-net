using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Online status of group.
    /// </summary>
    public class GroupsOnlineStatus
    {
        /// <summary>
        /// Estimated time of answer (for status = answer_mark).
        /// </summary>
        public int? Minutes { get; set; } 

        public string Status { get; set; } 
    }
}
