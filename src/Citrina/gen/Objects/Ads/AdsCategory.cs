using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsCategory
    {
        /// <summary>
        /// Category ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Category name.
        /// </summary>
        public string Name { get; set; } 

        public IEnumerable<BaseObjectWithName> Subcategories { get; set; } 
    }
}
