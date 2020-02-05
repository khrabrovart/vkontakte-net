using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseObjectWithName
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Object name.
        /// </summary>
        public string Name { get; set; } 
    }
}
