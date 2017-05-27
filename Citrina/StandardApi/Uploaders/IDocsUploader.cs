using Citrina.StandardApi.Models;
using System.Threading.Tasks;

namespace Citrina.StandardApi.Uploaders
{
    public interface IDocsUploader
    {
        Task<UploadResponse<DocsDocUploadResponse>> UploadDocAsync(DocsGetUploadServerResponse server, string file);
    }
}
