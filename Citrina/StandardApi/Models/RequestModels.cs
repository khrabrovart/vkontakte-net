using System.Collections.Generic;
using System;

namespace Citrina.StandardApi.Models
{
    public class UsersGetRequest : RequestModelBase
    {
        public IEnumerable<string> UserIds { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class UsersSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? Sort { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public int? City { get; set; }
        public int? Country { get; set; }
        public string Hometown { get; set; }
        public int? UniversityCountry { get; set; }
        public int? University { get; set; }
        public int? UniversityYear { get; set; }
        public int? UniversityFaculty { get; set; }
        public int? UniversityChair { get; set; }
        public int? Sex { get; set; }
        public int? Status { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? BirthDay { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthYear { get; set; }
        public bool? Online { get; set; }
        public bool? HasPhoto { get; set; }
        public int? SchoolCountry { get; set; }
        public int? SchoolCity { get; set; }
        public int? SchoolClass { get; set; }
        public int? School { get; set; }
        public int? SchoolYear { get; set; }
        public string Religion { get; set; }
        public string Interests { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public int? GroupId { get; set; }
        public IEnumerable<string> FromList { get; set; }
    }

    public class UsersIsAppUserRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class UsersGetSubscriptionsRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public bool? Extended { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class UsersGetFollowersRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class UsersReportRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }

    public class UsersGetNearbyRequest : RequestModelBase
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Accuracy { get; set; }
        public int? Timeout { get; set; }
        public int? Radius { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class AuthCheckPhoneRequest : RequestModelBase
    {
        public string Phone { get; set; }
        public int? ClientId { get; set; }
        public string ClientSecret { get; set; }
        public bool? AuthByPhone { get; set; }
    }

    public class AuthSignupRequest : RequestModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool? TestMode { get; set; }
        public bool? Voice { get; set; }
        public int? Sex { get; set; }
        public string Sid { get; set; }
    }

    public class AuthConfirmRequest : RequestModelBase
    {
        public int? ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
        public bool? TestMode { get; set; }
        public int? Intro { get; set; }
    }

    public class AuthRestoreRequest : RequestModelBase
    {
        public string Phone { get; set; }
    }

    public class WallGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string Domain { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string Filter { get; set; }
        public bool? Extended { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class WallSearchRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string Domain { get; set; }
        public string Query { get; set; }
        public bool? OwnersOnly { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public bool? Extended { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class PhotosCreateAlbumRequest : RequestModelBase
    {
        public string Title { get; set; }
        public int? GroupId { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? UploadByAdminsOnly { get; set; }
        public bool? CommentsDisabled { get; set; }
    }

    public class PhotosEditAlbumRequest : RequestModelBase
    {
        public int? AlbumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? OwnerId { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? UploadByAdminsOnly { get; set; }
        public bool? CommentsDisabled { get; set; }
    }

    public class PhotosGetAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? NeedSystem { get; set; }
        public bool? NeedCovers { get; set; }
        public bool? PhotoSizes { get; set; }
    }

    public class PhotosGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string AlbumId { get; set; }
        public IEnumerable<string> PhotoIds { get; set; }
        public bool? Rev { get; set; }
        public bool? Extended { get; set; }
        public string FeedType { get; set; }
        public DateTime? Feed { get; set; }
        public bool? PhotoSizes { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class PhotosGetAlbumsCountRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
    }

    public class PhotosGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> Photos { get; set; }
        public bool? Extended { get; set; }
        public bool? PhotoSizes { get; set; }
    }

    public class PhotosGetUploadServerRequest : RequestModelBase
    {
        public int? AlbumId { get; set; }
        public int? GroupId { get; set; }
    }

    public class PhotosGetOwnerPhotoUploadServerRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
    }

    public class PhotosGetChatUploadServerRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public int? CropX { get; set; }
        public int? CropY { get; set; }
        public int? CropWidth { get; set; }
    }

    public class PhotosGetMarketUploadServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public bool? MainPhoto { get; set; }
        public int? CropX { get; set; }
        public int? CropY { get; set; }
        public int? CropWidth { get; set; }
    }

    public class PhotosGetMarketAlbumUploadServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class PhotosSaveMarketPhotoRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Photo { get; set; }
        public int? Server { get; set; }
        public string Hash { get; set; }
        public string CropData { get; set; }
        public string CropHash { get; set; }
    }

    public class PhotosSaveMarketAlbumPhotoRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Photo { get; set; }
        public int? Server { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosSaveOwnerPhotoRequest : RequestModelBase
    {
        public string Server { get; set; }
        public string Hash { get; set; }
        public string Photo { get; set; }
    }

    public class PhotosSaveWallPhotoRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public string Photo { get; set; }
        public int? Server { get; set; }
        public string Hash { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Caption { get; set; }
    }

    public class PhotosGetWallUploadServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class PhotosGetMessagesUploadServerRequest : RequestModelBase
    {
    }

    public class PhotosSaveMessagesPhotoRequest : RequestModelBase
    {
        public string Photo { get; set; }
        public int? Server { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosReportRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public int? Reason { get; set; }
    }

    public class PhotosReportCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public int? Reason { get; set; }
    }

    public class PhotosSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Sort { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public int? Radius { get; set; }
    }

    public class FriendsGetRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Order { get; set; }
        public int? ListId { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class FriendsGetOnlineRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? ListId { get; set; }
        public bool? OnlineMobile { get; set; }
        public string Order { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
    }

    public class FriendsGetMutualRequest : RequestModelBase
    {
        public int? SourceUid { get; set; }
        public int? TargetUid { get; set; }
        public IEnumerable<int> TargetUids { get; set; }
        public string Order { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
    }

    public class FriendsGetRecentRequest : RequestModelBase
    {
        public int? Count { get; set; }
    }

    public class FriendsGetRequestsRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
        public bool? NeedMutual { get; set; }
        public bool? Out { get; set; }
        public int? Sort { get; set; }
        public bool? Suggested { get; set; }
    }

    public class FriendsAddRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Text { get; set; }
        public bool? Follow { get; set; }
    }

    public class FriendsEditRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public IEnumerable<int> ListIds { get; set; }
    }

    public class FriendsDeleteRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class FriendsGetListsRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public bool? ReturnSystem { get; set; }
    }

    public class FriendsAddListRequest : RequestModelBase
    {
        public string Name { get; set; }
        public IEnumerable<int> UserIds { get; set; }
    }

    public class FriendsEditListRequest : RequestModelBase
    {
        public string Name { get; set; }
        public int? ListId { get; set; }
        public IEnumerable<int> UserIds { get; set; }
        public IEnumerable<int> AddUserIds { get; set; }
        public IEnumerable<int> DeleteUserIds { get; set; }
    }

    public class FriendsDeleteListRequest : RequestModelBase
    {
        public int? ListId { get; set; }
    }

    public class FriendsGetAppUsersRequest : RequestModelBase
    {
    }

    public class FriendsGetByPhonesRequest : RequestModelBase
    {
        public IEnumerable<string> Phones { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class FriendsDeleteAllRequestsRequest : RequestModelBase
    {
    }

    public class FriendsGetSuggestionsRequest : RequestModelBase
    {
        public IEnumerable<string> Filter { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class FriendsAreFriendsRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
        public bool? NeedSign { get; set; }
    }

    public class FriendsGetAvailableForCallRequest : RequestModelBase
    {
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class FriendsSearchRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Q { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class WidgetsGetCommentsRequest : RequestModelBase
    {
        public int? WidgetApiId { get; set; }
        public string Url { get; set; }
        public string PageId { get; set; }
        public string Order { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public int? Count { get; set; }
    }

    public class WidgetsGetPagesRequest : RequestModelBase
    {
        public int? WidgetApiId { get; set; }
        public string Order { get; set; }
        public string Period { get; set; }
        public int? Count { get; set; }
    }

    public class SecureGetAppBalanceRequest : RequestModelBase
    {
    }

    public class SecureGetTransactionsHistoryRequest : RequestModelBase
    {
    }

    public class SecureGetSMSHistoryRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Limit { get; set; }
    }

    public class SecureSendSMSNotificationRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Message { get; set; }
    }

    public class SecureSendNotificationRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
    }

    public class SecureSetCounterRequest : RequestModelBase
    {
        public IEnumerable<string> Counters { get; set; }
        public int? UserId { get; set; }
        public int? Counter { get; set; }
    }

    public class SecureSetUserLevelRequest : RequestModelBase
    {
        public IEnumerable<string> Levels { get; set; }
        public int? UserId { get; set; }
        public int? Level { get; set; }
    }

    public class SecureGetUserLevelRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
    }

    public class StorageGetRequest : RequestModelBase
    {
        public string Key { get; set; }
        public IEnumerable<string> Keys { get; set; }
        public int? UserId { get; set; }
    }

    public class StorageSetRequest : RequestModelBase
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int? UserId { get; set; }
    }

    public class StorageGetKeysRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? Count { get; set; }
    }

    public class OrdersGetRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public bool? TestMode { get; set; }
    }

    public class OrdersGetByIdRequest : RequestModelBase
    {
        public int? OrderId { get; set; }
        public IEnumerable<int> OrderIds { get; set; }
        public bool? TestMode { get; set; }
    }

    public class OrdersChangeStateRequest : RequestModelBase
    {
        public int? OrderId { get; set; }
        public string Action { get; set; }
        public int? AppOrderId { get; set; }
        public bool? TestMode { get; set; }
    }

    public class OrdersGetAmountRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public IEnumerable<string> Votes { get; set; }
    }

    public class PhotosSaveRequest : RequestModelBase
    {
        public int? AlbumId { get; set; }
        public int? GroupId { get; set; }
        public int? Server { get; set; }
        public string PhotosList { get; set; }
        public string Hash { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Caption { get; set; }
    }

    public class PhotosCopyRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public string AccessKey { get; set; }
    }

    public class PhotosEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public string Caption { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string PlaceStr { get; set; }
        public string FoursquareId { get; set; }
        public bool? DeletePlace { get; set; }
    }

    public class PhotosMoveRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? TargetAlbumId { get; set; }
        public int? PhotoId { get; set; }
    }

