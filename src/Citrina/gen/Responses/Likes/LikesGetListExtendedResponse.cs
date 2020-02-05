using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LikesGetListExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<UsersUserMin> Items { get; set; } 
    }
}
