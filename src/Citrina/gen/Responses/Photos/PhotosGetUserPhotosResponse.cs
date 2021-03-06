using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosGetUserPhotosResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<PhotosPhoto> Items { get; set; } 
    }
}
