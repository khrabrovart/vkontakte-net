using System.Collections.Generic;

namespace Citrina.Uploader
{
    internal class FileCheckerOptions
    {
        public long FileSizeLimit { get; set; }
        public IEnumerable<string> Extensions { get; set; }
        public int MaxFilesCount { get; set; }
    }
}
