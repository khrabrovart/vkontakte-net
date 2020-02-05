using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsDeleteResponse
    {
        /// <summary>
        /// Returns 1 if friend has been deleted.
        /// </summary>
        public enum FriendDeleted
        {
            Ok,
        }

        /// <summary>
        /// Returns 1 if out request has been canceled.
        /// </summary>
        public enum OutRequestDeleted
        {
            Ok,
        }

        /// <summary>
        /// Returns 1 if incoming request has been declined.
        /// </summary>
        public enum InRequestDeleted
        {
            Ok,
        }

        /// <summary>
        /// Returns 1 if suggestion has been declined.
        /// </summary>
        public enum SuggestionDeleted
        {
            Ok,
        }
        public bool? Success { get; set; } 
    }
}
