using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedNewsfeedItem
    {
        /// <summary>
        /// type of digest.
        /// </summary>
        public enum Template
        {
            [EnumMember(Value = "list")]
            List,
            [EnumMember(Value = "grid")]
            Grid,
        }

        public enum BlockType
        {
            [EnumMember(Value = "local")]
            Local,
            [EnumMember(Value = "remote")]
            Remote,
        }
        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedEventActivity Activity { get; set; } 

        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        public IEnumerable<WallWallpost> CopyHistory { get; set; } 

        public BaseGeo Geo { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public string PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemPhotoPhotos Photos { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemFriendFriends Friends { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemNoteNotes Notes { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemAudioAudio Audio { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemVideoVideo Video { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Topic post ID.
        /// </summary>
        public int? PostId { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public string ButtonText { get; set; } 

        /// <summary>
        /// id of feed in digest.
        /// </summary>
        public string FeedId { get; set; } 

        public IEnumerable<WallWallpost> Items { get; set; } 

        public IEnumerable<string> MainPostIds { get; set; } 

        public string Title { get; set; } 

        public string TrackCode { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public IEnumerable<StoriesStory> Stories { get; set; } 

        public string Title { get; set; } 

        public string TrackCode { get; set; } 
    }
}
