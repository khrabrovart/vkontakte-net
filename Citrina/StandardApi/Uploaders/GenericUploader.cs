namespace Citrina.StandardApi.Uploaders
{
    internal class GenericUploader : IGenericUploader
    {
        public IPhotosUploader Photos { get; }
        public IAudioUploader Audio { get; set; }
        public IVideoUploader Video { get; set; }
        public IDocsUploader Docs { get; set; }

        public GenericUploader()
        {
            Photos = new PhotosUploader();
            Audio = new AudioUploader();
            Video = new VideoUploader();
            Docs = new DocsUploader();
        }
    }
}
