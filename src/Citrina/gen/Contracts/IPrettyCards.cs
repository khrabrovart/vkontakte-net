using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IPrettyCardsApi
    {
        Task<ApiRequest<PrettyCardsCreateResponse>> CreateApi(int? ownerId = null, string photo = null, string title = null, string link = null, string price = null, string priceOld = null, string button = null);

        Task<ApiRequest<PrettyCardsDeleteResponse>> DeleteApi(int? ownerId = null, int? cardId = null);

        Task<ApiRequest<PrettyCardsEditResponse>> EditApi(int? ownerId = null, int? cardId = null, string photo = null, string title = null, string link = null, string price = null, string priceOld = null, string button = null);

        Task<ApiRequest<PrettyCardsGetResponse>> GetApi(int? ownerId = null, int? offset = null, int? count = null);

        Task<ApiRequest<IEnumerable<PrettyCardsPrettyCard>>> GetByIdApi(int? ownerId = null, IEnumerable<int> cardIds = null);

        Task<ApiRequest<string>> GetUploadURLApi();
    }
}
