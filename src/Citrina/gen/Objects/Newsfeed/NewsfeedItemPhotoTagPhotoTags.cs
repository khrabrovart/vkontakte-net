using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemPhotoTagPhotoTags
    {
        /// <summary>
        /// Tags number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<NewsfeedNewsfeedPhoto> Items { get; set; } 
    }
}
