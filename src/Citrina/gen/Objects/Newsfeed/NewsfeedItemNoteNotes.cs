using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemNoteNotes
    {
        /// <summary>
        /// Notes number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<NewsfeedNewsfeedNote> Items { get; set; } 
    }
}
