using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersMilitary
    {
        /// <summary>
        /// Country ID.
        /// </summary>
        public int? CountryId { get; set; } 

        /// <summary>
        /// From year.
        /// </summary>
        public int? From { get; set; } 

        /// <summary>
        /// Military ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Unit name.
        /// </summary>
        public string Unit { get; set; } 

        /// <summary>
        /// Unit ID.
        /// </summary>
        public int? UnitId { get; set; } 

        /// <summary>
        /// Till year.
        /// </summary>
        public int? Until { get; set; } 
    }
}
