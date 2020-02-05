using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AppsLeaderboard
    {
        /// <summary>
        /// Level.
        /// </summary>
        public int? Level { get; set; } 

        /// <summary>
        /// Points number.
        /// </summary>
        public int? Points { get; set; } 

        /// <summary>
        /// Score number.
        /// </summary>
        public int? Score { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
