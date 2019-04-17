using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class WidgetsCommentMedia
    {
        public int? ItemId { get; set; } 

        public int? OwnerId { get; set; } 

        public string ThumbSrc { get; set; } 

        public WidgetsCommentMediaType Type { get; set; } 
    }

    public class WidgetsCommentMediaType
    {
    }

    public class WidgetsCommentReplies
    {
        public bool? CanPost { get; set; } 

        public int? Count { get; set; } 

        public IEnumerable<object> Replies { get; set; } 
    }

    public class WidgetsCommentRepliesItem
    {
        public int? Cid { get; set; } 

        public int? Date { get; set; } 

        public WidgetsWidgetLikes Likes { get; set; } 

        public string Text { get; set; } 

        public int? Uid { get; set; } 

        public UsersUserFull User { get; set; } 
    }

    public class WidgetsWidgetComment
    {
        public IEnumerable<object> Attachments { get; set; } 

        public bool? CanDelete { get; set; } 

        public WidgetsCommentReplies Comments { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public WidgetsCommentMedia Media { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public int? PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        public string Text { get; set; } 

        public int? ToId { get; set; } 

        public UsersUserFull User { get; set; } 
    }

    public class WidgetsWidgetLikes
    {
        public int? Count { get; set; } 
    }

    public class WidgetsWidgetPage
    {
        public BaseObjectCount Comments { get; set; } 

        public int? Date { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public BaseObjectCount Likes { get; set; } 

        public string PageId { get; set; } 

        public string Photo { get; set; } 

        public string Title { get; set; } 

        public string Url { get; set; } 
    }
}
