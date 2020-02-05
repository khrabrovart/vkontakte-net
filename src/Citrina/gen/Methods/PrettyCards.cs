using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PrettyCards : IPrettyCards
    {
        public Task<ApiRequest<PrettyCardsCreateResponse>> CreateApi(int? ownerId = null, string photo = null, string title = null, string link = null, string price = null, string priceOld = null, string button = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo"] = photo,
                ["title"] = title,
                ["link"] = link,
                ["price"] = price,
                ["price_old"] = priceOld,
                ["button"] = button,
            };

            return RequestManager.CreateRequestAsync<PrettyCardsCreateResponse>("prettyCards.create", null, request);
        }

        public Task<ApiRequest<PrettyCardsDeleteResponse>> DeleteApi(int? ownerId = null, int? cardId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["card_id"] = cardId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PrettyCardsDeleteResponse>("prettyCards.delete", null, request);
        }

        public Task<ApiRequest<PrettyCardsEditResponse>> EditApi(int? ownerId = null, int? cardId = null, string photo = null, string title = null, string link = null, string price = null, string priceOld = null, string button = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["card_id"] = cardId?.ToString(),
                ["photo"] = photo,
                ["title"] = title,
                ["link"] = link,
                ["price"] = price,
                ["price_old"] = priceOld,
                ["button"] = button,
            };

            return RequestManager.CreateRequestAsync<PrettyCardsEditResponse>("prettyCards.edit", null, request);
        }

        public Task<ApiRequest<PrettyCardsGetResponse>> GetApi(int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PrettyCardsGetResponse>("prettyCards.get", null, request);
        }

        public Task<ApiRequest<IEnumerable<PrettyCardsPrettyCard>>> GetByIdApi(int? ownerId = null, IEnumerable<int> cardIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["card_ids"] = RequestHelpers.ParseEnumerable(cardIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PrettyCardsPrettyCard>>("prettyCards.getById", null, request);
        }

        public Task<ApiRequest<string>> GetUploadURLApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<string>("prettyCards.getUploadURL", null, request);
        }
    }
}
