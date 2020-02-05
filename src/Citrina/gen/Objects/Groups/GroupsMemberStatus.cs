using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsMemberStatus
    {
        /// <summary>
        /// Information whether user is a member of the group.
        /// </summary>
        public bool? Member { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
