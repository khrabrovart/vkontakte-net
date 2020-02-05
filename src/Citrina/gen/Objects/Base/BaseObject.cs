using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseObject
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Object title.
        /// </summary>
        public string Title { get; set; } 
    }
}
