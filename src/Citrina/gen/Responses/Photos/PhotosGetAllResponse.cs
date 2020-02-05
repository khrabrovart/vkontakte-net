using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosGetAllResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<PhotosPhotoXtrRealOffset> Items { get; set; } 

        /// <summary>
        /// Information whether next page is presented.
        /// </summary>
        public bool? More { get; set; } 
    }
}
