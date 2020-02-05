using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedNewsfeedNote
    {
        /// <summary>
        /// Comments Number.
        /// </summary>
        public int? Comments { get; set; } 

        /// <summary>
        /// Note ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// integer.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Note title.
        /// </summary>
        public string Title { get; set; } 
    }
}
