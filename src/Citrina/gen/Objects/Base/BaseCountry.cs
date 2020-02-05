using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseCountry
    {
        /// <summary>
        /// Country ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Country title.
        /// </summary>
        public string Title { get; set; } 
    }
}
