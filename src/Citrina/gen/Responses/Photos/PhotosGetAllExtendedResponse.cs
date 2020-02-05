using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosGetAllExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<PhotosPhotoFullXtrRealOffset> Items { get; set; } 

        /// <summary>
        /// Information whether next page is presented.
        /// </summary>
        public bool? More { get; set; } 
    }
}
