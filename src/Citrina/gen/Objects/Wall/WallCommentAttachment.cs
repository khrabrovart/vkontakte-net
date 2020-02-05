using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallCommentAttachment
    {
        public AudioAudio Audio { get; set; } 

        public DocsDoc Doc { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketMarketAlbum { get; set; } 

        public WallAttachedNote Note { get; set; } 

        public PagesWikipageFull Page { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseSticker Sticker { get; set; } 

        public string Type { get; set; } 

        public VideoVideo Video { get; set; } 
    }
}
