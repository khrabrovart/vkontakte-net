using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IDocsApi
    {
        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// </summary>
        Task<ApiRequest<DocsAddResponse>> AddApi(int? ownerId = null, int? docId = null, string accessKey = null);

        /// <summary>
        /// Deletes a user or community document.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? docId = null);

        /// <summary>
        /// Edits a document.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null);

        /// <summary>
        /// Returns detailed information about user or community documents.
        /// </summary>
        Task<ApiRequest<DocsGetResponse>> GetApi(int? count = null, int? offset = null, int? type = null, int? ownerId = null);

        /// <summary>
        /// Returns information about documents by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> GetByIdApi(IEnumerable<string> docs = null);

        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetMessagesUploadServerApi(string type = null, int? peerId = null);

        /// <summary>
        /// Returns documents types available for current user.
        /// </summary>
        Task<ApiRequest<DocsGetTypesResponse>> GetTypesApi(int? ownerId = null);

        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetUploadServerApi(int? groupId = null);

        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetWallUploadServerApi(int? groupId = null);

        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        Task<ApiRequest<DocsSaveResponse>> SaveApi(string file = null, string title = null, string tags = null);

        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        Task<ApiRequest<DocsSearchResponse>> SearchApi(string q = null, bool? searchOwn = null, int? count = null, int? offset = null);
    }
}
