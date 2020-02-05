using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsMemberRole
    {
        /// <summary>
        /// User ID.
        /// </summary>
        public int? Id { get; set; } 

        public IEnumerable<GroupsMemberRolePermission> Permissions { get; set; } 

        public string Role { get; set; } 
    }
}
