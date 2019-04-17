using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class PhotosCommentXtrPid
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? Pid { get; set; } 

        public int? ReplyToComment { get; set; } 

        public int? ReplyToUser { get; set; } 

        public string Text { get; set; } 
    }

    public class PhotosImage
    {
        public int? Height { get; set; } 

        public PhotosImageType Type { get; set; } 

        public string Url { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosImageType
    {
    }

    public class PhotosMarketAlbumUploadResponse
    {
        public int? Gid { get; set; } 

        public string Hash { get; set; } 

        public string Photo { get; set; } 

        public int? Server { get; set; } 
    }

    public class PhotosMarketUploadResponse
    {
        public string CropData { get; set; } 

        public string CropHash { get; set; } 

        public int? GroupId { get; set; } 

        public string Hash { get; set; } 

        public string Photo { get; set; } 

        public int? Server { get; set; } 
    }

    public class PhotosMessageUploadResponse
    {
        public string Hash { get; set; } 

        public string Photo { get; set; } 

        public int? Server { get; set; } 
    }

    public class PhotosOwnerUploadResponse
    {
        public string Hash { get; set; } 

        public string Photo { get; set; } 

        public int? Server { get; set; } 
    }

    public class PhotosPhoto
    {
        public string AccessKey { get; set; } 

        public int? AlbumId { get; set; } 

        public int? Date { get; set; } 

        public int? Height { get; set; } 

        public int? Id { get; set; } 

        public IEnumerable<object> Images { get; set; } 

        public double? Lat { get; set; } 

        public double? Long { get; set; } 

        public int? OwnerId { get; set; } 

        public int? PostId { get; set; } 

        public string Text { get; set; } 

        public int? UserId { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosPhotoAlbum
    {
        public int? Created { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public int? Size { get; set; } 

        public PhotosPhoto Thumb { get; set; } 

        public string Title { get; set; } 

        public int? Updated { get; set; } 
    }

    public class PhotosPhotoAlbumFull
    {
        public bool? CanUpload { get; set; } 

        public bool? CommentsDisabled { get; set; } 

        public int? Created { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public IEnumerable<object> PrivacyComment { get; set; } 

        public IEnumerable<object> PrivacyView { get; set; } 

        public int? Size { get; set; } 

        public IEnumerable<object> Sizes { get; set; } 

        public int? ThumbId { get; set; } 

        public bool? ThumbIsLast { get; set; } 

        public string ThumbSrc { get; set; } 

        public string Title { get; set; } 

        public int? Updated { get; set; } 

        public bool? UploadByAdminsOnly { get; set; } 
    }

    public class PhotosPhotoFull
    {
        public string AccessKey { get; set; } 

        public int? AlbumId { get; set; } 

        public bool? CanComment { get; set; } 

        public BaseObjectCount Comments { get; set; } 

        public int? Date { get; set; } 

        public int? Height { get; set; } 

        public int? Id { get; set; } 

        public IEnumerable<object> Images { get; set; } 

        public double? Lat { get; set; } 

        public BaseLikes Likes { get; set; } 

        public double? Long { get; set; } 

        public int? OwnerId { get; set; } 

        public int? PostId { get; set; } 

        public BaseObjectCount Reposts { get; set; } 

        public BaseObjectCount Tags { get; set; } 

        public string Text { get; set; } 

        public int? UserId { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosPhotoFullXtrRealOffset
    {
        public string AccessKey { get; set; } 

        public int? AlbumId { get; set; } 

        public bool? CanComment { get; set; } 

        public BaseObjectCount Comments { get; set; } 

        public int? Date { get; set; } 

        public int? Height { get; set; } 

        public BasePropertyExists Hidden { get; set; } 

        public int? Id { get; set; } 

        public double? Lat { get; set; } 

        public BaseLikes Likes { get; set; } 

        public double? Long { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo1280 { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo2560 { get; set; } 

        public string Photo604 { get; set; } 

        public string Photo75 { get; set; } 

        public string Photo807 { get; set; } 

        public int? PostId { get; set; } 

        public int? RealOffset { get; set; } 

        public BaseObjectCount Reposts { get; set; } 

        public IEnumerable<object> Sizes { get; set; } 

        public BaseObjectCount Tags { get; set; } 

        public string Text { get; set; } 

        public int? UserId { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosPhotoSizes
    {
        public int? Height { get; set; } 

        public string Src { get; set; } 

        public PhotosPhotoSizesType Type { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosPhotoSizesType
    {
    }

    public class PhotosPhotoTag
    {
        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? PlacerId { get; set; } 

        public string TaggedName { get; set; } 

        public int? UserId { get; set; } 

        public bool? Viewed { get; set; } 

        public double? X { get; set; } 

        public double? X2 { get; set; } 

        public double? Y { get; set; } 

        public double? Y2 { get; set; } 
    }

    public class PhotosPhotoUpload
    {
        public int? AlbumId { get; set; } 

        public string UploadUrl { get; set; } 

        public int? UserId { get; set; } 
    }

    public class PhotosPhotoUploadResponse
    {
        public int? Aid { get; set; } 

        public string Hash { get; set; } 

        public string PhotosList { get; set; } 

        public int? Server { get; set; } 
    }

    public class PhotosPhotoXtrRealOffset
    {
        public string AccessKey { get; set; } 

        public int? AlbumId { get; set; } 

        public int? Date { get; set; } 

        public int? Height { get; set; } 

        public BasePropertyExists Hidden { get; set; } 

        public int? Id { get; set; } 

        public double? Lat { get; set; } 

        public double? Long { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo1280 { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo2560 { get; set; } 

        public string Photo604 { get; set; } 

        public string Photo75 { get; set; } 

        public string Photo807 { get; set; } 

        public int? PostId { get; set; } 

        public int? RealOffset { get; set; } 

        public IEnumerable<object> Sizes { get; set; } 

        public string Text { get; set; } 

        public int? UserId { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosPhotoXtrTagInfo
    {
        public string AccessKey { get; set; } 

        public int? AlbumId { get; set; } 

        public int? Date { get; set; } 

        public int? Height { get; set; } 

        public int? Id { get; set; } 

        public double? Lat { get; set; } 

        public double? Long { get; set; } 

        public int? OwnerId { get; set; } 

        public string Photo1280 { get; set; } 

        public string Photo130 { get; set; } 

        public string Photo2560 { get; set; } 

        public string Photo604 { get; set; } 

        public string Photo75 { get; set; } 

        public string Photo807 { get; set; } 

        public int? PlacerId { get; set; } 

        public int? PostId { get; set; } 

        public IEnumerable<object> Sizes { get; set; } 

        public int? TagCreated { get; set; } 

        public int? TagId { get; set; } 

        public string Text { get; set; } 

        public int? UserId { get; set; } 

        public int? Width { get; set; } 
    }

    public class PhotosWallUploadResponse
    {
        public string Hash { get; set; } 

        public string Photo { get; set; } 

        public int? Server { get; set; } 
    }
}
