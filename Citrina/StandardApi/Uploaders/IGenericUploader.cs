namespace Citrina.StandardApi.Uploaders
{
    public interface IGenericUploader
    {
        IPhotosUploader Photos { get; }
        IAudioUploader Audio { get; }
        IVideoUploader Video { get; }
        IDocsUploader Docs { get; }
    }
}
