using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class BaseBoolInt
    {
    }

    public class BaseCommentsInfo
    {
        public bool? CanPost { get; set; } 

        public int? Count { get; set; } 

        public bool? GroupsCanPost { get; set; } 
    }

    public class BaseCountry
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class BaseError
    {
        public int? ErrorCode { get; set; } 

        public string ErrorMsg { get; set; } 

        public IEnumerable<object> RequestParams { get; set; } 
    }

    public class BaseGeo
    {
        public BaseGeoCoordinates Coordinates { get; set; } 

        public BasePlace Place { get; set; } 

        public int? Showmap { get; set; } 

        public string Type { get; set; } 
    }

    public class BaseGeoCoordinates
    {
        public double? Latitude { get; set; } 

        public double? Longitude { get; set; } 
    }

    public class BaseImage
    {
        public int? Height { get; set; } 

        public string Url { get; set; } 

        public int? Width { get; set; } 
    }

    public class BaseLikes
    {
        public int? Count { get; set; } 

        public bool? UserLikes { get; set; } 
    }

    public class BaseLikesInfo
    {
        public bool? CanLike { get; set; } 

        public bool? CanPublish { get; set; } 

        public int? Count { get; set; } 

        public int? UserLikes { get; set; } 
    }

    public class BaseLink
    {
        public BaseLinkApplication Application { get; set; } 

        public BaseLinkButton Button { get; set; } 

        public string Caption { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public string PreviewPage { get; set; } 

        public string PreviewUrl { get; set; } 

        public BaseLinkProduct Product { get; set; } 

        public BaseLinkRating Rating { get; set; } 

        public string Title { get; set; } 

        public string Url { get; set; } 
    }

    public class BaseLinkApplication
    {
        public double? AppId { get; set; } 

        public BaseLinkApplicationStore Store { get; set; } 
    }

    public class BaseLinkApplicationStore
    {
        public double? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class BaseLinkButton
    {
        public BaseLinkButtonAction Action { get; set; } 

        public string Title { get; set; } 
    }

    public class BaseLinkButtonAction
    {
        public BaseLinkButtonActionType Type { get; set; } 

        public string Url { get; set; } 
    }

    public class BaseLinkButtonActionType
    {
    }

    public class BaseLinkProduct
    {
        public MarketPrice Price { get; set; } 
    }

    public class BaseLinkRating
    {
        public int? ReviewsCount { get; set; } 

        public double? Stars { get; set; } 
    }

    public class BaseMessageError
    {
        public int? Code { get; set; } 

        public string Description { get; set; } 
    }

    public class BaseObject
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class BaseObjectCount
    {
        public int? Count { get; set; } 
    }

    public class BaseObjectWithName
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class BaseOkResponse
    {
    }

    public class BasePlace
    {
        public string Address { get; set; } 

        public int? Checkins { get; set; } 

        public string City { get; set; } 

        public string Country { get; set; } 

        public int? Created { get; set; } 

        public string Icon { get; set; } 

        public int? Id { get; set; } 

        public double? Latitude { get; set; } 

        public double? Longitude { get; set; } 

        public string Title { get; set; } 

        public string Type { get; set; } 
    }

    public class BasePropertyExists
    {
    }

    public class BaseRepostsInfo
    {
        public int? Count { get; set; } 

        public int? UserReposted { get; set; } 
    }

    public class BaseRequestParam
    {
        public string Key { get; set; } 

        public string Value { get; set; } 
    }

    public class BaseSex
    {
    }

    public class BaseSticker
    {
        public IEnumerable<object> Images { get; set; } 

        public IEnumerable<object> ImagesWithBackground { get; set; } 

        public int? ProductId { get; set; } 

        public int? StickerId { get; set; } 
    }

    public class BaseUploadServer
    {
        public string UploadUrl { get; set; } 
    }

    public class BaseUserGroupFields
    {
    }

    public class BaseUserId
    {
        public int? UserId { get; set; } 
    }
}
