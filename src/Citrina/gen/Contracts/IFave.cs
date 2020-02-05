using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IFaveApi
    {
        Task<ApiRequest<bool?>> AddArticleApi(string url = null);

        /// <summary>
        /// Adds a link to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddLinkApi(string link = null);

        Task<ApiRequest<bool?>> AddPageApi(int? userId = null, int? groupId = null);

        Task<ApiRequest<bool?>> AddPostApi(int? ownerId = null, int? id = null, string accessKey = null);

        Task<ApiRequest<bool?>> AddProductApi(int? ownerId = null, int? id = null, string accessKey = null);

        Task<ApiRequest<FaveTag>> AddTagApi(string name = null);

        Task<ApiRequest<bool?>> AddVideoApi(int? ownerId = null, int? id = null, string accessKey = null);

        Task<ApiRequest<bool?>> EditTagApi(int? id = null, string name = null);

        Task<ApiRequest<FaveGetResponse>> GetApi(bool? extended = null, string itemType = null, int? tagId = null, int? offset = null, int? count = null, string fields = null, bool? isFromSnackbar = null);

        Task<ApiRequest<FaveGetExtendedResponse>> GetApi(bool? extended = null, string itemType = null, int? tagId = null, int? offset = null, int? count = null, string fields = null, bool? isFromSnackbar = null);

        Task<ApiRequest<FaveGetPagesResponse>> GetPagesApi(int? offset = null, int? count = null, string type = null, IEnumerable<BaseUserGroupFields> fields = null, int? tagId = null);

        Task<ApiRequest<FaveGetTagsResponse>> GetTagsApi();

        Task<ApiRequest<bool?>> MarkSeenApi();

        Task<ApiRequest<bool?>> RemoveArticleApi(int? ownerId = null, int? articleId = null);

        /// <summary>
        /// Removes link from the user's faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveLinkApi(string linkId = null, string link = null);

        Task<ApiRequest<bool?>> RemovePageApi(int? userId = null, int? groupId = null);

        Task<ApiRequest<bool?>> RemovePostApi(int? ownerId = null, int? id = null);

        Task<ApiRequest<bool?>> RemoveProductApi(int? ownerId = null, int? id = null);

        Task<ApiRequest<bool?>> RemoveTagApi(int? id = null);

        Task<ApiRequest<bool?>> ReorderTagsApi(IEnumerable<int> ids = null);

        Task<ApiRequest<bool?>> SetPageTagsApi(int? userId = null, int? groupId = null, IEnumerable<int> tagIds = null);

        Task<ApiRequest<bool?>> SetTagsApi(string itemType = null, int? itemOwnerId = null, int? itemId = null, IEnumerable<int> tagIds = null, string linkId = null, string linkUrl = null);

        Task<ApiRequest<bool?>> TrackPageInteractionApi(int? userId = null, int? groupId = null);
    }
}
