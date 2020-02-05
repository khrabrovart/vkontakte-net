using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetCatalogInfoResponse
    {
        /// <summary>
        /// Information whether catalog is enabled for current user.
        /// </summary>
        public int? Enabled { get; set; } 

        public IEnumerable<GroupsGroupCategory> Categories { get; set; } 
    }
}
