using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Activity stats.
    /// </summary>
    public class StatsActivity
    {
        /// <summary>
        /// Comments number.
        /// </summary>
        public int? Comments { get; set; } 

        /// <summary>
        /// Reposts number.
        /// </summary>
        public int? Copies { get; set; } 

        /// <summary>
        /// Hidden from news count.
        /// </summary>
        public int? Hidden { get; set; } 

        /// <summary>
        /// Likes number.
        /// </summary>
        public int? Likes { get; set; } 

        /// <summary>
        /// New subscribers count.
        /// </summary>
        public int? Subscribed { get; set; } 

        /// <summary>
        /// Unsubscribed count.
        /// </summary>
        public int? Unsubscribed { get; set; } 
    }
}
