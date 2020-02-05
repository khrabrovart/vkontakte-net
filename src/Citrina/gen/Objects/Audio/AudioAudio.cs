using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AudioAudio
    {
        /// <summary>
        /// Artist name.
        /// </summary>
        public string Artist { get; set; } 

        /// <summary>
        /// Audio ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// URL of mp3 file.
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// Duration in seconds.
        /// </summary>
        public int? Duration { get; set; } 

        /// <summary>
        /// Date when uploaded.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Album ID.
        /// </summary>
        public int? AlbumId { get; set; } 

        /// <summary>
        /// Genre ID.
        /// </summary>
        public int? GenreId { get; set; } 

        /// <summary>
        /// Performer name.
        /// </summary>
        public string Performer { get; set; } 
    }
}
