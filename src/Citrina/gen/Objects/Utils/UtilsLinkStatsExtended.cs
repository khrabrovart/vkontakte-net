using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsLinkStatsExtended
    {
        /// <summary>
        /// Link key (characters after vk.cc/).
        /// </summary>
        public string Key { get; set; } 

        public IEnumerable<UtilsStatsExtended> Stats { get; set; } 
    }
}
