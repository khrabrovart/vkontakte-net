using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotesNoteComment
    {
        /// <summary>
        /// Date when the comment has beed added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Message { get; set; } 

        /// <summary>
        /// Note ID.
        /// </summary>
        public int? Nid { get; set; } 

        /// <summary>
        /// Note ID.
        /// </summary>
        public int? Oid { get; set; } 

        /// <summary>
        /// ID of replied comment .
        /// </summary>
        public int? ReplyTo { get; set; } 

        /// <summary>
        /// Comment author's ID.
        /// </summary>
        public int? Uid { get; set; } 
    }
}
