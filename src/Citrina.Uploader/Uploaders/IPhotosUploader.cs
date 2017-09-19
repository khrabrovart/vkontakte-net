using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IPhotosUploader
    {
        Task<UploadResponse<PhotosPhotoUploadResponse>> UploadAlbumPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files);
        Task<UploadResponse<PhotosWallUploadResponse>> UploadWallPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files);
        Task<UploadResponse<PhotosOwnerUploadResponse>> UploadOwnerPhotoAsync(PhotosPhotoUpload server, string file);
        Task<UploadResponse<PhotosMessageUploadResponse>> UploadMessagePhotoAsync(PhotosPhotoUpload server, string file);
        Task<UploadResponse<PhotosPhotoUploadResponse>> UploadChatPhotoAsync(PhotosGetChatUploadServerResponse server, string file);
        Task<UploadResponse<PhotosMarketUploadResponse>> UploadMarketPhotoAsync(PhotosGetMarketUploadServerResponse server, string file);
        Task<UploadResponse<PhotosMarketUploadResponse>> UploadMarketAlbumPhotoAsync(PhotosGetMarketAlbumUploadServerResponse server, string file);
    }
}
