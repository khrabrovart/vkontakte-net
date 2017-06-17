using Citrina.StandardApi.Core;
using Citrina.StandardApi.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Citrina.StandardApi.Uploaders
{
    internal class DocsUploader : IDocsUploader
    {
        private const int FileSizeMbLimit = 200;

        public Task<UploadResponse<DocsDocUploadResponse>> UploadDocAsync(DocsGetUploadServerResponse server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return HttpUploader.UploadAsync<DocsDocUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }

        private void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException($"File {file} does not exist.", nameof(file));
            }

            var info = new FileInfo(file);

            if (info.Length / 1024 / 1024 > FileSizeMbLimit)
            {
                throw new ArgumentException($"File {file} has invalid size.", nameof(file));
            }
        }
    }
}
