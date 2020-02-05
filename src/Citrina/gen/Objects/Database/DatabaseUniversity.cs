using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseUniversity
    {
        /// <summary>
        /// University ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// University title.
        /// </summary>
        public string Title { get; set; } 
    }
}
