using Citrina.StandardApi.Uploaders;

namespace Citrina.Uploader
{
    public interface ICitrinaFileUploader
    {
        IPhotosUploader Photos { get; }
        IAudioUploader Audio { get; }
        IVideoUploader Video { get; }
        IDocsUploader Docs { get; }
    }
}
