using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IMarketApi
    {
        /// <summary>
        /// Ads a new item to the market.
        /// </summary>
        Task<ApiRequest<MarketAddResponse>> AddApi(int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, double? oldPrice = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int> photoIds = null, string url = null);

        /// <summary>
        /// Creates new collection of items.
        /// </summary>
        Task<ApiRequest<MarketAddAlbumResponse>> AddAlbumApi(int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null);

        /// <summary>
        /// Adds an item to one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> AddToAlbumApi(int? ownerId = null, int? itemId = null, IEnumerable<int> albumIds = null);

        /// <summary>
        /// Creates a new comment for an item.
        /// </summary>
        Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);

        /// <summary>
        /// Deletes an item.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? itemId = null);

        /// <summary>
        /// Deletes a collection of items.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbumApi(int? ownerId = null, int? albumId = null);

        /// <summary>
        /// Deletes an item's comment.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Edits an item.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int> photoIds = null, string url = null);

        /// <summary>
        /// Edits a collection of items.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbumApi(int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null);

        /// <summary>
        /// Chages item comment's text.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetResponse>> GetApi(int? ownerId = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetExtendedResponse>> GetApi(int? ownerId = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Returns items album's data.
        /// </summary>
        Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumByIdApi(int? ownerId = null, IEnumerable<int> albumIds = null);

        /// <summary>
        /// Returns community's collections list.
        /// </summary>
        Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdResponse>> GetByIdApi(IEnumerable<string> itemIds = null, bool? extended = null);

        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> itemIds = null, bool? extended = null);

        /// <summary>
        /// Returns a list of market categories.
        /// </summary>
        Task<ApiRequest<MarketGetCategoriesResponse>> GetCategoriesApi(int? count = null, int? offset = null);

        /// <summary>
        /// Returns comments list for an item.
        /// </summary>
        Task<ApiRequest<MarketGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Removes an item from one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveFromAlbumApi(int? ownerId = null, int? itemId = null, IEnumerable<int> albumIds = null);

        /// <summary>
        /// Reorders the collections list.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbumsApi(int? ownerId = null, int? albumId = null, int? before = null, int? after = null);

        /// <summary>
        /// Changes item place in a collection.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderItemsApi(int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null);

        /// <summary>
        /// Sends a complaint to the item.
        /// </summary>
        Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? itemId = null, int? reason = null);

        /// <summary>
        /// Sends a complaint to the item's comment.
        /// </summary>
        Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null);

        /// <summary>
        /// Restores recently deleted item.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? itemId = null);

        /// <summary>
        /// Restores a recently deleted comment.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Searches market items in a community's catalog.
        /// </summary>
        Task<ApiRequest<MarketSearchResponse>> SearchApi(int? ownerId = null, int? albumId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int> tags = null, int? sort = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null, int? status = null);

        /// <summary>
        /// Searches market items in a community's catalog.
        /// </summary>
        Task<ApiRequest<MarketSearchExtendedResponse>> SearchApi(int? ownerId = null, int? albumId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int> tags = null, int? sort = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null, int? status = null);
    }
}
