using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseSticker
    {
        public IEnumerable<BaseImage> Images { get; set; } 

        public IEnumerable<BaseImage> ImagesWithBackground { get; set; } 

        /// <summary>
        /// Collection ID.
        /// </summary>
        public int? ProductId { get; set; } 

        /// <summary>
        /// Sticker ID.
        /// </summary>
        public int? StickerId { get; set; } 
    }
}
