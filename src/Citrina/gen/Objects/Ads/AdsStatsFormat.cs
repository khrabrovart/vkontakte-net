using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsStatsFormat
    {
        /// <summary>
        /// Clicks number.
        /// </summary>
        public int? Clicks { get; set; } 

        /// <summary>
        /// Day as YYYY-MM-DD.
        /// </summary>
        public string Day { get; set; } 

        /// <summary>
        /// Impressions number.
        /// </summary>
        public int? Impressions { get; set; } 

        /// <summary>
        /// Events number.
        /// </summary>
        public int? JoinRate { get; set; } 

        /// <summary>
        /// Month as YYYY-MM.
        /// </summary>
        public string Month { get; set; } 

        /// <summary>
        /// 1 if period=overall.
        /// </summary>
        public int? Overall { get; set; } 

        /// <summary>
        /// Reach .
        /// </summary>
        public int? Reach { get; set; } 

        /// <summary>
        /// Spent funds.
        /// </summary>
        public int? Spent { get; set; } 

        /// <summary>
        /// Clickthoughs to the advertised site.
        /// </summary>
        public int? VideoClicksSite { get; set; } 

        /// <summary>
        /// Video views number.
        /// </summary>
        public int? VideoViews { get; set; } 

        /// <summary>
        /// Video views (full video).
        /// </summary>
        public int? VideoViewsFull { get; set; } 

        /// <summary>
        /// Video views (half of video).
        /// </summary>
        public int? VideoViewsHalf { get; set; } 
    }
}
