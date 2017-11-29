using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IPhotosUploader
    {
        Task<UploadRequest<PhotosPhotoUploadResponse>> UploadAlbumPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files);
        Task<UploadRequest<PhotosWallUploadResponse>> UploadWallPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files);
        Task<UploadRequest<PhotosOwnerUploadResponse>> UploadOwnerPhotoAsync(PhotosGetOwnerPhotoUploadServerResponse server, string file);
        Task<UploadRequest<PhotosMessageUploadResponse>> UploadMessagePhotoAsync(PhotosPhotoUpload server, string file);
        Task<UploadRequest<PhotosPhotoUploadResponse>> UploadChatPhotoAsync(PhotosGetChatUploadServerResponse server, string file);
        Task<UploadRequest<PhotosMarketUploadResponse>> UploadMarketPhotoAsync(PhotosGetMarketUploadServerResponse server, string file);
        Task<UploadRequest<PhotosMarketUploadResponse>> UploadMarketAlbumPhotoAsync(PhotosGetMarketAlbumUploadServerResponse server, string file);
    }
}
