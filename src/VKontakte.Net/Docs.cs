using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class DocsDoc
    {
        public string AccessKey { get; set; } 

        public int? Date { get; set; } 

        public string Ext { get; set; } 

        public int? Id { get; set; } 

        public bool? IsLicensed { get; set; } 

        public int? OwnerId { get; set; } 

        public DocsDocPreview Preview { get; set; } 

        public int? Size { get; set; } 

        public string Title { get; set; } 

        public int? Type { get; set; } 

        public string Url { get; set; } 
    }

    public class DocsDocAttachmentType
    {
    }

    public class DocsDocPreview
    {
        public DocsDocPreviewPhoto Photo { get; set; } 

        public DocsDocPreviewVideo Video { get; set; } 
    }

    public class DocsDocPreviewPhoto
    {
        public IEnumerable<object> Sizes { get; set; } 
    }

    public class DocsDocPreviewVideo
    {
        public int? Filesize { get; set; } 

        public int? Height { get; set; } 

        public string Src { get; set; } 

        public int? Width { get; set; } 
    }

    public class DocsDocTypes
    {
        public int? Count { get; set; } 

        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class DocsDocUploadResponse
    {
        public string File { get; set; } 
    }
}
