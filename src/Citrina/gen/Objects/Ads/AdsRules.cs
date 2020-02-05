using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsRules
    {
        public IEnumerable<AdsParagraphs> Paragraphs { get; set; } 

        /// <summary>
        /// Comment.
        /// </summary>
        public string Title { get; set; } 
    }
}
