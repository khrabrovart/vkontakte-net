using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersCropPhoto
    {
        public UsersCropPhotoCrop Crop { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public UsersCropPhotoRect Rect { get; set; } 
    }
}
