using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsLongPollEvents
    {
        public bool? AudioNew { get; set; } 

        public bool? BoardPostDelete { get; set; } 

        public bool? BoardPostEdit { get; set; } 

        public bool? BoardPostNew { get; set; } 

        public bool? BoardPostRestore { get; set; } 

        public bool? GroupChangePhoto { get; set; } 

        public bool? GroupChangeSettings { get; set; } 

        public bool? GroupJoin { get; set; } 

        public bool? GroupLeave { get; set; } 

        public bool? GroupOfficersEdit { get; set; } 

        public bool? LeadFormsNew { get; set; } 

        public bool? MarketCommentDelete { get; set; } 

        public bool? MarketCommentEdit { get; set; } 

        public bool? MarketCommentNew { get; set; } 

        public bool? MarketCommentRestore { get; set; } 

        public bool? MessageAllow { get; set; } 

        public bool? MessageDeny { get; set; } 

        public bool? MessageNew { get; set; } 

        public bool? MessageRead { get; set; } 

        public bool? MessageReply { get; set; } 

        public bool? MessageTypingState { get; set; } 

        public bool? MessagesEdit { get; set; } 

        public bool? PhotoCommentDelete { get; set; } 

        public bool? PhotoCommentEdit { get; set; } 

        public bool? PhotoCommentNew { get; set; } 

        public bool? PhotoCommentRestore { get; set; } 

        public bool? PhotoNew { get; set; } 

        public bool? PollVoteNew { get; set; } 

        public bool? UserBlock { get; set; } 

        public bool? UserUnblock { get; set; } 

        public bool? VideoCommentDelete { get; set; } 

        public bool? VideoCommentEdit { get; set; } 

        public bool? VideoCommentNew { get; set; } 

        public bool? VideoCommentRestore { get; set; } 

        public bool? VideoNew { get; set; } 

        public bool? WallPostNew { get; set; } 

        public bool? WallReplyDelete { get; set; } 

        public bool? WallReplyEdit { get; set; } 

        public bool? WallReplyNew { get; set; } 

        public bool? WallReplyRestore { get; set; } 

        public bool? WallRepost { get; set; } 
    }
}
