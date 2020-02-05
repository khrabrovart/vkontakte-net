using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseStation
    {
        /// <summary>
        /// City ID.
        /// </summary>
        public int? CityId { get; set; } 

        /// <summary>
        /// Hex color code without #.
        /// </summary>
        public string Color { get; set; } 

        /// <summary>
        /// Station ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Station name.
        /// </summary>
        public string Name { get; set; } 
    }
}
