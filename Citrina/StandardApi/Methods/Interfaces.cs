using System.Collections.Generic;
using System.Threading.Tasks;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi
{
    public interface IAccountApi
    {
        Task<ApiCall<AccountGetCountersRequest, AccountAccountCounters>> GetCounters(AccountGetCountersRequest request);
        Task<ApiCall<AccountSetNameInMenuRequest, bool?>> SetNameInMenu(AccountSetNameInMenuRequest request);
        Task<ApiCall<AccountSetOnlineRequest, bool?>> SetOnline(AccountSetOnlineRequest request);
        Task<ApiCall<AccountSetOfflineRequest, bool?>> SetOffline(AccountSetOfflineRequest request);
        Task<ApiCall<AccountLookupContactsRequest, AccountLookupResult>> LookupContacts(AccountLookupContactsRequest request);
        Task<ApiCall<AccountRegisterDeviceRequest, bool?>> RegisterDevice(AccountRegisterDeviceRequest request);
        Task<ApiCall<AccountUnregisterDeviceRequest, bool?>> UnregisterDevice(AccountUnregisterDeviceRequest request);
        Task<ApiCall<AccountSetSilenceModeRequest, bool?>> SetSilenceMode(AccountSetSilenceModeRequest request);
        Task<ApiCall<AccountGetPushSettingsRequest, AccountPushSettings>> GetPushSettings(AccountGetPushSettingsRequest request);
        Task<ApiCall<AccountSetPushSettingsRequest, bool?>> SetPushSettings(AccountSetPushSettingsRequest request);
        Task<ApiCall<AccountGetAppPermissionsRequest, int?>> GetAppPermissions(AccountGetAppPermissionsRequest request);
        Task<ApiCall<AccountGetActiveOffersRequest, AccountGetActiveOffersResponse>> GetActiveOffers(AccountGetActiveOffersRequest request);
        Task<ApiCall<AccountBanUserRequest, bool?>> BanUser(AccountBanUserRequest request);
        Task<ApiCall<AccountUnbanUserRequest, bool?>> UnbanUser(AccountUnbanUserRequest request);
        Task<ApiCall<AccountGetBannedRequest, AccountGetBannedResponse>> GetBanned(AccountGetBannedRequest request);
        Task<ApiCall<AccountGetInfoRequest, AccountInfo>> GetInfo(AccountGetInfoRequest request);
        Task<ApiCall<AccountSetInfoRequest, bool?>> SetInfo(AccountSetInfoRequest request);
        Task<ApiCall<AccountChangePasswordRequest, AccountChangePasswordResponse>> ChangePassword(AccountChangePasswordRequest request);
        Task<ApiCall<AccountGetProfileInfoRequest, AccountUserSettings>> GetProfileInfo(AccountGetProfileInfoRequest request);
        Task<ApiCall<AccountSaveProfileInfoRequest, AccountSaveProfileInfoResponse>> SaveProfileInfo(AccountSaveProfileInfoRequest request);
    }

    public interface IAdsApi
    {
        Task<ApiCall<AdsGetAccountsRequest, IEnumerable<AdsAccount>>> GetAccounts(AdsGetAccountsRequest request);
        Task<ApiCall<AdsGetClientsRequest, IEnumerable<AdsClient>>> GetClients(AdsGetClientsRequest request);
        Task<ApiCall<AdsCreateClientsRequest, IEnumerable<int>>> CreateClients(AdsCreateClientsRequest request);
        Task<ApiCall<AdsUpdateClientsRequest, int?>> UpdateClients(AdsUpdateClientsRequest request);
        Task<ApiCall<AdsDeleteClientsRequest, int?>> DeleteClients(AdsDeleteClientsRequest request);
        Task<ApiCall<AdsGetCampaignsRequest, IEnumerable<AdsCampaign>>> GetCampaigns(AdsGetCampaignsRequest request);
        Task<ApiCall<AdsCreateCampaignsRequest, IEnumerable<int>>> CreateCampaigns(AdsCreateCampaignsRequest request);
        Task<ApiCall<AdsUpdateCampaignsRequest, int?>> UpdateCampaigns(AdsUpdateCampaignsRequest request);
        Task<ApiCall<AdsDeleteCampaignsRequest, int?>> DeleteCampaigns(AdsDeleteCampaignsRequest request);
        Task<ApiCall<AdsGetAdsRequest, IEnumerable<AdsAd>>> GetAds(AdsGetAdsRequest request);
        Task<ApiCall<AdsGetAdsLayoutRequest, IEnumerable<AdsAdLayout>>> GetAdsLayout(AdsGetAdsLayoutRequest request);
        Task<ApiCall<AdsGetAdsTargetingRequest, IEnumerable<AdsTargSettings>>> GetAdsTargeting(AdsGetAdsTargetingRequest request);
        Task<ApiCall<AdsCreateAdsRequest, IEnumerable<int>>> CreateAds(AdsCreateAdsRequest request);
        Task<ApiCall<AdsUpdateAdsRequest, IEnumerable<int>>> UpdateAds(AdsUpdateAdsRequest request);
        Task<ApiCall<AdsDeleteAdsRequest, IEnumerable<int>>> DeleteAds(AdsDeleteAdsRequest request);
        Task<ApiCall<AdsCheckLinkRequest, AdsLinkStatus>> CheckLink(AdsCheckLinkRequest request);
        Task<ApiCall<AdsGetStatisticsRequest, IEnumerable<AdsStats>>> GetStatistics(AdsGetStatisticsRequest request);
        Task<ApiCall<AdsGetDemographicsRequest, IEnumerable<AdsDemoStats>>> GetDemographics(AdsGetDemographicsRequest request);
        Task<ApiCall<AdsGetAdsPostsReachRequest, IEnumerable<AdsPostStats>>> GetAdsPostsReach(AdsGetAdsPostsReachRequest request);
        Task<ApiCall<AdsGetBudgetRequest, int?>> GetBudget(AdsGetBudgetRequest request);
        Task<ApiCall<AdsGetOfficeUsersRequest, IEnumerable<AdsUsers>>> GetOfficeUsers(AdsGetOfficeUsersRequest request);
        Task<ApiCall<AdsAddOfficeUsersRequest, bool?>> AddOfficeUsers(AdsAddOfficeUsersRequest request);
        Task<ApiCall<AdsRemoveOfficeUsersRequest, bool?>> RemoveOfficeUsers(AdsRemoveOfficeUsersRequest request);
        Task<ApiCall<AdsGetTargetingStatsRequest, AdsTargStats>> GetTargetingStats(AdsGetTargetingStatsRequest request);
        Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestions>>> GetSuggestions(AdsGetSuggestionsRequest request);
        Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(AdsGetSuggestionsRequest request);
        Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(AdsGetSuggestionsRequest request);
        Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(AdsGetSuggestionsRequest request);
        Task<ApiCall<AdsGetCategoriesRequest, IEnumerable<AdsCategory>>> GetCategories(AdsGetCategoriesRequest request);
        Task<ApiCall<AdsGetUploadURLRequest, string>> GetUploadURL(AdsGetUploadURLRequest request);
        Task<ApiCall<AdsGetVideoUploadURLRequest, string>> GetVideoUploadURL(AdsGetVideoUploadURLRequest request);
        Task<ApiCall<AdsGetFloodStatsRequest, AdsFloodStats>> GetFloodStats(AdsGetFloodStatsRequest request);
        Task<ApiCall<AdsGetRejectionReasonRequest, AdsRejectReason>> GetRejectionReason(AdsGetRejectionReasonRequest request);
        Task<ApiCall<AdsCreateTargetGroupRequest, AdsCreateTargetGroupResponse>> CreateTargetGroup(AdsCreateTargetGroupRequest request);
        Task<ApiCall<AdsUpdateTargetGroupRequest, bool?>> UpdateTargetGroup(AdsUpdateTargetGroupRequest request);
        Task<ApiCall<AdsDeleteTargetGroupRequest, bool?>> DeleteTargetGroup(AdsDeleteTargetGroupRequest request);
        Task<ApiCall<AdsGetTargetGroupsRequest, IEnumerable<AdsTargetGroup>>> GetTargetGroups(AdsGetTargetGroupsRequest request);
        Task<ApiCall<AdsImportTargetContactsRequest, int?>> ImportTargetContacts(AdsImportTargetContactsRequest request);
    }

    public interface IAppsApi
    {
        Task<ApiCall<AppsGetCatalogRequest, AppsGetCatalogResponse>> GetCatalog(AppsGetCatalogRequest request);
        Task<ApiCall<AppsGetRequest, AppsGetResponse>> Get(AppsGetRequest request);
        Task<ApiCall<AppsSendRequestRequest, int?>> SendRequest(AppsSendRequestRequest request);
        Task<ApiCall<AppsDeleteAppRequestsRequest, bool?>> DeleteAppRequests(AppsDeleteAppRequestsRequest request);
        Task<ApiCall<AppsGetFriendsListRequest, AppsGetFriendsListResponse>> GetFriendsList(AppsGetFriendsListRequest request);
        Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardResponse>> GetLeaderboard(AppsGetLeaderboardRequest request);
        Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(AppsGetLeaderboardRequest request);
        Task<ApiCall<AppsGetScoreRequest, int?>> GetScore(AppsGetScoreRequest request);
    }

    public interface IAudioApi
    {
        Task<ApiCall<AudioGetRequest, AudioGetResponse>> Get(AudioGetRequest request);
        Task<ApiCall<AudioGetByIdRequest, IEnumerable<AudioAudioFull>>> GetById(AudioGetByIdRequest request);
        Task<ApiCall<AudioGetLyricsRequest, AudioLyrics>> GetLyrics(AudioGetLyricsRequest request);
        Task<ApiCall<AudioSearchRequest, AudioSearchResponse>> Search(AudioSearchRequest request);
        Task<ApiCall<AudioGetUploadServerRequest, AudioGetUploadServerResponse>> GetUploadServer(AudioGetUploadServerRequest request);
        Task<ApiCall<AudioSaveRequest, AudioAudio>> Save(AudioSaveRequest request);
        Task<ApiCall<AudioAddRequest, int?>> Add(AudioAddRequest request);
        Task<ApiCall<AudioDeleteRequest, bool?>> Delete(AudioDeleteRequest request);
        Task<ApiCall<AudioEditRequest, int?>> Edit(AudioEditRequest request);
        Task<ApiCall<AudioReorderRequest, bool?>> Reorder(AudioReorderRequest request);
        Task<ApiCall<AudioRestoreRequest, bool?>> Restore(AudioRestoreRequest request);
        Task<ApiCall<AudioGetAlbumsRequest, AudioGetAlbumsResponse>> GetAlbums(AudioGetAlbumsRequest request);
        Task<ApiCall<AudioAddAlbumRequest, AudioAddAlbumResponse>> AddAlbum(AudioAddAlbumRequest request);
        Task<ApiCall<AudioEditAlbumRequest, bool?>> EditAlbum(AudioEditAlbumRequest request);
        Task<ApiCall<AudioDeleteAlbumRequest, bool?>> DeleteAlbum(AudioDeleteAlbumRequest request);
        Task<ApiCall<AudioMoveToAlbumRequest, bool?>> MoveToAlbum(AudioMoveToAlbumRequest request);
        Task<ApiCall<AudioSetBroadcastRequest, IEnumerable<int>>> SetBroadcast(AudioSetBroadcastRequest request);
        Task<ApiCall<AudioGetBroadcastListRequest, IEnumerable<UsersUserBroadcast>>> GetBroadcastList(AudioGetBroadcastListRequest request);
        Task<ApiCall<AudioGetRecommendationsRequest, IEnumerable<AudioAudioFull>>> GetRecommendations(AudioGetRecommendationsRequest request);
        Task<ApiCall<AudioGetPopularRequest, IEnumerable<AudioAudioFull>>> GetPopular(AudioGetPopularRequest request);
        Task<ApiCall<AudioGetCountRequest, int?>> GetCount(AudioGetCountRequest request);
    }

    public interface IAuthApi
    {
        Task<ApiCall<AuthCheckPhoneRequest, bool?>> CheckPhone(AuthCheckPhoneRequest request);
        Task<ApiCall<AuthSignupRequest, AuthSignupResponse>> Signup(AuthSignupRequest request);
        Task<ApiCall<AuthConfirmRequest, AuthConfirmResponse>> Confirm(AuthConfirmRequest request);
        Task<ApiCall<AuthRestoreRequest, AuthRestoreResponse>> Restore(AuthRestoreRequest request);
    }

    public interface IBoardApi
    {
        Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsResponse>> GetTopics(BoardGetTopicsRequest request);
        Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsExtendedResponse>> GetTopicsExtended(BoardGetTopicsRequest request);
        Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsResponse>> GetComments(BoardGetCommentsRequest request);
        Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsExtendedResponse>> GetCommentsExtended(BoardGetCommentsRequest request);
        Task<ApiCall<BoardAddTopicRequest, int?>> AddTopic(BoardAddTopicRequest request);
        Task<ApiCall<BoardCreateCommentRequest, int?>> CreateComment(BoardCreateCommentRequest request);
        Task<ApiCall<BoardDeleteTopicRequest, bool?>> DeleteTopic(BoardDeleteTopicRequest request);
        Task<ApiCall<BoardEditTopicRequest, bool?>> EditTopic(BoardEditTopicRequest request);
        Task<ApiCall<BoardEditCommentRequest, bool?>> EditComment(BoardEditCommentRequest request);
        Task<ApiCall<BoardRestoreCommentRequest, bool?>> RestoreComment(BoardRestoreCommentRequest request);
        Task<ApiCall<BoardDeleteCommentRequest, bool?>> DeleteComment(BoardDeleteCommentRequest request);
        Task<ApiCall<BoardOpenTopicRequest, bool?>> OpenTopic(BoardOpenTopicRequest request);
        Task<ApiCall<BoardCloseTopicRequest, bool?>> CloseTopic(BoardCloseTopicRequest request);
        Task<ApiCall<BoardFixTopicRequest, bool?>> FixTopic(BoardFixTopicRequest request);
        Task<ApiCall<BoardUnfixTopicRequest, bool?>> UnfixTopic(BoardUnfixTopicRequest request);
    }

    public interface IDatabaseApi
    {
        Task<ApiCall<DatabaseGetCountriesRequest, DatabaseGetCountriesResponse>> GetCountries(DatabaseGetCountriesRequest request);
        Task<ApiCall<DatabaseGetRegionsRequest, DatabaseGetRegionsResponse>> GetRegions(DatabaseGetRegionsRequest request);
        Task<ApiCall<DatabaseGetStreetsByIdRequest, IEnumerable<DatabaseStreet>>> GetStreetsById(DatabaseGetStreetsByIdRequest request);
        Task<ApiCall<DatabaseGetCountriesByIdRequest, IEnumerable<BaseCountry>>> GetCountriesById(DatabaseGetCountriesByIdRequest request);
        Task<ApiCall<DatabaseGetCitiesRequest, DatabaseGetCitiesResponse>> GetCities(DatabaseGetCitiesRequest request);
        Task<ApiCall<DatabaseGetCitiesByIdRequest, IEnumerable<BaseObject>>> GetCitiesById(DatabaseGetCitiesByIdRequest request);
        Task<ApiCall<DatabaseGetUniversitiesRequest, DatabaseGetUniversitiesResponse>> GetUniversities(DatabaseGetUniversitiesRequest request);
        Task<ApiCall<DatabaseGetSchoolsRequest, DatabaseGetSchoolsResponse>> GetSchools(DatabaseGetSchoolsRequest request);
        Task<ApiCall<DatabaseGetSchoolClassesRequest, IEnumerable<IEnumerable<string>>>> GetSchoolClasses(DatabaseGetSchoolClassesRequest request);
        Task<ApiCall<DatabaseGetFacultiesRequest, DatabaseGetFacultiesResponse>> GetFaculties(DatabaseGetFacultiesRequest request);
        Task<ApiCall<DatabaseGetChairsRequest, DatabaseGetChairsResponse>> GetChairs(DatabaseGetChairsRequest request);
    }

    public interface IDocsApi
    {
        Task<ApiCall<DocsGetRequest, DocsGetResponse>> Get(DocsGetRequest request);
        Task<ApiCall<DocsGetByIdRequest, IEnumerable<DocsDoc>>> GetById(DocsGetByIdRequest request);
        Task<ApiCall<DocsGetUploadServerRequest, DocsGetUploadServerResponse>> GetUploadServer(DocsGetUploadServerRequest request);
        Task<ApiCall<DocsGetWallUploadServerRequest, DocsGetWallUploadServerResponse>> GetWallUploadServer(DocsGetWallUploadServerRequest request);
        Task<ApiCall<DocsSaveRequest, IEnumerable<DocsDoc>>> Save(DocsSaveRequest request);
        Task<ApiCall<DocsDeleteRequest, bool?>> Delete(DocsDeleteRequest request);
        Task<ApiCall<DocsAddRequest, DocsAddResponse>> Add(DocsAddRequest request);
        Task<ApiCall<DocsGetTypesRequest, DocsGetTypesResponse>> GetTypes(DocsGetTypesRequest request);
        Task<ApiCall<DocsSearchRequest, DocsSearchResponse>> Search(DocsSearchRequest request);
        Task<ApiCall<DocsEditRequest, bool?>> Edit(DocsEditRequest request);
    }

    public interface IFaveApi
    {
        Task<ApiCall<FaveGetUsersRequest, FaveGetUsersResponse>> GetUsers(FaveGetUsersRequest request);
        Task<ApiCall<FaveGetPhotosRequest, FaveGetPhotosResponse>> GetPhotos(FaveGetPhotosRequest request);
        Task<ApiCall<FaveGetPostsRequest, FaveGetPostsResponse>> GetPosts(FaveGetPostsRequest request);
        Task<ApiCall<FaveGetVideosRequest, FaveGetVideosResponse>> GetVideos(FaveGetVideosRequest request);
        Task<ApiCall<FaveGetLinksRequest, FaveGetLinksResponse>> GetLinks(FaveGetLinksRequest request);
        Task<ApiCall<FaveGetMarketItemsRequest, FaveGetMarketItemsResponse>> GetMarketItems(FaveGetMarketItemsRequest request);
        Task<ApiCall<FaveAddUserRequest, bool?>> AddUser(FaveAddUserRequest request);
        Task<ApiCall<FaveRemoveUserRequest, bool?>> RemoveUser(FaveRemoveUserRequest request);
        Task<ApiCall<FaveAddGroupRequest, bool?>> AddGroup(FaveAddGroupRequest request);
        Task<ApiCall<FaveRemoveGroupRequest, bool?>> RemoveGroup(FaveRemoveGroupRequest request);
        Task<ApiCall<FaveAddLinkRequest, bool?>> AddLink(FaveAddLinkRequest request);
        Task<ApiCall<FaveRemoveLinkRequest, bool?>> RemoveLink(FaveRemoveLinkRequest request);
    }

    public interface IFriendsApi
    {
        Task<ApiCall<FriendsGetRequest, FriendsGetResponse>> Get(FriendsGetRequest request);
        Task<ApiCall<FriendsGetRequest, FriendsGetFieldsResponse>> GetFields(FriendsGetRequest request);
        Task<ApiCall<FriendsGetOnlineRequest, IEnumerable<int>>> GetOnline(FriendsGetOnlineRequest request);
        Task<ApiCall<FriendsGetOnlineRequest, FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(FriendsGetOnlineRequest request);
        Task<ApiCall<FriendsGetMutualRequest, IEnumerable<int>>> GetMutual(FriendsGetMutualRequest request);
        Task<ApiCall<FriendsGetRecentRequest, IEnumerable<int>>> GetRecent(FriendsGetRecentRequest request);
        Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsResponse>> GetRequests(FriendsGetRequestsRequest request);
        Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(FriendsGetRequestsRequest request);
        Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsExtendedResponse>> GetRequestsExtended(FriendsGetRequestsRequest request);
        Task<ApiCall<FriendsAddRequest, int?>> Add(FriendsAddRequest request);
        Task<ApiCall<FriendsEditRequest, bool?>> Edit(FriendsEditRequest request);
        Task<ApiCall<FriendsDeleteRequest, FriendsDeleteResponse>> Delete(FriendsDeleteRequest request);
        Task<ApiCall<FriendsGetListsRequest, FriendsGetListsResponse>> GetLists(FriendsGetListsRequest request);
        Task<ApiCall<FriendsAddListRequest, FriendsAddListResponse>> AddList(FriendsAddListRequest request);
        Task<ApiCall<FriendsEditListRequest, bool?>> EditList(FriendsEditListRequest request);
        Task<ApiCall<FriendsDeleteListRequest, bool?>> DeleteList(FriendsDeleteListRequest request);
        Task<ApiCall<FriendsGetAppUsersRequest, IEnumerable<int>>> GetAppUsers(FriendsGetAppUsersRequest request);
        Task<ApiCall<FriendsGetByPhonesRequest, IEnumerable<FriendsUserXtrPhone>>> GetByPhones(FriendsGetByPhonesRequest request);
        Task<ApiCall<FriendsDeleteAllRequestsRequest, bool?>> DeleteAllRequests(FriendsDeleteAllRequestsRequest request);
        Task<ApiCall<FriendsGetSuggestionsRequest, FriendsGetSuggestionsResponse>> GetSuggestions(FriendsGetSuggestionsRequest request);
        Task<ApiCall<FriendsAreFriendsRequest, IEnumerable<FriendsFriendStatus>>> AreFriends(FriendsAreFriendsRequest request);
        Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallResponse>> GetAvailableForCall(FriendsGetAvailableForCallRequest request);
        Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(FriendsGetAvailableForCallRequest request);
        Task<ApiCall<FriendsSearchRequest, FriendsSearchResponse>> Search(FriendsSearchRequest request);
    }

    public interface IGiftsApi
    {
        Task<ApiCall<GiftsGetRequest, GiftsGetResponse>> Get(GiftsGetRequest request);
    }

    public interface IGroupsApi
    {
        Task<ApiCall<GroupsIsMemberRequest, bool?>> IsMember(GroupsIsMemberRequest request);
        Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupsIsMemberRequest request);
        Task<ApiCall<GroupsIsMemberRequest, GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupsIsMemberRequest request);
        Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupsIsMemberRequest request);
        Task<ApiCall<GroupsGetByIdRequest, IEnumerable<GroupsGroupFull>>> GetById(GroupsGetByIdRequest request);
        Task<ApiCall<GroupsGetRequest, GroupsGetResponse>> Get(GroupsGetRequest request);
        Task<ApiCall<GroupsGetRequest, GroupsGetExtendedResponse>> GetExtended(GroupsGetRequest request);
        Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersResponse>> GetMembers(GroupsGetMembersRequest request);
        Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFieldsResponse>> GetMembersFields(GroupsGetMembersRequest request);
        Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFilterResponse>> GetMembersFilter(GroupsGetMembersRequest request);
        Task<ApiCall<GroupsJoinRequest, bool?>> Join(GroupsJoinRequest request);
        Task<ApiCall<GroupsLeaveRequest, bool?>> Leave(GroupsLeaveRequest request);
        Task<ApiCall<GroupsSearchRequest, GroupsSearchResponse>> Search(GroupsSearchRequest request);
        Task<ApiCall<GroupsGetCatalogRequest, GroupsGetCatalogResponse>> GetCatalog(GroupsGetCatalogRequest request);
        Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoResponse>> GetCatalogInfo(GroupsGetCatalogInfoRequest request);
        Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(GroupsGetCatalogInfoRequest request);
        Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesResponse>> GetInvites(GroupsGetInvitesRequest request);
        Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesExtendedResponse>> GetInvitesExtended(GroupsGetInvitesRequest request);
        Task<ApiCall<GroupsGetInvitedUsersRequest, GroupsGetInvitedUsersResponse>> GetInvitedUsers(GroupsGetInvitedUsersRequest request);
        Task<ApiCall<GroupsBanUserRequest, bool?>> BanUser(GroupsBanUserRequest request);
        Task<ApiCall<GroupsUnbanUserRequest, bool?>> UnbanUser(GroupsUnbanUserRequest request);
        Task<ApiCall<GroupsGetBannedRequest, GroupsGetBannedResponse>> GetBanned(GroupsGetBannedRequest request);
        Task<ApiCall<GroupsCreateRequest, GroupsGroup>> Create(GroupsCreateRequest request);
        Task<ApiCall<GroupsEditRequest, bool?>> Edit(GroupsEditRequest request);
        Task<ApiCall<GroupsEditPlaceRequest, GroupsEditPlaceResponse>> EditPlace(GroupsEditPlaceRequest request);
        Task<ApiCall<GroupsGetSettingsRequest, GroupsGroupSettings>> GetSettings(GroupsGetSettingsRequest request);
        Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsResponse>> GetRequests(GroupsGetRequestsRequest request);
        Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsFieldsResponse>> GetRequestsFields(GroupsGetRequestsRequest request);
        Task<ApiCall<GroupsEditManagerRequest, bool?>> EditManager(GroupsEditManagerRequest request);
        Task<ApiCall<GroupsInviteRequest, bool?>> Invite(GroupsInviteRequest request);
        Task<ApiCall<GroupsAddLinkRequest, GroupsGroupLink>> AddLink(GroupsAddLinkRequest request);
        Task<ApiCall<GroupsDeleteLinkRequest, bool?>> DeleteLink(GroupsDeleteLinkRequest request);
        Task<ApiCall<GroupsEditLinkRequest, bool?>> EditLink(GroupsEditLinkRequest request);
        Task<ApiCall<GroupsReorderLinkRequest, bool?>> ReorderLink(GroupsReorderLinkRequest request);
        Task<ApiCall<GroupsRemoveUserRequest, bool?>> RemoveUser(GroupsRemoveUserRequest request);
        Task<ApiCall<GroupsApproveRequestRequest, bool?>> ApproveRequest(GroupsApproveRequestRequest request);
        Task<ApiCall<GroupsGetCallbackConfirmationCodeRequest, GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupsGetCallbackConfirmationCodeRequest request);
        Task<ApiCall<GroupsGetCallbackServerSettingsRequest, GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupsGetCallbackServerSettingsRequest request);
        Task<ApiCall<GroupsGetCallbackSettingsRequest, GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupsGetCallbackSettingsRequest request);
        Task<ApiCall<GroupsSetCallbackServerRequest, GroupsSetCallbackServerResponse>> SetCallbackServer(GroupsSetCallbackServerRequest request);
        Task<ApiCall<GroupsSetCallbackServerSettingsRequest, bool?>> SetCallbackServerSettings(GroupsSetCallbackServerSettingsRequest request);
        Task<ApiCall<GroupsSetCallbackSettingsRequest, bool?>> SetCallbackSettings(GroupsSetCallbackSettingsRequest request);
    }

    public interface ILeadsApi
    {
        Task<ApiCall<LeadsCompleteRequest, LeadsComplete>> Complete(LeadsCompleteRequest request);
        Task<ApiCall<LeadsStartRequest, LeadsStart>> Start(LeadsStartRequest request);
        Task<ApiCall<LeadsGetStatsRequest, LeadsLead>> GetStats(LeadsGetStatsRequest request);
        Task<ApiCall<LeadsGetUsersRequest, IEnumerable<LeadsEntry>>> GetUsers(LeadsGetUsersRequest request);
        Task<ApiCall<LeadsCheckUserRequest, LeadsChecked>> CheckUser(LeadsCheckUserRequest request);
        Task<ApiCall<LeadsMetricHitRequest, LeadsMetricHitResponse>> MetricHit(LeadsMetricHitRequest request);
    }

    public interface ILikesApi
    {
        Task<ApiCall<LikesGetListRequest, LikesGetListResponse>> GetList(LikesGetListRequest request);
        Task<ApiCall<LikesGetListRequest, LikesGetListExtendedResponse>> GetListExtended(LikesGetListRequest request);
        Task<ApiCall<LikesAddRequest, LikesAddResponse>> Add(LikesAddRequest request);
        Task<ApiCall<LikesDeleteRequest, LikesDeleteResponse>> Delete(LikesDeleteRequest request);
        Task<ApiCall<LikesIsLikedRequest, LikesIsLikedResponse>> IsLiked(LikesIsLikedRequest request);
    }

    public interface IMarketApi
    {
        Task<ApiCall<MarketGetRequest, MarketGetResponse>> Get(MarketGetRequest request);
        Task<ApiCall<MarketGetRequest, MarketGetExtendedResponse>> GetExtended(MarketGetRequest request);
        Task<ApiCall<MarketGetByIdRequest, MarketGetByIdResponse>> GetById(MarketGetByIdRequest request);
        Task<ApiCall<MarketGetByIdRequest, MarketGetByIdExtendedResponse>> GetByIdExtended(MarketGetByIdRequest request);
        Task<ApiCall<MarketSearchRequest, MarketSearchResponse>> Search(MarketSearchRequest request);
        Task<ApiCall<MarketSearchRequest, MarketSearchExtendedResponse>> SearchExtended(MarketSearchRequest request);
        Task<ApiCall<MarketGetAlbumsRequest, MarketGetAlbumsResponse>> GetAlbums(MarketGetAlbumsRequest request);
        Task<ApiCall<MarketGetAlbumByIdRequest, MarketGetAlbumByIdResponse>> GetAlbumById(MarketGetAlbumByIdRequest request);
        Task<ApiCall<MarketCreateCommentRequest, int?>> CreateComment(MarketCreateCommentRequest request);
        Task<ApiCall<MarketGetCommentsRequest, MarketGetCommentsResponse>> GetComments(MarketGetCommentsRequest request);
        Task<ApiCall<MarketDeleteCommentRequest, bool?>> DeleteComment(MarketDeleteCommentRequest request);
        Task<ApiCall<MarketRestoreCommentRequest, bool?>> RestoreComment(MarketRestoreCommentRequest request);
        Task<ApiCall<MarketEditCommentRequest, bool?>> EditComment(MarketEditCommentRequest request);
        Task<ApiCall<MarketReportCommentRequest, bool?>> ReportComment(MarketReportCommentRequest request);
        Task<ApiCall<MarketGetCategoriesRequest, MarketGetCategoriesResponse>> GetCategories(MarketGetCategoriesRequest request);
        Task<ApiCall<MarketReportRequest, bool?>> Report(MarketReportRequest request);
        Task<ApiCall<MarketAddRequest, MarketAddResponse>> Add(MarketAddRequest request);
        Task<ApiCall<MarketEditRequest, bool?>> Edit(MarketEditRequest request);
        Task<ApiCall<MarketDeleteRequest, bool?>> Delete(MarketDeleteRequest request);
        Task<ApiCall<MarketRestoreRequest, bool?>> Restore(MarketRestoreRequest request);
        Task<ApiCall<MarketReorderItemsRequest, bool?>> ReorderItems(MarketReorderItemsRequest request);
        Task<ApiCall<MarketReorderAlbumsRequest, bool?>> ReorderAlbums(MarketReorderAlbumsRequest request);
        Task<ApiCall<MarketAddAlbumRequest, MarketAddAlbumResponse>> AddAlbum(MarketAddAlbumRequest request);
        Task<ApiCall<MarketEditAlbumRequest, bool?>> EditAlbum(MarketEditAlbumRequest request);
        Task<ApiCall<MarketDeleteAlbumRequest, bool?>> DeleteAlbum(MarketDeleteAlbumRequest request);
        Task<ApiCall<MarketRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(MarketRemoveFromAlbumRequest request);
        Task<ApiCall<MarketAddToAlbumRequest, bool?>> AddToAlbum(MarketAddToAlbumRequest request);
    }

    public interface IMessagesApi
    {
        Task<ApiCall<MessagesGetRequest, MessagesGetResponse>> Get(MessagesGetRequest request);
        Task<ApiCall<MessagesGetDialogsRequest, MessagesGetDialogsResponse>> GetDialogs(MessagesGetDialogsRequest request);
        Task<ApiCall<MessagesGetByIdRequest, MessagesGetByIdResponse>> GetById(MessagesGetByIdRequest request);
        Task<ApiCall<MessagesSearchRequest, MessagesSearchResponse>> Search(MessagesSearchRequest request);
        Task<ApiCall<MessagesGetHistoryRequest, MessagesGetHistoryResponse>> GetHistory(MessagesGetHistoryRequest request);
        Task<ApiCall<MessagesGetHistoryAttachmentsRequest, MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(MessagesGetHistoryAttachmentsRequest request);
        Task<ApiCall<MessagesSendRequest, int?>> Send(MessagesSendRequest request);
        Task<ApiCall<MessagesDeleteRequest, bool?>> Delete(MessagesDeleteRequest request);
        Task<ApiCall<MessagesDeleteDialogRequest, bool?>> DeleteDialog(MessagesDeleteDialogRequest request);
        Task<ApiCall<MessagesRestoreRequest, bool?>> Restore(MessagesRestoreRequest request);
        Task<ApiCall<MessagesMarkAsReadRequest, bool?>> MarkAsRead(MessagesMarkAsReadRequest request);
        Task<ApiCall<MessagesMarkAsImportantRequest, IEnumerable<int>>> MarkAsImportant(MessagesMarkAsImportantRequest request);
        Task<ApiCall<MessagesGetLongPollServerRequest, MessagesLongpollParams>> GetLongPollServer(MessagesGetLongPollServerRequest request);
        Task<ApiCall<MessagesGetLongPollHistoryRequest, MessagesGetLongPollHistoryResponse>> GetLongPollHistory(MessagesGetLongPollHistoryRequest request);
        Task<ApiCall<MessagesGetChatRequest, MessagesChat>> GetChat(MessagesGetChatRequest request);
        Task<ApiCall<MessagesGetChatRequest, MessagesChatFull>> GetChatFields(MessagesGetChatRequest request);
        Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChat>>> GetChatChatIds(MessagesGetChatRequest request);
        Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(MessagesGetChatRequest request);
        Task<ApiCall<MessagesCreateChatRequest, int?>> CreateChat(MessagesCreateChatRequest request);
        Task<ApiCall<MessagesEditChatRequest, bool?>> EditChat(MessagesEditChatRequest request);
        Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsers(MessagesGetChatUsersRequest request);
        Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(MessagesGetChatUsersRequest request);
        Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIds(MessagesGetChatUsersRequest request);
        Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIdsFields(MessagesGetChatUsersRequest request);
        Task<ApiCall<MessagesSetActivityRequest, bool?>> SetActivity(MessagesSetActivityRequest request);
        Task<ApiCall<MessagesSearchDialogsRequest, string>> SearchDialogs(MessagesSearchDialogsRequest request);
        Task<ApiCall<MessagesAddChatUserRequest, bool?>> AddChatUser(MessagesAddChatUserRequest request);
        Task<ApiCall<MessagesRemoveChatUserRequest, bool?>> RemoveChatUser(MessagesRemoveChatUserRequest request);
        Task<ApiCall<MessagesGetLastActivityRequest, MessagesLastActivity>> GetLastActivity(MessagesGetLastActivityRequest request);
        Task<ApiCall<MessagesSetChatPhotoRequest, MessagesSetChatPhotoResponse>> SetChatPhoto(MessagesSetChatPhotoRequest request);
        Task<ApiCall<MessagesDeleteChatPhotoRequest, MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(MessagesDeleteChatPhotoRequest request);
        Task<ApiCall<MessagesDenyMessagesFromGroupRequest, bool?>> DenyMessagesFromGroup(MessagesDenyMessagesFromGroupRequest request);
        Task<ApiCall<MessagesAllowMessagesFromGroupRequest, bool?>> AllowMessagesFromGroup(MessagesAllowMessagesFromGroupRequest request);
        Task<ApiCall<MessagesIsMessagesFromGroupAllowedRequest, MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(MessagesIsMessagesFromGroupAllowedRequest request);
    }

    public interface INewsfeedApi
    {
        Task<ApiCall<NewsfeedGetRequest, NewsfeedGetResponse>> Get(NewsfeedGetRequest request);
        Task<ApiCall<NewsfeedGetRecommendedRequest, NewsfeedGetRecommendedResponse>> GetRecommended(NewsfeedGetRecommendedRequest request);
        Task<ApiCall<NewsfeedGetCommentsRequest, NewsfeedGetCommentsResponse>> GetComments(NewsfeedGetCommentsRequest request);
        Task<ApiCall<NewsfeedGetMentionsRequest, NewsfeedGetMentionsResponse>> GetMentions(NewsfeedGetMentionsRequest request);
        Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedResponse>> GetBanned(NewsfeedGetBannedRequest request);
        Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedExtendedResponse>> GetBannedExtended(NewsfeedGetBannedRequest request);
        Task<ApiCall<NewsfeedAddBanRequest, bool?>> AddBan(NewsfeedAddBanRequest request);
        Task<ApiCall<NewsfeedDeleteBanRequest, bool?>> DeleteBan(NewsfeedDeleteBanRequest request);
        Task<ApiCall<NewsfeedIgnoreItemRequest, bool?>> IgnoreItem(NewsfeedIgnoreItemRequest request);
        Task<ApiCall<NewsfeedUnignoreItemRequest, bool?>> UnignoreItem(NewsfeedUnignoreItemRequest request);
        Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchResponse>> Search(NewsfeedSearchRequest request);
        Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchExtendedResponse>> SearchExtended(NewsfeedSearchRequest request);
        Task<ApiCall<NewsfeedGetListsRequest, NewsfeedGetListsResponse>> GetLists(NewsfeedGetListsRequest request);
        Task<ApiCall<NewsfeedSaveListRequest, int?>> SaveList(NewsfeedSaveListRequest request);
        Task<ApiCall<NewsfeedDeleteListRequest, bool?>> DeleteList(NewsfeedDeleteListRequest request);
        Task<ApiCall<NewsfeedUnsubscribeRequest, bool?>> Unsubscribe(NewsfeedUnsubscribeRequest request);
        Task<ApiCall<NewsfeedGetSuggestedSourcesRequest, NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(NewsfeedGetSuggestedSourcesRequest request);
    }

    public interface INotesApi
    {
        Task<ApiCall<NotesGetRequest, NotesGetResponse>> Get(NotesGetRequest request);
        Task<ApiCall<NotesGetByIdRequest, NotesNote>> GetById(NotesGetByIdRequest request);
        Task<ApiCall<NotesAddRequest, int?>> Add(NotesAddRequest request);
        Task<ApiCall<NotesEditRequest, bool?>> Edit(NotesEditRequest request);
        Task<ApiCall<NotesDeleteRequest, bool?>> Delete(NotesDeleteRequest request);
        Task<ApiCall<NotesGetCommentsRequest, NotesGetCommentsResponse>> GetComments(NotesGetCommentsRequest request);
        Task<ApiCall<NotesCreateCommentRequest, int?>> CreateComment(NotesCreateCommentRequest request);
        Task<ApiCall<NotesEditCommentRequest, bool?>> EditComment(NotesEditCommentRequest request);
        Task<ApiCall<NotesDeleteCommentRequest, bool?>> DeleteComment(NotesDeleteCommentRequest request);
        Task<ApiCall<NotesRestoreCommentRequest, bool?>> RestoreComment(NotesRestoreCommentRequest request);
    }

    public interface INotificationsApi
    {
        Task<ApiCall<NotificationsGetRequest, NotificationsGetResponse>> Get(NotificationsGetRequest request);
        Task<ApiCall<NotificationsMarkAsViewedRequest, bool?>> MarkAsViewed(NotificationsMarkAsViewedRequest request);
    }

    public interface IOrdersApi
    {
        Task<ApiCall<OrdersGetRequest, IEnumerable<OrdersOrder>>> Get(OrdersGetRequest request);
        Task<ApiCall<OrdersGetByIdRequest, IEnumerable<OrdersOrder>>> GetById(OrdersGetByIdRequest request);
        Task<ApiCall<OrdersChangeStateRequest, string>> ChangeState(OrdersChangeStateRequest request);
        Task<ApiCall<OrdersGetAmountRequest, OrdersAmount>> GetAmount(OrdersGetAmountRequest request);
    }

    public interface IPagesApi
    {
        Task<ApiCall<PagesGetRequest, PagesWikipageFull>> Get(PagesGetRequest request);
        Task<ApiCall<PagesSaveRequest, int?>> Save(PagesSaveRequest request);
        Task<ApiCall<PagesSaveAccessRequest, int?>> SaveAccess(PagesSaveAccessRequest request);
        Task<ApiCall<PagesGetHistoryRequest, IEnumerable<PagesWikipageVersion>>> GetHistory(PagesGetHistoryRequest request);
        Task<ApiCall<PagesGetTitlesRequest, IEnumerable<PagesWikipage>>> GetTitles(PagesGetTitlesRequest request);
        Task<ApiCall<PagesGetVersionRequest, PagesWikipageFull>> GetVersion(PagesGetVersionRequest request);
        Task<ApiCall<PagesParseWikiRequest, string>> ParseWiki(PagesParseWikiRequest request);
        Task<ApiCall<PagesClearCacheRequest, bool?>> ClearCache(PagesClearCacheRequest request);
    }

    public interface IPhotosApi
    {
        Task<ApiCall<PhotosCreateAlbumRequest, PhotosPhotoAlbumFull>> CreateAlbum(PhotosCreateAlbumRequest request);
        Task<ApiCall<PhotosEditAlbumRequest, bool?>> EditAlbum(PhotosEditAlbumRequest request);
        Task<ApiCall<PhotosGetAlbumsRequest, PhotosGetAlbumsResponse>> GetAlbums(PhotosGetAlbumsRequest request);
        Task<ApiCall<PhotosGetRequest, PhotosGetResponse>> Get(PhotosGetRequest request);
        Task<ApiCall<PhotosGetRequest, PhotosGetExtendedResponse>> GetExtended(PhotosGetRequest request);
        Task<ApiCall<PhotosGetAlbumsCountRequest, int?>> GetAlbumsCount(PhotosGetAlbumsCountRequest request);
        Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhoto>>> GetById(PhotosGetByIdRequest request);
        Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhotoFull>>> GetByIdExtended(PhotosGetByIdRequest request);
        Task<ApiCall<PhotosGetUploadServerRequest, PhotosPhotoUpload>> GetUploadServer(PhotosGetUploadServerRequest request);
        Task<ApiCall<PhotosGetOwnerPhotoUploadServerRequest, PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(PhotosGetOwnerPhotoUploadServerRequest request);
        Task<ApiCall<PhotosGetChatUploadServerRequest, PhotosGetChatUploadServerResponse>> GetChatUploadServer(PhotosGetChatUploadServerRequest request);
        Task<ApiCall<PhotosGetMarketUploadServerRequest, PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(PhotosGetMarketUploadServerRequest request);
        Task<ApiCall<PhotosGetMarketAlbumUploadServerRequest, PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(PhotosGetMarketAlbumUploadServerRequest request);
        Task<ApiCall<PhotosSaveMarketPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketPhoto(PhotosSaveMarketPhotoRequest request);
        Task<ApiCall<PhotosSaveMarketAlbumPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(PhotosSaveMarketAlbumPhotoRequest request);
        Task<ApiCall<PhotosSaveOwnerPhotoRequest, PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(PhotosSaveOwnerPhotoRequest request);
        Task<ApiCall<PhotosSaveWallPhotoRequest, IEnumerable<PhotosPhoto>>> SaveWallPhoto(PhotosSaveWallPhotoRequest request);
        Task<ApiCall<PhotosGetWallUploadServerRequest, PhotosPhotoUpload>> GetWallUploadServer(PhotosGetWallUploadServerRequest request);
        Task<ApiCall<PhotosGetMessagesUploadServerRequest, PhotosPhotoUpload>> GetMessagesUploadServer(PhotosGetMessagesUploadServerRequest request);
        Task<ApiCall<PhotosSaveMessagesPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(PhotosSaveMessagesPhotoRequest request);
        Task<ApiCall<PhotosReportRequest, bool?>> Report(PhotosReportRequest request);
        Task<ApiCall<PhotosReportCommentRequest, bool?>> ReportComment(PhotosReportCommentRequest request);
        Task<ApiCall<PhotosSearchRequest, PhotosSearchResponse>> Search(PhotosSearchRequest request);
        Task<ApiCall<PhotosSaveRequest, IEnumerable<PhotosPhoto>>> Save(PhotosSaveRequest request);
        Task<ApiCall<PhotosCopyRequest, int?>> Copy(PhotosCopyRequest request);
        Task<ApiCall<PhotosEditRequest, bool?>> Edit(PhotosEditRequest request);
        Task<ApiCall<PhotosMoveRequest, bool?>> Move(PhotosMoveRequest request);
        Task<ApiCall<PhotosMakeCoverRequest, bool?>> MakeCover(PhotosMakeCoverRequest request);
        Task<ApiCall<PhotosReorderAlbumsRequest, bool?>> ReorderAlbums(PhotosReorderAlbumsRequest request);
        Task<ApiCall<PhotosReorderPhotosRequest, bool?>> ReorderPhotos(PhotosReorderPhotosRequest request);
        Task<ApiCall<PhotosGetAllRequest, PhotosGetAllResponse>> GetAll(PhotosGetAllRequest request);
        Task<ApiCall<PhotosGetAllRequest, PhotosGetAllExtendedResponse>> GetAllExtended(PhotosGetAllRequest request);
        Task<ApiCall<PhotosGetUserPhotosRequest, PhotosGetUserPhotosResponse>> GetUserPhotos(PhotosGetUserPhotosRequest request);
        Task<ApiCall<PhotosDeleteAlbumRequest, bool?>> DeleteAlbum(PhotosDeleteAlbumRequest request);
        Task<ApiCall<PhotosDeleteRequest, bool?>> Delete(PhotosDeleteRequest request);
        Task<ApiCall<PhotosRestoreRequest, bool?>> Restore(PhotosRestoreRequest request);
        Task<ApiCall<PhotosConfirmTagRequest, bool?>> ConfirmTag(PhotosConfirmTagRequest request);
        Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsResponse>> GetComments(PhotosGetCommentsRequest request);
        Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsExtendedResponse>> GetCommentsExtended(PhotosGetCommentsRequest request);
        Task<ApiCall<PhotosGetAllCommentsRequest, PhotosGetAllCommentsResponse>> GetAllComments(PhotosGetAllCommentsRequest request);
        Task<ApiCall<PhotosCreateCommentRequest, int?>> CreateComment(PhotosCreateCommentRequest request);
        Task<ApiCall<PhotosDeleteCommentRequest, bool?>> DeleteComment(PhotosDeleteCommentRequest request);
        Task<ApiCall<PhotosRestoreCommentRequest, bool?>> RestoreComment(PhotosRestoreCommentRequest request);
        Task<ApiCall<PhotosEditCommentRequest, bool?>> EditComment(PhotosEditCommentRequest request);
        Task<ApiCall<PhotosGetTagsRequest, IEnumerable<PhotosPhotoTag>>> GetTags(PhotosGetTagsRequest request);
        Task<ApiCall<PhotosPutTagRequest, int?>> PutTag(PhotosPutTagRequest request);
        Task<ApiCall<PhotosRemoveTagRequest, bool?>> RemoveTag(PhotosRemoveTagRequest request);
        Task<ApiCall<PhotosGetNewTagsRequest, PhotosGetNewTagsResponse>> GetNewTags(PhotosGetNewTagsRequest request);
    }

    public interface IPlacesApi
    {
        Task<ApiCall<PlacesAddRequest, PlacesAddResponse>> Add(PlacesAddRequest request);
        Task<ApiCall<PlacesGetByIdRequest, IEnumerable<PlacesPlaceMin>>> GetById(PlacesGetByIdRequest request);
        Task<ApiCall<PlacesSearchRequest, PlacesSearchResponse>> Search(PlacesSearchRequest request);
        Task<ApiCall<PlacesCheckinRequest, PlacesCheckinResponse>> Checkin(PlacesCheckinRequest request);
        Task<ApiCall<PlacesGetCheckinsRequest, PlacesGetCheckinsResponse>> GetCheckins(PlacesGetCheckinsRequest request);
        Task<ApiCall<PlacesGetTypesRequest, IEnumerable<PlacesTypes>>> GetTypes(PlacesGetTypesRequest request);
    }

    public interface IPollsApi
    {
        Task<ApiCall<PollsGetByIdRequest, PollsPoll>> GetById(PollsGetByIdRequest request);
        Task<ApiCall<PollsAddVoteRequest, bool?>> AddVote(PollsAddVoteRequest request);
        Task<ApiCall<PollsDeleteVoteRequest, bool?>> DeleteVote(PollsDeleteVoteRequest request);
        Task<ApiCall<PollsGetVotersRequest, IEnumerable<PollsVoters>>> GetVoters(PollsGetVotersRequest request);
        Task<ApiCall<PollsCreateRequest, PollsPoll>> Create(PollsCreateRequest request);
        Task<ApiCall<PollsEditRequest, bool?>> Edit(PollsEditRequest request);
    }

    public interface ISearchApi
    {
        Task<ApiCall<SearchGetHintsRequest, IEnumerable<SearchHint>>> GetHints(SearchGetHintsRequest request);
    }

    public interface ISecureApi
    {
        Task<ApiCall<SecureGetAppBalanceRequest, int?>> GetAppBalance(SecureGetAppBalanceRequest request);
        Task<ApiCall<SecureGetTransactionsHistoryRequest, IEnumerable<SecureTransaction>>> GetTransactionsHistory(SecureGetTransactionsHistoryRequest request);
        Task<ApiCall<SecureGetSMSHistoryRequest, IEnumerable<SecureSmsNotification>>> GetSMSHistory(SecureGetSMSHistoryRequest request);
        Task<ApiCall<SecureSendSMSNotificationRequest, bool?>> SendSMSNotification(SecureSendSMSNotificationRequest request);
        Task<ApiCall<SecureSendNotificationRequest, IEnumerable<int>>> SendNotification(SecureSendNotificationRequest request);
        Task<ApiCall<SecureSetCounterRequest, bool?>> SetCounter(SecureSetCounterRequest request);
        Task<ApiCall<SecureSetUserLevelRequest, bool?>> SetUserLevel(SecureSetUserLevelRequest request);
        Task<ApiCall<SecureGetUserLevelRequest, IEnumerable<SecureLevel>>> GetUserLevel(SecureGetUserLevelRequest request);
        Task<ApiCall<SecureAddAppEventRequest, bool?>> AddAppEvent(SecureAddAppEventRequest request);
        Task<ApiCall<SecureCheckTokenRequest, SecureTokenChecked>> CheckToken(SecureCheckTokenRequest request);
    }

    public interface IStatsApi
    {
        Task<ApiCall<StatsGetRequest, IEnumerable<StatsPeriod>>> Get(StatsGetRequest request);
        Task<ApiCall<StatsTrackVisitorRequest, bool?>> TrackVisitor(StatsTrackVisitorRequest request);
        Task<ApiCall<StatsGetPostReachRequest, IEnumerable<StatsWallpostStat>>> GetPostReach(StatsGetPostReachRequest request);
    }

    public interface IStatusApi
    {
        Task<ApiCall<StatusGetRequest, StatusStatus>> Get(StatusGetRequest request);
        Task<ApiCall<StatusSetRequest, bool?>> Set(StatusSetRequest request);
    }

    public interface IStorageApi
    {
        Task<ApiCall<StorageGetRequest, string>> Get(StorageGetRequest request);
        Task<ApiCall<StorageSetRequest, bool?>> Set(StorageSetRequest request);
        Task<ApiCall<StorageGetKeysRequest, IEnumerable<string>>> GetKeys(StorageGetKeysRequest request);
    }

    public interface IUsersApi
    {
        Task<ApiCall<UsersGetRequest, IEnumerable<UsersUserXtrCounters>>> Get(UsersGetRequest request);
        Task<ApiCall<UsersSearchRequest, UsersSearchResponse>> Search(UsersSearchRequest request);
        Task<ApiCall<UsersIsAppUserRequest, bool?>> IsAppUser(UsersIsAppUserRequest request);
        Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsResponse>> GetSubscriptions(UsersGetSubscriptionsRequest request);
        Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UsersGetSubscriptionsRequest request);
        Task<ApiCall<UsersGetFollowersRequest, UsersGetFollowersResponse>> GetFollowers(UsersGetFollowersRequest request);
        Task<ApiCall<UsersReportRequest, bool?>> Report(UsersReportRequest request);
        Task<ApiCall<UsersGetNearbyRequest, UsersGetNearbyResponse>> GetNearby(UsersGetNearbyRequest request);
    }

    public interface IUtilsApi
    {
        Task<ApiCall<UtilsCheckLinkRequest, UtilsLinkChecked>> CheckLink(UtilsCheckLinkRequest request);
        Task<ApiCall<UtilsResolveScreenNameRequest, UtilsDomainResolved>> ResolveScreenName(UtilsResolveScreenNameRequest request);
        Task<ApiCall<UtilsGetServerTimeRequest, int?>> GetServerTime(UtilsGetServerTimeRequest request);
    }

    public interface IVideoApi
    {
        Task<ApiCall<VideoGetRequest, VideoGetResponse>> Get(VideoGetRequest request);
        Task<ApiCall<VideoGetRequest, VideoGetExtendedResponse>> GetExtended(VideoGetRequest request);
        Task<ApiCall<VideoEditRequest, bool?>> Edit(VideoEditRequest request);
        Task<ApiCall<VideoAddRequest, bool?>> Add(VideoAddRequest request);
        Task<ApiCall<VideoSaveRequest, VideoSaveResult>> Save(VideoSaveRequest request);
        Task<ApiCall<VideoDeleteRequest, bool?>> Delete(VideoDeleteRequest request);
        Task<ApiCall<VideoRestoreRequest, bool?>> Restore(VideoRestoreRequest request);
        Task<ApiCall<VideoSearchRequest, VideoSearchResponse>> Search(VideoSearchRequest request);
        Task<ApiCall<VideoSearchRequest, VideoSearchExtendedResponse>> SearchExtended(VideoSearchRequest request);
        Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosResponse>> GetUserVideos(VideoGetUserVideosRequest request);
        Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(VideoGetUserVideosRequest request);
        Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsResponse>> GetAlbums(VideoGetAlbumsRequest request);
        Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(VideoGetAlbumsRequest request);
        Task<ApiCall<VideoGetAlbumByIdRequest, VideoVideoAlbumFull>> GetAlbumById(VideoGetAlbumByIdRequest request);
        Task<ApiCall<VideoAddAlbumRequest, VideoAddAlbumResponse>> AddAlbum(VideoAddAlbumRequest request);
        Task<ApiCall<VideoEditAlbumRequest, bool?>> EditAlbum(VideoEditAlbumRequest request);
        Task<ApiCall<VideoDeleteAlbumRequest, bool?>> DeleteAlbum(VideoDeleteAlbumRequest request);
        Task<ApiCall<VideoReorderAlbumsRequest, bool?>> ReorderAlbums(VideoReorderAlbumsRequest request);
        Task<ApiCall<VideoReorderVideosRequest, bool?>> ReorderVideos(VideoReorderVideosRequest request);
        Task<ApiCall<VideoAddToAlbumRequest, bool?>> AddToAlbum(VideoAddToAlbumRequest request);
        Task<ApiCall<VideoRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(VideoRemoveFromAlbumRequest request);
        Task<ApiCall<VideoGetAlbumsByVideoRequest, IEnumerable<int>>> GetAlbumsByVideo(VideoGetAlbumsByVideoRequest request);
        Task<ApiCall<VideoGetAlbumsByVideoRequest, VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(VideoGetAlbumsByVideoRequest request);
        Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsResponse>> GetComments(VideoGetCommentsRequest request);
        Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsExtendedResponse>> GetCommentsExtended(VideoGetCommentsRequest request);
        Task<ApiCall<VideoCreateCommentRequest, int?>> CreateComment(VideoCreateCommentRequest request);
        Task<ApiCall<VideoDeleteCommentRequest, bool?>> DeleteComment(VideoDeleteCommentRequest request);
        Task<ApiCall<VideoRestoreCommentRequest, bool?>> RestoreComment(VideoRestoreCommentRequest request);
        Task<ApiCall<VideoEditCommentRequest, bool?>> EditComment(VideoEditCommentRequest request);
        Task<ApiCall<VideoGetTagsRequest, IEnumerable<VideoVideoTag>>> GetTags(VideoGetTagsRequest request);
        Task<ApiCall<VideoPutTagRequest, int?>> PutTag(VideoPutTagRequest request);
        Task<ApiCall<VideoRemoveTagRequest, bool?>> RemoveTag(VideoRemoveTagRequest request);
        Task<ApiCall<VideoGetNewTagsRequest, VideoGetNewTagsResponse>> GetNewTags(VideoGetNewTagsRequest request);
        Task<ApiCall<VideoReportRequest, bool?>> Report(VideoReportRequest request);
        Task<ApiCall<VideoReportCommentRequest, bool?>> ReportComment(VideoReportCommentRequest request);
        Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogResponse>> GetCatalog(VideoGetCatalogRequest request);
        Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogExtendedResponse>> GetCatalogExtended(VideoGetCatalogRequest request);
        Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionResponse>> GetCatalogSection(VideoGetCatalogSectionRequest request);
        Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(VideoGetCatalogSectionRequest request);
        Task<ApiCall<VideoHideCatalogSectionRequest, bool?>> HideCatalogSection(VideoHideCatalogSectionRequest request);
    }

    public interface IWallApi
    {
        Task<ApiCall<WallGetRequest, WallGetResponse>> Get(WallGetRequest request);
        Task<ApiCall<WallGetRequest, WallGetExtendedResponse>> GetExtended(WallGetRequest request);
        Task<ApiCall<WallSearchRequest, WallSearchResponse>> Search(WallSearchRequest request);
        Task<ApiCall<WallSearchRequest, WallSearchExtendedResponse>> SearchExtended(WallSearchRequest request);
        Task<ApiCall<WallGetByIdRequest, IEnumerable<WallWallpostFull>>> GetById(WallGetByIdRequest request);
        Task<ApiCall<WallGetByIdRequest, WallGetByIdExtendedResponse>> GetByIdExtended(WallGetByIdRequest request);
        Task<ApiCall<WallPostRequest, WallPostResponse>> Post(WallPostRequest request);
        Task<ApiCall<WallRepostRequest, WallRepostResponse>> Repost(WallRepostRequest request);
        Task<ApiCall<WallGetRepostsRequest, WallGetRepostsResponse>> GetReposts(WallGetRepostsRequest request);
        Task<ApiCall<WallEditRequest, bool?>> Edit(WallEditRequest request);
        Task<ApiCall<WallDeleteRequest, bool?>> Delete(WallDeleteRequest request);
        Task<ApiCall<WallRestoreRequest, bool?>> Restore(WallRestoreRequest request);
        Task<ApiCall<WallPinRequest, bool?>> Pin(WallPinRequest request);
        Task<ApiCall<WallUnpinRequest, bool?>> Unpin(WallUnpinRequest request);
        Task<ApiCall<WallGetCommentsRequest, WallGetCommentsResponse>> GetComments(WallGetCommentsRequest request);
        Task<ApiCall<WallGetCommentsRequest, WallGetCommentsExtendedResponse>> GetCommentsExtended(WallGetCommentsRequest request);
        Task<ApiCall<WallCreateCommentRequest, WallCreateCommentResponse>> CreateComment(WallCreateCommentRequest request);
        Task<ApiCall<WallEditCommentRequest, bool?>> EditComment(WallEditCommentRequest request);
        Task<ApiCall<WallDeleteCommentRequest, bool?>> DeleteComment(WallDeleteCommentRequest request);
        Task<ApiCall<WallRestoreCommentRequest, bool?>> RestoreComment(WallRestoreCommentRequest request);
        Task<ApiCall<WallReportPostRequest, bool?>> ReportPost(WallReportPostRequest request);
        Task<ApiCall<WallReportCommentRequest, bool?>> ReportComment(WallReportCommentRequest request);
    }

    public interface IWidgetsApi
    {
        Task<ApiCall<WidgetsGetCommentsRequest, WidgetsGetCommentsResponse>> GetComments(WidgetsGetCommentsRequest request);
        Task<ApiCall<WidgetsGetPagesRequest, WidgetsGetPagesResponse>> GetPages(WidgetsGetPagesRequest request);
    }
}