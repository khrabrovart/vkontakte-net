using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StatsWallpostStat
    {
        /// <summary>
        /// Hidings number.
        /// </summary>
        public int? Hide { get; set; } 

        /// <summary>
        /// People have joined the group.
        /// </summary>
        public int? JoinGroup { get; set; } 

        /// <summary>
        /// Link clickthrough.
        /// </summary>
        public int? Links { get; set; } 

        /// <summary>
        /// Subscribers reach.
        /// </summary>
        public int? ReachSubscribers { get; set; } 

        /// <summary>
        /// Total reach.
        /// </summary>
        public int? ReachTotal { get; set; } 

        /// <summary>
        /// Reports number.
        /// </summary>
        public int? Report { get; set; } 

        /// <summary>
        /// Clickthrough to community.
        /// </summary>
        public int? ToGroup { get; set; } 

        /// <summary>
        /// Unsubscribed members.
        /// </summary>
        public int? Unsubscribe { get; set; } 
    }
}
