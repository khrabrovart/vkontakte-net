using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesStory
    {
        /// <summary>
        /// Access key for private object.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Information whether current user can comment the story (0 - no, 1 - yes).
        /// </summary>
        public bool? CanComment { get; set; } 

        /// <summary>
        /// Information whether current user can reply to the story (0 - no, 1 - yes).
        /// </summary>
        public bool? CanReply { get; set; } 

        /// <summary>
        /// Information whether current user can see the story (0 - no, 1 - yes).
        /// </summary>
        public bool? CanSee { get; set; } 

        /// <summary>
        /// Information whether current user can share the story (0 - no, 1 - yes).
        /// </summary>
        public bool? CanShare { get; set; } 

        /// <summary>
        /// Date when story has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Story expiration time. Unixtime.
        /// </summary>
        public int? ExpiresAt { get; set; } 

        /// <summary>
        /// Story ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Information whether the story is deleted (false - no, true - yes).
        /// </summary>
        public bool? IsDeleted { get; set; } 

        /// <summary>
        /// Information whether the story is expired (false - no, true - yes).
        /// </summary>
        public bool? IsExpired { get; set; } 

        public StoriesStoryLink Link { get; set; } 

        /// <summary>
        /// Story owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public StoriesStory ParentStory { get; set; } 

        /// <summary>
        /// Access key for private object.
        /// </summary>
        public string ParentStoryAccessKey { get; set; } 

        /// <summary>
        /// Parent story ID.
        /// </summary>
        public int? ParentStoryId { get; set; } 

        /// <summary>
        /// Parent story owner's ID.
        /// </summary>
        public int? ParentStoryOwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        /// <summary>
        /// Replies to current story.
        /// </summary>
        public StoriesReplies Replies { get; set; } 

        /// <summary>
        /// Information whether current user has seen the story or not (0 - no, 1 - yes).
        /// </summary>
        public bool? Seen { get; set; } 

        public string Type { get; set; } 

        public StoriesStoryVideo Video { get; set; } 

        /// <summary>
        /// Views number.
        /// </summary>
        public int? Views { get; set; } 

        /// <summary>
        /// Does author have stories privacy restrictions.
        /// </summary>
        public bool? IsRestricted { get; set; } 

        /// <summary>
        /// Is video without sound.
        /// </summary>
        public bool? NoSound { get; set; } 

        /// <summary>
        /// Does video need to be muted.
        /// </summary>
        public bool? NeedMute { get; set; } 

        /// <summary>
        /// Information whether story has question sticker and current user can send question to the author.
        /// </summary>
        public bool? CanAsk { get; set; } 

        /// <summary>
        /// Information whether story has question sticker and current user can send anonymous question to the author.
        /// </summary>
        public bool? CanAskAnonymous { get; set; } 
    }
}
