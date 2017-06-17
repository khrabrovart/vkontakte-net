using System.Collections.Generic;
using System.Threading.Tasks;
using Citrina.StandardApi.Core;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi
{
    internal class AccountApi : IAccountApi
    {
        public Task<ApiCall<AccountGetCountersRequest, AccountAccountCounters>> GetCounters(AccountGetCountersRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetCountersRequest, AccountAccountCounters>("account.getCounters", request);
        }

        public Task<ApiCall<AccountSetNameInMenuRequest, bool?>> SetNameInMenu(AccountSetNameInMenuRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetNameInMenuRequest, bool?>("account.setNameInMenu", request);
        }

        public Task<ApiCall<AccountSetOnlineRequest, bool?>> SetOnline(AccountSetOnlineRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetOnlineRequest, bool?>("account.setOnline", request);
        }

        public Task<ApiCall<AccountSetOfflineRequest, bool?>> SetOffline(AccountSetOfflineRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetOfflineRequest, bool?>("account.setOffline", request);
        }

        public Task<ApiCall<AccountLookupContactsRequest, AccountLookupResult>> LookupContacts(AccountLookupContactsRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountLookupContactsRequest, AccountLookupResult>("account.lookupContacts", request);
        }

        public Task<ApiCall<AccountRegisterDeviceRequest, bool?>> RegisterDevice(AccountRegisterDeviceRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountRegisterDeviceRequest, bool?>("account.registerDevice", request);
        }

        public Task<ApiCall<AccountUnregisterDeviceRequest, bool?>> UnregisterDevice(AccountUnregisterDeviceRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountUnregisterDeviceRequest, bool?>("account.unregisterDevice", request);
        }

        public Task<ApiCall<AccountSetSilenceModeRequest, bool?>> SetSilenceMode(AccountSetSilenceModeRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetSilenceModeRequest, bool?>("account.setSilenceMode", request);
        }

        public Task<ApiCall<AccountGetPushSettingsRequest, AccountPushSettings>> GetPushSettings(AccountGetPushSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetPushSettingsRequest, AccountPushSettings>("account.getPushSettings", request);
        }

        public Task<ApiCall<AccountSetPushSettingsRequest, bool?>> SetPushSettings(AccountSetPushSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetPushSettingsRequest, bool?>("account.setPushSettings", request);
        }

        public Task<ApiCall<AccountGetAppPermissionsRequest, int?>> GetAppPermissions(AccountGetAppPermissionsRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetAppPermissionsRequest, int?>("account.getAppPermissions", request);
        }

        public Task<ApiCall<AccountGetActiveOffersRequest, AccountGetActiveOffersResponse>> GetActiveOffers(AccountGetActiveOffersRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetActiveOffersRequest, AccountGetActiveOffersResponse>("account.getActiveOffers", request);
        }

        public Task<ApiCall<AccountBanUserRequest, bool?>> BanUser(AccountBanUserRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountBanUserRequest, bool?>("account.banUser", request);
        }

        public Task<ApiCall<AccountUnbanUserRequest, bool?>> UnbanUser(AccountUnbanUserRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountUnbanUserRequest, bool?>("account.unbanUser", request);
        }

        public Task<ApiCall<AccountGetBannedRequest, AccountGetBannedResponse>> GetBanned(AccountGetBannedRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetBannedRequest, AccountGetBannedResponse>("account.getBanned", request);
        }

        public Task<ApiCall<AccountGetInfoRequest, AccountInfo>> GetInfo(AccountGetInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetInfoRequest, AccountInfo>("account.getInfo", request);
        }

        public Task<ApiCall<AccountSetInfoRequest, bool?>> SetInfo(AccountSetInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSetInfoRequest, bool?>("account.setInfo", request);
        }

        public Task<ApiCall<AccountChangePasswordRequest, AccountChangePasswordResponse>> ChangePassword(AccountChangePasswordRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountChangePasswordRequest, AccountChangePasswordResponse>("account.changePassword", request);
        }

        public Task<ApiCall<AccountGetProfileInfoRequest, AccountUserSettings>> GetProfileInfo(AccountGetProfileInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountGetProfileInfoRequest, AccountUserSettings>("account.getProfileInfo", request);
        }

        public Task<ApiCall<AccountSaveProfileInfoRequest, AccountSaveProfileInfoResponse>> SaveProfileInfo(AccountSaveProfileInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<AccountSaveProfileInfoRequest, AccountSaveProfileInfoResponse>("account.saveProfileInfo", request);
        }
    }

    internal class AdsApi : IAdsApi
    {
        public Task<ApiCall<AdsGetAccountsRequest, IEnumerable<AdsAccount>>> GetAccounts(AdsGetAccountsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetAccountsRequest, IEnumerable<AdsAccount>>("ads.getAccounts", request);
        }

        public Task<ApiCall<AdsGetClientsRequest, IEnumerable<AdsClient>>> GetClients(AdsGetClientsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetClientsRequest, IEnumerable<AdsClient>>("ads.getClients", request);
        }

        public Task<ApiCall<AdsCreateClientsRequest, IEnumerable<int>>> CreateClients(AdsCreateClientsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsCreateClientsRequest, IEnumerable<int>>("ads.createClients", request);
        }

        public Task<ApiCall<AdsUpdateClientsRequest, int?>> UpdateClients(AdsUpdateClientsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsUpdateClientsRequest, int?>("ads.updateClients", request);
        }

        public Task<ApiCall<AdsDeleteClientsRequest, int?>> DeleteClients(AdsDeleteClientsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsDeleteClientsRequest, int?>("ads.deleteClients", request);
        }

        public Task<ApiCall<AdsGetCampaignsRequest, IEnumerable<AdsCampaign>>> GetCampaigns(AdsGetCampaignsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetCampaignsRequest, IEnumerable<AdsCampaign>>("ads.getCampaigns", request);
        }

        public Task<ApiCall<AdsCreateCampaignsRequest, IEnumerable<int>>> CreateCampaigns(AdsCreateCampaignsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsCreateCampaignsRequest, IEnumerable<int>>("ads.createCampaigns", request);
        }

        public Task<ApiCall<AdsUpdateCampaignsRequest, int?>> UpdateCampaigns(AdsUpdateCampaignsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsUpdateCampaignsRequest, int?>("ads.updateCampaigns", request);
        }

        public Task<ApiCall<AdsDeleteCampaignsRequest, int?>> DeleteCampaigns(AdsDeleteCampaignsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsDeleteCampaignsRequest, int?>("ads.deleteCampaigns", request);
        }

        public Task<ApiCall<AdsGetAdsRequest, IEnumerable<AdsAd>>> GetAds(AdsGetAdsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetAdsRequest, IEnumerable<AdsAd>>("ads.getAds", request);
        }

        public Task<ApiCall<AdsGetAdsLayoutRequest, IEnumerable<AdsAdLayout>>> GetAdsLayout(AdsGetAdsLayoutRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetAdsLayoutRequest, IEnumerable<AdsAdLayout>>("ads.getAdsLayout", request);
        }

        public Task<ApiCall<AdsGetAdsTargetingRequest, IEnumerable<AdsTargSettings>>> GetAdsTargeting(AdsGetAdsTargetingRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetAdsTargetingRequest, IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", request);
        }

        public Task<ApiCall<AdsCreateAdsRequest, IEnumerable<int>>> CreateAds(AdsCreateAdsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsCreateAdsRequest, IEnumerable<int>>("ads.createAds", request);
        }

        public Task<ApiCall<AdsUpdateAdsRequest, IEnumerable<int>>> UpdateAds(AdsUpdateAdsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsUpdateAdsRequest, IEnumerable<int>>("ads.updateAds", request);
        }

        public Task<ApiCall<AdsDeleteAdsRequest, IEnumerable<int>>> DeleteAds(AdsDeleteAdsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsDeleteAdsRequest, IEnumerable<int>>("ads.deleteAds", request);
        }

        public Task<ApiCall<AdsCheckLinkRequest, AdsLinkStatus>> CheckLink(AdsCheckLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsCheckLinkRequest, AdsLinkStatus>("ads.checkLink", request);
        }

        public Task<ApiCall<AdsGetStatisticsRequest, IEnumerable<AdsStats>>> GetStatistics(AdsGetStatisticsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetStatisticsRequest, IEnumerable<AdsStats>>("ads.getStatistics", request);
        }

        public Task<ApiCall<AdsGetDemographicsRequest, IEnumerable<AdsDemoStats>>> GetDemographics(AdsGetDemographicsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetDemographicsRequest, IEnumerable<AdsDemoStats>>("ads.getDemographics", request);
        }

        public Task<ApiCall<AdsGetAdsPostsReachRequest, IEnumerable<AdsPostStats>>> GetAdsPostsReach(AdsGetAdsPostsReachRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetAdsPostsReachRequest, IEnumerable<AdsPostStats>>("ads.getAdsPostsReach", request);
        }

        public Task<ApiCall<AdsGetBudgetRequest, int?>> GetBudget(AdsGetBudgetRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetBudgetRequest, int?>("ads.getBudget", request);
        }

        public Task<ApiCall<AdsGetOfficeUsersRequest, IEnumerable<AdsUsers>>> GetOfficeUsers(AdsGetOfficeUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetOfficeUsersRequest, IEnumerable<AdsUsers>>("ads.getOfficeUsers", request);
        }

        public Task<ApiCall<AdsAddOfficeUsersRequest, bool?>> AddOfficeUsers(AdsAddOfficeUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsAddOfficeUsersRequest, bool?>("ads.addOfficeUsers", request);
        }

        public Task<ApiCall<AdsRemoveOfficeUsersRequest, bool?>> RemoveOfficeUsers(AdsRemoveOfficeUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsRemoveOfficeUsersRequest, bool?>("ads.removeOfficeUsers", request);
        }

        public Task<ApiCall<AdsGetTargetingStatsRequest, AdsTargStats>> GetTargetingStats(AdsGetTargetingStatsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetTargetingStatsRequest, AdsTargStats>("ads.getTargetingStats", request);
        }

        public Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestions>>> GetSuggestions(AdsGetSuggestionsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", request);
        }

        public Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(AdsGetSuggestionsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", request);
        }

        public Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(AdsGetSuggestionsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", request);
        }

        public Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(AdsGetSuggestionsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", request);
        }

        public Task<ApiCall<AdsGetCategoriesRequest, IEnumerable<AdsCategory>>> GetCategories(AdsGetCategoriesRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetCategoriesRequest, IEnumerable<AdsCategory>>("ads.getCategories", request);
        }

        public Task<ApiCall<AdsGetUploadURLRequest, string>> GetUploadURL(AdsGetUploadURLRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetUploadURLRequest, string>("ads.getUploadURL", request);
        }

        public Task<ApiCall<AdsGetVideoUploadURLRequest, string>> GetVideoUploadURL(AdsGetVideoUploadURLRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetVideoUploadURLRequest, string>("ads.getVideoUploadURL", request);
        }

        public Task<ApiCall<AdsGetFloodStatsRequest, AdsFloodStats>> GetFloodStats(AdsGetFloodStatsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetFloodStatsRequest, AdsFloodStats>("ads.getFloodStats", request);
        }

        public Task<ApiCall<AdsGetRejectionReasonRequest, AdsRejectReason>> GetRejectionReason(AdsGetRejectionReasonRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetRejectionReasonRequest, AdsRejectReason>("ads.getRejectionReason", request);
        }

        public Task<ApiCall<AdsCreateTargetGroupRequest, AdsCreateTargetGroupResponse>> CreateTargetGroup(AdsCreateTargetGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsCreateTargetGroupRequest, AdsCreateTargetGroupResponse>("ads.createTargetGroup", request);
        }

        public Task<ApiCall<AdsUpdateTargetGroupRequest, bool?>> UpdateTargetGroup(AdsUpdateTargetGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsUpdateTargetGroupRequest, bool?>("ads.updateTargetGroup", request);
        }

        public Task<ApiCall<AdsDeleteTargetGroupRequest, bool?>> DeleteTargetGroup(AdsDeleteTargetGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsDeleteTargetGroupRequest, bool?>("ads.deleteTargetGroup", request);
        }

        public Task<ApiCall<AdsGetTargetGroupsRequest, IEnumerable<AdsTargetGroup>>> GetTargetGroups(AdsGetTargetGroupsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsGetTargetGroupsRequest, IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", request);
        }

        public Task<ApiCall<AdsImportTargetContactsRequest, int?>> ImportTargetContacts(AdsImportTargetContactsRequest request)
        {
            return RequestManager.CreateRequestAsync<AdsImportTargetContactsRequest, int?>("ads.importTargetContacts", request);
        }
    }

    internal class AppsApi : IAppsApi
    {
        public Task<ApiCall<AppsGetCatalogRequest, AppsGetCatalogResponse>> GetCatalog(AppsGetCatalogRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetCatalogRequest, AppsGetCatalogResponse>("apps.getCatalog", request);
        }

        public Task<ApiCall<AppsGetRequest, AppsGetResponse>> Get(AppsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetRequest, AppsGetResponse>("apps.get", request);
        }

        public Task<ApiCall<AppsSendRequestRequest, int?>> SendRequest(AppsSendRequestRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsSendRequestRequest, int?>("apps.sendRequest", request);
        }

        public Task<ApiCall<AppsDeleteAppRequestsRequest, bool?>> DeleteAppRequests(AppsDeleteAppRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsDeleteAppRequestsRequest, bool?>("apps.deleteAppRequests", request);
        }

        public Task<ApiCall<AppsGetFriendsListRequest, AppsGetFriendsListResponse>> GetFriendsList(AppsGetFriendsListRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetFriendsListRequest, AppsGetFriendsListResponse>("apps.getFriendsList", request);
        }

        public Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardResponse>> GetLeaderboard(AppsGetLeaderboardRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetLeaderboardRequest, AppsGetLeaderboardResponse>("apps.getLeaderboard", request);
        }

        public Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(AppsGetLeaderboardRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetLeaderboardRequest, AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", request);
        }

        public Task<ApiCall<AppsGetScoreRequest, int?>> GetScore(AppsGetScoreRequest request)
        {
            return RequestManager.CreateRequestAsync<AppsGetScoreRequest, int?>("apps.getScore", request);
        }
    }

    internal class AudioApi : IAudioApi
    {
        public Task<ApiCall<AudioGetRequest, AudioGetResponse>> Get(AudioGetRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetRequest, AudioGetResponse>("audio.get", request);
        }

        public Task<ApiCall<AudioGetByIdRequest, IEnumerable<AudioAudioFull>>> GetById(AudioGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetByIdRequest, IEnumerable<AudioAudioFull>>("audio.getById", request);
        }

        public Task<ApiCall<AudioGetLyricsRequest, AudioLyrics>> GetLyrics(AudioGetLyricsRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetLyricsRequest, AudioLyrics>("audio.getLyrics", request);
        }

        public Task<ApiCall<AudioSearchRequest, AudioSearchResponse>> Search(AudioSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioSearchRequest, AudioSearchResponse>("audio.search", request);
        }

        public Task<ApiCall<AudioGetUploadServerRequest, AudioGetUploadServerResponse>> GetUploadServer(AudioGetUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetUploadServerRequest, AudioGetUploadServerResponse>("audio.getUploadServer", request);
        }

        public Task<ApiCall<AudioSaveRequest, AudioAudio>> Save(AudioSaveRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioSaveRequest, AudioAudio>("audio.save", request);
        }

        public Task<ApiCall<AudioAddRequest, int?>> Add(AudioAddRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioAddRequest, int?>("audio.add", request);
        }

        public Task<ApiCall<AudioDeleteRequest, bool?>> Delete(AudioDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioDeleteRequest, bool?>("audio.delete", request);
        }

        public Task<ApiCall<AudioEditRequest, int?>> Edit(AudioEditRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioEditRequest, int?>("audio.edit", request);
        }

        public Task<ApiCall<AudioReorderRequest, bool?>> Reorder(AudioReorderRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioReorderRequest, bool?>("audio.reorder", request);
        }

        public Task<ApiCall<AudioRestoreRequest, bool?>> Restore(AudioRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioRestoreRequest, bool?>("audio.restore", request);
        }

        public Task<ApiCall<AudioGetAlbumsRequest, AudioGetAlbumsResponse>> GetAlbums(AudioGetAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetAlbumsRequest, AudioGetAlbumsResponse>("audio.getAlbums", request);
        }

        public Task<ApiCall<AudioAddAlbumRequest, AudioAddAlbumResponse>> AddAlbum(AudioAddAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioAddAlbumRequest, AudioAddAlbumResponse>("audio.addAlbum", request);
        }

        public Task<ApiCall<AudioEditAlbumRequest, bool?>> EditAlbum(AudioEditAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioEditAlbumRequest, bool?>("audio.editAlbum", request);
        }

        public Task<ApiCall<AudioDeleteAlbumRequest, bool?>> DeleteAlbum(AudioDeleteAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioDeleteAlbumRequest, bool?>("audio.deleteAlbum", request);
        }

        public Task<ApiCall<AudioMoveToAlbumRequest, bool?>> MoveToAlbum(AudioMoveToAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioMoveToAlbumRequest, bool?>("audio.moveToAlbum", request);
        }

        public Task<ApiCall<AudioSetBroadcastRequest, IEnumerable<int>>> SetBroadcast(AudioSetBroadcastRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioSetBroadcastRequest, IEnumerable<int>>("audio.setBroadcast", request);
        }

        public Task<ApiCall<AudioGetBroadcastListRequest, IEnumerable<UsersUserBroadcast>>> GetBroadcastList(AudioGetBroadcastListRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetBroadcastListRequest, IEnumerable<UsersUserBroadcast>>("audio.getBroadcastList", request);
        }

        public Task<ApiCall<AudioGetRecommendationsRequest, IEnumerable<AudioAudioFull>>> GetRecommendations(AudioGetRecommendationsRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetRecommendationsRequest, IEnumerable<AudioAudioFull>>("audio.getRecommendations", request);
        }

        public Task<ApiCall<AudioGetPopularRequest, IEnumerable<AudioAudioFull>>> GetPopular(AudioGetPopularRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetPopularRequest, IEnumerable<AudioAudioFull>>("audio.getPopular", request);
        }

        public Task<ApiCall<AudioGetCountRequest, int?>> GetCount(AudioGetCountRequest request)
        {
            return RequestManager.CreateRequestAsync<AudioGetCountRequest, int?>("audio.getCount", request);
        }
    }

    internal class AuthApi : IAuthApi
    {
        public Task<ApiCall<AuthCheckPhoneRequest, bool?>> CheckPhone(AuthCheckPhoneRequest request)
        {
            return RequestManager.CreateRequestAsync<AuthCheckPhoneRequest, bool?>("auth.checkPhone", request);
        }

        public Task<ApiCall<AuthSignupRequest, AuthSignupResponse>> Signup(AuthSignupRequest request)
        {
            return RequestManager.CreateRequestAsync<AuthSignupRequest, AuthSignupResponse>("auth.signup", request);
        }

        public Task<ApiCall<AuthConfirmRequest, AuthConfirmResponse>> Confirm(AuthConfirmRequest request)
        {
            return RequestManager.CreateRequestAsync<AuthConfirmRequest, AuthConfirmResponse>("auth.confirm", request);
        }

        public Task<ApiCall<AuthRestoreRequest, AuthRestoreResponse>> Restore(AuthRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<AuthRestoreRequest, AuthRestoreResponse>("auth.restore", request);
        }
    }

    internal class BoardApi : IBoardApi
    {
        public Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsResponse>> GetTopics(BoardGetTopicsRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsRequest, BoardGetTopicsResponse>("board.getTopics", request);
        }

        public Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsExtendedResponse>> GetTopicsExtended(BoardGetTopicsRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsRequest, BoardGetTopicsExtendedResponse>("board.getTopics", request);
        }

        public Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsResponse>> GetComments(BoardGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsRequest, BoardGetCommentsResponse>("board.getComments", request);
        }

        public Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsExtendedResponse>> GetCommentsExtended(BoardGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsRequest, BoardGetCommentsExtendedResponse>("board.getComments", request);
        }

        public Task<ApiCall<BoardAddTopicRequest, int?>> AddTopic(BoardAddTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardAddTopicRequest, int?>("board.addTopic", request);
        }

        public Task<ApiCall<BoardCreateCommentRequest, int?>> CreateComment(BoardCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardCreateCommentRequest, int?>("board.createComment", request);
        }

        public Task<ApiCall<BoardDeleteTopicRequest, bool?>> DeleteTopic(BoardDeleteTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardDeleteTopicRequest, bool?>("board.deleteTopic", request);
        }

        public Task<ApiCall<BoardEditTopicRequest, bool?>> EditTopic(BoardEditTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardEditTopicRequest, bool?>("board.editTopic", request);
        }

        public Task<ApiCall<BoardEditCommentRequest, bool?>> EditComment(BoardEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardEditCommentRequest, bool?>("board.editComment", request);
        }

        public Task<ApiCall<BoardRestoreCommentRequest, bool?>> RestoreComment(BoardRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardRestoreCommentRequest, bool?>("board.restoreComment", request);
        }

        public Task<ApiCall<BoardDeleteCommentRequest, bool?>> DeleteComment(BoardDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardDeleteCommentRequest, bool?>("board.deleteComment", request);
        }

        public Task<ApiCall<BoardOpenTopicRequest, bool?>> OpenTopic(BoardOpenTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardOpenTopicRequest, bool?>("board.openTopic", request);
        }

        public Task<ApiCall<BoardCloseTopicRequest, bool?>> CloseTopic(BoardCloseTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardCloseTopicRequest, bool?>("board.closeTopic", request);
        }

        public Task<ApiCall<BoardFixTopicRequest, bool?>> FixTopic(BoardFixTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardFixTopicRequest, bool?>("board.fixTopic", request);
        }

        public Task<ApiCall<BoardUnfixTopicRequest, bool?>> UnfixTopic(BoardUnfixTopicRequest request)
        {
            return RequestManager.CreateRequestAsync<BoardUnfixTopicRequest, bool?>("board.unfixTopic", request);
        }
    }

    internal class DatabaseApi : IDatabaseApi
    {
        public Task<ApiCall<DatabaseGetCountriesRequest, DatabaseGetCountriesResponse>> GetCountries(DatabaseGetCountriesRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCountriesRequest, DatabaseGetCountriesResponse>("database.getCountries", request);
        }

        public Task<ApiCall<DatabaseGetRegionsRequest, DatabaseGetRegionsResponse>> GetRegions(DatabaseGetRegionsRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetRegionsRequest, DatabaseGetRegionsResponse>("database.getRegions", request);
        }

        public Task<ApiCall<DatabaseGetStreetsByIdRequest, IEnumerable<DatabaseStreet>>> GetStreetsById(DatabaseGetStreetsByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetStreetsByIdRequest, IEnumerable<DatabaseStreet>>("database.getStreetsById", request);
        }

        public Task<ApiCall<DatabaseGetCountriesByIdRequest, IEnumerable<BaseCountry>>> GetCountriesById(DatabaseGetCountriesByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCountriesByIdRequest, IEnumerable<BaseCountry>>("database.getCountriesById", request);
        }

        public Task<ApiCall<DatabaseGetCitiesRequest, DatabaseGetCitiesResponse>> GetCities(DatabaseGetCitiesRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCitiesRequest, DatabaseGetCitiesResponse>("database.getCities", request);
        }

        public Task<ApiCall<DatabaseGetCitiesByIdRequest, IEnumerable<BaseObject>>> GetCitiesById(DatabaseGetCitiesByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCitiesByIdRequest, IEnumerable<BaseObject>>("database.getCitiesById", request);
        }

        public Task<ApiCall<DatabaseGetUniversitiesRequest, DatabaseGetUniversitiesResponse>> GetUniversities(DatabaseGetUniversitiesRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesRequest, DatabaseGetUniversitiesResponse>("database.getUniversities", request);
        }

        public Task<ApiCall<DatabaseGetSchoolsRequest, DatabaseGetSchoolsResponse>> GetSchools(DatabaseGetSchoolsRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsRequest, DatabaseGetSchoolsResponse>("database.getSchools", request);
        }

        public Task<ApiCall<DatabaseGetSchoolClassesRequest, IEnumerable<IEnumerable<string>>>> GetSchoolClasses(DatabaseGetSchoolClassesRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetSchoolClassesRequest, IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", request);
        }

        public Task<ApiCall<DatabaseGetFacultiesRequest, DatabaseGetFacultiesResponse>> GetFaculties(DatabaseGetFacultiesRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesRequest, DatabaseGetFacultiesResponse>("database.getFaculties", request);
        }

        public Task<ApiCall<DatabaseGetChairsRequest, DatabaseGetChairsResponse>> GetChairs(DatabaseGetChairsRequest request)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetChairsRequest, DatabaseGetChairsResponse>("database.getChairs", request);
        }
    }

    internal class DocsApi : IDocsApi
    {
        public Task<ApiCall<DocsGetRequest, DocsGetResponse>> Get(DocsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsGetRequest, DocsGetResponse>("docs.get", request);
        }

        public Task<ApiCall<DocsGetByIdRequest, IEnumerable<DocsDoc>>> GetById(DocsGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsGetByIdRequest, IEnumerable<DocsDoc>>("docs.getById", request);
        }

        public Task<ApiCall<DocsGetUploadServerRequest, DocsGetUploadServerResponse>> GetUploadServer(DocsGetUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsGetUploadServerRequest, DocsGetUploadServerResponse>("docs.getUploadServer", request);
        }

        public Task<ApiCall<DocsGetWallUploadServerRequest, DocsGetWallUploadServerResponse>> GetWallUploadServer(DocsGetWallUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerRequest, DocsGetWallUploadServerResponse>("docs.getWallUploadServer", request);
        }

        public Task<ApiCall<DocsSaveRequest, IEnumerable<DocsDoc>>> Save(DocsSaveRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsSaveRequest, IEnumerable<DocsDoc>>("docs.save", request);
        }

        public Task<ApiCall<DocsDeleteRequest, bool?>> Delete(DocsDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsDeleteRequest, bool?>("docs.delete", request);
        }

        public Task<ApiCall<DocsAddRequest, DocsAddResponse>> Add(DocsAddRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsAddRequest, DocsAddResponse>("docs.add", request);
        }

        public Task<ApiCall<DocsGetTypesRequest, DocsGetTypesResponse>> GetTypes(DocsGetTypesRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsGetTypesRequest, DocsGetTypesResponse>("docs.getTypes", request);
        }

        public Task<ApiCall<DocsSearchRequest, DocsSearchResponse>> Search(DocsSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsSearchRequest, DocsSearchResponse>("docs.search", request);
        }

        public Task<ApiCall<DocsEditRequest, bool?>> Edit(DocsEditRequest request)
        {
            return RequestManager.CreateRequestAsync<DocsEditRequest, bool?>("docs.edit", request);
        }
    }

    internal class FaveApi : IFaveApi
    {
        public Task<ApiCall<FaveGetUsersRequest, FaveGetUsersResponse>> GetUsers(FaveGetUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetUsersRequest, FaveGetUsersResponse>("fave.getUsers", request);
        }

        public Task<ApiCall<FaveGetPhotosRequest, FaveGetPhotosResponse>> GetPhotos(FaveGetPhotosRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetPhotosRequest, FaveGetPhotosResponse>("fave.getPhotos", request);
        }

        public Task<ApiCall<FaveGetPostsRequest, FaveGetPostsResponse>> GetPosts(FaveGetPostsRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetPostsRequest, FaveGetPostsResponse>("fave.getPosts", request);
        }

        public Task<ApiCall<FaveGetVideosRequest, FaveGetVideosResponse>> GetVideos(FaveGetVideosRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetVideosRequest, FaveGetVideosResponse>("fave.getVideos", request);
        }

        public Task<ApiCall<FaveGetLinksRequest, FaveGetLinksResponse>> GetLinks(FaveGetLinksRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetLinksRequest, FaveGetLinksResponse>("fave.getLinks", request);
        }

        public Task<ApiCall<FaveGetMarketItemsRequest, FaveGetMarketItemsResponse>> GetMarketItems(FaveGetMarketItemsRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveGetMarketItemsRequest, FaveGetMarketItemsResponse>("fave.getMarketItems", request);
        }

        public Task<ApiCall<FaveAddUserRequest, bool?>> AddUser(FaveAddUserRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveAddUserRequest, bool?>("fave.addUser", request);
        }

        public Task<ApiCall<FaveRemoveUserRequest, bool?>> RemoveUser(FaveRemoveUserRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveRemoveUserRequest, bool?>("fave.removeUser", request);
        }

        public Task<ApiCall<FaveAddGroupRequest, bool?>> AddGroup(FaveAddGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveAddGroupRequest, bool?>("fave.addGroup", request);
        }

        public Task<ApiCall<FaveRemoveGroupRequest, bool?>> RemoveGroup(FaveRemoveGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveRemoveGroupRequest, bool?>("fave.removeGroup", request);
        }

        public Task<ApiCall<FaveAddLinkRequest, bool?>> AddLink(FaveAddLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveAddLinkRequest, bool?>("fave.addLink", request);
        }

        public Task<ApiCall<FaveRemoveLinkRequest, bool?>> RemoveLink(FaveRemoveLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<FaveRemoveLinkRequest, bool?>("fave.removeLink", request);
        }
    }

    internal class FriendsApi : IFriendsApi
    {
        public Task<ApiCall<FriendsGetRequest, FriendsGetResponse>> Get(FriendsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequest, FriendsGetResponse>("friends.get", request);
        }

        public Task<ApiCall<FriendsGetRequest, FriendsGetFieldsResponse>> GetFields(FriendsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequest, FriendsGetFieldsResponse>("friends.get", request);
        }

        public Task<ApiCall<FriendsGetOnlineRequest, IEnumerable<int>>> GetOnline(FriendsGetOnlineRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetOnlineRequest, IEnumerable<int>>("friends.getOnline", request);
        }

        public Task<ApiCall<FriendsGetOnlineRequest, FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(FriendsGetOnlineRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetOnlineRequest, FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", request);
        }

        public Task<ApiCall<FriendsGetMutualRequest, IEnumerable<int>>> GetMutual(FriendsGetMutualRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetMutualRequest, IEnumerable<int>>("friends.getMutual", request);
        }

        public Task<ApiCall<FriendsGetRecentRequest, IEnumerable<int>>> GetRecent(FriendsGetRecentRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRecentRequest, IEnumerable<int>>("friends.getRecent", request);
        }

        public Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsResponse>> GetRequests(FriendsGetRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsResponse>("friends.getRequests", request);
        }

        public Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(FriendsGetRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsNeedMutualResponse>("friends.getRequests", request);
        }

        public Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsExtendedResponse>> GetRequestsExtended(FriendsGetRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsExtendedResponse>("friends.getRequests", request);
        }

        public Task<ApiCall<FriendsAddRequest, int?>> Add(FriendsAddRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsAddRequest, int?>("friends.add", request);
        }

        public Task<ApiCall<FriendsEditRequest, bool?>> Edit(FriendsEditRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsEditRequest, bool?>("friends.edit", request);
        }

        public Task<ApiCall<FriendsDeleteRequest, FriendsDeleteResponse>> Delete(FriendsDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsDeleteRequest, FriendsDeleteResponse>("friends.delete", request);
        }

        public Task<ApiCall<FriendsGetListsRequest, FriendsGetListsResponse>> GetLists(FriendsGetListsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetListsRequest, FriendsGetListsResponse>("friends.getLists", request);
        }

        public Task<ApiCall<FriendsAddListRequest, FriendsAddListResponse>> AddList(FriendsAddListRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsAddListRequest, FriendsAddListResponse>("friends.addList", request);
        }

        public Task<ApiCall<FriendsEditListRequest, bool?>> EditList(FriendsEditListRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsEditListRequest, bool?>("friends.editList", request);
        }

        public Task<ApiCall<FriendsDeleteListRequest, bool?>> DeleteList(FriendsDeleteListRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsDeleteListRequest, bool?>("friends.deleteList", request);
        }

        public Task<ApiCall<FriendsGetAppUsersRequest, IEnumerable<int>>> GetAppUsers(FriendsGetAppUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetAppUsersRequest, IEnumerable<int>>("friends.getAppUsers", request);
        }

        public Task<ApiCall<FriendsGetByPhonesRequest, IEnumerable<FriendsUserXtrPhone>>> GetByPhones(FriendsGetByPhonesRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetByPhonesRequest, IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", request);
        }

        public Task<ApiCall<FriendsDeleteAllRequestsRequest, bool?>> DeleteAllRequests(FriendsDeleteAllRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsDeleteAllRequestsRequest, bool?>("friends.deleteAllRequests", request);
        }

        public Task<ApiCall<FriendsGetSuggestionsRequest, FriendsGetSuggestionsResponse>> GetSuggestions(FriendsGetSuggestionsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetSuggestionsRequest, FriendsGetSuggestionsResponse>("friends.getSuggestions", request);
        }

        public Task<ApiCall<FriendsAreFriendsRequest, IEnumerable<FriendsFriendStatus>>> AreFriends(FriendsAreFriendsRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsAreFriendsRequest, IEnumerable<FriendsFriendStatus>>("friends.areFriends", request);
        }

        public Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallResponse>> GetAvailableForCall(FriendsGetAvailableForCallRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallResponse>("friends.getAvailableForCall", request);
        }

        public Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(FriendsGetAvailableForCallRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallFieldsResponse>("friends.getAvailableForCall", request);
        }

        public Task<ApiCall<FriendsSearchRequest, FriendsSearchResponse>> Search(FriendsSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<FriendsSearchRequest, FriendsSearchResponse>("friends.search", request);
        }
    }

    internal class GiftsApi : IGiftsApi
    {
        public Task<ApiCall<GiftsGetRequest, GiftsGetResponse>> Get(GiftsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<GiftsGetRequest, GiftsGetResponse>("gifts.get", request);
        }
    }

    internal class GroupsApi : IGroupsApi
    {
        public Task<ApiCall<GroupsIsMemberRequest, bool?>> IsMember(GroupsIsMemberRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberRequest, bool?>("groups.isMember", request);
        }

        public Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupsIsMemberRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatus>>("groups.isMember", request);
        }

        public Task<ApiCall<GroupsIsMemberRequest, GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupsIsMemberRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberRequest, GroupsIsMemberExtendedResponse>("groups.isMember", request);
        }

        public Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupsIsMemberRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatusFull>>("groups.isMember", request);
        }

        public Task<ApiCall<GroupsGetByIdRequest, IEnumerable<GroupsGroupFull>>> GetById(GroupsGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetByIdRequest, IEnumerable<GroupsGroupFull>>("groups.getById", request);
        }

        public Task<ApiCall<GroupsGetRequest, GroupsGetResponse>> Get(GroupsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequest, GroupsGetResponse>("groups.get", request);
        }

        public Task<ApiCall<GroupsGetRequest, GroupsGetExtendedResponse>> GetExtended(GroupsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequest, GroupsGetExtendedResponse>("groups.get", request);
        }

        public Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersResponse>> GetMembers(GroupsGetMembersRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersResponse>("groups.getMembers", request);
        }

        public Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFieldsResponse>> GetMembersFields(GroupsGetMembersRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersFieldsResponse>("groups.getMembers", request);
        }

        public Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFilterResponse>> GetMembersFilter(GroupsGetMembersRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersFilterResponse>("groups.getMembers", request);
        }

        public Task<ApiCall<GroupsJoinRequest, bool?>> Join(GroupsJoinRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsJoinRequest, bool?>("groups.join", request);
        }

        public Task<ApiCall<GroupsLeaveRequest, bool?>> Leave(GroupsLeaveRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsLeaveRequest, bool?>("groups.leave", request);
        }

        public Task<ApiCall<GroupsSearchRequest, GroupsSearchResponse>> Search(GroupsSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsSearchRequest, GroupsSearchResponse>("groups.search", request);
        }

        public Task<ApiCall<GroupsGetCatalogRequest, GroupsGetCatalogResponse>> GetCatalog(GroupsGetCatalogRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogRequest, GroupsGetCatalogResponse>("groups.getCatalog", request);
        }

        public Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoResponse>> GetCatalogInfo(GroupsGetCatalogInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", request);
        }

        public Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(GroupsGetCatalogInfoRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoExtendedResponse>("groups.getCatalogInfo", request);
        }

        public Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesResponse>> GetInvites(GroupsGetInvitesRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitesRequest, GroupsGetInvitesResponse>("groups.getInvites", request);
        }

        public Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesExtendedResponse>> GetInvitesExtended(GroupsGetInvitesRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitesRequest, GroupsGetInvitesExtendedResponse>("groups.getInvites", request);
        }

        public Task<ApiCall<GroupsGetInvitedUsersRequest, GroupsGetInvitedUsersResponse>> GetInvitedUsers(GroupsGetInvitedUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitedUsersRequest, GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", request);
        }

        public Task<ApiCall<GroupsBanUserRequest, bool?>> BanUser(GroupsBanUserRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsBanUserRequest, bool?>("groups.banUser", request);
        }

        public Task<ApiCall<GroupsUnbanUserRequest, bool?>> UnbanUser(GroupsUnbanUserRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsUnbanUserRequest, bool?>("groups.unbanUser", request);
        }

        public Task<ApiCall<GroupsGetBannedRequest, GroupsGetBannedResponse>> GetBanned(GroupsGetBannedRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetBannedRequest, GroupsGetBannedResponse>("groups.getBanned", request);
        }

        public Task<ApiCall<GroupsCreateRequest, GroupsGroup>> Create(GroupsCreateRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsCreateRequest, GroupsGroup>("groups.create", request);
        }

        public Task<ApiCall<GroupsEditRequest, bool?>> Edit(GroupsEditRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsEditRequest, bool?>("groups.edit", request);
        }

        public Task<ApiCall<GroupsEditPlaceRequest, GroupsEditPlaceResponse>> EditPlace(GroupsEditPlaceRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsEditPlaceRequest, GroupsEditPlaceResponse>("groups.editPlace", request);
        }

        public Task<ApiCall<GroupsGetSettingsRequest, GroupsGroupSettings>> GetSettings(GroupsGetSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetSettingsRequest, GroupsGroupSettings>("groups.getSettings", request);
        }

        public Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsResponse>> GetRequests(GroupsGetRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequestsRequest, GroupsGetRequestsResponse>("groups.getRequests", request);
        }

        public Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsFieldsResponse>> GetRequestsFields(GroupsGetRequestsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequestsRequest, GroupsGetRequestsFieldsResponse>("groups.getRequests", request);
        }

        public Task<ApiCall<GroupsEditManagerRequest, bool?>> EditManager(GroupsEditManagerRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsEditManagerRequest, bool?>("groups.editManager", request);
        }

        public Task<ApiCall<GroupsInviteRequest, bool?>> Invite(GroupsInviteRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsInviteRequest, bool?>("groups.invite", request);
        }

        public Task<ApiCall<GroupsAddLinkRequest, GroupsGroupLink>> AddLink(GroupsAddLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsAddLinkRequest, GroupsGroupLink>("groups.addLink", request);
        }

        public Task<ApiCall<GroupsDeleteLinkRequest, bool?>> DeleteLink(GroupsDeleteLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsDeleteLinkRequest, bool?>("groups.deleteLink", request);
        }

        public Task<ApiCall<GroupsEditLinkRequest, bool?>> EditLink(GroupsEditLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsEditLinkRequest, bool?>("groups.editLink", request);
        }

        public Task<ApiCall<GroupsReorderLinkRequest, bool?>> ReorderLink(GroupsReorderLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsReorderLinkRequest, bool?>("groups.reorderLink", request);
        }

        public Task<ApiCall<GroupsRemoveUserRequest, bool?>> RemoveUser(GroupsRemoveUserRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsRemoveUserRequest, bool?>("groups.removeUser", request);
        }

        public Task<ApiCall<GroupsApproveRequestRequest, bool?>> ApproveRequest(GroupsApproveRequestRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsApproveRequestRequest, bool?>("groups.approveRequest", request);
        }

        public Task<ApiCall<GroupsGetCallbackConfirmationCodeRequest, GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupsGetCallbackConfirmationCodeRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeRequest, GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", request);
        }

        public Task<ApiCall<GroupsGetCallbackServerSettingsRequest, GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupsGetCallbackServerSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsRequest, GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", request);
        }

        public Task<ApiCall<GroupsGetCallbackSettingsRequest, GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupsGetCallbackSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsRequest, GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", request);
        }

        public Task<ApiCall<GroupsSetCallbackServerRequest, GroupsSetCallbackServerResponse>> SetCallbackServer(GroupsSetCallbackServerRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerRequest, GroupsSetCallbackServerResponse>("groups.setCallbackServer", request);
        }

        public Task<ApiCall<GroupsSetCallbackServerSettingsRequest, bool?>> SetCallbackServerSettings(GroupsSetCallbackServerSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerSettingsRequest, bool?>("groups.setCallbackServerSettings", request);
        }

        public Task<ApiCall<GroupsSetCallbackSettingsRequest, bool?>> SetCallbackSettings(GroupsSetCallbackSettingsRequest request)
        {
            return RequestManager.CreateRequestAsync<GroupsSetCallbackSettingsRequest, bool?>("groups.setCallbackSettings", request);
        }
    }

    internal class LeadsApi : ILeadsApi
    {
        public Task<ApiCall<LeadsCompleteRequest, LeadsComplete>> Complete(LeadsCompleteRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsCompleteRequest, LeadsComplete>("leads.complete", request);
        }

        public Task<ApiCall<LeadsStartRequest, LeadsStart>> Start(LeadsStartRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsStartRequest, LeadsStart>("leads.start", request);
        }

        public Task<ApiCall<LeadsGetStatsRequest, LeadsLead>> GetStats(LeadsGetStatsRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsGetStatsRequest, LeadsLead>("leads.getStats", request);
        }

        public Task<ApiCall<LeadsGetUsersRequest, IEnumerable<LeadsEntry>>> GetUsers(LeadsGetUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsGetUsersRequest, IEnumerable<LeadsEntry>>("leads.getUsers", request);
        }

        public Task<ApiCall<LeadsCheckUserRequest, LeadsChecked>> CheckUser(LeadsCheckUserRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsCheckUserRequest, LeadsChecked>("leads.checkUser", request);
        }

        public Task<ApiCall<LeadsMetricHitRequest, LeadsMetricHitResponse>> MetricHit(LeadsMetricHitRequest request)
        {
            return RequestManager.CreateRequestAsync<LeadsMetricHitRequest, LeadsMetricHitResponse>("leads.metricHit", request);
        }
    }

    internal class LikesApi : ILikesApi
    {
        public Task<ApiCall<LikesGetListRequest, LikesGetListResponse>> GetList(LikesGetListRequest request)
        {
            return RequestManager.CreateRequestAsync<LikesGetListRequest, LikesGetListResponse>("likes.getList", request);
        }

        public Task<ApiCall<LikesGetListRequest, LikesGetListExtendedResponse>> GetListExtended(LikesGetListRequest request)
        {
            return RequestManager.CreateRequestAsync<LikesGetListRequest, LikesGetListExtendedResponse>("likes.getList", request);
        }

        public Task<ApiCall<LikesAddRequest, LikesAddResponse>> Add(LikesAddRequest request)
        {
            return RequestManager.CreateRequestAsync<LikesAddRequest, LikesAddResponse>("likes.add", request);
        }

        public Task<ApiCall<LikesDeleteRequest, LikesDeleteResponse>> Delete(LikesDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<LikesDeleteRequest, LikesDeleteResponse>("likes.delete", request);
        }

        public Task<ApiCall<LikesIsLikedRequest, LikesIsLikedResponse>> IsLiked(LikesIsLikedRequest request)
        {
            return RequestManager.CreateRequestAsync<LikesIsLikedRequest, LikesIsLikedResponse>("likes.isLiked", request);
        }
    }

    internal class MarketApi : IMarketApi
    {
        public Task<ApiCall<MarketGetRequest, MarketGetResponse>> Get(MarketGetRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetRequest, MarketGetResponse>("market.get", request);
        }

        public Task<ApiCall<MarketGetRequest, MarketGetExtendedResponse>> GetExtended(MarketGetRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetRequest, MarketGetExtendedResponse>("market.get", request);
        }

        public Task<ApiCall<MarketGetByIdRequest, MarketGetByIdResponse>> GetById(MarketGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetByIdRequest, MarketGetByIdResponse>("market.getById", request);
        }

        public Task<ApiCall<MarketGetByIdRequest, MarketGetByIdExtendedResponse>> GetByIdExtended(MarketGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetByIdRequest, MarketGetByIdExtendedResponse>("market.getById", request);
        }

        public Task<ApiCall<MarketSearchRequest, MarketSearchResponse>> Search(MarketSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketSearchRequest, MarketSearchResponse>("market.search", request);
        }

        public Task<ApiCall<MarketSearchRequest, MarketSearchExtendedResponse>> SearchExtended(MarketSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketSearchRequest, MarketSearchExtendedResponse>("market.search", request);
        }

        public Task<ApiCall<MarketGetAlbumsRequest, MarketGetAlbumsResponse>> GetAlbums(MarketGetAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetAlbumsRequest, MarketGetAlbumsResponse>("market.getAlbums", request);
        }

        public Task<ApiCall<MarketGetAlbumByIdRequest, MarketGetAlbumByIdResponse>> GetAlbumById(MarketGetAlbumByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetAlbumByIdRequest, MarketGetAlbumByIdResponse>("market.getAlbumById", request);
        }

        public Task<ApiCall<MarketCreateCommentRequest, int?>> CreateComment(MarketCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketCreateCommentRequest, int?>("market.createComment", request);
        }

        public Task<ApiCall<MarketGetCommentsRequest, MarketGetCommentsResponse>> GetComments(MarketGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetCommentsRequest, MarketGetCommentsResponse>("market.getComments", request);
        }

        public Task<ApiCall<MarketDeleteCommentRequest, bool?>> DeleteComment(MarketDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketDeleteCommentRequest, bool?>("market.deleteComment", request);
        }

        public Task<ApiCall<MarketRestoreCommentRequest, bool?>> RestoreComment(MarketRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketRestoreCommentRequest, bool?>("market.restoreComment", request);
        }

        public Task<ApiCall<MarketEditCommentRequest, bool?>> EditComment(MarketEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketEditCommentRequest, bool?>("market.editComment", request);
        }

        public Task<ApiCall<MarketReportCommentRequest, bool?>> ReportComment(MarketReportCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketReportCommentRequest, bool?>("market.reportComment", request);
        }

        public Task<ApiCall<MarketGetCategoriesRequest, MarketGetCategoriesResponse>> GetCategories(MarketGetCategoriesRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketGetCategoriesRequest, MarketGetCategoriesResponse>("market.getCategories", request);
        }

        public Task<ApiCall<MarketReportRequest, bool?>> Report(MarketReportRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketReportRequest, bool?>("market.report", request);
        }

        public Task<ApiCall<MarketAddRequest, MarketAddResponse>> Add(MarketAddRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketAddRequest, MarketAddResponse>("market.add", request);
        }

        public Task<ApiCall<MarketEditRequest, bool?>> Edit(MarketEditRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketEditRequest, bool?>("market.edit", request);
        }

        public Task<ApiCall<MarketDeleteRequest, bool?>> Delete(MarketDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketDeleteRequest, bool?>("market.delete", request);
        }

        public Task<ApiCall<MarketRestoreRequest, bool?>> Restore(MarketRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketRestoreRequest, bool?>("market.restore", request);
        }

        public Task<ApiCall<MarketReorderItemsRequest, bool?>> ReorderItems(MarketReorderItemsRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketReorderItemsRequest, bool?>("market.reorderItems", request);
        }

        public Task<ApiCall<MarketReorderAlbumsRequest, bool?>> ReorderAlbums(MarketReorderAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketReorderAlbumsRequest, bool?>("market.reorderAlbums", request);
        }

        public Task<ApiCall<MarketAddAlbumRequest, MarketAddAlbumResponse>> AddAlbum(MarketAddAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketAddAlbumRequest, MarketAddAlbumResponse>("market.addAlbum", request);
        }

        public Task<ApiCall<MarketEditAlbumRequest, bool?>> EditAlbum(MarketEditAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketEditAlbumRequest, bool?>("market.editAlbum", request);
        }

        public Task<ApiCall<MarketDeleteAlbumRequest, bool?>> DeleteAlbum(MarketDeleteAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketDeleteAlbumRequest, bool?>("market.deleteAlbum", request);
        }

        public Task<ApiCall<MarketRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(MarketRemoveFromAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketRemoveFromAlbumRequest, bool?>("market.removeFromAlbum", request);
        }

        public Task<ApiCall<MarketAddToAlbumRequest, bool?>> AddToAlbum(MarketAddToAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<MarketAddToAlbumRequest, bool?>("market.addToAlbum", request);
        }
    }

    internal class MessagesApi : IMessagesApi
    {
        public Task<ApiCall<MessagesGetRequest, MessagesGetResponse>> Get(MessagesGetRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetRequest, MessagesGetResponse>("messages.get", request);
        }

        public Task<ApiCall<MessagesGetDialogsRequest, MessagesGetDialogsResponse>> GetDialogs(MessagesGetDialogsRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetDialogsRequest, MessagesGetDialogsResponse>("messages.getDialogs", request);
        }

        public Task<ApiCall<MessagesGetByIdRequest, MessagesGetByIdResponse>> GetById(MessagesGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetByIdRequest, MessagesGetByIdResponse>("messages.getById", request);
        }

        public Task<ApiCall<MessagesSearchRequest, MessagesSearchResponse>> Search(MessagesSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesSearchRequest, MessagesSearchResponse>("messages.search", request);
        }

        public Task<ApiCall<MessagesGetHistoryRequest, MessagesGetHistoryResponse>> GetHistory(MessagesGetHistoryRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryRequest, MessagesGetHistoryResponse>("messages.getHistory", request);
        }

        public Task<ApiCall<MessagesGetHistoryAttachmentsRequest, MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(MessagesGetHistoryAttachmentsRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsRequest, MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", request);
        }

        public Task<ApiCall<MessagesSendRequest, int?>> Send(MessagesSendRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesSendRequest, int?>("messages.send", request);
        }

        public Task<ApiCall<MessagesDeleteRequest, bool?>> Delete(MessagesDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteRequest, bool?>("messages.delete", request);
        }

        public Task<ApiCall<MessagesDeleteDialogRequest, bool?>> DeleteDialog(MessagesDeleteDialogRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteDialogRequest, bool?>("messages.deleteDialog", request);
        }

        public Task<ApiCall<MessagesRestoreRequest, bool?>> Restore(MessagesRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesRestoreRequest, bool?>("messages.restore", request);
        }

        public Task<ApiCall<MessagesMarkAsReadRequest, bool?>> MarkAsRead(MessagesMarkAsReadRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesMarkAsReadRequest, bool?>("messages.markAsRead", request);
        }

        public Task<ApiCall<MessagesMarkAsImportantRequest, IEnumerable<int>>> MarkAsImportant(MessagesMarkAsImportantRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesMarkAsImportantRequest, IEnumerable<int>>("messages.markAsImportant", request);
        }

        public Task<ApiCall<MessagesGetLongPollServerRequest, MessagesLongpollParams>> GetLongPollServer(MessagesGetLongPollServerRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetLongPollServerRequest, MessagesLongpollParams>("messages.getLongPollServer", request);
        }

        public Task<ApiCall<MessagesGetLongPollHistoryRequest, MessagesGetLongPollHistoryResponse>> GetLongPollHistory(MessagesGetLongPollHistoryRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryRequest, MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", request);
        }

        public Task<ApiCall<MessagesGetChatRequest, MessagesChat>> GetChat(MessagesGetChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatRequest, MessagesChat>("messages.getChat", request);
        }

        public Task<ApiCall<MessagesGetChatRequest, MessagesChatFull>> GetChatFields(MessagesGetChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatRequest, MessagesChatFull>("messages.getChat", request);
        }

        public Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChat>>> GetChatChatIds(MessagesGetChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatRequest, IEnumerable<MessagesChat>>("messages.getChat", request);
        }

        public Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(MessagesGetChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatRequest, IEnumerable<MessagesChatFull>>("messages.getChat", request);
        }

        public Task<ApiCall<MessagesCreateChatRequest, int?>> CreateChat(MessagesCreateChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesCreateChatRequest, int?>("messages.createChat", request);
        }

        public Task<ApiCall<MessagesEditChatRequest, bool?>> EditChat(MessagesEditChatRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesEditChatRequest, bool?>("messages.editChat", request);
        }

        public Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsers(MessagesGetChatUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request);
        }

        public Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(MessagesGetChatUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<MessagesUserXtrInvitedBy>>("messages.getChatUsers", request);
        }

        public Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIds(MessagesGetChatUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request);
        }

        public Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIdsFields(MessagesGetChatUsersRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request);
        }

        public Task<ApiCall<MessagesSetActivityRequest, bool?>> SetActivity(MessagesSetActivityRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesSetActivityRequest, bool?>("messages.setActivity", request);
        }

        public Task<ApiCall<MessagesSearchDialogsRequest, string>> SearchDialogs(MessagesSearchDialogsRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesSearchDialogsRequest, string>("messages.searchDialogs", request);
        }

        public Task<ApiCall<MessagesAddChatUserRequest, bool?>> AddChatUser(MessagesAddChatUserRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesAddChatUserRequest, bool?>("messages.addChatUser", request);
        }

        public Task<ApiCall<MessagesRemoveChatUserRequest, bool?>> RemoveChatUser(MessagesRemoveChatUserRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesRemoveChatUserRequest, bool?>("messages.removeChatUser", request);
        }

        public Task<ApiCall<MessagesGetLastActivityRequest, MessagesLastActivity>> GetLastActivity(MessagesGetLastActivityRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesGetLastActivityRequest, MessagesLastActivity>("messages.getLastActivity", request);
        }

        public Task<ApiCall<MessagesSetChatPhotoRequest, MessagesSetChatPhotoResponse>> SetChatPhoto(MessagesSetChatPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesSetChatPhotoRequest, MessagesSetChatPhotoResponse>("messages.setChatPhoto", request);
        }

        public Task<ApiCall<MessagesDeleteChatPhotoRequest, MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(MessagesDeleteChatPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoRequest, MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", request);
        }

        public Task<ApiCall<MessagesDenyMessagesFromGroupRequest, bool?>> DenyMessagesFromGroup(MessagesDenyMessagesFromGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesDenyMessagesFromGroupRequest, bool?>("messages.denyMessagesFromGroup", request);
        }

        public Task<ApiCall<MessagesAllowMessagesFromGroupRequest, bool?>> AllowMessagesFromGroup(MessagesAllowMessagesFromGroupRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesAllowMessagesFromGroupRequest, bool?>("messages.allowMessagesFromGroup", request);
        }

        public Task<ApiCall<MessagesIsMessagesFromGroupAllowedRequest, MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(MessagesIsMessagesFromGroupAllowedRequest request)
        {
            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedRequest, MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", request);
        }
    }

    internal class NewsfeedApi : INewsfeedApi
    {
        public Task<ApiCall<NewsfeedGetRequest, NewsfeedGetResponse>> Get(NewsfeedGetRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetRequest, NewsfeedGetResponse>("newsfeed.get", request);
        }

        public Task<ApiCall<NewsfeedGetRecommendedRequest, NewsfeedGetRecommendedResponse>> GetRecommended(NewsfeedGetRecommendedRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetRecommendedRequest, NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", request);
        }

        public Task<ApiCall<NewsfeedGetCommentsRequest, NewsfeedGetCommentsResponse>> GetComments(NewsfeedGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetCommentsRequest, NewsfeedGetCommentsResponse>("newsfeed.getComments", request);
        }

        public Task<ApiCall<NewsfeedGetMentionsRequest, NewsfeedGetMentionsResponse>> GetMentions(NewsfeedGetMentionsRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetMentionsRequest, NewsfeedGetMentionsResponse>("newsfeed.getMentions", request);
        }

        public Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedResponse>> GetBanned(NewsfeedGetBannedRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetBannedRequest, NewsfeedGetBannedResponse>("newsfeed.getBanned", request);
        }

        public Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedExtendedResponse>> GetBannedExtended(NewsfeedGetBannedRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetBannedRequest, NewsfeedGetBannedExtendedResponse>("newsfeed.getBanned", request);
        }

        public Task<ApiCall<NewsfeedAddBanRequest, bool?>> AddBan(NewsfeedAddBanRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedAddBanRequest, bool?>("newsfeed.addBan", request);
        }

        public Task<ApiCall<NewsfeedDeleteBanRequest, bool?>> DeleteBan(NewsfeedDeleteBanRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedDeleteBanRequest, bool?>("newsfeed.deleteBan", request);
        }

        public Task<ApiCall<NewsfeedIgnoreItemRequest, bool?>> IgnoreItem(NewsfeedIgnoreItemRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedIgnoreItemRequest, bool?>("newsfeed.ignoreItem", request);
        }

        public Task<ApiCall<NewsfeedUnignoreItemRequest, bool?>> UnignoreItem(NewsfeedUnignoreItemRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedUnignoreItemRequest, bool?>("newsfeed.unignoreItem", request);
        }

        public Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchResponse>> Search(NewsfeedSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchRequest, NewsfeedSearchResponse>("newsfeed.search", request);
        }

        public Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchExtendedResponse>> SearchExtended(NewsfeedSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchRequest, NewsfeedSearchExtendedResponse>("newsfeed.search", request);
        }

        public Task<ApiCall<NewsfeedGetListsRequest, NewsfeedGetListsResponse>> GetLists(NewsfeedGetListsRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetListsRequest, NewsfeedGetListsResponse>("newsfeed.getLists", request);
        }

        public Task<ApiCall<NewsfeedSaveListRequest, int?>> SaveList(NewsfeedSaveListRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSaveListRequest, int?>("newsfeed.saveList", request);
        }

        public Task<ApiCall<NewsfeedDeleteListRequest, bool?>> DeleteList(NewsfeedDeleteListRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedDeleteListRequest, bool?>("newsfeed.deleteList", request);
        }

        public Task<ApiCall<NewsfeedUnsubscribeRequest, bool?>> Unsubscribe(NewsfeedUnsubscribeRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedUnsubscribeRequest, bool?>("newsfeed.unsubscribe", request);
        }

        public Task<ApiCall<NewsfeedGetSuggestedSourcesRequest, NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(NewsfeedGetSuggestedSourcesRequest request)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetSuggestedSourcesRequest, NewsfeedGetSuggestedSourcesResponse>("newsfeed.getSuggestedSources", request);
        }
    }

    internal class NotesApi : INotesApi
    {
        public Task<ApiCall<NotesGetRequest, NotesGetResponse>> Get(NotesGetRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesGetRequest, NotesGetResponse>("notes.get", request);
        }

        public Task<ApiCall<NotesGetByIdRequest, NotesNote>> GetById(NotesGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesGetByIdRequest, NotesNote>("notes.getById", request);
        }

        public Task<ApiCall<NotesAddRequest, int?>> Add(NotesAddRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesAddRequest, int?>("notes.add", request);
        }

        public Task<ApiCall<NotesEditRequest, bool?>> Edit(NotesEditRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesEditRequest, bool?>("notes.edit", request);
        }

        public Task<ApiCall<NotesDeleteRequest, bool?>> Delete(NotesDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesDeleteRequest, bool?>("notes.delete", request);
        }

        public Task<ApiCall<NotesGetCommentsRequest, NotesGetCommentsResponse>> GetComments(NotesGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesGetCommentsRequest, NotesGetCommentsResponse>("notes.getComments", request);
        }

        public Task<ApiCall<NotesCreateCommentRequest, int?>> CreateComment(NotesCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesCreateCommentRequest, int?>("notes.createComment", request);
        }

        public Task<ApiCall<NotesEditCommentRequest, bool?>> EditComment(NotesEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesEditCommentRequest, bool?>("notes.editComment", request);
        }

        public Task<ApiCall<NotesDeleteCommentRequest, bool?>> DeleteComment(NotesDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesDeleteCommentRequest, bool?>("notes.deleteComment", request);
        }

        public Task<ApiCall<NotesRestoreCommentRequest, bool?>> RestoreComment(NotesRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<NotesRestoreCommentRequest, bool?>("notes.restoreComment", request);
        }
    }

    internal class NotificationsApi : INotificationsApi
    {
        public Task<ApiCall<NotificationsGetRequest, NotificationsGetResponse>> Get(NotificationsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<NotificationsGetRequest, NotificationsGetResponse>("notifications.get", request);
        }

        public Task<ApiCall<NotificationsMarkAsViewedRequest, bool?>> MarkAsViewed(NotificationsMarkAsViewedRequest request)
        {
            return RequestManager.CreateRequestAsync<NotificationsMarkAsViewedRequest, bool?>("notifications.markAsViewed", request);
        }
    }

    internal class OrdersApi : IOrdersApi
    {
        public Task<ApiCall<OrdersGetRequest, IEnumerable<OrdersOrder>>> Get(OrdersGetRequest request)
        {
            return RequestManager.CreateRequestAsync<OrdersGetRequest, IEnumerable<OrdersOrder>>("orders.get", request);
        }

        public Task<ApiCall<OrdersGetByIdRequest, IEnumerable<OrdersOrder>>> GetById(OrdersGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<OrdersGetByIdRequest, IEnumerable<OrdersOrder>>("orders.getById", request);
        }

        public Task<ApiCall<OrdersChangeStateRequest, string>> ChangeState(OrdersChangeStateRequest request)
        {
            return RequestManager.CreateRequestAsync<OrdersChangeStateRequest, string>("orders.changeState", request);
        }

        public Task<ApiCall<OrdersGetAmountRequest, OrdersAmount>> GetAmount(OrdersGetAmountRequest request)
        {
            return RequestManager.CreateRequestAsync<OrdersGetAmountRequest, OrdersAmount>("orders.getAmount", request);
        }
    }

    internal class PagesApi : IPagesApi
    {
        public Task<ApiCall<PagesGetRequest, PagesWikipageFull>> Get(PagesGetRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesGetRequest, PagesWikipageFull>("pages.get", request);
        }

        public Task<ApiCall<PagesSaveRequest, int?>> Save(PagesSaveRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesSaveRequest, int?>("pages.save", request);
        }

        public Task<ApiCall<PagesSaveAccessRequest, int?>> SaveAccess(PagesSaveAccessRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesSaveAccessRequest, int?>("pages.saveAccess", request);
        }

        public Task<ApiCall<PagesGetHistoryRequest, IEnumerable<PagesWikipageVersion>>> GetHistory(PagesGetHistoryRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesGetHistoryRequest, IEnumerable<PagesWikipageVersion>>("pages.getHistory", request);
        }

        public Task<ApiCall<PagesGetTitlesRequest, IEnumerable<PagesWikipage>>> GetTitles(PagesGetTitlesRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesGetTitlesRequest, IEnumerable<PagesWikipage>>("pages.getTitles", request);
        }

        public Task<ApiCall<PagesGetVersionRequest, PagesWikipageFull>> GetVersion(PagesGetVersionRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesGetVersionRequest, PagesWikipageFull>("pages.getVersion", request);
        }

        public Task<ApiCall<PagesParseWikiRequest, string>> ParseWiki(PagesParseWikiRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesParseWikiRequest, string>("pages.parseWiki", request);
        }

        public Task<ApiCall<PagesClearCacheRequest, bool?>> ClearCache(PagesClearCacheRequest request)
        {
            return RequestManager.CreateRequestAsync<PagesClearCacheRequest, bool?>("pages.clearCache", request);
        }
    }

    internal class PhotosApi : IPhotosApi
    {
        public Task<ApiCall<PhotosCreateAlbumRequest, PhotosPhotoAlbumFull>> CreateAlbum(PhotosCreateAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosCreateAlbumRequest, PhotosPhotoAlbumFull>("photos.createAlbum", request);
        }

        public Task<ApiCall<PhotosEditAlbumRequest, bool?>> EditAlbum(PhotosEditAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosEditAlbumRequest, bool?>("photos.editAlbum", request);
        }

        public Task<ApiCall<PhotosGetAlbumsRequest, PhotosGetAlbumsResponse>> GetAlbums(PhotosGetAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAlbumsRequest, PhotosGetAlbumsResponse>("photos.getAlbums", request);
        }

        public Task<ApiCall<PhotosGetRequest, PhotosGetResponse>> Get(PhotosGetRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetRequest, PhotosGetResponse>("photos.get", request);
        }

        public Task<ApiCall<PhotosGetRequest, PhotosGetExtendedResponse>> GetExtended(PhotosGetRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetRequest, PhotosGetExtendedResponse>("photos.get", request);
        }

        public Task<ApiCall<PhotosGetAlbumsCountRequest, int?>> GetAlbumsCount(PhotosGetAlbumsCountRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAlbumsCountRequest, int?>("photos.getAlbumsCount", request);
        }

        public Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhoto>>> GetById(PhotosGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetByIdRequest, IEnumerable<PhotosPhoto>>("photos.getById", request);
        }

        public Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhotoFull>>> GetByIdExtended(PhotosGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetByIdRequest, IEnumerable<PhotosPhotoFull>>("photos.getById", request);
        }

        public Task<ApiCall<PhotosGetUploadServerRequest, PhotosPhotoUpload>> GetUploadServer(PhotosGetUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetUploadServerRequest, PhotosPhotoUpload>("photos.getUploadServer", request);
        }

        public Task<ApiCall<PhotosGetOwnerPhotoUploadServerRequest, PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(PhotosGetOwnerPhotoUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetOwnerPhotoUploadServerRequest, PhotosGetOwnerPhotoUploadServerResponse>("photos.getOwnerPhotoUploadServer", request);
        }

        public Task<ApiCall<PhotosGetChatUploadServerRequest, PhotosGetChatUploadServerResponse>> GetChatUploadServer(PhotosGetChatUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetChatUploadServerRequest, PhotosGetChatUploadServerResponse>("photos.getChatUploadServer", request);
        }

        public Task<ApiCall<PhotosGetMarketUploadServerRequest, PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(PhotosGetMarketUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetMarketUploadServerRequest, PhotosGetMarketUploadServerResponse>("photos.getMarketUploadServer", request);
        }

        public Task<ApiCall<PhotosGetMarketAlbumUploadServerRequest, PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(PhotosGetMarketAlbumUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetMarketAlbumUploadServerRequest, PhotosGetMarketAlbumUploadServerResponse>("photos.getMarketAlbumUploadServer", request);
        }

        public Task<ApiCall<PhotosSaveMarketPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketPhoto(PhotosSaveMarketPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveMarketPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", request);
        }

        public Task<ApiCall<PhotosSaveMarketAlbumPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(PhotosSaveMarketAlbumPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveMarketAlbumPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", request);
        }

        public Task<ApiCall<PhotosSaveOwnerPhotoRequest, PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(PhotosSaveOwnerPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoRequest, PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", request);
        }

        public Task<ApiCall<PhotosSaveWallPhotoRequest, IEnumerable<PhotosPhoto>>> SaveWallPhoto(PhotosSaveWallPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveWallPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", request);
        }

        public Task<ApiCall<PhotosGetWallUploadServerRequest, PhotosPhotoUpload>> GetWallUploadServer(PhotosGetWallUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetWallUploadServerRequest, PhotosPhotoUpload>("photos.getWallUploadServer", request);
        }

        public Task<ApiCall<PhotosGetMessagesUploadServerRequest, PhotosPhotoUpload>> GetMessagesUploadServer(PhotosGetMessagesUploadServerRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetMessagesUploadServerRequest, PhotosPhotoUpload>("photos.getMessagesUploadServer", request);
        }

        public Task<ApiCall<PhotosSaveMessagesPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(PhotosSaveMessagesPhotoRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveMessagesPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", request);
        }

        public Task<ApiCall<PhotosReportRequest, bool?>> Report(PhotosReportRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosReportRequest, bool?>("photos.report", request);
        }

        public Task<ApiCall<PhotosReportCommentRequest, bool?>> ReportComment(PhotosReportCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosReportCommentRequest, bool?>("photos.reportComment", request);
        }

        public Task<ApiCall<PhotosSearchRequest, PhotosSearchResponse>> Search(PhotosSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSearchRequest, PhotosSearchResponse>("photos.search", request);
        }

        public Task<ApiCall<PhotosSaveRequest, IEnumerable<PhotosPhoto>>> Save(PhotosSaveRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveRequest, IEnumerable<PhotosPhoto>>("photos.save", request);
        }

        public Task<ApiCall<PhotosCopyRequest, int?>> Copy(PhotosCopyRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosCopyRequest, int?>("photos.copy", request);
        }

        public Task<ApiCall<PhotosEditRequest, bool?>> Edit(PhotosEditRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosEditRequest, bool?>("photos.edit", request);
        }

        public Task<ApiCall<PhotosMoveRequest, bool?>> Move(PhotosMoveRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosMoveRequest, bool?>("photos.move", request);
        }

        public Task<ApiCall<PhotosMakeCoverRequest, bool?>> MakeCover(PhotosMakeCoverRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosMakeCoverRequest, bool?>("photos.makeCover", request);
        }

        public Task<ApiCall<PhotosReorderAlbumsRequest, bool?>> ReorderAlbums(PhotosReorderAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosReorderAlbumsRequest, bool?>("photos.reorderAlbums", request);
        }

        public Task<ApiCall<PhotosReorderPhotosRequest, bool?>> ReorderPhotos(PhotosReorderPhotosRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosReorderPhotosRequest, bool?>("photos.reorderPhotos", request);
        }

        public Task<ApiCall<PhotosGetAllRequest, PhotosGetAllResponse>> GetAll(PhotosGetAllRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllRequest, PhotosGetAllResponse>("photos.getAll", request);
        }

        public Task<ApiCall<PhotosGetAllRequest, PhotosGetAllExtendedResponse>> GetAllExtended(PhotosGetAllRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllRequest, PhotosGetAllExtendedResponse>("photos.getAll", request);
        }

        public Task<ApiCall<PhotosGetUserPhotosRequest, PhotosGetUserPhotosResponse>> GetUserPhotos(PhotosGetUserPhotosRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosRequest, PhotosGetUserPhotosResponse>("photos.getUserPhotos", request);
        }

        public Task<ApiCall<PhotosDeleteAlbumRequest, bool?>> DeleteAlbum(PhotosDeleteAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosDeleteAlbumRequest, bool?>("photos.deleteAlbum", request);
        }

        public Task<ApiCall<PhotosDeleteRequest, bool?>> Delete(PhotosDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosDeleteRequest, bool?>("photos.delete", request);
        }

        public Task<ApiCall<PhotosRestoreRequest, bool?>> Restore(PhotosRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosRestoreRequest, bool?>("photos.restore", request);
        }

        public Task<ApiCall<PhotosConfirmTagRequest, bool?>> ConfirmTag(PhotosConfirmTagRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosConfirmTagRequest, bool?>("photos.confirmTag", request);
        }

        public Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsResponse>> GetComments(PhotosGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetCommentsRequest, PhotosGetCommentsResponse>("photos.getComments", request);
        }

        public Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsExtendedResponse>> GetCommentsExtended(PhotosGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetCommentsRequest, PhotosGetCommentsExtendedResponse>("photos.getComments", request);
        }

        public Task<ApiCall<PhotosGetAllCommentsRequest, PhotosGetAllCommentsResponse>> GetAllComments(PhotosGetAllCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllCommentsRequest, PhotosGetAllCommentsResponse>("photos.getAllComments", request);
        }

        public Task<ApiCall<PhotosCreateCommentRequest, int?>> CreateComment(PhotosCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosCreateCommentRequest, int?>("photos.createComment", request);
        }

        public Task<ApiCall<PhotosDeleteCommentRequest, bool?>> DeleteComment(PhotosDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosDeleteCommentRequest, bool?>("photos.deleteComment", request);
        }

        public Task<ApiCall<PhotosRestoreCommentRequest, bool?>> RestoreComment(PhotosRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosRestoreCommentRequest, bool?>("photos.restoreComment", request);
        }

        public Task<ApiCall<PhotosEditCommentRequest, bool?>> EditComment(PhotosEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosEditCommentRequest, bool?>("photos.editComment", request);
        }

        public Task<ApiCall<PhotosGetTagsRequest, IEnumerable<PhotosPhotoTag>>> GetTags(PhotosGetTagsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetTagsRequest, IEnumerable<PhotosPhotoTag>>("photos.getTags", request);
        }

        public Task<ApiCall<PhotosPutTagRequest, int?>> PutTag(PhotosPutTagRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosPutTagRequest, int?>("photos.putTag", request);
        }

        public Task<ApiCall<PhotosRemoveTagRequest, bool?>> RemoveTag(PhotosRemoveTagRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosRemoveTagRequest, bool?>("photos.removeTag", request);
        }

        public Task<ApiCall<PhotosGetNewTagsRequest, PhotosGetNewTagsResponse>> GetNewTags(PhotosGetNewTagsRequest request)
        {
            return RequestManager.CreateRequestAsync<PhotosGetNewTagsRequest, PhotosGetNewTagsResponse>("photos.getNewTags", request);
        }
    }

    internal class PlacesApi : IPlacesApi
    {
        public Task<ApiCall<PlacesAddRequest, PlacesAddResponse>> Add(PlacesAddRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesAddRequest, PlacesAddResponse>("places.add", request);
        }

        public Task<ApiCall<PlacesGetByIdRequest, IEnumerable<PlacesPlaceMin>>> GetById(PlacesGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesGetByIdRequest, IEnumerable<PlacesPlaceMin>>("places.getById", request);
        }

        public Task<ApiCall<PlacesSearchRequest, PlacesSearchResponse>> Search(PlacesSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesSearchRequest, PlacesSearchResponse>("places.search", request);
        }

        public Task<ApiCall<PlacesCheckinRequest, PlacesCheckinResponse>> Checkin(PlacesCheckinRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesCheckinRequest, PlacesCheckinResponse>("places.checkin", request);
        }

        public Task<ApiCall<PlacesGetCheckinsRequest, PlacesGetCheckinsResponse>> GetCheckins(PlacesGetCheckinsRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesGetCheckinsRequest, PlacesGetCheckinsResponse>("places.getCheckins", request);
        }

        public Task<ApiCall<PlacesGetTypesRequest, IEnumerable<PlacesTypes>>> GetTypes(PlacesGetTypesRequest request)
        {
            return RequestManager.CreateRequestAsync<PlacesGetTypesRequest, IEnumerable<PlacesTypes>>("places.getTypes", request);
        }
    }

    internal class PollsApi : IPollsApi
    {
        public Task<ApiCall<PollsGetByIdRequest, PollsPoll>> GetById(PollsGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsGetByIdRequest, PollsPoll>("polls.getById", request);
        }

        public Task<ApiCall<PollsAddVoteRequest, bool?>> AddVote(PollsAddVoteRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsAddVoteRequest, bool?>("polls.addVote", request);
        }

        public Task<ApiCall<PollsDeleteVoteRequest, bool?>> DeleteVote(PollsDeleteVoteRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsDeleteVoteRequest, bool?>("polls.deleteVote", request);
        }

        public Task<ApiCall<PollsGetVotersRequest, IEnumerable<PollsVoters>>> GetVoters(PollsGetVotersRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsGetVotersRequest, IEnumerable<PollsVoters>>("polls.getVoters", request);
        }

        public Task<ApiCall<PollsCreateRequest, PollsPoll>> Create(PollsCreateRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsCreateRequest, PollsPoll>("polls.create", request);
        }

        public Task<ApiCall<PollsEditRequest, bool?>> Edit(PollsEditRequest request)
        {
            return RequestManager.CreateRequestAsync<PollsEditRequest, bool?>("polls.edit", request);
        }
    }

    internal class SearchApi : ISearchApi
    {
        public Task<ApiCall<SearchGetHintsRequest, IEnumerable<SearchHint>>> GetHints(SearchGetHintsRequest request)
        {
            return RequestManager.CreateRequestAsync<SearchGetHintsRequest, IEnumerable<SearchHint>>("search.getHints", request);
        }
    }

    internal class SecureApi : ISecureApi
    {
        public Task<ApiCall<SecureGetAppBalanceRequest, int?>> GetAppBalance(SecureGetAppBalanceRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureGetAppBalanceRequest, int?>("secure.getAppBalance", request);
        }

        public Task<ApiCall<SecureGetTransactionsHistoryRequest, IEnumerable<SecureTransaction>>> GetTransactionsHistory(SecureGetTransactionsHistoryRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureGetTransactionsHistoryRequest, IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", request);
        }

        public Task<ApiCall<SecureGetSMSHistoryRequest, IEnumerable<SecureSmsNotification>>> GetSMSHistory(SecureGetSMSHistoryRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureGetSMSHistoryRequest, IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", request);
        }

        public Task<ApiCall<SecureSendSMSNotificationRequest, bool?>> SendSMSNotification(SecureSendSMSNotificationRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureSendSMSNotificationRequest, bool?>("secure.sendSMSNotification", request);
        }

        public Task<ApiCall<SecureSendNotificationRequest, IEnumerable<int>>> SendNotification(SecureSendNotificationRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureSendNotificationRequest, IEnumerable<int>>("secure.sendNotification", request);
        }

        public Task<ApiCall<SecureSetCounterRequest, bool?>> SetCounter(SecureSetCounterRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureSetCounterRequest, bool?>("secure.setCounter", request);
        }

        public Task<ApiCall<SecureSetUserLevelRequest, bool?>> SetUserLevel(SecureSetUserLevelRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureSetUserLevelRequest, bool?>("secure.setUserLevel", request);
        }

        public Task<ApiCall<SecureGetUserLevelRequest, IEnumerable<SecureLevel>>> GetUserLevel(SecureGetUserLevelRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureGetUserLevelRequest, IEnumerable<SecureLevel>>("secure.getUserLevel", request);
        }

        public Task<ApiCall<SecureAddAppEventRequest, bool?>> AddAppEvent(SecureAddAppEventRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureAddAppEventRequest, bool?>("secure.addAppEvent", request);
        }

        public Task<ApiCall<SecureCheckTokenRequest, SecureTokenChecked>> CheckToken(SecureCheckTokenRequest request)
        {
            return RequestManager.CreateRequestAsync<SecureCheckTokenRequest, SecureTokenChecked>("secure.checkToken", request);
        }
    }

    internal class StatsApi : IStatsApi
    {
        public Task<ApiCall<StatsGetRequest, IEnumerable<StatsPeriod>>> Get(StatsGetRequest request)
        {
            return RequestManager.CreateRequestAsync<StatsGetRequest, IEnumerable<StatsPeriod>>("stats.get", request);
        }

        public Task<ApiCall<StatsTrackVisitorRequest, bool?>> TrackVisitor(StatsTrackVisitorRequest request)
        {
            return RequestManager.CreateRequestAsync<StatsTrackVisitorRequest, bool?>("stats.trackVisitor", request);
        }

        public Task<ApiCall<StatsGetPostReachRequest, IEnumerable<StatsWallpostStat>>> GetPostReach(StatsGetPostReachRequest request)
        {
            return RequestManager.CreateRequestAsync<StatsGetPostReachRequest, IEnumerable<StatsWallpostStat>>("stats.getPostReach", request);
        }
    }

    internal class StatusApi : IStatusApi
    {
        public Task<ApiCall<StatusGetRequest, StatusStatus>> Get(StatusGetRequest request)
        {
            return RequestManager.CreateRequestAsync<StatusGetRequest, StatusStatus>("status.get", request);
        }

        public Task<ApiCall<StatusSetRequest, bool?>> Set(StatusSetRequest request)
        {
            return RequestManager.CreateRequestAsync<StatusSetRequest, bool?>("status.set", request);
        }
    }

    internal class StorageApi : IStorageApi
    {
        public Task<ApiCall<StorageGetRequest, string>> Get(StorageGetRequest request)
        {
            return RequestManager.CreateRequestAsync<StorageGetRequest, string>("storage.get", request);
        }

        public Task<ApiCall<StorageSetRequest, bool?>> Set(StorageSetRequest request)
        {
            return RequestManager.CreateRequestAsync<StorageSetRequest, bool?>("storage.set", request);
        }

        public Task<ApiCall<StorageGetKeysRequest, IEnumerable<string>>> GetKeys(StorageGetKeysRequest request)
        {
            return RequestManager.CreateRequestAsync<StorageGetKeysRequest, IEnumerable<string>>("storage.getKeys", request);
        }
    }

    internal class UsersApi : IUsersApi
    {
        public Task<ApiCall<UsersGetRequest, IEnumerable<UsersUserXtrCounters>>> Get(UsersGetRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersGetRequest, IEnumerable<UsersUserXtrCounters>>("users.get", request);
        }

        public Task<ApiCall<UsersSearchRequest, UsersSearchResponse>> Search(UsersSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersSearchRequest, UsersSearchResponse>("users.search", request);
        }

        public Task<ApiCall<UsersIsAppUserRequest, bool?>> IsAppUser(UsersIsAppUserRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersIsAppUserRequest, bool?>("users.isAppUser", request);
        }

        public Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsResponse>> GetSubscriptions(UsersGetSubscriptionsRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsRequest, UsersGetSubscriptionsResponse>("users.getSubscriptions", request);
        }

        public Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UsersGetSubscriptionsRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsRequest, UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", request);
        }

        public Task<ApiCall<UsersGetFollowersRequest, UsersGetFollowersResponse>> GetFollowers(UsersGetFollowersRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersGetFollowersRequest, UsersGetFollowersResponse>("users.getFollowers", request);
        }

        public Task<ApiCall<UsersReportRequest, bool?>> Report(UsersReportRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersReportRequest, bool?>("users.report", request);
        }

        public Task<ApiCall<UsersGetNearbyRequest, UsersGetNearbyResponse>> GetNearby(UsersGetNearbyRequest request)
        {
            return RequestManager.CreateRequestAsync<UsersGetNearbyRequest, UsersGetNearbyResponse>("users.getNearby", request);
        }
    }

    internal class UtilsApi : IUtilsApi
    {
        public Task<ApiCall<UtilsCheckLinkRequest, UtilsLinkChecked>> CheckLink(UtilsCheckLinkRequest request)
        {
            return RequestManager.CreateRequestAsync<UtilsCheckLinkRequest, UtilsLinkChecked>("utils.checkLink", request);
        }

        public Task<ApiCall<UtilsResolveScreenNameRequest, UtilsDomainResolved>> ResolveScreenName(UtilsResolveScreenNameRequest request)
        {
            return RequestManager.CreateRequestAsync<UtilsResolveScreenNameRequest, UtilsDomainResolved>("utils.resolveScreenName", request);
        }

        public Task<ApiCall<UtilsGetServerTimeRequest, int?>> GetServerTime(UtilsGetServerTimeRequest request)
        {
            return RequestManager.CreateRequestAsync<UtilsGetServerTimeRequest, int?>("utils.getServerTime", request);
        }
    }

    internal class VideoApi : IVideoApi
    {
        public Task<ApiCall<VideoGetRequest, VideoGetResponse>> Get(VideoGetRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetRequest, VideoGetResponse>("video.get", request);
        }

        public Task<ApiCall<VideoGetRequest, VideoGetExtendedResponse>> GetExtended(VideoGetRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetRequest, VideoGetExtendedResponse>("video.get", request);
        }

        public Task<ApiCall<VideoEditRequest, bool?>> Edit(VideoEditRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoEditRequest, bool?>("video.edit", request);
        }

        public Task<ApiCall<VideoAddRequest, bool?>> Add(VideoAddRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoAddRequest, bool?>("video.add", request);
        }

        public Task<ApiCall<VideoSaveRequest, VideoSaveResult>> Save(VideoSaveRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoSaveRequest, VideoSaveResult>("video.save", request);
        }

        public Task<ApiCall<VideoDeleteRequest, bool?>> Delete(VideoDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoDeleteRequest, bool?>("video.delete", request);
        }

        public Task<ApiCall<VideoRestoreRequest, bool?>> Restore(VideoRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoRestoreRequest, bool?>("video.restore", request);
        }

        public Task<ApiCall<VideoSearchRequest, VideoSearchResponse>> Search(VideoSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoSearchRequest, VideoSearchResponse>("video.search", request);
        }

        public Task<ApiCall<VideoSearchRequest, VideoSearchExtendedResponse>> SearchExtended(VideoSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoSearchRequest, VideoSearchExtendedResponse>("video.search", request);
        }

        public Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosResponse>> GetUserVideos(VideoGetUserVideosRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetUserVideosRequest, VideoGetUserVideosResponse>("video.getUserVideos", request);
        }

        public Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(VideoGetUserVideosRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetUserVideosRequest, VideoGetUserVideosExtendedResponse>("video.getUserVideos", request);
        }

        public Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsResponse>> GetAlbums(VideoGetAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsRequest, VideoGetAlbumsResponse>("video.getAlbums", request);
        }

        public Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(VideoGetAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsRequest, VideoGetAlbumsExtendedResponse>("video.getAlbums", request);
        }

        public Task<ApiCall<VideoGetAlbumByIdRequest, VideoVideoAlbumFull>> GetAlbumById(VideoGetAlbumByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumByIdRequest, VideoVideoAlbumFull>("video.getAlbumById", request);
        }

        public Task<ApiCall<VideoAddAlbumRequest, VideoAddAlbumResponse>> AddAlbum(VideoAddAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoAddAlbumRequest, VideoAddAlbumResponse>("video.addAlbum", request);
        }

        public Task<ApiCall<VideoEditAlbumRequest, bool?>> EditAlbum(VideoEditAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoEditAlbumRequest, bool?>("video.editAlbum", request);
        }

        public Task<ApiCall<VideoDeleteAlbumRequest, bool?>> DeleteAlbum(VideoDeleteAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoDeleteAlbumRequest, bool?>("video.deleteAlbum", request);
        }

        public Task<ApiCall<VideoReorderAlbumsRequest, bool?>> ReorderAlbums(VideoReorderAlbumsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoReorderAlbumsRequest, bool?>("video.reorderAlbums", request);
        }

        public Task<ApiCall<VideoReorderVideosRequest, bool?>> ReorderVideos(VideoReorderVideosRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoReorderVideosRequest, bool?>("video.reorderVideos", request);
        }

        public Task<ApiCall<VideoAddToAlbumRequest, bool?>> AddToAlbum(VideoAddToAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoAddToAlbumRequest, bool?>("video.addToAlbum", request);
        }

        public Task<ApiCall<VideoRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(VideoRemoveFromAlbumRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoRemoveFromAlbumRequest, bool?>("video.removeFromAlbum", request);
        }

        public Task<ApiCall<VideoGetAlbumsByVideoRequest, IEnumerable<int>>> GetAlbumsByVideo(VideoGetAlbumsByVideoRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoRequest, IEnumerable<int>>("video.getAlbumsByVideo", request);
        }

        public Task<ApiCall<VideoGetAlbumsByVideoRequest, VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(VideoGetAlbumsByVideoRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoRequest, VideoGetAlbumsByVideoExtendedResponse>("video.getAlbumsByVideo", request);
        }

        public Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsResponse>> GetComments(VideoGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCommentsRequest, VideoGetCommentsResponse>("video.getComments", request);
        }

        public Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsExtendedResponse>> GetCommentsExtended(VideoGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCommentsRequest, VideoGetCommentsExtendedResponse>("video.getComments", request);
        }

        public Task<ApiCall<VideoCreateCommentRequest, int?>> CreateComment(VideoCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoCreateCommentRequest, int?>("video.createComment", request);
        }

        public Task<ApiCall<VideoDeleteCommentRequest, bool?>> DeleteComment(VideoDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoDeleteCommentRequest, bool?>("video.deleteComment", request);
        }

        public Task<ApiCall<VideoRestoreCommentRequest, bool?>> RestoreComment(VideoRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoRestoreCommentRequest, bool?>("video.restoreComment", request);
        }

        public Task<ApiCall<VideoEditCommentRequest, bool?>> EditComment(VideoEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoEditCommentRequest, bool?>("video.editComment", request);
        }

        public Task<ApiCall<VideoGetTagsRequest, IEnumerable<VideoVideoTag>>> GetTags(VideoGetTagsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetTagsRequest, IEnumerable<VideoVideoTag>>("video.getTags", request);
        }

        public Task<ApiCall<VideoPutTagRequest, int?>> PutTag(VideoPutTagRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoPutTagRequest, int?>("video.putTag", request);
        }

        public Task<ApiCall<VideoRemoveTagRequest, bool?>> RemoveTag(VideoRemoveTagRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoRemoveTagRequest, bool?>("video.removeTag", request);
        }

        public Task<ApiCall<VideoGetNewTagsRequest, VideoGetNewTagsResponse>> GetNewTags(VideoGetNewTagsRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetNewTagsRequest, VideoGetNewTagsResponse>("video.getNewTags", request);
        }

        public Task<ApiCall<VideoReportRequest, bool?>> Report(VideoReportRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoReportRequest, bool?>("video.report", request);
        }

        public Task<ApiCall<VideoReportCommentRequest, bool?>> ReportComment(VideoReportCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoReportCommentRequest, bool?>("video.reportComment", request);
        }

        public Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogResponse>> GetCatalog(VideoGetCatalogRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogRequest, VideoGetCatalogResponse>("video.getCatalog", request);
        }

        public Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogExtendedResponse>> GetCatalogExtended(VideoGetCatalogRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogRequest, VideoGetCatalogExtendedResponse>("video.getCatalog", request);
        }

        public Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionResponse>> GetCatalogSection(VideoGetCatalogSectionRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionRequest, VideoGetCatalogSectionResponse>("video.getCatalogSection", request);
        }

        public Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(VideoGetCatalogSectionRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionRequest, VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", request);
        }

        public Task<ApiCall<VideoHideCatalogSectionRequest, bool?>> HideCatalogSection(VideoHideCatalogSectionRequest request)
        {
            return RequestManager.CreateRequestAsync<VideoHideCatalogSectionRequest, bool?>("video.hideCatalogSection", request);
        }
    }

    internal class WallApi : IWallApi
    {
        public Task<ApiCall<WallGetRequest, WallGetResponse>> Get(WallGetRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetRequest, WallGetResponse>("wall.get", request);
        }

        public Task<ApiCall<WallGetRequest, WallGetExtendedResponse>> GetExtended(WallGetRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetRequest, WallGetExtendedResponse>("wall.get", request);
        }

        public Task<ApiCall<WallSearchRequest, WallSearchResponse>> Search(WallSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<WallSearchRequest, WallSearchResponse>("wall.search", request);
        }

        public Task<ApiCall<WallSearchRequest, WallSearchExtendedResponse>> SearchExtended(WallSearchRequest request)
        {
            return RequestManager.CreateRequestAsync<WallSearchRequest, WallSearchExtendedResponse>("wall.search", request);
        }

        public Task<ApiCall<WallGetByIdRequest, IEnumerable<WallWallpostFull>>> GetById(WallGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetByIdRequest, IEnumerable<WallWallpostFull>>("wall.getById", request);
        }

        public Task<ApiCall<WallGetByIdRequest, WallGetByIdExtendedResponse>> GetByIdExtended(WallGetByIdRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetByIdRequest, WallGetByIdExtendedResponse>("wall.getById", request);
        }

        public Task<ApiCall<WallPostRequest, WallPostResponse>> Post(WallPostRequest request)
        {
            return RequestManager.CreateRequestAsync<WallPostRequest, WallPostResponse>("wall.post", request);
        }

        public Task<ApiCall<WallRepostRequest, WallRepostResponse>> Repost(WallRepostRequest request)
        {
            return RequestManager.CreateRequestAsync<WallRepostRequest, WallRepostResponse>("wall.repost", request);
        }

        public Task<ApiCall<WallGetRepostsRequest, WallGetRepostsResponse>> GetReposts(WallGetRepostsRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetRepostsRequest, WallGetRepostsResponse>("wall.getReposts", request);
        }

        public Task<ApiCall<WallEditRequest, bool?>> Edit(WallEditRequest request)
        {
            return RequestManager.CreateRequestAsync<WallEditRequest, bool?>("wall.edit", request);
        }

        public Task<ApiCall<WallDeleteRequest, bool?>> Delete(WallDeleteRequest request)
        {
            return RequestManager.CreateRequestAsync<WallDeleteRequest, bool?>("wall.delete", request);
        }

        public Task<ApiCall<WallRestoreRequest, bool?>> Restore(WallRestoreRequest request)
        {
            return RequestManager.CreateRequestAsync<WallRestoreRequest, bool?>("wall.restore", request);
        }

        public Task<ApiCall<WallPinRequest, bool?>> Pin(WallPinRequest request)
        {
            return RequestManager.CreateRequestAsync<WallPinRequest, bool?>("wall.pin", request);
        }

        public Task<ApiCall<WallUnpinRequest, bool?>> Unpin(WallUnpinRequest request)
        {
            return RequestManager.CreateRequestAsync<WallUnpinRequest, bool?>("wall.unpin", request);
        }

        public Task<ApiCall<WallGetCommentsRequest, WallGetCommentsResponse>> GetComments(WallGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsRequest, WallGetCommentsResponse>("wall.getComments", request);
        }

        public Task<ApiCall<WallGetCommentsRequest, WallGetCommentsExtendedResponse>> GetCommentsExtended(WallGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsRequest, WallGetCommentsExtendedResponse>("wall.getComments", request);
        }

        public Task<ApiCall<WallCreateCommentRequest, WallCreateCommentResponse>> CreateComment(WallCreateCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<WallCreateCommentRequest, WallCreateCommentResponse>("wall.createComment", request);
        }

        public Task<ApiCall<WallEditCommentRequest, bool?>> EditComment(WallEditCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<WallEditCommentRequest, bool?>("wall.editComment", request);
        }

        public Task<ApiCall<WallDeleteCommentRequest, bool?>> DeleteComment(WallDeleteCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<WallDeleteCommentRequest, bool?>("wall.deleteComment", request);
        }

        public Task<ApiCall<WallRestoreCommentRequest, bool?>> RestoreComment(WallRestoreCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<WallRestoreCommentRequest, bool?>("wall.restoreComment", request);
        }

        public Task<ApiCall<WallReportPostRequest, bool?>> ReportPost(WallReportPostRequest request)
        {
            return RequestManager.CreateRequestAsync<WallReportPostRequest, bool?>("wall.reportPost", request);
        }

        public Task<ApiCall<WallReportCommentRequest, bool?>> ReportComment(WallReportCommentRequest request)
        {
            return RequestManager.CreateRequestAsync<WallReportCommentRequest, bool?>("wall.reportComment", request);
        }
    }

    internal class WidgetsApi : IWidgetsApi
    {
        public Task<ApiCall<WidgetsGetCommentsRequest, WidgetsGetCommentsResponse>> GetComments(WidgetsGetCommentsRequest request)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetCommentsRequest, WidgetsGetCommentsResponse>("widgets.getComments", request);
        }

        public Task<ApiCall<WidgetsGetPagesRequest, WidgetsGetPagesResponse>> GetPages(WidgetsGetPagesRequest request)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetPagesRequest, WidgetsGetPagesResponse>("widgets.getPages", request);
        }
    }
}