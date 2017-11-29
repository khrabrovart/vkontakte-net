using System.Threading.Tasks;

namespace Citrina.Uploader
{
    internal class DocsUploader : IDocsUploader
    {
        private const long FileSizeLimit = 200 * 1024 * 1024;

        public Task<UploadRequest<DocsDocUploadResponse>> UploadDocAsync(DocsGetUploadServerResponse server, string file)
        {
            FileChecker.Check(file, new FileCheckerOptions
            {
                FileSizeLimit = FileSizeLimit 
            });

            return HttpUploader.UploadAsync<DocsDocUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }
    }
}
