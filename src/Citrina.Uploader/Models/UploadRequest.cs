namespace Citrina.Uploader
{
    public class UploadRequest<T>
    {
        public T Response { get; set; }
        public string Error { get; set; }
        public bool IsError { get; set; }
    }
}