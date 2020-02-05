using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IPollsApi
    {
        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> AddVoteApi(int? ownerId = null, int? pollId = null, IEnumerable<int> answerIds = null, bool? isBoard = null);

        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// </summary>
        Task<ApiRequest<PollsPoll>> CreateApi(string question = null, bool? isAnonymous = null, bool? isMultiple = null, int? endDate = null, int? ownerId = null, string addAnswers = null, int? photoId = null, string backgroundId = null);

        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteVoteApi(int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null);

        /// <summary>
        /// Edits created polls.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? pollId = null, string question = null, string addAnswers = null, string editAnswers = null, string deleteAnswers = null, int? endDate = null, int? photoId = null, string backgroundId = null);

        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// </summary>
        Task<ApiRequest<PollsPoll>> GetByIdApi(int? ownerId = null, bool? isBoard = null, int? pollId = null, bool? extended = null, int? friendsCount = null, IEnumerable<string> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// </summary>
        Task<ApiRequest<IEnumerable<PollsVoters>>> GetVotersApi(int? ownerId = null, int? pollId = null, IEnumerable<int> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null);
    }
}
