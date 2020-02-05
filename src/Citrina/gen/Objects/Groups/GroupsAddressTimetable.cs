using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Timetable for a week.
    /// </summary>
    public class GroupsAddressTimetable
    {
        /// <summary>
        /// Timetable for friday.
        /// </summary>
        public GroupsAddressTimetableDay Fri { get; set; } 

        /// <summary>
        /// Timetable for monday.
        /// </summary>
        public GroupsAddressTimetableDay Mon { get; set; } 

        /// <summary>
        /// Timetable for saturday.
        /// </summary>
        public GroupsAddressTimetableDay Sat { get; set; } 

        /// <summary>
        /// Timetable for sunday.
        /// </summary>
        public GroupsAddressTimetableDay Sun { get; set; } 

        /// <summary>
        /// Timetable for thursday.
        /// </summary>
        public GroupsAddressTimetableDay Thu { get; set; } 

        /// <summary>
        /// Timetable for tuesday.
        /// </summary>
        public GroupsAddressTimetableDay Tue { get; set; } 

        /// <summary>
        /// Timetable for wednesday.
        /// </summary>
        public GroupsAddressTimetableDay Wed { get; set; } 
    }
}
