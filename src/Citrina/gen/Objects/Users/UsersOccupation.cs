using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersOccupation
    {
        /// <summary>
        /// ID of school, university, company group.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Name of occupation.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Type of occupation.
        /// </summary>
        public string Type { get; set; } 
    }
}
