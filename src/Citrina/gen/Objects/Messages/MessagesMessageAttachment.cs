using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesMessageAttachment
    {
        public AudioAudio Audio { get; set; } 

        public MessagesAudioMessage AudioMessage { get; set; } 

        public DocsDoc Doc { get; set; } 

        public GiftsLayout Gift { get; set; } 

        public MessagesGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketMarketAlbum { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseSticker Sticker { get; set; } 

        public string Type { get; set; } 

        public VideoVideo Video { get; set; } 

        public WallWallpostFull Wall { get; set; } 

        public WallWallComment WallReply { get; set; } 
    }
}
