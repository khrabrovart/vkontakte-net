using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsLinkStats
    {
        /// <summary>
        /// Link key (characters after vk.cc/).
        /// </summary>
        public string Key { get; set; } 

        public IEnumerable<UtilsStats> Stats { get; set; } 
    }
}
