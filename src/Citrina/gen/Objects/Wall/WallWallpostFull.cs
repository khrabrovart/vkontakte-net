using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallWallpostFull
    {
        /// <summary>
        /// Access key to private object.
        /// </summary>
        public string AccessKey { get; set; } 

        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        /// <summary>
        /// Date of publishing in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Date of editing in Unixtime.
        /// </summary>
        public int? Edited { get; set; } 

        /// <summary>
        /// Post author ID.
        /// </summary>
        public int? FromId { get; set; } 

        public WallGeo Geo { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Is post archived, only for post owners.
        /// </summary>
        public bool? IsArchived { get; set; } 

        /// <summary>
        /// Information whether the post in favorites list.
        /// </summary>
        public bool? IsFavorite { get; set; } 

        /// <summary>
        /// Count of likes.
        /// </summary>
        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Wall owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public string PostType { get; set; } 

        /// <summary>
        /// Count of views.
        /// </summary>
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
        /// Count of views.
        /// </summary>
        public WallViews Views { get; set; } 

        public IEnumerable<WallWallpost> CopyHistory { get; set; } 

        /// <summary>
        /// Information whether current user can edit the post.
        /// </summary>
        public bool? CanEdit { get; set; } 

        /// <summary>
        /// Post creator ID (if post still can be edited).
        /// </summary>
        public int? CreatedBy { get; set; } 

        /// <summary>
        /// Information whether current user can delete the post.
        /// </summary>
        public bool? CanDelete { get; set; } 

        /// <summary>
        /// Information whether current user can pin the post.
        /// </summary>
        public bool? CanPin { get; set; } 

        /// <summary>
        /// Information whether the post is pinned.
        /// </summary>
        public int? IsPinned { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        /// <summary>
        /// Information whether the post is marked as ads.
        /// </summary>
        public bool? MarkedAsAds { get; set; } 
    }
}
