using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsTargetGroup
    {
        /// <summary>
        /// Audience.
        /// </summary>
        public int? AudienceCount { get; set; } 

        /// <summary>
        /// Site domain.
        /// </summary>
        public string Domain { get; set; } 

        /// <summary>
        /// Group ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Number of days for user to be in group.
        /// </summary>
        public int? Lifetime { get; set; } 

        /// <summary>
        /// Group name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Pixel code.
        /// </summary>
        public string Pixel { get; set; } 
    }
}
