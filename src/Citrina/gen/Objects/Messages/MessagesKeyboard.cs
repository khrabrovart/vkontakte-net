using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesKeyboard
    {
        /// <summary>
        /// Community or bot, which set this keyboard.
        /// </summary>
        public int? AuthorId { get; set; } 

        public IEnumerable<IEnumerable<MessagesKeyboardButton>> Buttons { get; set; } 

        /// <summary>
        /// Should this keyboard disappear on first use.
        /// </summary>
        public bool? OneTime { get; set; } 

        public bool? Inline { get; set; } 
    }
}
