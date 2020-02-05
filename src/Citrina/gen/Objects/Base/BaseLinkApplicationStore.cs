using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkApplicationStore
    {
        /// <summary>
        /// Store Id.
        /// </summary>
        public double? Id { get; set; } 

        /// <summary>
        /// Store name.
        /// </summary>
        public string Name { get; set; } 
    }
}
