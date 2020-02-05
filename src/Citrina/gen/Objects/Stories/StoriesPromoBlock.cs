using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Additional data for promo stories.
    /// </summary>
    public class StoriesPromoBlock
    {
        /// <summary>
        /// Promo story title.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// RL of square photo of the story with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// RL of square photo of the story with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// Hide animation for promo story.
        /// </summary>
        public bool? NotAnimated { get; set; } 
    }
}
