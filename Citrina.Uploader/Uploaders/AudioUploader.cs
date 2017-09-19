using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Citrina.StandardApi.Uploaders;

namespace Citrina.Uploader
{
    internal class AudioUploader : IAudioUploader
    {
        private readonly IEnumerable<string> Extensions = new[] { ".mp3" };

        /*public Task<UploadResponse<AudioAudioUploadResponse>> UploadAudioAsync(AudioGetUploadServerResponse server, string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException(nameof(file));
            }

            CheckFile(file);
            return HttpUploader.UploadAsync<AudioAudioUploadResponse>(server.UploadUrl, new[] { file }, "file");
        }*/

        private void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException($"File {file} does not exist.", nameof(file));
            }

            var info = new FileInfo(file);

            if (!Extensions.Contains(info.Extension))
            {
                throw new ArgumentException($"File {file} has invalid extension.", nameof(file));
            }
        }
    }
}
