using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseSchool
    {
        /// <summary>
        /// School ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// School title.
        /// </summary>
        public string Title { get; set; } 
    }
}
