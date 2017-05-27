using System.Collections.Generic;
using System.Threading.Tasks;
using Citrina.StandardApi.Core;
using Citrina.StandardApi.Models;
using System.Linq;
using System;
using System.IO;

namespace Citrina.StandardApi.Uploaders
{
    internal class PhotosUploader : IPhotosUploader
    {
        private const int AlbumPhotoFilesLimit = 5;
        private const int WallPhotoFilesLimit = 6;

        private const int FileSizeMbLimit = 50;

        private readonly IEnumerable<string> Extensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

        public async Task<UploadResponse<PhotosPhotoUploadResponse>> UploadAlbumPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files)
        {
            if (files == null)
            {
                throw new ArgumentNullException(nameof(files));
            }

            if (files.Count() > AlbumPhotoFilesLimit)
            {
                throw new ArgumentException($"Max files count is {AlbumPhotoFilesLimit}", nameof(files));
            }

            foreach (var file in files)
            {
                CheckFile(file);
            }

            return await HttpUploader.UploadAsync<PhotosPhotoUploadResponse>(server.UploadUrl, files, "file", true).ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosWallUploadResponse>> UploadWallPhotosAsync(PhotosPhotoUpload server, IEnumerable<string> files)
        {
            if (files == null)
            {
                throw new ArgumentNullException(nameof(files));
            }

            if (files.Count() > WallPhotoFilesLimit)
            {
                throw new ArgumentException($"Max files count is {WallPhotoFilesLimit}", nameof(files));
            }

            foreach (var file in files)
            {
                CheckFile(file);
            }

            return await HttpUploader.UploadAsync<PhotosWallUploadResponse>(server.UploadUrl, files, "photo").ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosOwnerUploadResponse>> UploadOwnerPhotoAsync(PhotosPhotoUpload server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return await HttpUploader.UploadAsync<PhotosOwnerUploadResponse>(server.UploadUrl, new[] { file }, "photo").ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosMessageUploadResponse>> UploadMessagePhotoAsync(PhotosPhotoUpload server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return await HttpUploader.UploadAsync<PhotosMessageUploadResponse>(server.UploadUrl, new[] { file }, "photo").ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosPhotoUploadResponse>> UploadChatPhotoAsync(PhotosGetChatUploadServerResponse server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return await HttpUploader.UploadAsync<PhotosPhotoUploadResponse>(server.UploadUrl, new[] { file }, "file").ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosMarketUploadResponse>> UploadMarketPhotoAsync(PhotosGetMarketUploadServerResponse server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return await HttpUploader.UploadAsync<PhotosMarketUploadResponse>(server.UploadUrl, new[] { file }, "file").ConfigureAwait(false);
        }

        public async Task<UploadResponse<PhotosMarketUploadResponse>> UploadMarketAlbumPhotoAsync(PhotosGetMarketAlbumUploadServerResponse server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return await HttpUploader.UploadAsync<PhotosMarketUploadResponse>(server.UploadUrl, new[] { file }, "file").ConfigureAwait(false);
        }

        private void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException($"File {file} does not exist.", nameof(file));
            }

            var info = new FileInfo(file);

            if (!Extensions.Contains(info.Extension))
            {
                throw new ArgumentException($"File {file} has invalid extension.", nameof(file));
            }

            if (info.Length / 1024 / 1024 > FileSizeMbLimit)
            {
                throw new ArgumentException($"File {file} has invalid size.", nameof(file));
            }
        }
    }
}
