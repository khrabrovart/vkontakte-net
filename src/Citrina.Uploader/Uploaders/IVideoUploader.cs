using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IVideoUploader
    {
        Task<UploadResponse<VideoUploadResponse>> UploadVideoAsync(VideoSaveResult server, string file);
    }
}
