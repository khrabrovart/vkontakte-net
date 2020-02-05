using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsGetCommentsResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<WidgetsWidgetComment> Posts { get; set; } 
    }
}
