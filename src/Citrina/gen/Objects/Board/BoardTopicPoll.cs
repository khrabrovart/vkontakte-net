using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BoardTopicPoll
    {
        /// <summary>
        /// Current user's answer ID.
        /// </summary>
        public int? AnswerId { get; set; } 

        public IEnumerable<PollsAnswer> Answers { get; set; } 

        /// <summary>
        /// Date when poll has been created in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// Information whether the poll is closed.
        /// </summary>
        public bool? IsClosed { get; set; } 

        /// <summary>
        /// Poll owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Poll ID.
        /// </summary>
        public int? PollId { get; set; } 

        /// <summary>
        /// Poll question.
        /// </summary>
        public string Question { get; set; } 

        /// <summary>
        /// Votes number.
        /// </summary>
        public string Votes { get; set; } 
    }
}
