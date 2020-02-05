using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsStatsSexAge
    {
        /// <summary>
        /// Age denotation.
        /// </summary>
        public string AgeRange { get; set; } 

        /// <summary>
        ///  Views by female users.
        /// </summary>
        public int? Female { get; set; } 

        /// <summary>
        ///  Views by male users.
        /// </summary>
        public int? Male { get; set; } 
    }
}
