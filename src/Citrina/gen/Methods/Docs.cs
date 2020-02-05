using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Docs : IDocs
    {
        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// </summary>
        public Task<ApiRequest<DocsAddResponse>> AddApi(int? ownerId = null, int? docId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<DocsAddResponse>("docs.add", null, request);
        }

        /// <summary>
        /// Deletes a user or community document.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? docId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.delete", null, request);
        }

        /// <summary>
        /// Edits a document.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["title"] = title,
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.edit", null, request);
        }

        /// <summary>
        /// Returns detailed information about user or community documents.
        /// </summary>
        public Task<ApiRequest<DocsGetResponse>> GetApi(int? count = null, int? offset = null, int? type = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["type"] = type?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetResponse>("docs.get", null, request);
        }

        /// <summary>
        /// Returns information about documents by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<DocsDoc>>> GetByIdApi(IEnumerable<string> docs = null)
        {
            var request = new Dictionary<string, string>
            {
                ["docs"] = RequestHelpers.ParseEnumerable(docs),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.getById", null, request);
        }

        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetMessagesUploadServerApi(string type = null, int? peerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["peer_id"] = peerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("docs.getMessagesUploadServer", null, request);
        }

        /// <summary>
        /// Returns documents types available for current user.
        /// </summary>
        public Task<ApiRequest<DocsGetTypesResponse>> GetTypesApi(int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetTypesResponse>("docs.getTypes", null, request);
        }

        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetUploadServerApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("docs.getUploadServer", null, request);
        }

        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetWallUploadServerApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("docs.getWallUploadServer", null, request);
        }

        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        public Task<ApiRequest<DocsSaveResponse>> SaveApi(string file = null, string title = null, string tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["file"] = file,
                ["title"] = title,
                ["tags"] = tags,
            };

            return RequestManager.CreateRequestAsync<DocsSaveResponse>("docs.save", null, request);
        }

        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        public Task<ApiRequest<DocsSearchResponse>> SearchApi(string q = null, bool? searchOwn = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["search_own"] = RequestHelpers.ParseBoolean(searchOwn),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", null, request);
        }
    }
}
