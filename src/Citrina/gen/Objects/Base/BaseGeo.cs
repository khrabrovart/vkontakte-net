using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseGeo
    {
        public BaseGeoCoordinates Coordinates { get; set; } 

        public BasePlace Place { get; set; } 

        /// <summary>
        /// Information whether a map is showed.
        /// </summary>
        public int? Showmap { get; set; } 

        /// <summary>
        /// Place type.
        /// </summary>
        public string Type { get; set; } 
    }
}
