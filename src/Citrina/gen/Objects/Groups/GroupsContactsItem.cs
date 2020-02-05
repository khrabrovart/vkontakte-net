using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsContactsItem
    {
        /// <summary>
        /// Contact description.
        /// </summary>
        public string Desc { get; set; } 

        /// <summary>
        /// Contact email.
        /// </summary>
        public string Email { get; set; } 

        /// <summary>
        /// Contact phone.
        /// </summary>
        public string Phone { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
