using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Timetable for one day.
    /// </summary>
    public class GroupsAddressTimetableDay
    {
        /// <summary>
        /// Close time of the break in minutes.
        /// </summary>
        public int? BreakCloseTime { get; set; } 

        /// <summary>
        /// Start time of the break in minutes.
        /// </summary>
        public int? BreakOpenTime { get; set; } 

        /// <summary>
        /// Close time in minutes.
        /// </summary>
        public int? CloseTime { get; set; } 

        /// <summary>
        /// Open time in minutes.
        /// </summary>
        public int? OpenTime { get; set; } 
    }
}
