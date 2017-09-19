using System;
using System.Collections.Generic;

namespace Citrina
{
    public class AccountChangePasswordResponse
    {
        /// <summary>
        /// New token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// New secret
        /// </summary>
        public string Secret { get; set; }
    }

    public class AccountGetActiveOffersResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AccountOffer> Items { get; set; }
    }

    public class AccountGetBannedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class AccountSaveProfileInfoResponse
    {
        /// <summary>
        /// 1 if changes has been processed
        /// </summary>
        public bool? Changed { get; set; }
        public AccountNameRequest NameRequest { get; set; }
    }

    public class AdsCreateTargetGroupResponse
    {
        /// <summary>
        /// Group ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Pixel code
        /// </summary>
        public string Pixel { get; set; }
    }

    public class AdsGetCategoriesResponse
    {
        /// <summary>
        /// Old categories
        /// </summary>
        public IEnumerable<AdsCategory> V1 { get; set; }
        /// <summary>
        /// Actual categories
        /// </summary>
        public IEnumerable<AdsCategory> V2 { get; set; }
    }

    public class AppsGetCatalogResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AppsApp> Items { get; set; }
    }

    public class AppsGetLeaderboardResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AppsLeaderboard> Items { get; set; }
    }

    public class AppsGetLeaderboardExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AppsLeaderboard> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class AppsGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AppsApp> Items { get; set; }
    }

    public class AppsGetFriendsListResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class AuthSignupResponse
    {
        /// <summary>
        /// Parameter to retry
        /// </summary>
        public string Sid { get; set; }
    }

    public class AuthConfirmResponse
    {
        /// <summary>
        /// 1 if success
        /// </summary>
        public int? Success { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
    }

    public class AuthRestoreResponse
    {
        /// <summary>
        /// 1 if success
        /// </summary>
        public int? Success { get; set; }
        /// <summary>
        /// Parameter needed to grant access by code
        /// </summary>
        public string Sid { get; set; }
    }

    public class BoardGetTopicsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BoardTopic> Items { get; set; }
        public int? DefaultOrder { get; set; }
        /// <summary>
        /// Information whether current user can add topic
        /// </summary>
        public bool? CanAddTopics { get; set; }
    }

    public class BoardGetTopicsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BoardTopic> Items { get; set; }
        public int? DefaultOrder { get; set; }
        /// <summary>
        /// Information whether current user can add topic
        /// </summary>
        public bool? CanAddTopics { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class BoardGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BoardTopicComment> Items { get; set; }
        public BoardTopicPoll Poll { get; set; }
    }

    public class BoardGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BoardTopicComment> Items { get; set; }
        public BoardTopicPoll Poll { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
    }

    public class DatabaseGetCountriesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BaseCountry> Items { get; set; }
    }

    public class DatabaseGetRegionsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DatabaseRegion> Items { get; set; }
    }

    public class DatabaseGetChairsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<BaseObject> Items { get; set; }
    }

    public class DatabaseGetCitiesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DatabaseCity> Items { get; set; }
    }

    public class DatabaseGetUniversitiesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DatabaseUniversity> Items { get; set; }
    }

    public class DatabaseGetSchoolsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DatabaseSchool> Items { get; set; }
    }

    public class DatabaseGetFacultiesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DatabaseFaculty> Items { get; set; }
    }

    public class DocsGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DocsDoc> Items { get; set; }
    }

    public class DocsGetUploadServerResponse
    {
        /// <summary>
        /// Upload URL
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class DocsGetWallUploadServerResponse
    {
        /// <summary>
        /// Upload URL
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class DocsAddResponse
    {
        /// <summary>
        /// Doc ID
        /// </summary>
        public int? Id { get; set; }
    }

    public class DocsGetTypesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DocsDocTypes> Items { get; set; }
    }

    public class DocsSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<DocsDoc> Items { get; set; }
    }

    public class FaveGetUsersResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class FaveGetPhotosResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class FaveGetPostsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class FaveGetVideosResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class FaveGetLinksResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<FaveFavesLink> Items { get; set; }
    }

    public class FaveGetMarketItemsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class FriendsGetResponse
    {
        /// <summary>
        /// Total friends number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class FriendsGetFieldsResponse
    {
        /// <summary>
        /// Total friends number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<FriendsUserXtrLists> Items { get; set; }
    }

    public class FriendsGetOnlineOnlineMobileResponse
    {
        public IEnumerable<int?> Online { get; set; }
        public IEnumerable<int?> OnlineMobile { get; set; }
    }

    public class FriendsGetRequestsResponse
    {
        /// <summary>
        /// Total requests number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class FriendsGetRequestsNeedMutualResponse
    {
        /// <summary>
        /// Total requests number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<FriendsRequests> Items { get; set; }
    }

    public class FriendsGetRequestsExtendedResponse
    {
        /// <summary>
        /// Total requests number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<FriendsRequestsXtrMessage> Items { get; set; }
    }

    public class FriendsDeleteResponse
    {
        public bool? Success { get; set; }
        /// <summary>
        /// Returns 1 if friend has been deleted
        /// </summary>
        public int? FriendDeleted { get; set; }
        /// <summary>
        /// Returns 1 if out request has been canceled
        /// </summary>
        public int? OutRequestDeleted { get; set; }
        /// <summary>
        /// Returns 1 if incoming request has been declined
        /// </summary>
        public int? InRequestDeleted { get; set; }
        /// <summary>
        /// Returns 1 if suggestion has been declined
        /// </summary>
        public int? SuggestionDeleted { get; set; }
    }

    public class FriendsGetListsResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<FriendsFriendsList> Items { get; set; }
    }

    public class FriendsAddListResponse
    {
        /// <summary>
        /// List ID
        /// </summary>
        public int? ListId { get; set; }
    }

    public class FriendsGetSuggestionsResponse
    {
        /// <summary>
        /// Total results number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class FriendsGetAvailableForCallResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class FriendsGetAvailableForCallFieldsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class FriendsSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class GiftsGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GiftsGift> Items { get; set; }
    }

    public class GroupsIsMemberExtendedResponse
    {
        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        public bool? Member { get; set; }
        /// <summary>
        /// Information whether user has been invited to the group
        /// </summary>
        public bool? Invitation { get; set; }
        /// <summary>
        /// Information whether user has sent request to the group
        /// </summary>
        public bool? Request { get; set; }
    }

    public class GroupsGetCallbackConfirmationCodeResponse
    {
        /// <summary>
        /// Confirmation code
        /// </summary>
        public string Code { get; set; }
    }

    public class GroupsGetCallbackServerSettingsResponse
    {
        /// <summary>
        /// Server URL
        /// </summary>
        public string ServerUrl { get; set; }
        /// <summary>
        /// Callback API secret key
        /// </summary>
        public string SecretKey { get; set; }
    }

    public class GroupsGetCallbackSettingsResponse
    {
        /// <summary>
        /// Whether notifications about new message enabled
        /// </summary>
        public bool? MessageNew { get; set; }
        /// <summary>
        /// Whether notifications about new message enabled
        /// </summary>
        public bool? MessageReply { get; set; }
        /// <summary>
        /// Whether notifications about allowed messages enabled
        /// </summary>
        public bool? MessageAllow { get; set; }
        /// <summary>
        /// Whether notifications about denied messages enabled
        /// </summary>
        public bool? MessageDeny { get; set; }
        /// <summary>
        /// Whether notifications about new photos enabled
        /// </summary>
        public bool? PhotoNew { get; set; }
        /// <summary>
        /// Whether notifications about new audios enabled
        /// </summary>
        public bool? AudioNew { get; set; }
        /// <summary>
        /// Whether notifications about new videos enabled
        /// </summary>
        public bool? VideoNew { get; set; }
        /// <summary>
        /// Whether notifications about new wall replies enabled
        /// </summary>
        public bool? WallReplyNew { get; set; }
        /// <summary>
        /// Comment on wall has been edited
        /// </summary>
        public bool? WallReplyEdit { get; set; }
        /// <summary>
        /// Comment on wall has been deleted
        /// </summary>
        public bool? WallReplyDelete { get; set; }
        /// <summary>
        /// Comment on wall has been restored
        /// </summary>
        public bool? WallPostRestore { get; set; }
        /// <summary>
        /// Whether notifications about new board posts enabled
        /// </summary>
        public bool? BoardPostNew { get; set; }
        /// <summary>
        /// Whether notifications about board posts edits enabled
        /// </summary>
        public bool? BoardPostEdit { get; set; }
        /// <summary>
        /// Whether notifications about board posts restores enabled
        /// </summary>
        public bool? BoardPostRestore { get; set; }
        /// <summary>
        /// Whether notifications about board posts deleted enabled
        /// </summary>
        public bool? BoardPostDelete { get; set; }
        /// <summary>
        /// Whether notifications about new photo comments enabled
        /// </summary>
        public bool? PhotoCommentNew { get; set; }
        /// <summary>
        /// Comment on photo has been edited
        /// </summary>
        public bool? PhotoCommentEdit { get; set; }
        /// <summary>
        /// Comment on photo has been deleted
        /// </summary>
        public bool? PhotoCommentDelete { get; set; }
        /// <summary>
        /// Comment on photo has been restored
        /// </summary>
        public bool? PhotoCommentRestore { get; set; }
        /// <summary>
        /// Whether notifications about new video comments enabled
        /// </summary>
        public bool? VideoCommentNew { get; set; }
        /// <summary>
        /// Comment on video has been edited
        /// </summary>
        public bool? VideoCommentEdit { get; set; }
        /// <summary>
        /// Comment on video has been deleted
        /// </summary>
        public bool? VideoCommentDelete { get; set; }
        /// <summary>
        /// Comment on video has been restored
        /// </summary>
        public bool? VideoCommentRestore { get; set; }
        /// <summary>
        /// Whether notifications about new market comments enabled
        /// </summary>
        public bool? MarketCommentNew { get; set; }
        /// <summary>
        /// Comment on market item has been edited
        /// </summary>
        public bool? MarketCommentEdit { get; set; }
        /// <summary>
        /// Comment on market item has been deleted
        /// </summary>
        public bool? MarketCommentDelete { get; set; }
        /// <summary>
        /// Comment on market item has been restored
        /// </summary>
        public bool? MarketCommentRestore { get; set; }
        /// <summary>
        /// Whether notifications about anyone joined the community enabled
        /// </summary>
        public bool? GroupJoin { get; set; }
        /// <summary>
        /// Whether notifications about anyone left the community enabled
        /// </summary>
        public bool? GroupLeave { get; set; }
    }

    public class GroupsSetCallbackServerResponse
    {
        /// <summary>
        /// State code
        /// </summary>
        public int? StateCode { get; set; }
        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }
    }

    public class GroupsGetResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class GroupsGetExtendedResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupFull> Items { get; set; }
    }

    public class GroupsGetMembersResponse
    {
        /// <summary>
        /// Total members number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class GroupsGetMembersFieldsResponse
    {
        /// <summary>
        /// Total members number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsUserXtrRole> Items { get; set; }
    }

    public class GroupsGetMembersFilterResponse
    {
        /// <summary>
        /// Total members number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsMemberRole> Items { get; set; }
    }

    public class GroupsSearchResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsGroup> Items { get; set; }
    }

    public class GroupsGetCatalogResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsGroup> Items { get; set; }
    }

    public class GroupsGetCatalogInfoResponse
    {
        /// <summary>
        /// Information whether catalog is enabled for current user
        /// </summary>
        public int? Enabled { get; set; }
        public IEnumerable<GroupsGroupCategory> Categories { get; set; }
    }

    public class GroupsGetCatalogInfoExtendedResponse
    {
        /// <summary>
        /// Information whether catalog is enabled for current user
        /// </summary>
        public int? Enabled { get; set; }
        public IEnumerable<GroupsGroupCategoryFull> Categories { get; set; }
    }

    public class GroupsGetInvitesResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupXtrInvitedBy> Items { get; set; }
    }

    public class GroupsGetInvitesExtendedResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupXtrInvitedBy> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class GroupsGetInvitedUsersResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class GroupsGetBannedResponse
    {
        /// <summary>
        /// Total users number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<GroupsUserXtrBanInfo> Items { get; set; }
    }

    public class GroupsEditPlaceResponse
    {
        public bool? Success { get; set; }
        /// <summary>
        /// Place address
        /// </summary>
        public string Address { get; set; }
    }

    public class GroupsGetRequestsResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class GroupsGetRequestsFieldsResponse
    {
        /// <summary>
        /// Total communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class LeadsMetricHitResponse
    {
        /// <summary>
        /// Information whether request has been processed successfully
        /// </summary>
        public bool? Result { get; set; }
        /// <summary>
        /// Redirect link
        /// </summary>
        public string RedirectLink { get; set; }
    }

    public class LikesGetListResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class LikesGetListExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class LikesAddResponse
    {
        /// <summary>
        /// Total likes number
        /// </summary>
        public int? Likes { get; set; }
    }

    public class LikesDeleteResponse
    {
        /// <summary>
        /// Total likes number
        /// </summary>
        public int? Likes { get; set; }
    }

    public class LikesIsLikedResponse
    {
        /// <summary>
        /// Information whether user liked the object
        /// </summary>
        public bool? Liked { get; set; }
        /// <summary>
        /// Information whether user reposted the object
        /// </summary>
        public bool? Copied { get; set; }
    }

    public class MarketGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketGetExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketGetByIdResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketGetByIdExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketSearchExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketGetAlbumsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketAlbum> Items { get; set; }
    }

    public class MarketGetAlbumByIdResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketAlbum> Items { get; set; }
    }

    public class MarketGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class MarketGetCategoriesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MarketMarketCategory> Items { get; set; }
    }

    public class MarketAddResponse
    {
        /// <summary>
        /// Item ID
        /// </summary>
        public int? MarketItemId { get; set; }
    }

    public class MarketAddAlbumResponse
    {
        /// <summary>
        /// Album ID
        /// </summary>
        public int? MarketAlbumId { get; set; }
    }

    public class MessagesGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesDeleteResponse
    {
    }

    public class MessagesGetDialogsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Unread dialogs number
        /// </summary>
        public int? UnreadDialogs { get; set; }
        public IEnumerable<MessagesDialog> Items { get; set; }
    }

    public class MessagesGetByIdResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesGetHistoryResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Unread dialogs number
        /// </summary>
        public int? Unread { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
        /// <summary>
        /// Id of last read inbound message
        /// </summary>
        public int? InRead { get; set; }
        /// <summary>
        /// Id of last read outbound message
        /// </summary>
        public int? OutRead { get; set; }
    }

    public class MessagesGetHistoryAttachmentsResponse
    {
        public IEnumerable<MessagesHistoryAttachment> Items { get; set; }
        /// <summary>
        /// Value for pagination
        /// </summary>
        public string NextFrom { get; set; }
    }

    public class MessagesGetLongPollHistoryResponse
    {
        public IEnumerable<IEnumerable<int?>> History { get; set; }
        public MessagesLongpollMessages Messages { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<MessagesChat> Chats { get; set; }
        /// <summary>
        /// Persistence timestamp
        /// </summary>
        public DateTime? NewPts { get; set; }
        /// <summary>
        /// Has more
        /// </summary>
        public bool? More { get; set; }
    }

    public class MessagesGetChatUsersChatIdsResponse
    {
    }

    public class MessagesGetChatUsersChatIdsFieldsResponse
    {
    }

    public class MessagesSetChatPhotoResponse
    {
        /// <summary>
        /// Service message ID
        /// </summary>
        public int? MessageId { get; set; }
        public MessagesChat Chat { get; set; }
    }

    public class MessagesDeleteChatPhotoResponse
    {
        /// <summary>
        /// Service message ID
        /// </summary>
        public int? MessageId { get; set; }
        public MessagesChat Chat { get; set; }
    }

    public class MessagesIsMessagesFromGroupAllowedResponse
    {
        public bool? IsAllowed { get; set; }
    }

    public class NewsfeedGetResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class NewsfeedGetRecommendedResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        /// <summary>
        /// New offset value
        /// </summary>
        public string NewOffset { get; set; }
        /// <summary>
        /// New from value
        /// </summary>
        public string NewFrom { get; set; }
    }

    public class NewsfeedGetCommentsResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        /// <summary>
        /// New from value
        /// </summary>
        public string NextFrom { get; set; }
    }

    public class NewsfeedGetMentionsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostToId> Items { get; set; }
    }

    public class NewsfeedGetBannedResponse
    {
        public IEnumerable<int?> Groups { get; set; }
        public IEnumerable<int?> Members { get; set; }
    }

    public class NewsfeedGetBannedExtendedResponse
    {
        public IEnumerable<UsersUserFull> Groups { get; set; }
        public IEnumerable<GroupsGroupFull> Members { get; set; }
    }

    public class NewsfeedSearchResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class NewsfeedSearchExtendedResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class NewsfeedGetListsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NewsfeedList> Items { get; set; }
    }

    public class NewsfeedGetListsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NewsfeedListFull> Items { get; set; }
    }

    public class NewsfeedGetSuggestedSourcesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<string> Items { get; set; }
    }

    public class NotesGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NotesNote> Items { get; set; }
    }

    public class NotesGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NotesNoteComment> Items { get; set; }
    }

    public class NotificationsGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NotificationsNotification> Items { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
        /// <summary>
        /// Time when user has been checked notifications last time
        /// </summary>
        public int? LastViewed { get; set; }
    }

    public class PhotosGetAlbumsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoAlbumFull> Items { get; set; }
    }

    public class PhotosGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFull> Items { get; set; }
    }

    public class PhotosGetOwnerCoverPhotoUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class PhotosGetOwnerPhotoUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class PhotosGetChatUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class PhotosGetMarketUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class PhotosGetMarketAlbumUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        public string UploadUrl { get; set; }
    }

    public class PhotosSaveOwnerPhotoResponse
    {
        /// <summary>
        /// Parameter for saveProfilePhoto method
        /// </summary>
        public string PhotoHash { get; set; }
        /// <summary>
        /// Uploaded image url
        /// </summary>
        public string PhotoSrc { get; set; }
    }

    public class PhotosSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetAllResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoXtrRealOffset> Items { get; set; }
        /// <summary>
        /// Information whether next page is presented
        /// </summary>
        public bool? More { get; set; }
    }

    public class PhotosGetAllExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFullXtrRealOffset> Items { get; set; }
        /// <summary>
        /// Information whether next page is presented
        /// </summary>
        public bool? More { get; set; }
    }

    public class PhotosGetUserPhotosResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetUserPhotoExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFull> Items { get; set; }
    }

    public class PhotosGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Real offset of the comments
        /// </summary>
        public int? RealOffset { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class PhotosGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Real offset of the comments
        /// </summary>
        public int? RealOffset { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class PhotosGetAllCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosCommentXtrPid> Items { get; set; }
    }

    public class PhotosGetNewTagsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoXtrTagInfo> Items { get; set; }
    }

    public class PlacesAddResponse
    {
        /// <summary>
        /// Place ID
        /// </summary>
        public int? Id { get; set; }
    }

    public class PlacesSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PlacesPlaceFull> Items { get; set; }
    }

    public class PlacesCheckinResponse
    {
        /// <summary>
        /// Checkin ID
        /// </summary>
        public int? Id { get; set; }
    }

    public class PlacesGetCheckinsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<PlacesCheckin> Items { get; set; }
    }

    public class StreamingGetServerUrlResponse
    {
        /// <summary>
        /// Server host
        /// </summary>
        public string Endpoint { get; set; }
        /// <summary>
        /// Access key
        /// </summary>
        public string Key { get; set; }
    }

    public class UsersSearchResponse
    {
        /// <summary>
        /// Total number of available results
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class UsersGetSubscriptionsResponse
    {
        public UsersUsersArray Users { get; set; }
        public GroupsGroupsArray Groups { get; set; }
    }

    public class UsersGetSubscriptionsExtendedResponse
    {
        /// <summary>
        /// Total number of available results
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<string> Items { get; set; }
    }

    public class UsersGetFollowersResponse
    {
        /// <summary>
        /// Total friends number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class UsersGetFollowersFieldsResponse
    {
        /// <summary>
        /// Total number of available results
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class UsersGetNearbyResponse
    {
        /// <summary>
        /// Users number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class UtilsGetLastShortenedLinksResponse
    {
        /// <summary>
        /// Total number of available results
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<UtilsLastShortenedLink> Items { get; set; }
    }

    public class VideoGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoGetExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideoFull> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoSearchExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetUserVideosResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoGetUserVideosExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetAlbumsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoGetAlbumsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoAddAlbumResponse
    {
        /// <summary>
        /// Created album ID
        /// </summary>
        public int? AlbumId { get; set; }
    }

    public class VideoGetAlbumsByVideoExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class VideoGetNewTagsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideoTagInfo> Items { get; set; }
    }

    public class VideoGetCatalogResponse
    {
        public IEnumerable<VideoCatBlock> Items { get; set; }
        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        public string Next { get; set; }
    }

    public class VideoGetCatalogExtendedResponse
    {
        public IEnumerable<VideoCatBlock> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        public string Next { get; set; }
    }

    public class VideoGetCatalogSectionResponse
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        public string Next { get; set; }
    }

    public class VideoGetCatalogSectionExtendedResponse
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        public string Next { get; set; }
    }

    public class WallGetResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class WallGetExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class WallSearchResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class WallSearchExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class WallGetByIdExtendedResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class WallPostResponse
    {
        /// <summary>
        /// Created post ID
        /// </summary>
        public int? PostId { get; set; }
    }

    public class WallRepostResponse
    {
        public bool? Success { get; set; }
        /// <summary>
        /// Created post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Reposts number
        /// </summary>
        public int? RepostsCount { get; set; }
        /// <summary>
        /// Reposts number
        /// </summary>
        public int? LikesCount { get; set; }
    }

    public class WallGetRepostsResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
    }

    public class WallGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class WallGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
    }

    public class WallCreateCommentResponse
    {
        /// <summary>
        /// Created comment ID
        /// </summary>
        public int? CommentId { get; set; }
    }

    public class WidgetsGetCommentsResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WidgetsWidgetComment> Posts { get; set; }
    }

    public class WidgetsGetPagesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<WidgetsWidgetPage> Pages { get; set; }
    }

}