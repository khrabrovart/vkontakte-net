using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallWallpostAttachment
    {
        /// <summary>
        /// Access key for the audio.
        /// </summary>
        public string AccessKey { get; set; } 

        public PhotosPhotoAlbum Album { get; set; } 

        public WallAppPost App { get; set; } 

        public AudioAudio Audio { get; set; } 

        public DocsDoc Doc { get; set; } 

        public EventsEventAttach Event { get; set; } 

        public WallGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketAlbum { get; set; } 

        public WallAttachedNote Note { get; set; } 

        public PagesWikipageFull Page { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public IEnumerable<string> PhotosList { get; set; } 

        public PollsPoll Poll { get; set; } 

        public WallPostedPhoto PostedPhoto { get; set; } 

        public string Type { get; set; } 

        public VideoVideo Video { get; set; } 
    }
}
