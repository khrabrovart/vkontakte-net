using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoVideoFiles
    {
        /// <summary>
        /// URL of the external player.
        /// </summary>
        public string External { get; set; } 

        /// <summary>
        /// URL of the mpeg4 file with 1080p quality.
        /// </summary>
        public string Mp41080 { get; set; } 

        /// <summary>
        /// URL of the mpeg4 file with 240p quality.
        /// </summary>
        public string Mp4240 { get; set; } 

        /// <summary>
        /// URL of the mpeg4 file with 360p quality.
        /// </summary>
        public string Mp4360 { get; set; } 

        /// <summary>
        /// URL of the mpeg4 file with 480p quality.
        /// </summary>
        public string Mp4480 { get; set; } 

        /// <summary>
        /// URL of the mpeg4 file with 720p quality.
        /// </summary>
        public string Mp4720 { get; set; } 
    }
}