    public class PhotosMakeCoverRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class PhotosReorderAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class PhotosReorderPhotosRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class PhotosGetAllRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public bool? Extended { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? PhotoSizes { get; set; }
        public bool? NoServiceAlbums { get; set; }
        public bool? NeedHidden { get; set; }
        public bool? SkipHidden { get; set; }
    }

    public class PhotosGetUserPhotosRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
        public string Sort { get; set; }
    }

    public class PhotosDeleteAlbumRequest : RequestModelBase
    {
        public int? AlbumId { get; set; }
        public int? GroupId { get; set; }
    }

    public class PhotosDeleteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
    }

    public class PhotosRestoreRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
    }

    public class PhotosConfirmTagRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string PhotoId { get; set; }
        public int? TagId { get; set; }
    }

    public class PhotosGetCommentsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? StartCommentId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string Sort { get; set; }
        public string AccessKey { get; set; }
        public bool? Extended { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class PhotosGetAllCommentsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class PhotosCreateCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public bool? FromGroup { get; set; }
        public int? ReplyToComment { get; set; }
        public int? StickerId { get; set; }
        public string AccessKey { get; set; }
        public string Guid { get; set; }
    }

    public class PhotosDeleteCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class PhotosRestoreCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class PhotosEditCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class PhotosGetTagsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public string AccessKey { get; set; }
    }

    public class PhotosPutTagRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public int? UserId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? X2 { get; set; }
        public double? Y2 { get; set; }
    }

    public class PhotosRemoveTagRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PhotoId { get; set; }
        public int? TagId { get; set; }
    }

    public class PhotosGetNewTagsRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class WallGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> Posts { get; set; }
        public bool? Extended { get; set; }
        public int? CopyHistoryDepth { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class WallPostRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public bool? FriendsOnly { get; set; }
        public bool? FromGroup { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public string Services { get; set; }
        public bool? Signed { get; set; }
        public DateTime? PublishDate { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public int? PlaceId { get; set; }
        public int? PostId { get; set; }
        public string Guid { get; set; }
        public bool? MarkAsAds { get; set; }
    }

    public class WallRepostRequest : RequestModelBase
    {
        public string Object { get; set; }
        public string Message { get; set; }
        public int? GroupId { get; set; }
        public bool? MarkAsAds { get; set; }
    }

    public class WallGetRepostsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class WallEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
        public bool? FriendsOnly { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public string Services { get; set; }
        public bool? Signed { get; set; }
        public DateTime? PublishDate { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public int? PlaceId { get; set; }
        public bool? MarkAsAds { get; set; }
    }

    public class WallDeleteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
    }

    public class WallRestoreRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
    }

    public class WallPinRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
    }

    public class WallUnpinRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
    }

    public class WallGetCommentsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? StartCommentId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string Sort { get; set; }
        public int? PreviewLength { get; set; }
        public bool? Extended { get; set; }
    }

    public class WallCreateCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
        public bool? FromGroup { get; set; }
        public string Message { get; set; }
        public int? ReplyToComment { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public int? StickerId { get; set; }
        public string Guid { get; set; }
    }

    public class WallEditCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class WallDeleteCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class WallRestoreCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class WallReportPostRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
        public int? Reason { get; set; }
    }

    public class WallReportCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public int? Reason { get; set; }
    }

    public class StatusGetRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
    }

    public class StatusSetRequest : RequestModelBase
    {
        public string Text { get; set; }
        public int? GroupId { get; set; }
    }

    public class AudioGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public IEnumerable<int> AudioIds { get; set; }
        public bool? NeedUser { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class AudioGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> Audios { get; set; }
    }

    public class AudioGetLyricsRequest : RequestModelBase
    {
        public int? LyricsId { get; set; }
    }

    public class AudioSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public bool? AutoComplete { get; set; }
        public bool? Lyrics { get; set; }
        public bool? PerformerOnly { get; set; }
        public int? Sort { get; set; }
        public bool? SearchOwn { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class AudioGetUploadServerRequest : RequestModelBase
    {
    }

    public class AudioSaveRequest : RequestModelBase
    {
        public int? Server { get; set; }
        public string Audio { get; set; }
        public string Hash { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }

    public class AudioAddRequest : RequestModelBase
    {
        public int? AudioId { get; set; }
        public int? OwnerId { get; set; }
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class AudioDeleteRequest : RequestModelBase
    {
        public int? AudioId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class AudioEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AudioId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int? GenreId { get; set; }
        public bool? NoSearch { get; set; }
    }

    public class AudioReorderRequest : RequestModelBase
    {
        public int? AudioId { get; set; }
        public int? OwnerId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class AudioRestoreRequest : RequestModelBase
    {
        public int? AudioId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class AudioGetAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class AudioAddAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
    }

    public class AudioEditAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
        public string Title { get; set; }
    }

    public class AudioDeleteAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class AudioMoveToAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
        public IEnumerable<int> AudioIds { get; set; }
    }

    public class AudioSetBroadcastRequest : RequestModelBase
    {
        public string Audio { get; set; }
        public IEnumerable<int> TargetIds { get; set; }
    }

    public class AudioGetBroadcastListRequest : RequestModelBase
    {
        public string Filter { get; set; }
        public bool? Active { get; set; }
    }

    public class AudioGetRecommendationsRequest : RequestModelBase
    {
        public string TargetAudio { get; set; }
        public int? UserId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Shuffle { get; set; }
    }

    public class AudioGetPopularRequest : RequestModelBase
    {
        public bool? OnlyEng { get; set; }
        public int? GenreId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class AudioGetCountRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
    }

    public class LeadsCompleteRequest : RequestModelBase
    {
        public string VkSid { get; set; }
        public string Secret { get; set; }
        public string Comment { get; set; }
    }

    public class LeadsStartRequest : RequestModelBase
    {
        public int? LeadId { get; set; }
        public string Secret { get; set; }
    }

    public class LeadsGetStatsRequest : RequestModelBase
    {
        public int? LeadId { get; set; }
        public string Secret { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
    }

    public class LeadsGetUsersRequest : RequestModelBase
    {
        public int? OfferId { get; set; }
        public string Secret { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public int? Status { get; set; }
        public bool? Reverse { get; set; }
    }

    public class LeadsCheckUserRequest : RequestModelBase
    {
        public int? LeadId { get; set; }
        public int? TestResult { get; set; }
        public int? Age { get; set; }
        public string Country { get; set; }
    }

    public class LeadsMetricHitRequest : RequestModelBase
    {
        public string Data { get; set; }
    }

    public class PagesGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PageId { get; set; }
        public bool? Global { get; set; }
        public bool? SitePreview { get; set; }
        public string Title { get; set; }
        public bool? NeedSource { get; set; }
        public bool? NeedHtml { get; set; }
    }

    public class PagesSaveRequest : RequestModelBase
    {
        public string Text { get; set; }
        public int? PageId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
    }

    public class PagesSaveAccessRequest : RequestModelBase
    {
        public int? PageId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public int? View { get; set; }
        public int? Edit { get; set; }
    }

    public class PagesGetHistoryRequest : RequestModelBase
    {
        public int? PageId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class PagesGetTitlesRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class PagesGetVersionRequest : RequestModelBase
    {
        public int? VersionId { get; set; }
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public bool? NeedHtml { get; set; }
    }

    public class PagesParseWikiRequest : RequestModelBase
    {
        public string Text { get; set; }
        public int? GroupId { get; set; }
    }

    public class PagesClearCacheRequest : RequestModelBase
    {
        public string Url { get; set; }
    }

    public class GroupsIsMemberRequest : RequestModelBase
    {
        public string GroupId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<int> UserIds { get; set; }
        public bool? Extended { get; set; }
    }

    public class GroupsGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> GroupIds { get; set; }
        public string GroupId { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class GroupsGetRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public bool? Extended { get; set; }
        public IEnumerable<string> Filter { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class GroupsGetMembersRequest : RequestModelBase
    {
        public string GroupId { get; set; }
        public string Sort { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string Filter { get; set; }
    }

    public class GroupsJoinRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string NotSure { get; set; }
    }

    public class GroupsLeaveRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class GroupsSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public string Type { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public bool? Future { get; set; }
        public bool? Market { get; set; }
        public int? Sort { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class GroupsGetCatalogRequest : RequestModelBase
    {
        public int? CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
    }

    public class GroupsGetCatalogInfoRequest : RequestModelBase
    {
        public bool? Extended { get; set; }
        public bool? Subcategories { get; set; }
    }

    public class GroupsGetInvitesRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class GroupsGetInvitedUsersRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class GroupsBanUserRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Reason { get; set; }
        public string Comment { get; set; }
        public bool? CommentVisible { get; set; }
    }

    public class GroupsUnbanUserRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsGetBannedRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsCreateRequest : RequestModelBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? PublicCategory { get; set; }
        public int? Subtype { get; set; }
    }

    public class GroupsEditRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ScreenName { get; set; }
        public int? Access { get; set; }
        public string Website { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Rss { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventFinishDate { get; set; }
        public int? EventGroupId { get; set; }
        public int? PublicCategory { get; set; }
        public int? PublicSubcategory { get; set; }
        public string PublicDate { get; set; }
        public int? Wall { get; set; }
        public int? Topics { get; set; }
        public int? Photos { get; set; }
        public int? Video { get; set; }
        public int? Audio { get; set; }
        public bool? Links { get; set; }
        public bool? Events { get; set; }
        public bool? Places { get; set; }
        public bool? Contacts { get; set; }
        public int? Docs { get; set; }
        public int? Wiki { get; set; }
        public bool? Messages { get; set; }
        public int? AgeLimits { get; set; }
        public bool? Market { get; set; }
        public bool? MarketComments { get; set; }
        public IEnumerable<int> MarketCountry { get; set; }
        public IEnumerable<int> MarketCity { get; set; }
        public int? MarketCurrency { get; set; }
        public int? MarketContact { get; set; }
        public int? MarketWiki { get; set; }
        public bool? ObsceneFilter { get; set; }
        public bool? ObsceneStopwords { get; set; }
        public IEnumerable<string> ObsceneWords { get; set; }
    }

    public class GroupsEditPlaceRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }

    public class GroupsGetSettingsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class GroupsGetRequestsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class GroupsEditManagerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
        public string Role { get; set; }
        public bool? IsContact { get; set; }
        public string ContactPosition { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }

    public class GroupsInviteRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsAddLinkRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
    }

    public class GroupsDeleteLinkRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? LinkId { get; set; }
    }

    public class GroupsEditLinkRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? LinkId { get; set; }
        public string Text { get; set; }
    }

    public class GroupsReorderLinkRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? LinkId { get; set; }
        public int? After { get; set; }
    }

    public class GroupsRemoveUserRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsApproveRequestRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsGetCallbackConfirmationCodeRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class GroupsGetCallbackServerSettingsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class GroupsGetCallbackSettingsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class GroupsSetCallbackServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string ServerUrl { get; set; }
    }

    public class GroupsSetCallbackServerSettingsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string SecretKey { get; set; }
    }

    public class GroupsSetCallbackSettingsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public bool? MessageNew { get; set; }
        public bool? MessageAllow { get; set; }
        public bool? MessageDeny { get; set; }
        public bool? PhotoNew { get; set; }
        public bool? AudioNew { get; set; }
        public bool? VideoNew { get; set; }
        public bool? WallReplyNew { get; set; }
        public bool? WallReplyEdit { get; set; }
        public bool? WallPostNew { get; set; }
        public bool? BoardPostNew { get; set; }
        public bool? BoardPostEdit { get; set; }
        public bool? BoardPostRestore { get; set; }
        public bool? BoardPostDelete { get; set; }
        public bool? PhotoCommentNew { get; set; }
        public bool? VideoCommentNew { get; set; }
        public bool? MarketCommentNew { get; set; }
        public bool? GroupJoin { get; set; }
        public bool? GroupLeave { get; set; }
    }

    public class BoardGetTopicsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public IEnumerable<int> TopicIds { get; set; }
        public int? Order { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
        public int? Preview { get; set; }
        public int? PreviewLength { get; set; }
    }

    public class BoardGetCommentsRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? StartCommentId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
        public string Sort { get; set; }
    }

    public class BoardAddTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool? FromGroup { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class BoardCreateCommentRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public bool? FromGroup { get; set; }
        public int? StickerId { get; set; }
        public string Guid { get; set; }
    }

    public class BoardDeleteTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
    }

    public class BoardEditTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public string Title { get; set; }
    }

    public class BoardEditCommentRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public int? CommentId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class BoardRestoreCommentRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public int? CommentId { get; set; }
    }

    public class BoardDeleteCommentRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
        public int? CommentId { get; set; }
    }

    public class BoardOpenTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
    }

    public class BoardCloseTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
    }

    public class BoardFixTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
    }

    public class BoardUnfixTopicRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? TopicId { get; set; }
    }

    public class VideoGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public IEnumerable<string> Videos { get; set; }
        public int? AlbumId { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? NoComments { get; set; }
        public bool? Repeat { get; set; }
    }

    public class VideoAddRequest : RequestModelBase
    {
        public int? TargetId { get; set; }
        public int? VideoId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class VideoSaveRequest : RequestModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? Wallpost { get; set; }
        public string Link { get; set; }
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? NoComments { get; set; }
        public bool? Repeat { get; set; }
    }

    public class VideoDeleteRequest : RequestModelBase
    {
        public int? VideoId { get; set; }
        public int? OwnerId { get; set; }
        public int? TargetId { get; set; }
    }

    public class VideoRestoreRequest : RequestModelBase
    {
        public int? VideoId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class VideoSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? Sort { get; set; }
        public int? Hd { get; set; }
        public bool? Adult { get; set; }
        public IEnumerable<string> Filters { get; set; }
        public bool? SearchOwn { get; set; }
        public int? Offset { get; set; }
        public int? Longer { get; set; }
        public int? Shorter { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoGetUserVideosRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoGetAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoGetAlbumByIdRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class VideoAddAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Privacy { get; set; }
    }

    public class VideoEditAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Privacy { get; set; }
    }

    public class VideoDeleteAlbumRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class VideoReorderAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class VideoReorderVideosRequest : RequestModelBase
    {
        public int? TargetId { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public int? BeforeOwnerId { get; set; }
        public int? BeforeVideoId { get; set; }
        public int? AfterOwnerId { get; set; }
        public int? AfterVideoId { get; set; }
    }

    public class VideoAddToAlbumRequest : RequestModelBase
    {
        public int? TargetId { get; set; }
        public int? AlbumId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
    }

    public class VideoRemoveFromAlbumRequest : RequestModelBase
    {
        public int? TargetId { get; set; }
        public int? AlbumId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
    }

    public class VideoGetAlbumsByVideoRequest : RequestModelBase
    {
        public int? TargetId { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoGetCommentsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? StartCommentId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string Sort { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoCreateCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public bool? FromGroup { get; set; }
        public int? ReplyToComment { get; set; }
        public int? StickerId { get; set; }
        public string Guid { get; set; }
    }

    public class VideoDeleteCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class VideoRestoreCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class VideoEditCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class VideoGetTagsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
    }

    public class VideoPutTagRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public string TaggedName { get; set; }
    }

    public class VideoRemoveTagRequest : RequestModelBase
    {
        public int? TagId { get; set; }
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
    }

    public class VideoGetNewTagsRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class VideoReportRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? VideoId { get; set; }
        public int? Reason { get; set; }
        public string Comment { get; set; }
        public string SearchQuery { get; set; }
    }

    public class VideoReportCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public int? Reason { get; set; }
    }

    public class VideoGetCatalogRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public int? ItemsCount { get; set; }
        public string From { get; set; }
        public IEnumerable<string> Filters { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoGetCatalogSectionRequest : RequestModelBase
    {
        public string SectionId { get; set; }
        public string From { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class VideoHideCatalogSectionRequest : RequestModelBase
    {
        public int? SectionId { get; set; }
    }

    public class NotesGetRequest : RequestModelBase
    {
        public IEnumerable<int> NoteIds { get; set; }
        public int? UserId { get; set; }
        public int? Count { get; set; }
    }

    public class NotesGetByIdRequest : RequestModelBase
    {
        public int? NoteId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class NotesAddRequest : RequestModelBase
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
    }

    public class NotesEditRequest : RequestModelBase
    {
        public int? NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
    }

    public class NotesDeleteRequest : RequestModelBase
    {
        public int? NoteId { get; set; }
    }

    public class NotesGetCommentsRequest : RequestModelBase
    {
        public int? NoteId { get; set; }
        public int? OwnerId { get; set; }
        public int? Count { get; set; }
    }

    public class NotesCreateCommentRequest : RequestModelBase
    {
        public int? NoteId { get; set; }
        public int? OwnerId { get; set; }
        public int? ReplyTo { get; set; }
        public string Message { get; set; }
        public string Guid { get; set; }
    }

    public class NotesEditCommentRequest : RequestModelBase
    {
        public int? CommentId { get; set; }
        public int? OwnerId { get; set; }
        public string Message { get; set; }
    }

    public class NotesDeleteCommentRequest : RequestModelBase
    {
        public int? CommentId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class NotesRestoreCommentRequest : RequestModelBase
    {
        public int? CommentId { get; set; }
        public int? OwnerId { get; set; }
    }

    public class PlacesAddRequest : RequestModelBase
    {
        public int? Type { get; set; }
        public string Title { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Address { get; set; }
    }

    public class PlacesGetByIdRequest : RequestModelBase
    {
        public IEnumerable<int> Places { get; set; }
    }

    public class PlacesSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Radius { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class PlacesCheckinRequest : RequestModelBase
    {
        public int? PlaceId { get; set; }
        public string Text { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? FriendsOnly { get; set; }
        public IEnumerable<string> Services { get; set; }
    }

    public class PlacesGetCheckinsRequest : RequestModelBase
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Place { get; set; }
        public int? UserId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public DateTime? Timestamp { get; set; }
        public bool? FriendsOnly { get; set; }
        public bool? NeedPlaces { get; set; }
    }

    public class PlacesGetTypesRequest : RequestModelBase
    {
    }

    public class AccountGetCountersRequest : RequestModelBase
    {
        public IEnumerable<string> Filter { get; set; }
    }

    public class AccountSetNameInMenuRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Name { get; set; }
    }

    public class AccountSetOnlineRequest : RequestModelBase
    {
        public bool? Voip { get; set; }
    }

    public class AccountSetOfflineRequest : RequestModelBase
    {
    }

    public class AccountLookupContactsRequest : RequestModelBase
    {
        public IEnumerable<string> Contacts { get; set; }
        public string Service { get; set; }
        public string Mycontact { get; set; }
        public bool? ReturnAll { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class AccountRegisterDeviceRequest : RequestModelBase
    {
        public string Token { get; set; }
        public string DeviceModel { get; set; }
        public int? DeviceYear { get; set; }
        public string DeviceId { get; set; }
        public string SystemVersion { get; set; }
        public string Settings { get; set; }
    }

    public class AccountUnregisterDeviceRequest : RequestModelBase
    {
        public string DeviceId { get; set; }
    }

    public class AccountSetSilenceModeRequest : RequestModelBase
    {
        public string DeviceId { get; set; }
        public DateTime? Time { get; set; }
        public int? PeerId { get; set; }
        public int? Sound { get; set; }
    }

    public class AccountGetPushSettingsRequest : RequestModelBase
    {
        public string DeviceId { get; set; }
    }

    public class AccountSetPushSettingsRequest : RequestModelBase
    {
        public string DeviceId { get; set; }
        public string Settings { get; set; }
        public string Key { get; set; }
        public IEnumerable<string> Value { get; set; }
    }

    public class AccountGetAppPermissionsRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class AccountGetActiveOffersRequest : RequestModelBase
    {
        public int? Count { get; set; }
    }

    public class AccountBanUserRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class AccountUnbanUserRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class AccountGetBannedRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class AccountGetInfoRequest : RequestModelBase
    {
        public IEnumerable<string> Fields { get; set; }
    }

    public class AccountSetInfoRequest : RequestModelBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class AccountChangePasswordRequest : RequestModelBase
    {
        public string RestoreSid { get; set; }
        public string ChangePasswordHash { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class AccountGetProfileInfoRequest : RequestModelBase
    {
    }

    public class AccountSaveProfileInfoRequest : RequestModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string ScreenName { get; set; }
        public int? CancelRequestId { get; set; }
        public int? Sex { get; set; }
        public int? Relation { get; set; }
        public int? RelationPartnerId { get; set; }
        public string Bdate { get; set; }
        public int? BdateVisibility { get; set; }
        public string HomeTown { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public string Status { get; set; }
    }

    public class MessagesGetRequest : RequestModelBase
    {
        public bool? Out { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public DateTime? TimeOffset { get; set; }
        public int? PreviewLength { get; set; }
        public int? LastMessageId { get; set; }
    }

    public class MessagesGetDialogsRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public int? StartMessageId { get; set; }
        public int? PreviewLength { get; set; }
        public bool? Unread { get; set; }
    }

    public class MessagesGetByIdRequest : RequestModelBase
    {
        public IEnumerable<int> MessageIds { get; set; }
    }

    public class MessagesSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? PeerId { get; set; }
        public DateTime? Date { get; set; }
        public int? Count { get; set; }
    }

    public class MessagesGetHistoryRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string UserId { get; set; }
        public int? PeerId { get; set; }
        public int? StartMessageId { get; set; }
        public int? Rev { get; set; }
    }

    public class MessagesGetHistoryAttachmentsRequest : RequestModelBase
    {
        public int? PeerId { get; set; }
        public string MediaType { get; set; }
        public string StartFrom { get; set; }
        public int? Count { get; set; }
        public bool? PhotoSizes { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class MessagesSendRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? RandomId { get; set; }
        public int? PeerId { get; set; }
        public string Domain { get; set; }
        public int? ChatId { get; set; }
        public IEnumerable<int> UserIds { get; set; }
        public string Message { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string Attachment { get; set; }
        public string ForwardMessages { get; set; }
        public int? StickerId { get; set; }
        public bool? Notification { get; set; }
    }

    public class MessagesDeleteRequest : RequestModelBase
    {
        public IEnumerable<int> MessageIds { get; set; }
        public bool? Spam { get; set; }
    }

    public class MessagesDeleteDialogRequest : RequestModelBase
    {
        public string UserId { get; set; }
        public int? PeerId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class MessagesRestoreRequest : RequestModelBase
    {
        public int? MessageId { get; set; }
    }

    public class MessagesMarkAsReadRequest : RequestModelBase
    {
        public IEnumerable<int> MessageIds { get; set; }
        public string PeerId { get; set; }
        public int? StartMessageId { get; set; }
    }

    public class MessagesMarkAsImportantRequest : RequestModelBase
    {
        public IEnumerable<int> MessageIds { get; set; }
        public int? Important { get; set; }
    }

    public class MessagesGetLongPollServerRequest : RequestModelBase
    {
        public bool? UseSsl { get; set; }
        public bool? NeedPts { get; set; }
    }

    public class MessagesGetLongPollHistoryRequest : RequestModelBase
    {
        public int? Ts { get; set; }
        public int? Pts { get; set; }
        public int? PreviewLength { get; set; }
        public bool? Onlines { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public int? EventsLimit { get; set; }
        public int? MsgsLimit { get; set; }
        public int? MaxMsgId { get; set; }
    }

    public class MessagesGetChatRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public IEnumerable<int> ChatIds { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class MessagesCreateChatRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
        public string Title { get; set; }
    }

    public class MessagesEditChatRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public string Title { get; set; }
    }

    public class MessagesGetChatUsersRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public IEnumerable<int> ChatIds { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class MessagesSetActivityRequest : RequestModelBase
    {
        public string UserId { get; set; }
        public string Type { get; set; }
        public int? PeerId { get; set; }
    }

    public class MessagesSearchDialogsRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? Limit { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class MessagesAddChatUserRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public int? UserId { get; set; }
    }

    public class MessagesRemoveChatUserRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
        public string UserId { get; set; }
    }

    public class MessagesGetLastActivityRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class MessagesSetChatPhotoRequest : RequestModelBase
    {
        public string File { get; set; }
    }

    public class MessagesDeleteChatPhotoRequest : RequestModelBase
    {
        public int? ChatId { get; set; }
    }

    public class MessagesDenyMessagesFromGroupRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class MessagesAllowMessagesFromGroupRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class MessagesIsMessagesFromGroupAllowedRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? UserId { get; set; }
    }

    public class NewsfeedGetRequest : RequestModelBase
    {
        public IEnumerable<string> Filters { get; set; }
        public bool? ReturnBanned { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? MaxPhotos { get; set; }
        public string SourceIds { get; set; }
        public string StartFrom { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class NewsfeedGetRecommendedRequest : RequestModelBase
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? MaxPhotos { get; set; }
        public string StartFrom { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class NewsfeedGetCommentsRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public IEnumerable<string> Filters { get; set; }
        public string Reposts { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StartFrom { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class NewsfeedGetMentionsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class NewsfeedGetBannedRequest : RequestModelBase
    {
        public bool? Extended { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class NewsfeedAddBanRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
        public IEnumerable<int> GroupIds { get; set; }
    }

    public class NewsfeedDeleteBanRequest : RequestModelBase
    {
        public IEnumerable<int> UserIds { get; set; }
        public IEnumerable<int> GroupIds { get; set; }
    }

    public class NewsfeedIgnoreItemRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class NewsfeedUnignoreItemRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class NewsfeedSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public bool? Extended { get; set; }
        public int? Count { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StartFrom { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class NewsfeedGetListsRequest : RequestModelBase
    {
        public IEnumerable<int> ListIds { get; set; }
    }

    public class NewsfeedSaveListRequest : RequestModelBase
    {
        public int? ListId { get; set; }
        public string Title { get; set; }
        public IEnumerable<int> SourceIds { get; set; }
        public bool? NoReposts { get; set; }
    }

    public class NewsfeedDeleteListRequest : RequestModelBase
    {
        public int? ListId { get; set; }
    }

    public class NewsfeedUnsubscribeRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class NewsfeedGetSuggestedSourcesRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Shuffle { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class LikesGetListRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public string PageUrl { get; set; }
        public string Filter { get; set; }
        public bool? FriendsOnly { get; set; }
        public bool? Extended { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? SkipOwn { get; set; }
    }

    public class LikesAddRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public string AccessKey { get; set; }
    }

    public class LikesDeleteRequest : RequestModelBase
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class LikesIsLikedRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class PollsGetByIdRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public bool? IsBoard { get; set; }
        public int? PollId { get; set; }
    }

    public class PollsAddVoteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PollId { get; set; }
        public int? AnswerId { get; set; }
        public bool? IsBoard { get; set; }
    }

    public class PollsDeleteVoteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PollId { get; set; }
        public int? AnswerId { get; set; }
        public bool? IsBoard { get; set; }
    }

    public class PollsGetVotersRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PollId { get; set; }
        public IEnumerable<int> AnswerIds { get; set; }
        public bool? IsBoard { get; set; }
        public bool? FriendsOnly { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class PollsCreateRequest : RequestModelBase
    {
        public string Question { get; set; }
        public bool? IsAnonymous { get; set; }
        public int? OwnerId { get; set; }
        public JsonArray AddAnswers { get; set; }
    }

    public class PollsEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PollId { get; set; }
        public string Question { get; set; }
        public JsonArray AddAnswers { get; set; }
        public string EditAnswers { get; set; }
        public JsonArray DeleteAnswers { get; set; }
    }

    public class DocsGetRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public int? OwnerId { get; set; }
    }

    public class DocsGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> Docs { get; set; }
    }

    public class DocsGetUploadServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class DocsGetWallUploadServerRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class DocsSaveRequest : RequestModelBase
    {
        public string File { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
    }

    public class DocsDeleteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? DocId { get; set; }
    }

    public class DocsAddRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? DocId { get; set; }
        public string AccessKey { get; set; }
    }

    public class DocsGetTypesRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
    }

    public class DocsSearchRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
    }

    public class DocsEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? DocId { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }

    public class FaveGetUsersRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class FaveGetPhotosRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? PhotoSizes { get; set; }
    }

    public class FaveGetPostsRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class FaveGetVideosRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class FaveGetLinksRequest : RequestModelBase
    {
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class FaveGetMarketItemsRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class FaveAddUserRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class FaveRemoveUserRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class FaveAddGroupRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class FaveRemoveGroupRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
    }

    public class FaveAddLinkRequest : RequestModelBase
    {
        public string Link { get; set; }
        public string Text { get; set; }
    }

    public class FaveRemoveLinkRequest : RequestModelBase
    {
        public string LinkId { get; set; }
    }

    public class NotificationsGetRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public string StartFrom { get; set; }
        public IEnumerable<string> Filters { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }

    public class NotificationsMarkAsViewedRequest : RequestModelBase
    {
    }

    public class StatsGetRequest : RequestModelBase
    {
        public int? GroupId { get; set; }
        public int? AppId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }

    public class StatsTrackVisitorRequest : RequestModelBase
    {
    }

    public class StatsGetPostReachRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? PostId { get; set; }
    }

    public class SearchGetHintsRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? Limit { get; set; }
        public IEnumerable<string> Filters { get; set; }
        public bool? SearchGlobal { get; set; }
    }

    public class AppsGetCatalogRequest : RequestModelBase
    {
        public string Sort { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public string Platform { get; set; }
        public bool? Extended { get; set; }
        public bool? ReturnFriends { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
        public string Q { get; set; }
        public int? GenreId { get; set; }
        public string Filter { get; set; }
    }

    public class AppsGetRequest : RequestModelBase
    {
        public int? AppId { get; set; }
        public IEnumerable<string> AppIds { get; set; }
        public string Platform { get; set; }
        public IEnumerable<string> Fields { get; set; }
        public string NameCase { get; set; }
    }

    public class AppsSendRequestRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public bool? Separate { get; set; }
    }

    public class AppsDeleteAppRequestsRequest : RequestModelBase
    {
    }

    public class AppsGetFriendsListRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public string Type { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class AppsGetLeaderboardRequest : RequestModelBase
    {
        public string Type { get; set; }
        public bool? Global { get; set; }
        public bool? Extended { get; set; }
    }

    public class SecureAddAppEventRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? ActivityId { get; set; }
        public int? Value { get; set; }
    }

    public class AppsGetScoreRequest : RequestModelBase
    {
        public int? UserId { get; set; }
    }

    public class UtilsCheckLinkRequest : RequestModelBase
    {
        public string Url { get; set; }
    }

    public class UtilsResolveScreenNameRequest : RequestModelBase
    {
        public string ScreenName { get; set; }
    }

    public class UtilsGetServerTimeRequest : RequestModelBase
    {
    }

    public class DatabaseGetCountriesRequest : RequestModelBase
    {
        public bool? NeedAll { get; set; }
        public string Code { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetRegionsRequest : RequestModelBase
    {
        public int? CountryId { get; set; }
        public string Q { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetStreetsByIdRequest : RequestModelBase
    {
        public IEnumerable<int> StreetIds { get; set; }
    }

    public class DatabaseGetCountriesByIdRequest : RequestModelBase
    {
        public IEnumerable<int> CountryIds { get; set; }
    }

    public class DatabaseGetCitiesRequest : RequestModelBase
    {
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string Q { get; set; }
        public bool? NeedAll { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetCitiesByIdRequest : RequestModelBase
    {
        public IEnumerable<int> CityIds { get; set; }
    }

    public class DatabaseGetUniversitiesRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetSchoolsRequest : RequestModelBase
    {
        public string Q { get; set; }
        public int? CityId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetSchoolClassesRequest : RequestModelBase
    {
        public int? CountryId { get; set; }
    }

    public class DatabaseGetFacultiesRequest : RequestModelBase
    {
        public int? UniversityId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class DatabaseGetChairsRequest : RequestModelBase
    {
        public int? FacultyId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class GiftsGetRequest : RequestModelBase
    {
        public int? UserId { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
    }

    public class AdsGetAccountsRequest : RequestModelBase
    {
    }

    public class AdsGetClientsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
    }

    public class AdsCreateClientsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsUpdateClientsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsDeleteClientsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Ids { get; set; }
    }

    public class AdsGetCampaignsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public bool? IncludeDeleted { get; set; }
        public string CampaignIds { get; set; }
    }

    public class AdsCreateCampaignsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsUpdateCampaignsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsDeleteCampaignsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Ids { get; set; }
    }

    public class AdsGetAdsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public bool? IncludeDeleted { get; set; }
        public string CampaignIds { get; set; }
        public string AdIds { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }

    public class AdsGetAdsLayoutRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public bool? IncludeDeleted { get; set; }
        public string CampaignIds { get; set; }
        public string AdIds { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }

    public class AdsGetAdsTargetingRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public bool? IncludeDeleted { get; set; }
        public string CampaignIds { get; set; }
        public string AdIds { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }

    public class AdsCreateAdsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsUpdateAdsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsDeleteAdsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Ids { get; set; }
    }

    public class AdsCheckLinkRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string LinkType { get; set; }
        public string LinkUrl { get; set; }
        public int? CampaignId { get; set; }
    }

    public class AdsGetStatisticsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string IdsType { get; set; }
        public string Ids { get; set; }
        public string Period { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }

    public class AdsGetDemographicsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string IdsType { get; set; }
        public string Ids { get; set; }
        public string Period { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }

    public class AdsGetAdsPostsReachRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string AdsIds { get; set; }
    }

    public class AdsGetBudgetRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
    }

    public class AdsGetOfficeUsersRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
    }

    public class AdsAddOfficeUsersRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Data { get; set; }
    }

    public class AdsRemoveOfficeUsersRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Ids { get; set; }
    }

    public class AdsGetTargetingStatsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public string Criteria { get; set; }
        public int? AdId { get; set; }
        public int? AdFormat { get; set; }
        public string AdPlatform { get; set; }
        public string LinkUrl { get; set; }
        public string LinkDomain { get; set; }
    }

    public class AdsGetSuggestionsRequest : RequestModelBase
    {
        public string Section { get; set; }
        public string Ids { get; set; }
        public string Q { get; set; }
        public int? Country { get; set; }
        public string Cities { get; set; }
        public string Lang { get; set; }
    }

    public class AdsGetCategoriesRequest : RequestModelBase
    {
        public string Lang { get; set; }
    }

    public class AdsGetUploadURLRequest : RequestModelBase
    {
        public int? AdFormat { get; set; }
    }

    public class AdsGetVideoUploadURLRequest : RequestModelBase
    {
    }

    public class AdsGetFloodStatsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
    }

    public class AdsGetRejectionReasonRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? AdId { get; set; }
    }

    public class AdsCreateTargetGroupRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int? Lifetime { get; set; }
    }

    public class AdsUpdateTargetGroupRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public int? TargetGroupId { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int? Lifetime { get; set; }
    }

    public class AdsDeleteTargetGroupRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public int? TargetGroupId { get; set; }
    }

    public class AdsGetTargetGroupsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public bool? Extended { get; set; }
    }

    public class AdsImportTargetContactsRequest : RequestModelBase
    {
        public int? AccountId { get; set; }
        public int? ClientId { get; set; }
        public int? TargetGroupId { get; set; }
        public string Contacts { get; set; }
    }

    public class SecureCheckTokenRequest : RequestModelBase
    {
        public string Token { get; set; }
        public string Ip { get; set; }
    }

    public class MarketGetRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public bool? Extended { get; set; }
    }

    public class MarketGetByIdRequest : RequestModelBase
    {
        public IEnumerable<string> ItemIds { get; set; }
        public bool? Extended { get; set; }
    }

    public class MarketSearchRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string Q { get; set; }
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public int? Rev { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
        public bool? Extended { get; set; }
    }

    public class MarketGetAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? Offset { get; set; }
        public int? Count { get; set; }
    }

    public class MarketGetAlbumByIdRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
    }

    public class MarketCreateCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public bool? FromGroup { get; set; }
        public int? ReplyToComment { get; set; }
        public int? StickerId { get; set; }
        public string Guid { get; set; }
    }

    public class MarketGetCommentsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public bool? NeedLikes { get; set; }
        public int? StartCommentId { get; set; }
        public int? Count { get; set; }
        public string Sort { get; set; }
        public bool? Extended { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }

    public class MarketDeleteCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class MarketRestoreCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
    }

    public class MarketEditCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Attachments { get; set; }
    }

    public class MarketReportCommentRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? CommentId { get; set; }
        public int? Reason { get; set; }
    }

    public class MarketGetCategoriesRequest : RequestModelBase
    {
        public int? Count { get; set; }
        public int? Offset { get; set; }
    }

    public class MarketReportRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public int? Reason { get; set; }
    }

    public class MarketAddRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public double? Price { get; set; }
        public bool? Deleted { get; set; }
        public int? MainPhotoId { get; set; }
        public IEnumerable<int> PhotoIds { get; set; }
    }

    public class MarketEditRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public double? Price { get; set; }
        public bool? Deleted { get; set; }
        public int? MainPhotoId { get; set; }
        public IEnumerable<int> PhotoIds { get; set; }
    }

    public class MarketDeleteRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class MarketRestoreRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
    }

    public class MarketReorderItemsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public int? ItemId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class MarketReorderAlbumsRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
    }

    public class MarketAddAlbumRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? PhotoId { get; set; }
        public bool? MainAlbum { get; set; }
    }

    public class MarketEditAlbumRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
        public string Title { get; set; }
        public int? PhotoId { get; set; }
        public bool? MainAlbum { get; set; }
    }

    public class MarketDeleteAlbumRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? AlbumId { get; set; }
    }

    public class MarketRemoveFromAlbumRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
    }

    public class MarketAddToAlbumRequest : RequestModelBase
    {
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public IEnumerable<int> AlbumIds { get; set; }
    }
}