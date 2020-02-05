using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BasePlace
    {
        /// <summary>
        /// Place address.
        /// </summary>
        public string Address { get; set; } 

        /// <summary>
        /// Checkins number.
        /// </summary>
        public int? Checkins { get; set; } 

        /// <summary>
        /// City name.
        /// </summary>
        public string City { get; set; } 

        /// <summary>
        /// Country name.
        /// </summary>
        public string Country { get; set; } 

        /// <summary>
        /// Date of the place creation in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// URL of the place's icon.
        /// </summary>
        public string Icon { get; set; } 

        /// <summary>
        /// Place ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Place latitude.
        /// </summary>
        public double? Latitude { get; set; } 

        /// <summary>
        /// Place longitude.
        /// </summary>
        public double? Longitude { get; set; } 

        /// <summary>
        /// Place title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Place type.
        /// </summary>
        public string Type { get; set; } 
    }
}
