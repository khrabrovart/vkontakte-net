using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsAdLayout
    {
        /// <summary>
        /// Ad format.
        /// </summary>
        public int? AdFormat { get; set; } 

        /// <summary>
        /// Campaign ID.
        /// </summary>
        public int? CampaignId { get; set; } 

        public int? CostType { get; set; } 

        /// <summary>
        /// Ad description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Ad ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Image URL.
        /// </summary>
        public string ImageSrc { get; set; } 

        /// <summary>
        /// URL of the preview image in double size.
        /// </summary>
        public string ImageSrc2x { get; set; } 

        /// <summary>
        /// Domain of advertised object.
        /// </summary>
        public string LinkDomain { get; set; } 

        /// <summary>
        /// URL of advertised object.
        /// </summary>
        public string LinkUrl { get; set; } 

        /// <summary>
        /// link to preview an ad as it is shown on the website.
        /// </summary>
        public string PreviewLink { get; set; } 

        /// <summary>
        /// Ad title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Information whether the ad is a video.
        /// </summary>
        public bool? Video { get; set; } 
    }
}
