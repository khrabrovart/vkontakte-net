using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IDocsApi
    {
        /// <summary>
        /// Returns detailed information about user or community documents.
        /// </summary>
        Task<ApiRequest<DocsGetResponse>> Get(UserAccessToken accessToken, int? count = null, int? offset = null, int? ownerId = null);
        /// <summary>
        /// Returns information about documents by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> GetById(UserAccessToken accessToken, IEnumerable<string> docs = null);
        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        Task<ApiRequest<DocsGetUploadServerResponse>> GetUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(GroupAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> Save(UserAccessToken accessToken, string file = null, string title = null, string tags = null);
        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> Save(GroupAccessToken accessToken, string file = null, string title = null, string tags = null);
        /// <summary>
        /// Deletes a user or community document.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? docId = null);
        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// </summary>
        Task<ApiRequest<DocsAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string accessKey = null);
        /// <summary>
        /// Returns documents types available for current user.
        /// </summary>
        Task<ApiRequest<DocsGetTypesResponse>> GetTypes(UserAccessToken accessToken, int? ownerId = null);
        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        Task<ApiRequest<DocsSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        Task<ApiRequest<DocsSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? count = null, int? offset = null);
        /// <summary>
        /// Edits a document.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null);
    }
}
