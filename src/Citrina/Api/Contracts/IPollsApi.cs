using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IPollsApi
    {
        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// </summary>
        Task<ApiRequest<PollsPoll>> GetById(UserAccessToken accessToken, int? ownerId = null, bool? isBoard = null, int? pollId = null);
        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> AddVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null);
        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null);
        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// </summary>
        Task<ApiRequest<IEnumerable<PollsVoters>>> GetVoters(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// </summary>
        Task<ApiRequest<PollsPoll>> Create(UserAccessToken accessToken, string question = null, bool? isAnonymous = null, int? ownerId = null, JsonArray addAnswers = null);
        /// <summary>
        /// Edits created polls
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, string question = null, JsonArray addAnswers = null, JsonArray editAnswers = null, JsonArray deleteAnswers = null);
    }
}
