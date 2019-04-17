using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class WallAppPost
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo604 { get; set; } 
    }

    public class WallAttachedNote
    {
        public int? Comments { get; set; } 

        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public int? ReadComments { get; set; } 

        public string Title { get; set; } 

        public string ViewUrl { get; set; } 
    }

    public class WallCommentAttachment
    {
        public AudioAudioFull Audio { get; set; } 

        public DocsDoc Doc { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketMarketAlbum { get; set; } 

        public WallAttachedNote Note { get; set; } 

        public PagesWikipageFull Page { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseSticker Sticker { get; set; } 

        public WallCommentAttachmentType Type { get; set; } 

        public VideoVideo Video { get; set; } 
    }

    public class WallCommentAttachmentType
    {
    }

    public class WallCommentThread
    {
        public bool? CanPost { get; set; } 

        public int? Count { get; set; } 

        public bool? GroupsCanPost { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class WallGraffiti
    {
        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo586 { get; set; } 
    }

    public class WallPostedPhoto
    {
        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo604 { get; set; } 
    }

    public class WallPostSource
    {
        public string Data { get; set; } 

        public string Platform { get; set; } 

        public WallPostSourceType Type { get; set; } 

        public string Url { get; set; } 
    }

    public class WallPostSourceType
    {
    }

    public class WallPostType
    {
    }

    public class WallViews
    {
        public int? Count { get; set; } 
    }

    public class WallWallComment
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? RealOffset { get; set; } 

        public int? ReplyToComment { get; set; } 

        public int? ReplyToUser { get; set; } 

        public string Text { get; set; } 

        public WallCommentThread Thread { get; set; } 
    }

    public class WallWallpost
    {
        public string AccessKey { get; set; } 

        public IEnumerable<object> Attachments { get; set; } 

        public int? Date { get; set; } 

        public int? Edited { get; set; } 

        public int? FromId { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public bool? IsArchived { get; set; } 

        public bool? IsFavorite { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? OwnerId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public WallPostType PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        public int? SignerId { get; set; } 

        public string Text { get; set; } 

        public WallViews Views { get; set; } 
    }

    public class WallWallpostAttachment
    {
        public string AccessKey { get; set; } 

        public PhotosPhotoAlbum Album { get; set; } 

        public WallAppPost App { get; set; } 

        public AudioAudioFull Audio { get; set; } 

        public DocsDoc Doc { get; set; } 

        public EventsEventAttach Event { get; set; } 

        public WallGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public MarketMarketItem Market { get; set; } 

        public MarketMarketAlbum MarketAlbum { get; set; } 

        public WallAttachedNote Note { get; set; } 

        public PagesWikipageFull Page { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public IEnumerable<object> PhotosList { get; set; } 

        public PollsPoll Poll { get; set; } 

        public WallPostedPhoto PostedPhoto { get; set; } 

        public WallWallpostAttachmentType Type { get; set; } 

        public VideoVideo Video { get; set; } 
    }

    public class WallWallpostAttachmentType
    {
    }

    public class WallWallpostFull
    {
    }

    public class WallWallpostToId
    {
        public IEnumerable<object> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        public int? CopyOwnerId { get; set; } 

        public int? CopyPostId { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public WallPostType PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        public int? SignerId { get; set; } 

        public string Text { get; set; } 

        public int? ToId { get; set; } 
    }
}
