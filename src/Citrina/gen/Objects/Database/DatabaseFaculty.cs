using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseFaculty
    {
        /// <summary>
        /// Faculty ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Faculty title.
        /// </summary>
        public string Title { get; set; } 
    }
}
