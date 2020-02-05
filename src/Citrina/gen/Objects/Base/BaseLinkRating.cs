using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkRating
    {
        /// <summary>
        /// Count of reviews.
        /// </summary>
        public int? ReviewsCount { get; set; } 

        /// <summary>
        /// Count of stars.
        /// </summary>
        public double? Stars { get; set; } 
    }
}
