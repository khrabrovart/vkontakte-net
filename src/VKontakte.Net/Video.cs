using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class VideoSaveResult
    {
        public string Description { get; set; } 

        public int? OwnerId { get; set; } 

        public string Title { get; set; } 

        public string UploadUrl { get; set; } 

        public int? VideoId { get; set; } 
    }

    public class VideoVideo
    {
        public string AccessKey { get; set; } 

        public int? AddingDate { get; set; } 

        public bool? CanAdd { get; set; } 

        public bool? CanComment { get; set; } 

        public bool? CanEdit { get; set; } 

        public bool? CanLike { get; set; } 

        public bool? CanRepost { get; set; } 

        public int? Comments { get; set; } 

        public int? Date { get; set; } 

        public string Description { get; set; } 

        public int? Duration { get; set; } 

        public VideoVideoFiles Files { get; set; } 

        public string FirstFrame130 { get; set; } 

        public string FirstFrame160 { get; set; } 

        public string FirstFrame320 { get; set; } 

        public string FirstFrame800 { get; set; } 

        public int? Height { get; set; } 

        public int? Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        public BasePropertyExists Live { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo320 { get; set; } 

        public string Photo800 { get; set; } 

        public string Player { get; set; } 

        public BasePropertyExists Processing { get; set; } 

        public string Title { get; set; } 

        public string Type { get; set; } 

        public int? Views { get; set; } 

        public int? Width { get; set; } 
    }

    public class VideoVideoAlbumFull
    {
        public int? Count { get; set; } 

        public int? Id { get; set; } 

        public IEnumerable<object> Image { get; set; } 

        public int? IsSystem { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo160 { get; set; } 

        public string Photo320 { get; set; } 

        public object Privacy { get; set; } 

        public string Title { get; set; } 

        public int? UpdatedTime { get; set; } 
    }

    public class VideoVideoFiles
    {
        public string External { get; set; } 

        public string Mp1080 { get; set; } 

        public string Mp240 { get; set; } 

        public string Mp360 { get; set; } 

        public string Mp480 { get; set; } 

        public string Mp720 { get; set; } 
    }

    public class VideoVideoFull
    {
        public string AccessKey { get; set; } 

        public int? AddingDate { get; set; } 

        public bool? CanAdd { get; set; } 

        public bool? CanComment { get; set; } 

        public bool? CanEdit { get; set; } 

        public bool? CanRepost { get; set; } 

        public int? Comments { get; set; } 

        public int? Date { get; set; } 

        public string Description { get; set; } 

        public int? Duration { get; set; } 

        public VideoVideoFiles Files { get; set; } 

        public string FirstFrame130 { get; set; } 

        public string FirstFrame160 { get; set; } 

        public string FirstFrame320 { get; set; } 

        public string FirstFrame800 { get; set; } 

        public int? Id { get; set; } 

        public BaseLikes Likes { get; set; } 

        public BasePropertyExists Live { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo320 { get; set; } 

        public string Photo800 { get; set; } 

        public string Player { get; set; } 

        public IEnumerable<object> PrivacyComment { get; set; } 

        public IEnumerable<object> PrivacyView { get; set; } 

        public BasePropertyExists Processing { get; set; } 

        public bool? Repeat { get; set; } 

        public string Title { get; set; } 

        public int? Views { get; set; } 
    }

    public class VideoVideoImage
    {
    }
}
