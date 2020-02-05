using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PrettyCardsEditResponse
    {
        /// <summary>
        /// Owner ID of edited pretty card.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Card ID of edited pretty card.
        /// </summary>
        public string CardId { get; set; } 
    }
}
