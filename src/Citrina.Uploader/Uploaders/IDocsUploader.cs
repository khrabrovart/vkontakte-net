using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IDocsUploader
    {
        Task<UploadResponse<DocsDocUploadResponse>> UploadDocAsync(DocsGetUploadServerResponse server, string file);
    }
}
