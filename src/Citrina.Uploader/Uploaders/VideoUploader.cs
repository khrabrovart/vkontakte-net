using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Uploader
{
    internal class VideoUploader : IVideoUploader
    {
        private readonly IEnumerable<string> Extensions = new[] { ".avi", ".mp4", ".3gp", ".mpeg", ".mov", ".mp3", ".flv", ".wmv" };

        public Task<UploadRequest<VideoUploadResponse>> UploadVideoAsync(VideoSaveResult server, string file)
        {
            FileChecker.Check(file, new FileCheckerOptions
            {
                Extensions = Extensions
            });

            return HttpUploader.UploadAsync<VideoUploadResponse>(server.UploadUrl, new[] { file }, "video_file");
        }
    }
}
