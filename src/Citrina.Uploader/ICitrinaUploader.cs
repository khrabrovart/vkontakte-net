namespace Citrina.Uploader
{
    public interface ICitrinaUploader
    {
        IPhotosUploader Photos { get; }
        IVideoUploader Video { get; }
        IDocsUploader Docs { get; }
    }
}
