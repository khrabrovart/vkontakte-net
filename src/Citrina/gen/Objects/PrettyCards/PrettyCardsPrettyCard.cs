using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PrettyCardsPrettyCard
    {
        /// <summary>
        /// Button key.
        /// </summary>
        public string Button { get; set; } 

        /// <summary>
        /// Button text in current language.
        /// </summary>
        public string ButtonText { get; set; } 

        /// <summary>
        /// Card ID (long int returned as string).
        /// </summary>
        public string CardId { get; set; } 

        public IEnumerable<BaseImage> Images { get; set; } 

        /// <summary>
        /// Link URL.
        /// </summary>
        public string LinkUrl { get; set; } 

        /// <summary>
        /// Photo ID (format "<owner_id>_<media_id>").
        /// </summary>
        public string Photo { get; set; } 

        /// <summary>
        /// Price if set (decimal number returned as string).
        /// </summary>
        public string Price { get; set; } 

        /// <summary>
        /// Old price if set (decimal number returned as string).
        /// </summary>
        public string PriceOld { get; set; } 

        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; } 
    }
}
