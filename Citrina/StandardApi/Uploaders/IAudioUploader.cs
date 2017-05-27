using Citrina.StandardApi.Models;
using System.Threading.Tasks;

namespace Citrina.StandardApi.Uploaders
{
    public interface IAudioUploader
    {
        Task<UploadResponse<AudioAudioUploadResponse>> UploadAudioAsync(AudioGetUploadServerResponse server, string file);
    }
}
