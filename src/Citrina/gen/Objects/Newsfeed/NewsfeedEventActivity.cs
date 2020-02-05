using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedEventActivity
    {
        /// <summary>
        /// address of event.
        /// </summary>
        public string Address { get; set; } 

        /// <summary>
        /// text of attach.
        /// </summary>
        public string ButtonText { get; set; } 

        /// <summary>
        /// array of friends ids.
        /// </summary>
        public IEnumerable<int> Friends { get; set; } 

        /// <summary>
        /// Current user's member status.
        /// </summary>
        public int? MemberStatus { get; set; } 

        /// <summary>
        /// text of attach.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// event start time.
        /// </summary>
        public int? Time { get; set; } 
    }
}
