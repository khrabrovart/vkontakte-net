using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountPushConversations
    {
        /// <summary>
        /// Items count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<AccountPushConversationsItem> Items { get; set; } 
    }
}
