using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PrettyCardsCreateResponse
    {
        /// <summary>
        /// Owner ID of created pretty card.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Card ID of created pretty card.
        /// </summary>
        public string CardId { get; set; } 
    }
}
