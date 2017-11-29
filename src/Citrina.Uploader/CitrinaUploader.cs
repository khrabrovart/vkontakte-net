namespace Citrina.Uploader
{
    public class CitrinaUploader : ICitrinaUploader
    {
        public IPhotosUploader Photos { get; }
        public IVideoUploader Video { get; }
        public IDocsUploader Docs { get; }

        public CitrinaUploader()
        {
            Photos = new PhotosUploader();
            Video = new VideoUploader();
            Docs = new DocsUploader();
        }
    }
}
