using Citrina.StandardApi.Models;
using System.Threading.Tasks;

namespace Citrina.StandardApi.Uploaders
{
    public interface IVideoUploader
    {
        Task<UploadResponse<VideoUploadResponse>> UploadVideoAsync(VideoSaveResult server, string file);
    }
}
