using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IMarketApi
    {
        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null, bool? extended = null);
        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<string> itemIds = null);
        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> itemIds = null, bool? extended = null);
        /// <summary>
        /// Searches market items in a community's catalog
        /// </summary>
        Task<ApiRequest<MarketSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null);
        /// <summary>
        /// Searches market items in a community's catalog
        /// </summary>
        Task<ApiRequest<MarketSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns community's collections list.
        /// </summary>
        Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns items album's data
        /// </summary>
        Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null);
        /// <summary>
        /// Creates a new comment for an item.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Returns comments list for an item.
        /// </summary>
        Task<ApiRequest<MarketGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Deletes an item's comment
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a recently deleted comment
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Chages item comment's text
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Sends a complaint to the item's comment.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns a list of market categories.
        /// </summary>
        Task<ApiRequest<MarketGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Sends a complaint to the item.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, int? reason = null);
        /// <summary>
        /// Ads a new item to the market.
        /// </summary>
        Task<ApiRequest<MarketAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null);
        /// <summary>
        /// Edits an item.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null);
        /// <summary>
        /// Deletes an item.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Restores recently deleted item
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Changes item place in a collection.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderItems(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the collections list.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Creates new collection of items
        /// </summary>
        Task<ApiRequest<MarketAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null);
        /// <summary>
        /// Edits a collection of items
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null);
        /// <summary>
        /// Deletes a collection of items.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null);
        /// <summary>
        /// Removes an item from one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveFromAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null);
        /// <summary>
        /// Adds an item to one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> AddToAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null);
    }
}
