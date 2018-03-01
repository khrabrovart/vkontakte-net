using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class DocsApi : IDocsApi
    {
        public Task<ApiRequest<DocsGetResponse>> Get(UserAccessToken accessToken, int? count = null, int? offset = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetResponse>("docs.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> GetById(UserAccessToken accessToken, IEnumerable<string> docs = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["docs"] = RequestHelpers.ParseEnumerable(docs),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.getById", accessToken, request);
        }

        public Task<ApiRequest<DocsGetUploadServerResponse>> GetUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetUploadServerResponse>("docs.getUploadServer", accessToken, request);
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(GroupAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(UserAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
                ["title"] = title,
                ["tags"] = tags,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(GroupAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
                ["title"] = title,
                ["tags"] = tags,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? docId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.delete", accessToken, request);
        }

        public Task<ApiRequest<DocsAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<DocsAddResponse>("docs.add", accessToken, request);
        }

        public Task<ApiRequest<DocsGetTypesResponse>> GetTypes(UserAccessToken accessToken, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetTypesResponse>("docs.getTypes", accessToken, request);
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken, request);
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["title"] = title,
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.edit", accessToken, request);
        }

    }
}
