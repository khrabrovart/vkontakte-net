using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PollsAnswer
    {
        /// <summary>
        /// Answer ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Answer rate in percents.
        /// </summary>
        public double? Rate { get; set; } 

        /// <summary>
        /// Answer text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Votes number.
        /// </summary>
        public int? Votes { get; set; } 
    }
}
