using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Fave : IFave
    {
        public Task<ApiRequest<bool?>> AddArticleApi(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addArticle", null, request);
        }

        /// <summary>
        /// Adds a link to user faves.
        /// </summary>
        public Task<ApiRequest<bool?>> AddLinkApi(string link = null)
        {
            var request = new Dictionary<string, string>
            {
                ["link"] = link,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addLink", null, request);
        }

        public Task<ApiRequest<bool?>> AddPageApi(int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addPage", null, request);
        }

        public Task<ApiRequest<bool?>> AddPostApi(int? ownerId = null, int? id = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["id"] = id?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addPost", null, request);
        }

        public Task<ApiRequest<bool?>> AddProductApi(int? ownerId = null, int? id = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["id"] = id?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addProduct", null, request);
        }

        public Task<ApiRequest<FaveTag>> AddTagApi(string name = null)
        {
            var request = new Dictionary<string, string>
            {
                ["name"] = name,
            };

            return RequestManager.CreateRequestAsync<FaveTag>("fave.addTag", null, request);
        }

        public Task<ApiRequest<bool?>> AddVideoApi(int? ownerId = null, int? id = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["id"] = id?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addVideo", null, request);
        }

        public Task<ApiRequest<bool?>> EditTagApi(int? id = null, string name = null)
        {
            var request = new Dictionary<string, string>
            {
                ["id"] = id?.ToString(),
                ["name"] = name,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.editTag", null, request);
        }

        public Task<ApiRequest<FaveGetResponse>> GetApi(bool? extended = null, string itemType = null, int? tagId = null, int? offset = null, int? count = null, string fields = null, bool? isFromSnackbar = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["item_type"] = itemType,
                ["tag_id"] = tagId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = fields,
                ["is_from_snackbar"] = RequestHelpers.ParseBoolean(isFromSnackbar),
            };

            return RequestManager.CreateRequestAsync<FaveGetResponse>("fave.get", null, request);
        }

        public Task<ApiRequest<FaveGetExtendedResponse>> GetApi(bool? extended = null, string itemType = null, int? tagId = null, int? offset = null, int? count = null, string fields = null, bool? isFromSnackbar = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["item_type"] = itemType,
                ["tag_id"] = tagId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = fields,
                ["is_from_snackbar"] = RequestHelpers.ParseBoolean(isFromSnackbar),
            };

            return RequestManager.CreateRequestAsync<FaveGetExtendedResponse>("fave.get", null, request);
        }

        public Task<ApiRequest<FaveGetPagesResponse>> GetPagesApi(int? offset = null, int? count = null, string type = null, IEnumerable<BaseUserGroupFields> fields = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["type"] = type,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FaveGetPagesResponse>("fave.getPages", null, request);
        }

        public Task<ApiRequest<FaveGetTagsResponse>> GetTagsApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<FaveGetTagsResponse>("fave.getTags", null, request);
        }

        public Task<ApiRequest<bool?>> MarkSeenApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.markSeen", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveArticleApi(int? ownerId = null, int? articleId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["article_id"] = articleId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeArticle", null, request);
        }

        /// <summary>
        /// Removes link from the user's faves.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveLinkApi(string linkId = null, string link = null)
        {
            var request = new Dictionary<string, string>
            {
                ["link_id"] = linkId,
                ["link"] = link,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeLink", null, request);
        }

        public Task<ApiRequest<bool?>> RemovePageApi(int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removePage", null, request);
        }

        public Task<ApiRequest<bool?>> RemovePostApi(int? ownerId = null, int? id = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["id"] = id?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removePost", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveProductApi(int? ownerId = null, int? id = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["id"] = id?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeProduct", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveTagApi(int? id = null)
        {
            var request = new Dictionary<string, string>
            {
                ["id"] = id?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeTag", null, request);
        }

        public Task<ApiRequest<bool?>> ReorderTagsApi(IEnumerable<int> ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["ids"] = RequestHelpers.ParseEnumerable(ids),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.reorderTags", null, request);
        }

        public Task<ApiRequest<bool?>> SetPageTagsApi(int? userId = null, int? groupId = null, IEnumerable<int> tagIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["tag_ids"] = RequestHelpers.ParseEnumerable(tagIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.setPageTags", null, request);
        }

        public Task<ApiRequest<bool?>> SetTagsApi(string itemType = null, int? itemOwnerId = null, int? itemId = null, IEnumerable<int> tagIds = null, string linkId = null, string linkUrl = null)
        {
            var request = new Dictionary<string, string>
            {
                ["item_type"] = itemType,
                ["item_owner_id"] = itemOwnerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["tag_ids"] = RequestHelpers.ParseEnumerable(tagIds),
                ["link_id"] = linkId,
                ["link_url"] = linkUrl,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.setTags", null, request);
        }

        public Task<ApiRequest<bool?>> TrackPageInteractionApi(int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.trackPageInteraction", null, request);
        }
    }
}
