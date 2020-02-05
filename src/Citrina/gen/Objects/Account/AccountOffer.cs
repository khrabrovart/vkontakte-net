using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountOffer
    {
        /// <summary>
        /// Offer description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Offer ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// URL of the preview image.
        /// </summary>
        public string Img { get; set; } 

        /// <summary>
        /// Instruction how to process the offer.
        /// </summary>
        public string Instruction { get; set; } 

        /// <summary>
        /// Instruction how to process the offer (HTML format).
        /// </summary>
        public string InstructionHtml { get; set; } 

        /// <summary>
        /// Offer price.
        /// </summary>
        public int? Price { get; set; } 

        /// <summary>
        /// Offer short description.
        /// </summary>
        public string ShortDescription { get; set; } 

        /// <summary>
        /// Offer tag.
        /// </summary>
        public string Tag { get; set; } 

        /// <summary>
        /// Offer title.
        /// </summary>
        public string Title { get; set; } 
    }
}
