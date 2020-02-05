using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesGetViewersExtendedResponse
    {
        /// <summary>
        /// Viewers count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<UsersUserFull> Items { get; set; } 
    }
}
