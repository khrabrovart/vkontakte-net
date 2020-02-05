using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsGetPagesResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<WidgetsWidgetPage> Pages { get; set; } 
    }
}
