using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkApplication
    {
        /// <summary>
        /// Application Id.
        /// </summary>
        public double? AppId { get; set; } 

        public BaseLinkApplicationStore Store { get; set; } 
    }
}
