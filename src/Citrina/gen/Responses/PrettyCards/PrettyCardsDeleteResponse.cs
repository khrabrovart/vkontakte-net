using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PrettyCardsDeleteResponse
    {
        /// <summary>
        /// Owner ID of deleted pretty card.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Card ID of deleted pretty card.
        /// </summary>
        public string CardId { get; set; } 

        /// <summary>
        /// Error reason if error happened.
        /// </summary>
        public string Error { get; set; } 
    }
}
