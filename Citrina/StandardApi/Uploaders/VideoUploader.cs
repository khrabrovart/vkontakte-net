using Citrina.StandardApi.Core;
using Citrina.StandardApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Citrina.StandardApi.Uploaders
{
    internal class VideoUploader : IVideoUploader
    {
        private readonly IEnumerable<string> Extensions = new[] { ".avi", ".mp4", ".3gp", ".mpeg", ".mov", ".mp3", ".flv", ".wmv" };

        public Task<UploadResponse<VideoUploadResponse>> UploadVideoAsync(VideoSaveResult server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return HttpUploader.UploadAsync<VideoUploadResponse>(server.UploadUrl, new[] { file }, "video_file");
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
        }
    }
}
