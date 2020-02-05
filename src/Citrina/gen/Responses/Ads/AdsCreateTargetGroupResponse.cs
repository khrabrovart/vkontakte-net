using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsCreateTargetGroupResponse
    {
        /// <summary>
        /// Group ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Pixel code.
        /// </summary>
        public string Pixel { get; set; } 
    }
}
