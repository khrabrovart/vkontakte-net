using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AppsGetLeaderboardExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<AppsLeaderboard> Items { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 
    }
}
