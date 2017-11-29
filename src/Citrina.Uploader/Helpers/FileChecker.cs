using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Citrina.Uploader
{
    internal static class FileChecker
    {
        public static void Check(string filepath, FileCheckerOptions options = null)
        {
            if (string.IsNullOrWhiteSpace(filepath))
            {
                throw new ArgumentNullException(nameof(filepath));
            }

            if (!File.Exists(filepath))
            {
                throw new ArgumentException($"File {filepath} does not exist.", nameof(filepath));
            }

            if (options != null)
            {
                var info = new FileInfo(filepath);

                if (options.Extensions != null && options.Extensions.Any() && !options.Extensions.Contains(info.Extension))
                { 
                    throw new ArgumentException($"File {filepath} has invalid extension.", nameof(filepath));
                }

                if (options.FileSizeLimit > 0 && info.Length > options.FileSizeLimit)
                { 
                    throw new ArgumentException($"File {filepath} has invalid size.", nameof(filepath));
                }
            }
        }

        public static void Check(IEnumerable<string> filepaths, FileCheckerOptions options = null)
        {
            if (options != null && options.MaxFilesCount > 0 && filepaths.Count() > options.MaxFilesCount)
            {
                throw new ArgumentException($"Max files count is {options.MaxFilesCount}.", nameof(filepaths));
            }

            foreach (var path in filepaths)
            {
                Check(path, options);
            }
        }
    }
}
