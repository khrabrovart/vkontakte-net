using System.Threading.Tasks;

namespace Citrina.Uploader
{
    public interface IDocsUploader
    {
        Task<UploadRequest<DocsDocUploadResponse>> UploadDocAsync(DocsGetUploadServerResponse server, string file);
    }
}
