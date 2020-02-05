using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoVideoFull
    {
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
        /// Information whether current user can add the video to favourites.
        /// </summary>
        public bool? CanAddToFaves { get; set; } 

        /// <summary>
        /// Information whether current user can comment the video.
        /// </summary>
        public bool? CanComment { get; set; } 

        /// <summary>
        /// Information whether current user can edit the video.
        /// </summary>
        public bool? CanEdit { get; set; } 

        /// <summary>
        /// Information whether current user can comment the video.
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
        /// URL of the first frame for the corresponding width.
        /// </summary>
        public string FirstFrame640 { get; set; } 

        /// <summary>
        /// URL of the first frame for the corresponding width.
        /// </summary>
        public string FirstFrame1280 { get; set; } 

        /// <summary>
        /// Video ID.
        /// </summary>
        public int? Id { get; set; } 

        public IEnumerable<VideoVideoImage> Image { get; set; } 

        public BaseLikes Likes { get; set; } 

        /// <summary>
        /// Returns if the video is live translation.
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
        /// Information whether the video is repeated.
        /// </summary>
        public bool? Repeat { get; set; } 

        /// <summary>
        /// Video title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Number of views.
        /// </summary>
        public int? Views { get; set; } 
    }
}
