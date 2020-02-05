using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsAddressesInfo
    {
        /// <summary>
        /// Information whether addresses is enabled.
        /// </summary>
        public bool? IsEnabled { get; set; } 

        /// <summary>
        /// Main address id for group.
        /// </summary>
        public int? MainAddressId { get; set; } 
    }
}
