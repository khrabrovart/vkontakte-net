using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IVideoUploader
    {
        Task<UploadRequest<VideoUploadResponse>> UploadVideoAsync(VideoSaveResult server, string file);
    }
}
