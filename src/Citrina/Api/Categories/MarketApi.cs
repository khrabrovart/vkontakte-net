using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class MarketApi : IMarketApi
    {
        public Task<ApiRequest<MarketGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetResponse>("market.get", accessToken, request);
        }

        public Task<ApiRequest<MarketGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetExtendedResponse>("market.get", accessToken, request);
        }

        public Task<ApiRequest<MarketGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<string> itemIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdResponse>("market.getById", accessToken, request);
        }

        public Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> itemIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdExtendedResponse>("market.getById", accessToken, request);
        }

        public Task<ApiRequest<MarketSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketSearchResponse>("market.search", accessToken, request);
        }

        public Task<ApiRequest<MarketSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketSearchExtendedResponse>("market.search", accessToken, request);
        }

        public Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumsResponse>("market.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumByIdResponse>("market.getAlbumById", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("market.createComment", accessToken, request);
        }

        public Task<ApiRequest<MarketGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MarketGetCommentsResponse>("market.getComments", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reportComment", accessToken, request);
        }

        public Task<ApiRequest<MarketGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetCategoriesResponse>("market.getCategories", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.report", accessToken, request);
        }

        public Task<ApiRequest<MarketAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
            };

            return RequestManager.CreateRequestAsync<MarketAddResponse>("market.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderItems(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderItems", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<MarketAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<MarketAddAlbumResponse>("market.addAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.removeFromAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddToAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.addToAlbum", accessToken, request);
        }

    }
}
