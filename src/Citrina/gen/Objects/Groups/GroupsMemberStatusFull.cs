using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsMemberStatusFull
    {
        /// <summary>
        /// Information whether user can be invited.
        /// </summary>
        public bool? CanInvite { get; set; } 

        /// <summary>
        /// Information whether user's invite to the group can be recalled.
        /// </summary>
        public bool? CanRecall { get; set; } 

        /// <summary>
        /// Information whether user has been invited to the group.
        /// </summary>
        public bool? Invitation { get; set; } 

        /// <summary>
        /// Information whether user is a member of the group.
        /// </summary>
        public bool? Member { get; set; } 

        /// <summary>
        /// Information whether user has send request to the group.
        /// </summary>
        public bool? Request { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
