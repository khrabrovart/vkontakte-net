using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Market : IMarket
    {
        /// <summary>
        /// Ads a new item to the market.
        /// </summary>
        public Task<ApiRequest<MarketAddResponse>> AddApi(int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, double? oldPrice = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int> photoIds = null, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["old_price"] = oldPrice?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<MarketAddResponse>("market.add", null, request);
        }

        /// <summary>
        /// Creates new collection of items.
        /// </summary>
        public Task<ApiRequest<MarketAddAlbumResponse>> AddAlbumApi(int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<MarketAddAlbumResponse>("market.addAlbum", null, request);
        }

        /// <summary>
        /// Adds an item to one or multiple collections.
        /// </summary>
        public Task<ApiRequest<bool?>> AddToAlbumApi(int? ownerId = null, int? itemId = null, IEnumerable<int> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.addToAlbum", null, request);
        }

        /// <summary>
        /// Creates a new comment for an item.
        /// </summary>
        public Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("market.createComment", null, request);
        }

        /// <summary>
        /// Deletes an item.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.delete", null, request);
        }

        /// <summary>
        /// Deletes a collection of items.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteAlbumApi(int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteAlbum", null, request);
        }

        /// <summary>
        /// Deletes an item's comment.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteComment", null, request);
        }

        /// <summary>
        /// Edits an item.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int> photoIds = null, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("market.edit", null, request);
        }

        /// <summary>
        /// Edits a collection of items.
        /// </summary>
        public Task<ApiRequest<bool?>> EditAlbumApi(int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editAlbum", null, request);
        }

        /// <summary>
        /// Chages item comment's text.
        /// </summary>
        public Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editComment", null, request);
        }

        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        public Task<ApiRequest<MarketGetResponse>> GetApi(int? ownerId = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetResponse>("market.get", null, request);
        }

        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        public Task<ApiRequest<MarketGetExtendedResponse>> GetApi(int? ownerId = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetExtendedResponse>("market.get", null, request);
        }

        /// <summary>
        /// Returns items album's data.
        /// </summary>
        public Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumByIdApi(int? ownerId = null, IEnumerable<int> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumByIdResponse>("market.getAlbumById", null, request);
        }

        /// <summary>
        /// Returns community's collections list.
        /// </summary>
        public Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumsResponse>("market.getAlbums", null, request);
        }

        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        public Task<ApiRequest<MarketGetByIdResponse>> GetByIdApi(IEnumerable<string> itemIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdResponse>("market.getById", null, request);
        }

        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        public Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> itemIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdExtendedResponse>("market.getById", null, request);
        }

        /// <summary>
        /// Returns a list of market categories.
        /// </summary>
        public Task<ApiRequest<MarketGetCategoriesResponse>> GetCategoriesApi(int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetCategoriesResponse>("market.getCategories", null, request);
        }

        /// <summary>
        /// Returns comments list for an item.
        /// </summary>
        public Task<ApiRequest<MarketGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MarketGetCommentsResponse>("market.getComments", null, request);
        }

        /// <summary>
        /// Removes an item from one or multiple collections.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveFromAlbumApi(int? ownerId = null, int? itemId = null, IEnumerable<int> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.removeFromAlbum", null, request);
        }

        /// <summary>
        /// Reorders the collections list.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderAlbumsApi(int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderAlbums", null, request);
        }

        /// <summary>
        /// Changes item place in a collection.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderItemsApi(int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderItems", null, request);
        }

        /// <summary>
        /// Sends a complaint to the item.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? itemId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.report", null, request);
        }

        /// <summary>
        /// Sends a complaint to the item's comment.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reportComment", null, request);
        }

        /// <summary>
        /// Restores recently deleted item.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restore", null, request);
        }

        /// <summary>
        /// Restores a recently deleted comment.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restoreComment", null, request);
        }

        /// <summary>
        /// Searches market items in a community's catalog.
        /// </summary>
        public Task<ApiRequest<MarketSearchResponse>> SearchApi(int? ownerId = null, int? albumId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int> tags = null, int? sort = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null, int? status = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["sort"] = sort?.ToString(),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["status"] = status?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketSearchResponse>("market.search", null, request);
        }

        /// <summary>
        /// Searches market items in a community's catalog.
        /// </summary>
        public Task<ApiRequest<MarketSearchExtendedResponse>> SearchApi(int? ownerId = null, int? albumId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int> tags = null, int? sort = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null, int? status = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["sort"] = sort?.ToString(),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["status"] = status?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketSearchExtendedResponse>("market.search", null, request);
        }
    }
}
