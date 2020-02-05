using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DocsDoc
    {
        /// <summary>
        /// Access key for the document.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Date when file has been uploaded in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// File extension.
        /// </summary>
        public string Ext { get; set; } 

        /// <summary>
        /// Document ID.
        /// </summary>
        public int? Id { get; set; } 

        public bool? IsLicensed { get; set; } 

        /// <summary>
        /// Document owner ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public DocsDocPreview Preview { get; set; } 

        /// <summary>
        /// File size in bites.
        /// </summary>
        public int? Size { get; set; } 

        /// <summary>
        /// Document title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Document type.
        /// </summary>
        public int? Type { get; set; } 

        /// <summary>
        /// File URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
