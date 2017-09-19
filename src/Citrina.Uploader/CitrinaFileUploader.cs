using Citrina.StandardApi.Uploaders;
using Citrina.Uploaders;

namespace Citrina.Uploader
{
    internal class CitrinaFileUploader : ICitrinaFileUploader
    {
        public IPhotosUploader Photos { get; }
        public IAudioUploader Audio { get; set; }
        public IVideoUploader Video { get; set; }
        public IDocsUploader Docs { get; set; }

        public CitrinaFileUploader()
        {
            Photos = new PhotosUploader();
            Audio = new AudioUploader();
            Video = new VideoUploader();
            Docs = new DocsUploader();
        }
    }
}
