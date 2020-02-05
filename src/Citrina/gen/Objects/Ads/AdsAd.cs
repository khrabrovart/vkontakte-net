using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsAd
    {
        /// <summary>
        /// Ad format.
        /// </summary>
        public int? AdFormat { get; set; } 

        /// <summary>
        /// Ad platform.
        /// </summary>
        public string AdPlatform { get; set; } 

        /// <summary>
        /// Total limit.
        /// </summary>
        public int? AllLimit { get; set; } 

        public int? Approved { get; set; } 

        /// <summary>
        /// Campaign ID.
        /// </summary>
        public int? CampaignId { get; set; } 

        /// <summary>
        /// Category ID.
        /// </summary>
        public int? Category1Id { get; set; } 

        /// <summary>
        /// Additional category ID.
        /// </summary>
        public int? Category2Id { get; set; } 

        public int? CostType { get; set; } 

        /// <summary>
        /// Cost of a click, kopecks.
        /// </summary>
        public int? Cpc { get; set; } 

        /// <summary>
        /// Cost of 1000 impressions, kopecks.
        /// </summary>
        public int? Cpm { get; set; } 

        /// <summary>
        /// Cost of an action, kopecks.
        /// </summary>
        public int? Cpa { get; set; } 

        /// <summary>
        /// Information whether disclaimer is enabled.
        /// </summary>
        public bool? DisclaimerMedical { get; set; } 

        /// <summary>
        /// Information whether disclaimer is enabled.
        /// </summary>
        public bool? DisclaimerSpecialist { get; set; } 

        /// <summary>
        /// Information whether disclaimer is enabled.
        /// </summary>
        public bool? DisclaimerSupplements { get; set; } 

        /// <summary>
        /// Ad ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Impressions limit.
        /// </summary>
        public int? ImpressionsLimit { get; set; } 

        /// <summary>
        /// Information whether impressions are limited.
        /// </summary>
        public bool? ImpressionsLimited { get; set; } 

        /// <summary>
        /// Ad title.
        /// </summary>
        public string Name { get; set; } 

        public int? Status { get; set; } 

        /// <summary>
        /// Information whether the ad is a video.
        /// </summary>
        public bool? Video { get; set; } 
    }
}
