using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoVideo
    {
        public enum Type
        {
            [EnumMember(Value = "video")]
            Video,
        }
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
    }
}
