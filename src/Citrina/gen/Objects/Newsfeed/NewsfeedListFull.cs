using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedListFull
    {
        /// <summary>
        /// List ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// List title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Information whether reposts hiding is enabled.
        /// </summary>
        public bool? NoReposts { get; set; } 

        public IEnumerable<int> SourceIds { get; set; } 
    }
}
