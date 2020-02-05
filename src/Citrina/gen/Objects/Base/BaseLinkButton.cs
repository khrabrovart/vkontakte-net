using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkButton
    {
        /// <summary>
        /// Button action.
        /// </summary>
        public BaseLinkButtonAction Action { get; set; } 

        /// <summary>
        /// Button title.
        /// </summary>
        public string Title { get; set; } 
    }
}
