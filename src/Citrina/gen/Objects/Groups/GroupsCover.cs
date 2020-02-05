using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsCover
    {
        /// <summary>
        /// Information whether cover is enabled.
        /// </summary>
        public bool? Enabled { get; set; } 

        public IEnumerable<BaseImage> Images { get; set; } 
    }
}
