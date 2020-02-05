using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersCareer
    {
        /// <summary>
        /// City ID.
        /// </summary>
        public int? CityId { get; set; } 

        /// <summary>
        /// Company name.
        /// </summary>
        public string Company { get; set; } 

        /// <summary>
        /// Country ID.
        /// </summary>
        public int? CountryId { get; set; } 

        /// <summary>
        /// From year.
        /// </summary>
        public int? From { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? GroupId { get; set; } 

        /// <summary>
        /// Career ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Position.
        /// </summary>
        public string Position { get; set; } 

        /// <summary>
        /// Till year.
        /// </summary>
        public int? Until { get; set; } 
    }
}
