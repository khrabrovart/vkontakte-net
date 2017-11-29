using Citrina.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Citrina.Uploader
{
    internal static class HttpUploader
    {
        public static async Task<UploadRequest<T>> UploadAsync<T>(string url, IEnumerable<string> files, string contentFieldName, bool incrementalFieldName = false)
        {
            var uploadingFiles = await GetFilesContentAsync(files).ConfigureAwait(false);

            if (uploadingFiles == null)
            {
                return new UploadRequest<T>
                {
                    IsError = true,
                    Error = "No content found."
                };
            }

            using (var client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent("---------------CitrinaBoundary"))
                {
                    for (int i = 0; i < uploadingFiles.Length; i++)
                    {
                        var fileContent = new ByteArrayContent(uploadingFiles[i].Content);
                        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("file")
                        {
                            FileName = uploadingFiles[i].Name,
                            Name = incrementalFieldName ? $"{contentFieldName}{i + 1}" : $"{contentFieldName}"
                        };

                        content.Add(fileContent);
                    }

                    using (var response = await client.PostAsync(url, content).ConfigureAwait(false))
                    {
#if (!NET45)
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif
                        var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                        try
                        {
                            return new UploadRequest<T>
                            {
                                Response = CitrinaJsonConverter.Deserialize<T>(data)
                            };
                        }
                        catch (Exception e)
                        {
                            return new UploadRequest<T>
                            {
                                IsError = true,
                                Error = $"Error occured while uploading files: Type={e.GetType()}, Message={e.Message}"
                            };
                        }
                    }
                }
            }
        }

        private static async Task<UploadingFile[]> GetFilesContentAsync(IEnumerable<string> files)
        {
            var filesContentTasks = files.Where(File.Exists).Select(async file =>
            {
                using (var fs = new FileStream(file, FileMode.Open))
                {
                    var buff = new byte[fs.Length];
                    await fs.ReadAsync(buff, 0, (int)fs.Length).ConfigureAwait(false);
                    return new UploadingFile {
                        Name = Path.GetFileName(file),
                        Content = buff
                    };
                }
            });

            return await Task.WhenAll(filesContentTasks).ConfigureAwait(false);
        }
    }
}
