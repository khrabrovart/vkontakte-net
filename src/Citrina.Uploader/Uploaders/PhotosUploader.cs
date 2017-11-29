using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Uploader
{
    internal class PhotosUploader : IPhotosUploader
    {
        private readonly FileCheckerOptions fileCheckerOptions = new FileCheckerOptions
        {
            Extensions = new[] { ".jpg", ".jpeg", ".png", ".gif" },
            FileSizeLimit = 50 * 1024 * 1024,
            MaxFilesCount = 5
        };
        
        public Task<UploadRequest<PhotosPhotoUploadResponse>> UploadAlbumPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files)
        {
            FileChecker.Check(files, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosPhotoUploadResponse>(server.UploadUrl, files, "file", true);
        }

        public Task<UploadRequest<PhotosWallUploadResponse>> UploadWallPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files)
        {
            FileChecker.Check(files, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosWallUploadResponse>(server.UploadUrl, files, "photo");
        }

        public Task<UploadRequest<PhotosOwnerUploadResponse>> UploadOwnerPhotoAsync(PhotosGetOwnerPhotoUploadServerResponse server, string file)
        {
            FileChecker.Check(file, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosOwnerUploadResponse>(server.UploadUrl, new[] { file }, "photo");
        }

        public Task<UploadRequest<PhotosMessageUploadResponse>> UploadMessagePhotoAsync(PhotosPhotoUpload server, string file)
        {
            FileChecker.Check(file, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosMessageUploadResponse>(server.UploadUrl, new[] { file }, "photo");
        }

        public Task<UploadRequest<PhotosPhotoUploadResponse>> UploadChatPhotoAsync(PhotosGetChatUploadServerResponse server, string file)
        {
            FileChecker.Check(file, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosPhotoUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }

        public Task<UploadRequest<PhotosMarketUploadResponse>> UploadMarketPhotoAsync(PhotosGetMarketUploadServerResponse server, string file)
        {
            FileChecker.Check(file, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosMarketUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }

        public Task<UploadRequest<PhotosMarketUploadResponse>> UploadMarketAlbumPhotoAsync(PhotosGetMarketAlbumUploadServerResponse server, string file)
        {
            FileChecker.Check(file, fileCheckerOptions);
            return HttpUploader.UploadAsync<PhotosMarketUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }
    }
}
