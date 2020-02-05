using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GiftsGift
    {
        /// <summary>
        /// Date when gist has been sent in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Gift sender ID.
        /// </summary>
        public int? FromId { get; set; } 

        public GiftsLayout Gift { get; set; } 

        /// <summary>
        /// Hash.
        /// </summary>
        public string GiftHash { get; set; } 

        /// <summary>
        /// Gift ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Message { get; set; } 

        public int? Privacy { get; set; } 
    }
}
