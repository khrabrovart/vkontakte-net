using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetTokenPermissionsResponse
    {
        public int? Mask { get; set; } 

        public IEnumerable<GroupsTokenPermissionSetting> Permissions { get; set; } 
    }
}
