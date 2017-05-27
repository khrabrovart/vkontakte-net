namespace Citrina.StandardApi.Models
{
    public class UploadResponse<T>
    {
        public T Data { get; set; }
        public string Error { get; set; }
        public bool IsError { get; set; }
    }
}