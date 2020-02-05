using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PollsPoll
    {
        /// <summary>
        /// Information whether the field is anonymous.
        /// </summary>
        public bool? Anonymous { get; set; } 

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
        /// Poll ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Poll owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

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
