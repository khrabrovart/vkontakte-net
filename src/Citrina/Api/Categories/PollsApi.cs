using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class PollsApi : IPollsApi
    {
        public Task<ApiRequest<PollsPoll>> GetById(UserAccessToken accessToken, int? ownerId = null, bool? isBoard = null, int? pollId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
                ["poll_id"] = pollId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.getById", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_id"] = answerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.addVote", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_id"] = answerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.deleteVote", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PollsVoters>>> GetVoters(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<IEnumerable<PollsVoters>>("polls.getVoters", accessToken, request);
        }

        public Task<ApiRequest<PollsPoll>> Create(UserAccessToken accessToken, string question = null, bool? isAnonymous = null, int? ownerId = null, JsonArray addAnswers = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["question"] = question,
                ["is_anonymous"] = RequestHelpers.ParseBoolean(isAnonymous),
                ["owner_id"] = ownerId?.ToString(),
                ["add_answers"] = addAnswers?.JsonValue,
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.create", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, string question = null, JsonArray addAnswers = null, JsonArray editAnswers = null, JsonArray deleteAnswers = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["question"] = question,
                ["add_answers"] = addAnswers?.JsonValue,
                ["edit_answers"] = editAnswers?.JsonValue,
                ["delete_answers"] = deleteAnswers?.JsonValue,
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.edit", accessToken, request);
        }

    }
}
