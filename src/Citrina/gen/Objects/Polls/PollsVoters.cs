using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PollsVoters
    {
        /// <summary>
        /// Answer ID.
        /// </summary>
        public int? AnswerId { get; set; } 

        public PollsVotersUsers Users { get; set; } 
    }
}
