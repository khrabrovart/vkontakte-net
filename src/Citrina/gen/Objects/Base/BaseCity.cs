using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseCity
    {
        /// <summary>
        /// City ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// City title.
        /// </summary>
        public string Title { get; set; } 
    }
}
