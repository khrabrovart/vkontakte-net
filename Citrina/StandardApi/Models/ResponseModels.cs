using System.Collections.Generic;

namespace Citrina.StandardApi.Models
{
    public class AccountChangePasswordResponse
    {
        public string Token { get; set; }
        public string Secret { get; set; }
    }

    public class AccountGetActiveOffersResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AccountOffer> Items { get; set; }
    }

    public class AccountGetBannedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class AccountSaveProfileInfoResponse
    {
        public bool? Changed { get; set; }
        public AccountNameRequest NameRequest { get; set; }
    }

    public class AdsCreateTargetGroupResponse
    {
        public int? Id { get; set; }
        public string Pixel { get; set; }
    }

    public class AppsGetCatalogResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AppsApp> Items { get; set; }
    }

    public class AppsGetLeaderboardResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AppsLeaderboard> Items { get; set; }
    }

    public class AppsGetLeaderboardExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AppsLeaderboard> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class AppsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AppsApp> Items { get; set; }
    }

    public class AppsGetFriendsListResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class AudioGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AudioAudioFull> Items { get; set; }
    }

    public class AudioSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AudioAudioFull> Items { get; set; }
    }

    public class AudioGetUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class AudioGetAlbumsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<AudioAudioAlbum> Items { get; set; }
    }

    public class AudioAddAlbumResponse
    {
        public int? AlbumId { get; set; }
    }

    public class AuthSignupResponse
    {
        public string Sid { get; set; }
    }

    public class AuthConfirmResponse
    {
        public int? Success { get; set; }
        public int? UserId { get; set; }
    }

    public class AuthRestoreResponse
    {
        public int? Success { get; set; }
        public string Sid { get; set; }
    }

    public class BoardGetTopicsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BoardTopic> Items { get; set; }
        public int? DefaultOrder { get; set; }
        public bool? CanAddTopics { get; set; }
    }

    public class BoardGetTopicsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BoardTopic> Items { get; set; }
        public int? DefaultOrder { get; set; }
        public bool? CanAddTopics { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class BoardGetCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BoardTopicComment> Items { get; set; }
        public BoardTopicPoll Poll { get; set; }
    }

    public class BoardGetCommentsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BoardTopicComment> Items { get; set; }
        public BoardTopicPoll Poll { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
    }

    public class DatabaseGetCountriesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BaseCountry> Items { get; set; }
    }

    public class DatabaseGetRegionsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DatabaseRegion> Items { get; set; }
    }

    public class DatabaseGetChairsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<BaseObject> Items { get; set; }
    }

    public class DatabaseGetCitiesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DatabaseCity> Items { get; set; }
    }

    public class DatabaseGetUniversitiesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DatabaseUniversity> Items { get; set; }
    }

    public class DatabaseGetSchoolsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DatabaseSchool> Items { get; set; }
    }

    public class DatabaseGetFacultiesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DatabaseFaculty> Items { get; set; }
    }

    public class DocsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DocsDoc> Items { get; set; }
    }

    public class DocsGetUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class DocsGetWallUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class DocsAddResponse
    {
        public int? Id { get; set; }
    }

    public class DocsGetTypesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DocsDocTypes> Items { get; set; }
    }

    public class DocsSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<DocsDoc> Items { get; set; }
    }

    public class FaveGetUsersResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class FaveGetPhotosResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class FaveGetPostsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class FaveGetVideosResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class FaveGetLinksResponse
    {
        public int? Count { get; set; }
        public IEnumerable<FaveFavesLink> Items { get; set; }
    }

    public class FaveGetMarketItemsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class FriendsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class FriendsGetFieldsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<FriendsUserXtrLists> Items { get; set; }
    }

    public class FriendsGetOnlineOnlineMobileResponse
    {
        public IEnumerable<int> Online { get; set; }
        public IEnumerable<int> OnlineMobile { get; set; }
    }

    public class FriendsGetRequestsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class FriendsGetRequestsNeedMutualResponse
    {
        public int? Count { get; set; }
        public IEnumerable<FriendsRequests> Items { get; set; }
    }

    public class FriendsGetRequestsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<FriendsRequestsXtrMessage> Items { get; set; }
    }

    public class FriendsDeleteResponse
    {
        public bool? Success { get; set; }
        public int? FriendDeleted { get; set; }
        public int? OutRequestDeleted { get; set; }
        public int? InRequestDeleted { get; set; }
        public int? SuggestionDeleted { get; set; }
    }

    public class FriendsGetListsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<FriendsFriendsList> Items { get; set; }
    }

    public class FriendsAddListResponse
    {
        public int? ListId { get; set; }
    }

    public class FriendsGetSuggestionsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class FriendsGetAvailableForCallResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class FriendsGetAvailableForCallFieldsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class FriendsSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class GiftsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GiftsGift> Items { get; set; }
    }

    public class GroupsIsMemberExtendedResponse
    {
        public bool? Member { get; set; }
        public bool? Invitation { get; set; }
        public bool? Request { get; set; }
    }

    public class GroupsGetCallbackConfirmationCodeResponse
    {
        public string Code { get; set; }
    }

    public class GroupsGetCallbackServerSettingsResponse
    {
        public string ServerUrl { get; set; }
        public string SecretKey { get; set; }
    }

    public class GroupsGetCallbackSettingsResponse
    {
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

    public class GroupsSetCallbackServerResponse
    {
        public int? StateCode { get; set; }
        public string State { get; set; }
    }

    public class GroupsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class GroupsGetExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupFull> Items { get; set; }
    }

    public class GroupsGetMembersResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class GroupsGetMembersFieldsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsUserXtrRole> Items { get; set; }
    }

    public class GroupsGetMembersFilterResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsMemberRole> Items { get; set; }
    }

    public class GroupsSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsGroup> Items { get; set; }
    }

    public class GroupsGetCatalogResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsGroup> Items { get; set; }
    }

    public class GroupsGetCatalogInfoResponse
    {
        public int? Enabled { get; set; }
        public IEnumerable<GroupsGroupCategory> Categories { get; set; }
    }

    public class GroupsGetCatalogInfoExtendedResponse
    {
        public int? Enabled { get; set; }
        public IEnumerable<GroupsGroupCategoryFull> Categories { get; set; }
    }

    public class GroupsGetInvitesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupXtrInvitedBy> Items { get; set; }
    }

    public class GroupsGetInvitesExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsGroupXtrInvitedBy> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
    }

    public class GroupsGetInvitedUsersResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class GroupsGetBannedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<GroupsUserXtrBanInfo> Items { get; set; }
    }

    public class GroupsEditPlaceResponse
    {
        public bool? Success { get; set; }
        public string Address { get; set; }
    }

    public class GroupsGetRequestsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class GroupsGetRequestsFieldsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class LeadsMetricHitResponse
    {
        public bool? Result { get; set; }
        public string RedirectLink { get; set; }
    }

    public class LikesGetListResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class LikesGetListExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserMin> Items { get; set; }
    }

    public class LikesAddResponse
    {
        public int? Likes { get; set; }
    }

    public class LikesDeleteResponse
    {
        public int? Likes { get; set; }
    }

    public class LikesIsLikedResponse
    {
        public bool? Liked { get; set; }
        public bool? Copied { get; set; }
    }

    public class MarketGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketGetExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketGetByIdResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketGetByIdExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItem> Items { get; set; }
    }

    public class MarketSearchExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketItemFull> Items { get; set; }
    }

    public class MarketGetAlbumsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketAlbum> Items { get; set; }
    }

    public class MarketGetAlbumByIdResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketAlbum> Items { get; set; }
    }

    public class MarketGetCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class MarketGetCategoriesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MarketMarketCategory> Items { get; set; }
    }

    public class MarketAddResponse
    {
        public int? MarketItemId { get; set; }
    }

    public class MarketAddAlbumResponse
    {
        public int? MarketAlbumId { get; set; }
    }

    public class MessagesGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesGetDialogsResponse
    {
        public int? Count { get; set; }
        public int? UnreadDialogs { get; set; }
        public IEnumerable<MessagesDialog> Items { get; set; }
    }

    public class MessagesGetByIdResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesGetHistoryResponse
    {
        public int? Count { get; set; }
        public int? Unread { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
        public int? InRead { get; set; }
        public int? OutRead { get; set; }
    }

    public class MessagesGetHistoryAttachmentsResponse
    {
        public IEnumerable<MessagesAttachmentsHistory> Items { get; set; }
        public string NextFrom { get; set; }
    }

    public class MessagesGetLongPollHistoryResponse
    {
        public IEnumerable<IEnumerable<int>> History { get; set; }
        public MessagesLongpollMessages Messages { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<MessagesChat> Chats { get; set; }
        public int? NewPts { get; set; }
        public bool? More { get; set; }
    }

    public class MessagesSetChatPhotoResponse
    {
        public int? MessageId { get; set; }
        public MessagesChat Chat { get; set; }
    }

    public class MessagesDeleteChatPhotoResponse
    {
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
        public string NewOffset { get; set; }
        public string NewFrom { get; set; }
    }

    public class NewsfeedGetCommentsResponse
    {
        public IEnumerable<NewsfeedNewsfeedItem> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        public string NextFrom { get; set; }
    }

    public class NewsfeedGetMentionsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallpostToId> Items { get; set; }
    }

    public class NewsfeedGetBannedResponse
    {
        public IEnumerable<int> Groups { get; set; }
        public IEnumerable<int> Members { get; set; }
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
        public int? Count { get; set; }
        public IEnumerable<NewsfeedList> Items { get; set; }
    }

    public class NewsfeedGetSuggestedSourcesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<string> Items { get; set; }
    }

    public class NotesGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<NotesNote> Items { get; set; }
    }

    public class NotesGetCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<NotesNoteComment> Items { get; set; }
    }

    public class NotificationsGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<NotificationsNotification> Items { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
        public int? LastViewed { get; set; }
    }

    public class PhotosGetAlbumsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoAlbumFull> Items { get; set; }
    }

    public class PhotosGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFull> Items { get; set; }
    }

    public class PhotosGetOwnerPhotoUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class PhotosGetChatUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class PhotosGetMarketUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class PhotosGetMarketAlbumUploadServerResponse
    {
        public string UploadUrl { get; set; }
    }

    public class PhotosSaveOwnerPhotoResponse
    {
        public string PhotoHash { get; set; }
        public string PhotoSrc { get; set; }
    }

    public class PhotosSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetAllResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoXtrRealOffset> Items { get; set; }
        public bool? More { get; set; }
    }

    public class PhotosGetAllExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFullXtrRealOffset> Items { get; set; }
        public bool? More { get; set; }
    }

    public class PhotosGetUserPhotosResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhoto> Items { get; set; }
    }

    public class PhotosGetUserPhotoExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoFull> Items { get; set; }
    }

    public class PhotosGetCommentsResponse
    {
        public int? Count { get; set; }
        public int? RealOffset { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class PhotosGetCommentsExtendedResponse
    {
        public int? Count { get; set; }
        public int? RealOffset { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class PhotosGetAllCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosCommentXtrPid> Items { get; set; }
    }

    public class PhotosGetNewTagsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PhotosPhotoXtrTagInfo> Items { get; set; }
    }

    public class PlacesAddResponse
    {
        public int? Id { get; set; }
    }

    public class PlacesSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PlacesPlaceFull> Items { get; set; }
    }

    public class PlacesCheckinResponse
    {
        public int? Id { get; set; }
    }

    public class PlacesGetCheckinsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<PlacesCheckin> Items { get; set; }
    }

    public class UsersSearchResponse
    {
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
        public int? Count { get; set; }
        public IEnumerable<string> Items { get; set; }
    }

    public class UsersGetFollowersResponse
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class UsersGetFollowersFieldsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class UsersGetNearbyResponse
    {
        public int? Count { get; set; }
        public IEnumerable<UsersUserFull> Items { get; set; }
    }

    public class VideoGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoGetExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideoFull> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoSearchExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetUserVideosResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class VideoGetUserVideosExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetAlbumsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoGetAlbumsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoAddAlbumResponse
    {
        public int? AlbumId { get; set; }
    }

    public class VideoGetAlbumsByVideoExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideoAlbumFull> Items { get; set; }
    }

    public class VideoGetCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUserMin> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class VideoGetCommentsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class VideoGetNewTagsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideoTagInfo> Items { get; set; }
    }

    public class VideoGetCatalogResponse
    {
        public IEnumerable<VideoCatBlock> Items { get; set; }
        public string Next { get; set; }
    }

    public class VideoGetCatalogExtendedResponse
    {
        public IEnumerable<VideoCatBlock> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        public string Next { get; set; }
    }

    public class VideoGetCatalogSectionResponse
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        public string Next { get; set; }
    }

    public class VideoGetCatalogSectionExtendedResponse
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
        public string Next { get; set; }
    }

    public class WallGetResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class WallGetExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
        public IEnumerable<UsersUserFull> Profiles { get; set; }
        public IEnumerable<GroupsGroupFull> Groups { get; set; }
    }

    public class WallSearchResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallpostFull> Items { get; set; }
    }

    public class WallSearchExtendedResponse
    {
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
        public int? PostId { get; set; }
    }

    public class WallRepostResponse
    {
        public bool? Success { get; set; }
        public int? PostId { get; set; }
        public int? RepostsCount { get; set; }
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
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
    }

    public class WallGetCommentsExtendedResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WallWallComment> Items { get; set; }
        public IEnumerable<UsersUser> Profiles { get; set; }
        public IEnumerable<GroupsGroup> Groups { get; set; }
    }

    public class WallCreateCommentResponse
    {
        public int? CommentId { get; set; }
    }

    public class WidgetsGetCommentsResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WidgetsWidgetComment> Posts { get; set; }
    }

    public class WidgetsGetPagesResponse
    {
        public int? Count { get; set; }
        public IEnumerable<WidgetsWidgetPage> Pages { get; set; }
    }
}