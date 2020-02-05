using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsPromotedPostReach
    {
        /// <summary>
        /// Hides amount.
        /// </summary>
        public int? Hide { get; set; } 

        /// <summary>
        /// Object ID from 'ids' parameter.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Community joins.
        /// </summary>
        public int? JoinGroup { get; set; } 

        /// <summary>
        /// Link clicks.
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
        /// Reports amount.
        /// </summary>
        public int? Report { get; set; } 

        /// <summary>
        /// Community clicks.
        /// </summary>
        public int? ToGroup { get; set; } 

        /// <summary>
        /// 'Unsubscribe' events amount.
        /// </summary>
        public int? Unsubscribe { get; set; } 

        /// <summary>
        /// Video views for 100 percent.
        /// </summary>
        public int? VideoViews100p { get; set; } 

        /// <summary>
        /// Video views for 25 percent.
        /// </summary>
        public int? VideoViews25p { get; set; } 

        /// <summary>
        /// Video views for 3 seconds.
        /// </summary>
        public int? VideoViews3s { get; set; } 

        /// <summary>
        /// Video views for 50 percent.
        /// </summary>
        public int? VideoViews50p { get; set; } 

        /// <summary>
        /// Video views for 75 percent.
        /// </summary>
        public int? VideoViews75p { get; set; } 

        /// <summary>
        /// Video starts.
        /// </summary>
        public int? VideoViewsStart { get; set; } 
    }
}
