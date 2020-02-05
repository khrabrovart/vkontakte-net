using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Polls : IPolls
    {
        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// </summary>
        public Task<ApiRequest<bool?>> AddVoteApi(int? ownerId = null, int? pollId = null, IEnumerable<int> answerIds = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_ids"] = RequestHelpers.ParseEnumerable(answerIds),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.addVote", null, request);
        }

        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// </summary>
        public Task<ApiRequest<PollsPoll>> CreateApi(string question = null, bool? isAnonymous = null, bool? isMultiple = null, int? endDate = null, int? ownerId = null, string addAnswers = null, int? photoId = null, string backgroundId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["question"] = question,
                ["is_anonymous"] = RequestHelpers.ParseBoolean(isAnonymous),
                ["is_multiple"] = RequestHelpers.ParseBoolean(isMultiple),
                ["end_date"] = endDate?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["add_answers"] = addAnswers,
                ["photo_id"] = photoId?.ToString(),
                ["background_id"] = backgroundId,
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.create", null, request);
        }

        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteVoteApi(int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_id"] = answerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.deleteVote", null, request);
        }

        /// <summary>
        /// Edits created polls.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? pollId = null, string question = null, string addAnswers = null, string editAnswers = null, string deleteAnswers = null, int? endDate = null, int? photoId = null, string backgroundId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["question"] = question,
                ["add_answers"] = addAnswers,
                ["edit_answers"] = editAnswers,
                ["delete_answers"] = deleteAnswers,
                ["end_date"] = endDate?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["background_id"] = backgroundId,
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.edit", null, request);
        }

        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// </summary>
        public Task<ApiRequest<PollsPoll>> GetByIdApi(int? ownerId = null, bool? isBoard = null, int? pollId = null, bool? extended = null, int? friendsCount = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
                ["poll_id"] = pollId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["friends_count"] = friendsCount?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.getById", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PollsVoters>>> GetVotersApi(int? ownerId = null, int? pollId = null, IEnumerable<int> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_ids"] = RequestHelpers.ParseEnumerable(answerIds),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PollsVoters>>("polls.getVoters", null, request);
        }
    }
}
