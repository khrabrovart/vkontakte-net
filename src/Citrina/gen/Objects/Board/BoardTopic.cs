using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BoardTopic
    {
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
    }
}
