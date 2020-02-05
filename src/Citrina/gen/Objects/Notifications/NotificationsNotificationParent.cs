using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsNotificationParent
    {
        public enum Type
        {
            [EnumMember(Value = "video")]
            Video,
        }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        /// <summary>
        /// ID of the source post owner.
        /// </summary>
        public int? CopyOwnerId { get; set; } 

        /// <summary>
        /// ID of the source post.
        /// </summary>
        public int? CopyPostId { get; set; } 

        /// <summary>
        /// Date of publishing in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Post author ID.
        /// </summary>
        public int? FromId { get; set; } 

        public WallGeo Geo { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// wall post ID (if comment).
        /// </summary>
        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public string PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Post signer ID.
        /// </summary>
        public int? SignerId { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Wall owner's ID.
        /// </summary>
        public int? ToId { get; set; } 

        /// <summary>
        /// Access key for the photo.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Album ID.
        /// </summary>
        public int? AlbumId { get; set; } 

        /// <summary>
        /// Date when uploaded.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Original photo height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Photo ID.
        /// </summary>
        public int? Id { get; set; } 

        public IEnumerable<PhotosImage> Images { get; set; } 

        /// <summary>
        /// Latitude.
        /// </summary>
        public double? Lat { get; set; } 

        /// <summary>
        /// Longitude.
        /// </summary>
        public double? @Long { get; set; } 

        /// <summary>
        /// Photo owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; } 

        /// <summary>
        /// Photo caption.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// ID of the user who have uploaded the photo.
        /// </summary>
        public int? UserId { get; set; } 

        /// <summary>
        /// Original photo width.
        /// </summary>
        public int? Width { get; set; } 

        /// <summary>
        /// Comments number.
        /// </summary>
        public int? Comments { get; set; } 

        /// <summary>
        /// Date when the topic has been created in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// Creator ID.
        /// </summary>
        public int? CreatedBy { get; set; } 

        /// <summary>
        /// Topic ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Information whether the topic is closed.
        /// </summary>
        public bool? IsClosed { get; set; } 

        /// <summary>
        /// Information whether the topic is fixed.
        /// </summary>
        public bool? IsFixed { get; set; } 

        /// <summary>
        /// Topic title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Date when the topic has been updated in Unixtime.
        /// </summary>
        public int? Updated { get; set; } 

        /// <summary>
        /// ID of user who updated the topic.
        /// </summary>
        public int? UpdatedBy { get; set; } 

        /// <summary>
        /// Video access key.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Date when the video has been added in Unixtime.
        /// </summary>
        public int? AddingDate { get; set; } 

        /// <summary>
        /// Information whether current user can add the video.
        /// </summary>
        public bool? CanAdd { get; set; } 

        /// <summary>
        /// Information whether current user can comment the video.
        /// </summary>
        public bool? CanComment { get; set; } 

        /// <summary>
        /// Information whether current user can edit the video.
        /// </summary>
        public bool? CanEdit { get; set; } 

        /// <summary>
        /// Information whether current user can like the video.
        /// </summary>
        public bool? CanLike { get; set; } 

        /// <summary>
        /// Information whether current user can repost this video.
        /// </summary>
        public bool? CanRepost { get; set; } 

        /// <summary>
        /// Number of comments.
        /// </summary>
        public int? Comments { get; set; } 

        /// <summary>
        /// Date when video has been uploaded in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Video description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Video duration in seconds.
        /// </summary>
        public int? Duration { get; set; } 

        public VideoVideoFiles Files { get; set; } 

        public IEnumerable<VideoVideoImage> FirstFrame { get; set; } 

        /// <summary>
        /// Video height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Video ID.
        /// </summary>
        public int? Id { get; set; } 

        public IEnumerable<VideoVideoImage> Image { get; set; } 

        public bool? IsFavorite { get; set; } 

        /// <summary>
        /// Returns if the video is a live stream.
        /// </summary>
        public int? Live { get; set; } 

        /// <summary>
        /// Video owner ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        public string Player { get; set; } 

        /// <summary>
        /// Returns if the video is processing.
        /// </summary>
        public int? Processing { get; set; } 

        /// <summary>
        /// Video title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Number of views.
        /// </summary>
        public int? Views { get; set; } 

        /// <summary>
        /// Video width.
        /// </summary>
        public int? Width { get; set; } 

        /// <summary>
        /// Date when the comment has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Author ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public WallWallpost Post { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 

        public BoardTopic Topic { get; set; } 

        public VideoVideo Video { get; set; } 
    }
}
