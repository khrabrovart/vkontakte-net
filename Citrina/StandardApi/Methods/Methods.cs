using System.Collections.Generic;
using System.Threading.Tasks;
using Citrina.StandardApi.Models;
using Citrina.StandardApi.Core;

namespace Citrina.StandardApi
{
    internal class AccountApi : IAccountApi
    {
        public async Task<ApiCall<AccountGetCountersRequest, AccountAccountCounters>> GetCounters(AccountGetCountersRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetCountersRequest, AccountAccountCounters>("account.getCounters", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetNameInMenuRequest, bool?>> SetNameInMenu(AccountSetNameInMenuRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetNameInMenuRequest, bool?>("account.setNameInMenu", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetOnlineRequest, bool?>> SetOnline(AccountSetOnlineRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetOnlineRequest, bool?>("account.setOnline", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetOfflineRequest, bool?>> SetOffline(AccountSetOfflineRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetOfflineRequest, bool?>("account.setOffline", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountLookupContactsRequest, AccountLookupResult>> LookupContacts(AccountLookupContactsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountLookupContactsRequest, AccountLookupResult>("account.lookupContacts", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountRegisterDeviceRequest, bool?>> RegisterDevice(AccountRegisterDeviceRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountRegisterDeviceRequest, bool?>("account.registerDevice", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountUnregisterDeviceRequest, bool?>> UnregisterDevice(AccountUnregisterDeviceRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountUnregisterDeviceRequest, bool?>("account.unregisterDevice", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetSilenceModeRequest, bool?>> SetSilenceMode(AccountSetSilenceModeRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetSilenceModeRequest, bool?>("account.setSilenceMode", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetPushSettingsRequest, AccountPushSettings>> GetPushSettings(AccountGetPushSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetPushSettingsRequest, AccountPushSettings>("account.getPushSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetPushSettingsRequest, bool?>> SetPushSettings(AccountSetPushSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetPushSettingsRequest, bool?>("account.setPushSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetAppPermissionsRequest, int?>> GetAppPermissions(AccountGetAppPermissionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetAppPermissionsRequest, int?>("account.getAppPermissions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetActiveOffersRequest, AccountGetActiveOffersResponse>> GetActiveOffers(AccountGetActiveOffersRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetActiveOffersRequest, AccountGetActiveOffersResponse>("account.getActiveOffers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountBanUserRequest, bool?>> BanUser(AccountBanUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountBanUserRequest, bool?>("account.banUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountUnbanUserRequest, bool?>> UnbanUser(AccountUnbanUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountUnbanUserRequest, bool?>("account.unbanUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetBannedRequest, AccountGetBannedResponse>> GetBanned(AccountGetBannedRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetBannedRequest, AccountGetBannedResponse>("account.getBanned", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetInfoRequest, AccountInfo>> GetInfo(AccountGetInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetInfoRequest, AccountInfo>("account.getInfo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSetInfoRequest, bool?>> SetInfo(AccountSetInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSetInfoRequest, bool?>("account.setInfo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountChangePasswordRequest, AccountChangePasswordResponse>> ChangePassword(AccountChangePasswordRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountChangePasswordRequest, AccountChangePasswordResponse>("account.changePassword", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountGetProfileInfoRequest, AccountUserSettings>> GetProfileInfo(AccountGetProfileInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountGetProfileInfoRequest, AccountUserSettings>("account.getProfileInfo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AccountSaveProfileInfoRequest, AccountSaveProfileInfoResponse>> SaveProfileInfo(AccountSaveProfileInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<AccountSaveProfileInfoRequest, AccountSaveProfileInfoResponse>("account.saveProfileInfo", request).ConfigureAwait(false);
        }
    }

    internal class AdsApi : IAdsApi
    {
        public async Task<ApiCall<AdsGetAccountsRequest, IEnumerable<AdsAccount>>> GetAccounts(AdsGetAccountsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetAccountsRequest, IEnumerable<AdsAccount>>("ads.getAccounts", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetClientsRequest, IEnumerable<AdsClient>>> GetClients(AdsGetClientsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetClientsRequest, IEnumerable<AdsClient>>("ads.getClients", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsCreateClientsRequest, IEnumerable<int>>> CreateClients(AdsCreateClientsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsCreateClientsRequest, IEnumerable<int>>("ads.createClients", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsUpdateClientsRequest, int?>> UpdateClients(AdsUpdateClientsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsUpdateClientsRequest, int?>("ads.updateClients", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsDeleteClientsRequest, int?>> DeleteClients(AdsDeleteClientsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsDeleteClientsRequest, int?>("ads.deleteClients", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetCampaignsRequest, IEnumerable<AdsCampaign>>> GetCampaigns(AdsGetCampaignsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetCampaignsRequest, IEnumerable<AdsCampaign>>("ads.getCampaigns", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsCreateCampaignsRequest, IEnumerable<int>>> CreateCampaigns(AdsCreateCampaignsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsCreateCampaignsRequest, IEnumerable<int>>("ads.createCampaigns", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsUpdateCampaignsRequest, int?>> UpdateCampaigns(AdsUpdateCampaignsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsUpdateCampaignsRequest, int?>("ads.updateCampaigns", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsDeleteCampaignsRequest, int?>> DeleteCampaigns(AdsDeleteCampaignsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsDeleteCampaignsRequest, int?>("ads.deleteCampaigns", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetAdsRequest, IEnumerable<AdsAd>>> GetAds(AdsGetAdsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetAdsRequest, IEnumerable<AdsAd>>("ads.getAds", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetAdsLayoutRequest, IEnumerable<AdsAdLayout>>> GetAdsLayout(AdsGetAdsLayoutRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetAdsLayoutRequest, IEnumerable<AdsAdLayout>>("ads.getAdsLayout", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetAdsTargetingRequest, IEnumerable<AdsTargSettings>>> GetAdsTargeting(AdsGetAdsTargetingRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetAdsTargetingRequest, IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsCreateAdsRequest, IEnumerable<int>>> CreateAds(AdsCreateAdsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsCreateAdsRequest, IEnumerable<int>>("ads.createAds", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsUpdateAdsRequest, IEnumerable<int>>> UpdateAds(AdsUpdateAdsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsUpdateAdsRequest, IEnumerable<int>>("ads.updateAds", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsDeleteAdsRequest, IEnumerable<int>>> DeleteAds(AdsDeleteAdsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsDeleteAdsRequest, IEnumerable<int>>("ads.deleteAds", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsCheckLinkRequest, AdsLinkStatus>> CheckLink(AdsCheckLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsCheckLinkRequest, AdsLinkStatus>("ads.checkLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetStatisticsRequest, IEnumerable<AdsStats>>> GetStatistics(AdsGetStatisticsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetStatisticsRequest, IEnumerable<AdsStats>>("ads.getStatistics", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetDemographicsRequest, IEnumerable<AdsDemoStats>>> GetDemographics(AdsGetDemographicsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetDemographicsRequest, IEnumerable<AdsDemoStats>>("ads.getDemographics", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetAdsPostsReachRequest, IEnumerable<AdsPostStats>>> GetAdsPostsReach(AdsGetAdsPostsReachRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetAdsPostsReachRequest, IEnumerable<AdsPostStats>>("ads.getAdsPostsReach", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetBudgetRequest, int?>> GetBudget(AdsGetBudgetRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetBudgetRequest, int?>("ads.getBudget", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetOfficeUsersRequest, IEnumerable<AdsUsers>>> GetOfficeUsers(AdsGetOfficeUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetOfficeUsersRequest, IEnumerable<AdsUsers>>("ads.getOfficeUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsAddOfficeUsersRequest, bool?>> AddOfficeUsers(AdsAddOfficeUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsAddOfficeUsersRequest, bool?>("ads.addOfficeUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsRemoveOfficeUsersRequest, bool?>> RemoveOfficeUsers(AdsRemoveOfficeUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsRemoveOfficeUsersRequest, bool?>("ads.removeOfficeUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetTargetingStatsRequest, AdsTargStats>> GetTargetingStats(AdsGetTargetingStatsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetTargetingStatsRequest, AdsTargStats>("ads.getTargetingStats", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestions>>> GetSuggestions(AdsGetSuggestionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(AdsGetSuggestionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(AdsGetSuggestionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(AdsGetSuggestionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetSuggestionsRequest, IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetCategoriesRequest, IEnumerable<AdsCategory>>> GetCategories(AdsGetCategoriesRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetCategoriesRequest, IEnumerable<AdsCategory>>("ads.getCategories", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetUploadURLRequest, string>> GetUploadURL(AdsGetUploadURLRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetUploadURLRequest, string>("ads.getUploadURL", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetVideoUploadURLRequest, string>> GetVideoUploadURL(AdsGetVideoUploadURLRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetVideoUploadURLRequest, string>("ads.getVideoUploadURL", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetFloodStatsRequest, AdsFloodStats>> GetFloodStats(AdsGetFloodStatsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetFloodStatsRequest, AdsFloodStats>("ads.getFloodStats", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetRejectionReasonRequest, AdsRejectReason>> GetRejectionReason(AdsGetRejectionReasonRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetRejectionReasonRequest, AdsRejectReason>("ads.getRejectionReason", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsCreateTargetGroupRequest, AdsCreateTargetGroupResponse>> CreateTargetGroup(AdsCreateTargetGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsCreateTargetGroupRequest, AdsCreateTargetGroupResponse>("ads.createTargetGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsUpdateTargetGroupRequest, bool?>> UpdateTargetGroup(AdsUpdateTargetGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsUpdateTargetGroupRequest, bool?>("ads.updateTargetGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsDeleteTargetGroupRequest, bool?>> DeleteTargetGroup(AdsDeleteTargetGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsDeleteTargetGroupRequest, bool?>("ads.deleteTargetGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsGetTargetGroupsRequest, IEnumerable<AdsTargetGroup>>> GetTargetGroups(AdsGetTargetGroupsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsGetTargetGroupsRequest, IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AdsImportTargetContactsRequest, int?>> ImportTargetContacts(AdsImportTargetContactsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AdsImportTargetContactsRequest, int?>("ads.importTargetContacts", request).ConfigureAwait(false);
        }
    }

    internal class AppsApi : IAppsApi
    {
        public async Task<ApiCall<AppsGetCatalogRequest, AppsGetCatalogResponse>> GetCatalog(AppsGetCatalogRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetCatalogRequest, AppsGetCatalogResponse>("apps.getCatalog", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsGetRequest, AppsGetResponse>> Get(AppsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetRequest, AppsGetResponse>("apps.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsSendRequestRequest, int?>> SendRequest(AppsSendRequestRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsSendRequestRequest, int?>("apps.sendRequest", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsDeleteAppRequestsRequest, bool?>> DeleteAppRequests(AppsDeleteAppRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsDeleteAppRequestsRequest, bool?>("apps.deleteAppRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsGetFriendsListRequest, AppsGetFriendsListResponse>> GetFriendsList(AppsGetFriendsListRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetFriendsListRequest, AppsGetFriendsListResponse>("apps.getFriendsList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardResponse>> GetLeaderboard(AppsGetLeaderboardRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetLeaderboardRequest, AppsGetLeaderboardResponse>("apps.getLeaderboard", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsGetLeaderboardRequest, AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(AppsGetLeaderboardRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetLeaderboardRequest, AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AppsGetScoreRequest, int?>> GetScore(AppsGetScoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<AppsGetScoreRequest, int?>("apps.getScore", request).ConfigureAwait(false);
        }
    }

    internal class AudioApi : IAudioApi
    {
        public async Task<ApiCall<AudioGetRequest, AudioGetResponse>> Get(AudioGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetRequest, AudioGetResponse>("audio.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetByIdRequest, IEnumerable<AudioAudioFull>>> GetById(AudioGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetByIdRequest, IEnumerable<AudioAudioFull>>("audio.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetLyricsRequest, AudioLyrics>> GetLyrics(AudioGetLyricsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetLyricsRequest, AudioLyrics>("audio.getLyrics", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioSearchRequest, AudioSearchResponse>> Search(AudioSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioSearchRequest, AudioSearchResponse>("audio.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetUploadServerRequest, AudioGetUploadServerResponse>> GetUploadServer(AudioGetUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetUploadServerRequest, AudioGetUploadServerResponse>("audio.getUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioSaveRequest, AudioAudio>> Save(AudioSaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioSaveRequest, AudioAudio>("audio.save", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioAddRequest, int?>> Add(AudioAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioAddRequest, int?>("audio.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioDeleteRequest, bool?>> Delete(AudioDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioDeleteRequest, bool?>("audio.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioEditRequest, int?>> Edit(AudioEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioEditRequest, int?>("audio.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioReorderRequest, bool?>> Reorder(AudioReorderRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioReorderRequest, bool?>("audio.reorder", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioRestoreRequest, bool?>> Restore(AudioRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioRestoreRequest, bool?>("audio.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetAlbumsRequest, AudioGetAlbumsResponse>> GetAlbums(AudioGetAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetAlbumsRequest, AudioGetAlbumsResponse>("audio.getAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioAddAlbumRequest, AudioAddAlbumResponse>> AddAlbum(AudioAddAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioAddAlbumRequest, AudioAddAlbumResponse>("audio.addAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioEditAlbumRequest, bool?>> EditAlbum(AudioEditAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioEditAlbumRequest, bool?>("audio.editAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioDeleteAlbumRequest, bool?>> DeleteAlbum(AudioDeleteAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioDeleteAlbumRequest, bool?>("audio.deleteAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioMoveToAlbumRequest, bool?>> MoveToAlbum(AudioMoveToAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioMoveToAlbumRequest, bool?>("audio.moveToAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioSetBroadcastRequest, IEnumerable<int>>> SetBroadcast(AudioSetBroadcastRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioSetBroadcastRequest, IEnumerable<int>>("audio.setBroadcast", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetBroadcastListRequest, IEnumerable<UsersUserBroadcast>>> GetBroadcastList(AudioGetBroadcastListRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetBroadcastListRequest, IEnumerable<UsersUserBroadcast>>("audio.getBroadcastList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetRecommendationsRequest, IEnumerable<AudioAudioFull>>> GetRecommendations(AudioGetRecommendationsRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetRecommendationsRequest, IEnumerable<AudioAudioFull>>("audio.getRecommendations", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetPopularRequest, IEnumerable<AudioAudioFull>>> GetPopular(AudioGetPopularRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetPopularRequest, IEnumerable<AudioAudioFull>>("audio.getPopular", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AudioGetCountRequest, int?>> GetCount(AudioGetCountRequest request)
        {
            return await RequestManager.CreateRequestAsync<AudioGetCountRequest, int?>("audio.getCount", request).ConfigureAwait(false);
        }
    }

    internal class AuthApi : IAuthApi
    {
        public async Task<ApiCall<AuthCheckPhoneRequest, bool?>> CheckPhone(AuthCheckPhoneRequest request)
        {
            return await RequestManager.CreateRequestAsync<AuthCheckPhoneRequest, bool?>("auth.checkPhone", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AuthSignupRequest, AuthSignupResponse>> Signup(AuthSignupRequest request)
        {
            return await RequestManager.CreateRequestAsync<AuthSignupRequest, AuthSignupResponse>("auth.signup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AuthConfirmRequest, AuthConfirmResponse>> Confirm(AuthConfirmRequest request)
        {
            return await RequestManager.CreateRequestAsync<AuthConfirmRequest, AuthConfirmResponse>("auth.confirm", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<AuthRestoreRequest, AuthRestoreResponse>> Restore(AuthRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<AuthRestoreRequest, AuthRestoreResponse>("auth.restore", request).ConfigureAwait(false);
        }
    }

    internal class BoardApi : IBoardApi
    {
        public async Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsResponse>> GetTopics(BoardGetTopicsRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardGetTopicsRequest, BoardGetTopicsResponse>("board.getTopics", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardGetTopicsRequest, BoardGetTopicsExtendedResponse>> GetTopicsExtended(BoardGetTopicsRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardGetTopicsRequest, BoardGetTopicsExtendedResponse>("board.getTopics", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsResponse>> GetComments(BoardGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardGetCommentsRequest, BoardGetCommentsResponse>("board.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardGetCommentsRequest, BoardGetCommentsExtendedResponse>> GetCommentsExtended(BoardGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardGetCommentsRequest, BoardGetCommentsExtendedResponse>("board.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardAddTopicRequest, int?>> AddTopic(BoardAddTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardAddTopicRequest, int?>("board.addTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardCreateCommentRequest, int?>> CreateComment(BoardCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardCreateCommentRequest, int?>("board.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardDeleteTopicRequest, bool?>> DeleteTopic(BoardDeleteTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardDeleteTopicRequest, bool?>("board.deleteTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardEditTopicRequest, bool?>> EditTopic(BoardEditTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardEditTopicRequest, bool?>("board.editTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardEditCommentRequest, bool?>> EditComment(BoardEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardEditCommentRequest, bool?>("board.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardRestoreCommentRequest, bool?>> RestoreComment(BoardRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardRestoreCommentRequest, bool?>("board.restoreComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardDeleteCommentRequest, bool?>> DeleteComment(BoardDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardDeleteCommentRequest, bool?>("board.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardOpenTopicRequest, bool?>> OpenTopic(BoardOpenTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardOpenTopicRequest, bool?>("board.openTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardCloseTopicRequest, bool?>> CloseTopic(BoardCloseTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardCloseTopicRequest, bool?>("board.closeTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardFixTopicRequest, bool?>> FixTopic(BoardFixTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardFixTopicRequest, bool?>("board.fixTopic", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<BoardUnfixTopicRequest, bool?>> UnfixTopic(BoardUnfixTopicRequest request)
        {
            return await RequestManager.CreateRequestAsync<BoardUnfixTopicRequest, bool?>("board.unfixTopic", request).ConfigureAwait(false);
        }
    }

    internal class DatabaseApi : IDatabaseApi
    {
        public async Task<ApiCall<DatabaseGetCountriesRequest, DatabaseGetCountriesResponse>> GetCountries(DatabaseGetCountriesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetCountriesRequest, DatabaseGetCountriesResponse>("database.getCountries", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetRegionsRequest, DatabaseGetRegionsResponse>> GetRegions(DatabaseGetRegionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetRegionsRequest, DatabaseGetRegionsResponse>("database.getRegions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetStreetsByIdRequest, IEnumerable<DatabaseStreet>>> GetStreetsById(DatabaseGetStreetsByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetStreetsByIdRequest, IEnumerable<DatabaseStreet>>("database.getStreetsById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetCountriesByIdRequest, IEnumerable<BaseCountry>>> GetCountriesById(DatabaseGetCountriesByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetCountriesByIdRequest, IEnumerable<BaseCountry>>("database.getCountriesById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetCitiesRequest, DatabaseGetCitiesResponse>> GetCities(DatabaseGetCitiesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetCitiesRequest, DatabaseGetCitiesResponse>("database.getCities", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetCitiesByIdRequest, IEnumerable<BaseObject>>> GetCitiesById(DatabaseGetCitiesByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetCitiesByIdRequest, IEnumerable<BaseObject>>("database.getCitiesById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetUniversitiesRequest, DatabaseGetUniversitiesResponse>> GetUniversities(DatabaseGetUniversitiesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetUniversitiesRequest, DatabaseGetUniversitiesResponse>("database.getUniversities", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetSchoolsRequest, DatabaseGetSchoolsResponse>> GetSchools(DatabaseGetSchoolsRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetSchoolsRequest, DatabaseGetSchoolsResponse>("database.getSchools", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetSchoolClassesRequest, IEnumerable<IEnumerable<string>>>> GetSchoolClasses(DatabaseGetSchoolClassesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetSchoolClassesRequest, IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetFacultiesRequest, DatabaseGetFacultiesResponse>> GetFaculties(DatabaseGetFacultiesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetFacultiesRequest, DatabaseGetFacultiesResponse>("database.getFaculties", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DatabaseGetChairsRequest, DatabaseGetChairsResponse>> GetChairs(DatabaseGetChairsRequest request)
        {
            return await RequestManager.CreateRequestAsync<DatabaseGetChairsRequest, DatabaseGetChairsResponse>("database.getChairs", request).ConfigureAwait(false);
        }
    }

    internal class DocsApi : IDocsApi
    {
        public async Task<ApiCall<DocsGetRequest, DocsGetResponse>> Get(DocsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsGetRequest, DocsGetResponse>("docs.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsGetByIdRequest, IEnumerable<DocsDoc>>> GetById(DocsGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsGetByIdRequest, IEnumerable<DocsDoc>>("docs.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsGetUploadServerRequest, DocsGetUploadServerResponse>> GetUploadServer(DocsGetUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsGetUploadServerRequest, DocsGetUploadServerResponse>("docs.getUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsGetWallUploadServerRequest, DocsGetWallUploadServerResponse>> GetWallUploadServer(DocsGetWallUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsGetWallUploadServerRequest, DocsGetWallUploadServerResponse>("docs.getWallUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsSaveRequest, IEnumerable<DocsDoc>>> Save(DocsSaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsSaveRequest, IEnumerable<DocsDoc>>("docs.save", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsDeleteRequest, bool?>> Delete(DocsDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsDeleteRequest, bool?>("docs.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsAddRequest, DocsAddResponse>> Add(DocsAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsAddRequest, DocsAddResponse>("docs.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsGetTypesRequest, DocsGetTypesResponse>> GetTypes(DocsGetTypesRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsGetTypesRequest, DocsGetTypesResponse>("docs.getTypes", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsSearchRequest, DocsSearchResponse>> Search(DocsSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsSearchRequest, DocsSearchResponse>("docs.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<DocsEditRequest, bool?>> Edit(DocsEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<DocsEditRequest, bool?>("docs.edit", request).ConfigureAwait(false);
        }
    }

    internal class FaveApi : IFaveApi
    {
        public async Task<ApiCall<FaveGetUsersRequest, FaveGetUsersResponse>> GetUsers(FaveGetUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetUsersRequest, FaveGetUsersResponse>("fave.getUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveGetPhotosRequest, FaveGetPhotosResponse>> GetPhotos(FaveGetPhotosRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetPhotosRequest, FaveGetPhotosResponse>("fave.getPhotos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveGetPostsRequest, FaveGetPostsResponse>> GetPosts(FaveGetPostsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetPostsRequest, FaveGetPostsResponse>("fave.getPosts", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveGetVideosRequest, FaveGetVideosResponse>> GetVideos(FaveGetVideosRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetVideosRequest, FaveGetVideosResponse>("fave.getVideos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveGetLinksRequest, FaveGetLinksResponse>> GetLinks(FaveGetLinksRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetLinksRequest, FaveGetLinksResponse>("fave.getLinks", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveGetMarketItemsRequest, FaveGetMarketItemsResponse>> GetMarketItems(FaveGetMarketItemsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveGetMarketItemsRequest, FaveGetMarketItemsResponse>("fave.getMarketItems", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveAddUserRequest, bool?>> AddUser(FaveAddUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveAddUserRequest, bool?>("fave.addUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveRemoveUserRequest, bool?>> RemoveUser(FaveRemoveUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveRemoveUserRequest, bool?>("fave.removeUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveAddGroupRequest, bool?>> AddGroup(FaveAddGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveAddGroupRequest, bool?>("fave.addGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveRemoveGroupRequest, bool?>> RemoveGroup(FaveRemoveGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveRemoveGroupRequest, bool?>("fave.removeGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveAddLinkRequest, bool?>> AddLink(FaveAddLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveAddLinkRequest, bool?>("fave.addLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FaveRemoveLinkRequest, bool?>> RemoveLink(FaveRemoveLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<FaveRemoveLinkRequest, bool?>("fave.removeLink", request).ConfigureAwait(false);
        }
    }

    internal class FriendsApi : IFriendsApi
    {
        public async Task<ApiCall<FriendsGetRequest, FriendsGetResponse>> Get(FriendsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRequest, FriendsGetResponse>("friends.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetRequest, FriendsGetFieldsResponse>> GetFields(FriendsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRequest, FriendsGetFieldsResponse>("friends.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetOnlineRequest, IEnumerable<int>>> GetOnline(FriendsGetOnlineRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetOnlineRequest, IEnumerable<int>>("friends.getOnline", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetOnlineRequest, FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(FriendsGetOnlineRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetOnlineRequest, FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetMutualRequest, IEnumerable<int>>> GetMutual(FriendsGetMutualRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetMutualRequest, IEnumerable<int>>("friends.getMutual", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetRecentRequest, IEnumerable<int>>> GetRecent(FriendsGetRecentRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRecentRequest, IEnumerable<int>>("friends.getRecent", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsResponse>> GetRequests(FriendsGetRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsResponse>("friends.getRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(FriendsGetRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsNeedMutualResponse>("friends.getRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetRequestsRequest, FriendsGetRequestsExtendedResponse>> GetRequestsExtended(FriendsGetRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetRequestsRequest, FriendsGetRequestsExtendedResponse>("friends.getRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsAddRequest, int?>> Add(FriendsAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsAddRequest, int?>("friends.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsEditRequest, bool?>> Edit(FriendsEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsEditRequest, bool?>("friends.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsDeleteRequest, FriendsDeleteResponse>> Delete(FriendsDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsDeleteRequest, FriendsDeleteResponse>("friends.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetListsRequest, FriendsGetListsResponse>> GetLists(FriendsGetListsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetListsRequest, FriendsGetListsResponse>("friends.getLists", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsAddListRequest, FriendsAddListResponse>> AddList(FriendsAddListRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsAddListRequest, FriendsAddListResponse>("friends.addList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsEditListRequest, bool?>> EditList(FriendsEditListRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsEditListRequest, bool?>("friends.editList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsDeleteListRequest, bool?>> DeleteList(FriendsDeleteListRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsDeleteListRequest, bool?>("friends.deleteList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetAppUsersRequest, IEnumerable<int>>> GetAppUsers(FriendsGetAppUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetAppUsersRequest, IEnumerable<int>>("friends.getAppUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetByPhonesRequest, IEnumerable<FriendsUserXtrPhone>>> GetByPhones(FriendsGetByPhonesRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetByPhonesRequest, IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsDeleteAllRequestsRequest, bool?>> DeleteAllRequests(FriendsDeleteAllRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsDeleteAllRequestsRequest, bool?>("friends.deleteAllRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetSuggestionsRequest, FriendsGetSuggestionsResponse>> GetSuggestions(FriendsGetSuggestionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetSuggestionsRequest, FriendsGetSuggestionsResponse>("friends.getSuggestions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsAreFriendsRequest, IEnumerable<FriendsFriendStatus>>> AreFriends(FriendsAreFriendsRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsAreFriendsRequest, IEnumerable<FriendsFriendStatus>>("friends.areFriends", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallResponse>> GetAvailableForCall(FriendsGetAvailableForCallRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallResponse>("friends.getAvailableForCall", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(FriendsGetAvailableForCallRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsGetAvailableForCallRequest, FriendsGetAvailableForCallFieldsResponse>("friends.getAvailableForCall", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<FriendsSearchRequest, FriendsSearchResponse>> Search(FriendsSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<FriendsSearchRequest, FriendsSearchResponse>("friends.search", request).ConfigureAwait(false);
        }
    }

    internal class GiftsApi : IGiftsApi
    {
        public async Task<ApiCall<GiftsGetRequest, GiftsGetResponse>> Get(GiftsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<GiftsGetRequest, GiftsGetResponse>("gifts.get", request).ConfigureAwait(false);
        }
    }

    internal class GroupsApi : IGroupsApi
    {
        public async Task<ApiCall<GroupsIsMemberRequest, bool?>> IsMember(GroupsIsMemberRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsIsMemberRequest, bool?>("groups.isMember", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupsIsMemberRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatus>>("groups.isMember", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsIsMemberRequest, GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupsIsMemberRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsIsMemberRequest, GroupsIsMemberExtendedResponse>("groups.isMember", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupsIsMemberRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsIsMemberRequest, IEnumerable<GroupsMemberStatusFull>>("groups.isMember", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetByIdRequest, IEnumerable<GroupsGroupFull>>> GetById(GroupsGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetByIdRequest, IEnumerable<GroupsGroupFull>>("groups.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetRequest, GroupsGetResponse>> Get(GroupsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetRequest, GroupsGetResponse>("groups.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetRequest, GroupsGetExtendedResponse>> GetExtended(GroupsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetRequest, GroupsGetExtendedResponse>("groups.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersResponse>> GetMembers(GroupsGetMembersRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersResponse>("groups.getMembers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFieldsResponse>> GetMembersFields(GroupsGetMembersRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersFieldsResponse>("groups.getMembers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetMembersRequest, GroupsGetMembersFilterResponse>> GetMembersFilter(GroupsGetMembersRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetMembersRequest, GroupsGetMembersFilterResponse>("groups.getMembers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsJoinRequest, bool?>> Join(GroupsJoinRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsJoinRequest, bool?>("groups.join", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsLeaveRequest, bool?>> Leave(GroupsLeaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsLeaveRequest, bool?>("groups.leave", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsSearchRequest, GroupsSearchResponse>> Search(GroupsSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsSearchRequest, GroupsSearchResponse>("groups.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCatalogRequest, GroupsGetCatalogResponse>> GetCatalog(GroupsGetCatalogRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCatalogRequest, GroupsGetCatalogResponse>("groups.getCatalog", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoResponse>> GetCatalogInfo(GroupsGetCatalogInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(GroupsGetCatalogInfoRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCatalogInfoRequest, GroupsGetCatalogInfoExtendedResponse>("groups.getCatalogInfo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesResponse>> GetInvites(GroupsGetInvitesRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetInvitesRequest, GroupsGetInvitesResponse>("groups.getInvites", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetInvitesRequest, GroupsGetInvitesExtendedResponse>> GetInvitesExtended(GroupsGetInvitesRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetInvitesRequest, GroupsGetInvitesExtendedResponse>("groups.getInvites", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetInvitedUsersRequest, GroupsGetInvitedUsersResponse>> GetInvitedUsers(GroupsGetInvitedUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetInvitedUsersRequest, GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsBanUserRequest, bool?>> BanUser(GroupsBanUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsBanUserRequest, bool?>("groups.banUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsUnbanUserRequest, bool?>> UnbanUser(GroupsUnbanUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsUnbanUserRequest, bool?>("groups.unbanUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetBannedRequest, GroupsGetBannedResponse>> GetBanned(GroupsGetBannedRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetBannedRequest, GroupsGetBannedResponse>("groups.getBanned", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsCreateRequest, GroupsGroup>> Create(GroupsCreateRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsCreateRequest, GroupsGroup>("groups.create", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsEditRequest, bool?>> Edit(GroupsEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsEditRequest, bool?>("groups.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsEditPlaceRequest, GroupsEditPlaceResponse>> EditPlace(GroupsEditPlaceRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsEditPlaceRequest, GroupsEditPlaceResponse>("groups.editPlace", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetSettingsRequest, GroupsGroupSettings>> GetSettings(GroupsGetSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetSettingsRequest, GroupsGroupSettings>("groups.getSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsResponse>> GetRequests(GroupsGetRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetRequestsRequest, GroupsGetRequestsResponse>("groups.getRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetRequestsRequest, GroupsGetRequestsFieldsResponse>> GetRequestsFields(GroupsGetRequestsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetRequestsRequest, GroupsGetRequestsFieldsResponse>("groups.getRequests", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsEditManagerRequest, bool?>> EditManager(GroupsEditManagerRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsEditManagerRequest, bool?>("groups.editManager", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsInviteRequest, bool?>> Invite(GroupsInviteRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsInviteRequest, bool?>("groups.invite", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsAddLinkRequest, GroupsGroupLink>> AddLink(GroupsAddLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsAddLinkRequest, GroupsGroupLink>("groups.addLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsDeleteLinkRequest, bool?>> DeleteLink(GroupsDeleteLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsDeleteLinkRequest, bool?>("groups.deleteLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsEditLinkRequest, bool?>> EditLink(GroupsEditLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsEditLinkRequest, bool?>("groups.editLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsReorderLinkRequest, bool?>> ReorderLink(GroupsReorderLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsReorderLinkRequest, bool?>("groups.reorderLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsRemoveUserRequest, bool?>> RemoveUser(GroupsRemoveUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsRemoveUserRequest, bool?>("groups.removeUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsApproveRequestRequest, bool?>> ApproveRequest(GroupsApproveRequestRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsApproveRequestRequest, bool?>("groups.approveRequest", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCallbackConfirmationCodeRequest, GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupsGetCallbackConfirmationCodeRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeRequest, GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCallbackServerSettingsRequest, GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupsGetCallbackServerSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsRequest, GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsGetCallbackSettingsRequest, GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupsGetCallbackSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsRequest, GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsSetCallbackServerRequest, GroupsSetCallbackServerResponse>> SetCallbackServer(GroupsSetCallbackServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsSetCallbackServerRequest, GroupsSetCallbackServerResponse>("groups.setCallbackServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsSetCallbackServerSettingsRequest, bool?>> SetCallbackServerSettings(GroupsSetCallbackServerSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsSetCallbackServerSettingsRequest, bool?>("groups.setCallbackServerSettings", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<GroupsSetCallbackSettingsRequest, bool?>> SetCallbackSettings(GroupsSetCallbackSettingsRequest request)
        {
            return await RequestManager.CreateRequestAsync<GroupsSetCallbackSettingsRequest, bool?>("groups.setCallbackSettings", request).ConfigureAwait(false);
        }
    }

    internal class LeadsApi : ILeadsApi
    {
        public async Task<ApiCall<LeadsCompleteRequest, LeadsComplete>> Complete(LeadsCompleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsCompleteRequest, LeadsComplete>("leads.complete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LeadsStartRequest, LeadsStart>> Start(LeadsStartRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsStartRequest, LeadsStart>("leads.start", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LeadsGetStatsRequest, LeadsLead>> GetStats(LeadsGetStatsRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsGetStatsRequest, LeadsLead>("leads.getStats", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LeadsGetUsersRequest, IEnumerable<LeadsEntry>>> GetUsers(LeadsGetUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsGetUsersRequest, IEnumerable<LeadsEntry>>("leads.getUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LeadsCheckUserRequest, LeadsChecked>> CheckUser(LeadsCheckUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsCheckUserRequest, LeadsChecked>("leads.checkUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LeadsMetricHitRequest, LeadsMetricHitResponse>> MetricHit(LeadsMetricHitRequest request)
        {
            return await RequestManager.CreateRequestAsync<LeadsMetricHitRequest, LeadsMetricHitResponse>("leads.metricHit", request).ConfigureAwait(false);
        }
    }

    internal class LikesApi : ILikesApi
    {
        public async Task<ApiCall<LikesGetListRequest, LikesGetListResponse>> GetList(LikesGetListRequest request)
        {
            return await RequestManager.CreateRequestAsync<LikesGetListRequest, LikesGetListResponse>("likes.getList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LikesGetListRequest, LikesGetListExtendedResponse>> GetListExtended(LikesGetListRequest request)
        {
            return await RequestManager.CreateRequestAsync<LikesGetListRequest, LikesGetListExtendedResponse>("likes.getList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LikesAddRequest, LikesAddResponse>> Add(LikesAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<LikesAddRequest, LikesAddResponse>("likes.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LikesDeleteRequest, LikesDeleteResponse>> Delete(LikesDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<LikesDeleteRequest, LikesDeleteResponse>("likes.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<LikesIsLikedRequest, LikesIsLikedResponse>> IsLiked(LikesIsLikedRequest request)
        {
            return await RequestManager.CreateRequestAsync<LikesIsLikedRequest, LikesIsLikedResponse>("likes.isLiked", request).ConfigureAwait(false);
        }
    }

    internal class MarketApi : IMarketApi
    {
        public async Task<ApiCall<MarketGetRequest, MarketGetResponse>> Get(MarketGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetRequest, MarketGetResponse>("market.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetRequest, MarketGetExtendedResponse>> GetExtended(MarketGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetRequest, MarketGetExtendedResponse>("market.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetByIdRequest, MarketGetByIdResponse>> GetById(MarketGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetByIdRequest, MarketGetByIdResponse>("market.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetByIdRequest, MarketGetByIdExtendedResponse>> GetByIdExtended(MarketGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetByIdRequest, MarketGetByIdExtendedResponse>("market.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketSearchRequest, MarketSearchResponse>> Search(MarketSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketSearchRequest, MarketSearchResponse>("market.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketSearchRequest, MarketSearchExtendedResponse>> SearchExtended(MarketSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketSearchRequest, MarketSearchExtendedResponse>("market.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetAlbumsRequest, MarketGetAlbumsResponse>> GetAlbums(MarketGetAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetAlbumsRequest, MarketGetAlbumsResponse>("market.getAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetAlbumByIdRequest, MarketGetAlbumByIdResponse>> GetAlbumById(MarketGetAlbumByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetAlbumByIdRequest, MarketGetAlbumByIdResponse>("market.getAlbumById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketCreateCommentRequest, int?>> CreateComment(MarketCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketCreateCommentRequest, int?>("market.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetCommentsRequest, MarketGetCommentsResponse>> GetComments(MarketGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetCommentsRequest, MarketGetCommentsResponse>("market.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketDeleteCommentRequest, bool?>> DeleteComment(MarketDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketDeleteCommentRequest, bool?>("market.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketRestoreCommentRequest, bool?>> RestoreComment(MarketRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketRestoreCommentRequest, bool?>("market.restoreComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketEditCommentRequest, bool?>> EditComment(MarketEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketEditCommentRequest, bool?>("market.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketReportCommentRequest, bool?>> ReportComment(MarketReportCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketReportCommentRequest, bool?>("market.reportComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketGetCategoriesRequest, MarketGetCategoriesResponse>> GetCategories(MarketGetCategoriesRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketGetCategoriesRequest, MarketGetCategoriesResponse>("market.getCategories", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketReportRequest, bool?>> Report(MarketReportRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketReportRequest, bool?>("market.report", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketAddRequest, MarketAddResponse>> Add(MarketAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketAddRequest, MarketAddResponse>("market.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketEditRequest, bool?>> Edit(MarketEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketEditRequest, bool?>("market.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketDeleteRequest, bool?>> Delete(MarketDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketDeleteRequest, bool?>("market.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketRestoreRequest, bool?>> Restore(MarketRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketRestoreRequest, bool?>("market.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketReorderItemsRequest, bool?>> ReorderItems(MarketReorderItemsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketReorderItemsRequest, bool?>("market.reorderItems", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketReorderAlbumsRequest, bool?>> ReorderAlbums(MarketReorderAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketReorderAlbumsRequest, bool?>("market.reorderAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketAddAlbumRequest, MarketAddAlbumResponse>> AddAlbum(MarketAddAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketAddAlbumRequest, MarketAddAlbumResponse>("market.addAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketEditAlbumRequest, bool?>> EditAlbum(MarketEditAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketEditAlbumRequest, bool?>("market.editAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketDeleteAlbumRequest, bool?>> DeleteAlbum(MarketDeleteAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketDeleteAlbumRequest, bool?>("market.deleteAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(MarketRemoveFromAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketRemoveFromAlbumRequest, bool?>("market.removeFromAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MarketAddToAlbumRequest, bool?>> AddToAlbum(MarketAddToAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<MarketAddToAlbumRequest, bool?>("market.addToAlbum", request).ConfigureAwait(false);
        }
    }

    internal class MessagesApi : IMessagesApi
    {
        public async Task<ApiCall<MessagesGetRequest, MessagesGetResponse>> Get(MessagesGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetRequest, MessagesGetResponse>("messages.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetDialogsRequest, MessagesGetDialogsResponse>> GetDialogs(MessagesGetDialogsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetDialogsRequest, MessagesGetDialogsResponse>("messages.getDialogs", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetByIdRequest, MessagesGetByIdResponse>> GetById(MessagesGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetByIdRequest, MessagesGetByIdResponse>("messages.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesSearchRequest, MessagesSearchResponse>> Search(MessagesSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesSearchRequest, MessagesSearchResponse>("messages.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetHistoryRequest, MessagesGetHistoryResponse>> GetHistory(MessagesGetHistoryRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetHistoryRequest, MessagesGetHistoryResponse>("messages.getHistory", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetHistoryAttachmentsRequest, MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(MessagesGetHistoryAttachmentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsRequest, MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesSendRequest, int?>> Send(MessagesSendRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesSendRequest, int?>("messages.send", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesDeleteRequest, bool?>> Delete(MessagesDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesDeleteRequest, bool?>("messages.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesDeleteDialogRequest, bool?>> DeleteDialog(MessagesDeleteDialogRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesDeleteDialogRequest, bool?>("messages.deleteDialog", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesRestoreRequest, bool?>> Restore(MessagesRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesRestoreRequest, bool?>("messages.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesMarkAsReadRequest, bool?>> MarkAsRead(MessagesMarkAsReadRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesMarkAsReadRequest, bool?>("messages.markAsRead", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesMarkAsImportantRequest, IEnumerable<int>>> MarkAsImportant(MessagesMarkAsImportantRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesMarkAsImportantRequest, IEnumerable<int>>("messages.markAsImportant", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetLongPollServerRequest, MessagesLongpollParams>> GetLongPollServer(MessagesGetLongPollServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetLongPollServerRequest, MessagesLongpollParams>("messages.getLongPollServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetLongPollHistoryRequest, MessagesGetLongPollHistoryResponse>> GetLongPollHistory(MessagesGetLongPollHistoryRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryRequest, MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatRequest, MessagesChat>> GetChat(MessagesGetChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatRequest, MessagesChat>("messages.getChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatRequest, MessagesChatFull>> GetChatFields(MessagesGetChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatRequest, MessagesChatFull>("messages.getChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChat>>> GetChatChatIds(MessagesGetChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatRequest, IEnumerable<MessagesChat>>("messages.getChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatRequest, IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(MessagesGetChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatRequest, IEnumerable<MessagesChatFull>>("messages.getChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesCreateChatRequest, int?>> CreateChat(MessagesCreateChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesCreateChatRequest, int?>("messages.createChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesEditChatRequest, bool?>> EditChat(MessagesEditChatRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesEditChatRequest, bool?>("messages.editChat", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsers(MessagesGetChatUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(MessagesGetChatUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<MessagesUserXtrInvitedBy>>("messages.getChatUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIds(MessagesGetChatUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetChatUsersRequest, IEnumerable<int>>> GetChatUsersChatIdsFields(MessagesGetChatUsersRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetChatUsersRequest, IEnumerable<int>>("messages.getChatUsers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesSetActivityRequest, bool?>> SetActivity(MessagesSetActivityRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesSetActivityRequest, bool?>("messages.setActivity", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesSearchDialogsRequest, string>> SearchDialogs(MessagesSearchDialogsRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesSearchDialogsRequest, string>("messages.searchDialogs", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesAddChatUserRequest, bool?>> AddChatUser(MessagesAddChatUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesAddChatUserRequest, bool?>("messages.addChatUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesRemoveChatUserRequest, bool?>> RemoveChatUser(MessagesRemoveChatUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesRemoveChatUserRequest, bool?>("messages.removeChatUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesGetLastActivityRequest, MessagesLastActivity>> GetLastActivity(MessagesGetLastActivityRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesGetLastActivityRequest, MessagesLastActivity>("messages.getLastActivity", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesSetChatPhotoRequest, MessagesSetChatPhotoResponse>> SetChatPhoto(MessagesSetChatPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesSetChatPhotoRequest, MessagesSetChatPhotoResponse>("messages.setChatPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesDeleteChatPhotoRequest, MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(MessagesDeleteChatPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoRequest, MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesDenyMessagesFromGroupRequest, bool?>> DenyMessagesFromGroup(MessagesDenyMessagesFromGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesDenyMessagesFromGroupRequest, bool?>("messages.denyMessagesFromGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesAllowMessagesFromGroupRequest, bool?>> AllowMessagesFromGroup(MessagesAllowMessagesFromGroupRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesAllowMessagesFromGroupRequest, bool?>("messages.allowMessagesFromGroup", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<MessagesIsMessagesFromGroupAllowedRequest, MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(MessagesIsMessagesFromGroupAllowedRequest request)
        {
            return await RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedRequest, MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", request).ConfigureAwait(false);
        }
    }

    internal class NewsfeedApi : INewsfeedApi
    {
        public async Task<ApiCall<NewsfeedGetRequest, NewsfeedGetResponse>> Get(NewsfeedGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetRequest, NewsfeedGetResponse>("newsfeed.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetRecommendedRequest, NewsfeedGetRecommendedResponse>> GetRecommended(NewsfeedGetRecommendedRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetRecommendedRequest, NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetCommentsRequest, NewsfeedGetCommentsResponse>> GetComments(NewsfeedGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetCommentsRequest, NewsfeedGetCommentsResponse>("newsfeed.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetMentionsRequest, NewsfeedGetMentionsResponse>> GetMentions(NewsfeedGetMentionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetMentionsRequest, NewsfeedGetMentionsResponse>("newsfeed.getMentions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedResponse>> GetBanned(NewsfeedGetBannedRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetBannedRequest, NewsfeedGetBannedResponse>("newsfeed.getBanned", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetBannedRequest, NewsfeedGetBannedExtendedResponse>> GetBannedExtended(NewsfeedGetBannedRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetBannedRequest, NewsfeedGetBannedExtendedResponse>("newsfeed.getBanned", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedAddBanRequest, bool?>> AddBan(NewsfeedAddBanRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedAddBanRequest, bool?>("newsfeed.addBan", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedDeleteBanRequest, bool?>> DeleteBan(NewsfeedDeleteBanRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedDeleteBanRequest, bool?>("newsfeed.deleteBan", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedIgnoreItemRequest, bool?>> IgnoreItem(NewsfeedIgnoreItemRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedIgnoreItemRequest, bool?>("newsfeed.ignoreItem", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedUnignoreItemRequest, bool?>> UnignoreItem(NewsfeedUnignoreItemRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedUnignoreItemRequest, bool?>("newsfeed.unignoreItem", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchResponse>> Search(NewsfeedSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedSearchRequest, NewsfeedSearchResponse>("newsfeed.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedSearchRequest, NewsfeedSearchExtendedResponse>> SearchExtended(NewsfeedSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedSearchRequest, NewsfeedSearchExtendedResponse>("newsfeed.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetListsRequest, NewsfeedGetListsResponse>> GetLists(NewsfeedGetListsRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetListsRequest, NewsfeedGetListsResponse>("newsfeed.getLists", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedSaveListRequest, int?>> SaveList(NewsfeedSaveListRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedSaveListRequest, int?>("newsfeed.saveList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedDeleteListRequest, bool?>> DeleteList(NewsfeedDeleteListRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedDeleteListRequest, bool?>("newsfeed.deleteList", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedUnsubscribeRequest, bool?>> Unsubscribe(NewsfeedUnsubscribeRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedUnsubscribeRequest, bool?>("newsfeed.unsubscribe", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NewsfeedGetSuggestedSourcesRequest, NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(NewsfeedGetSuggestedSourcesRequest request)
        {
            return await RequestManager.CreateRequestAsync<NewsfeedGetSuggestedSourcesRequest, NewsfeedGetSuggestedSourcesResponse>("newsfeed.getSuggestedSources", request).ConfigureAwait(false);
        }
    }

    internal class NotesApi : INotesApi
    {
        public async Task<ApiCall<NotesGetRequest, NotesGetResponse>> Get(NotesGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesGetRequest, NotesGetResponse>("notes.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesGetByIdRequest, NotesNote>> GetById(NotesGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesGetByIdRequest, NotesNote>("notes.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesAddRequest, int?>> Add(NotesAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesAddRequest, int?>("notes.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesEditRequest, bool?>> Edit(NotesEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesEditRequest, bool?>("notes.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesDeleteRequest, bool?>> Delete(NotesDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesDeleteRequest, bool?>("notes.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesGetCommentsRequest, NotesGetCommentsResponse>> GetComments(NotesGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesGetCommentsRequest, NotesGetCommentsResponse>("notes.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesCreateCommentRequest, int?>> CreateComment(NotesCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesCreateCommentRequest, int?>("notes.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesEditCommentRequest, bool?>> EditComment(NotesEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesEditCommentRequest, bool?>("notes.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesDeleteCommentRequest, bool?>> DeleteComment(NotesDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesDeleteCommentRequest, bool?>("notes.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotesRestoreCommentRequest, bool?>> RestoreComment(NotesRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotesRestoreCommentRequest, bool?>("notes.restoreComment", request).ConfigureAwait(false);
        }
    }

    internal class NotificationsApi : INotificationsApi
    {
        public async Task<ApiCall<NotificationsGetRequest, NotificationsGetResponse>> Get(NotificationsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotificationsGetRequest, NotificationsGetResponse>("notifications.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<NotificationsMarkAsViewedRequest, bool?>> MarkAsViewed(NotificationsMarkAsViewedRequest request)
        {
            return await RequestManager.CreateRequestAsync<NotificationsMarkAsViewedRequest, bool?>("notifications.markAsViewed", request).ConfigureAwait(false);
        }
    }

    internal class OrdersApi : IOrdersApi
    {
        public async Task<ApiCall<OrdersGetRequest, IEnumerable<OrdersOrder>>> Get(OrdersGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<OrdersGetRequest, IEnumerable<OrdersOrder>>("orders.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<OrdersGetByIdRequest, IEnumerable<OrdersOrder>>> GetById(OrdersGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<OrdersGetByIdRequest, IEnumerable<OrdersOrder>>("orders.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<OrdersChangeStateRequest, string>> ChangeState(OrdersChangeStateRequest request)
        {
            return await RequestManager.CreateRequestAsync<OrdersChangeStateRequest, string>("orders.changeState", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<OrdersGetAmountRequest, OrdersAmount>> GetAmount(OrdersGetAmountRequest request)
        {
            return await RequestManager.CreateRequestAsync<OrdersGetAmountRequest, OrdersAmount>("orders.getAmount", request).ConfigureAwait(false);
        }
    }

    internal class PagesApi : IPagesApi
    {
        public async Task<ApiCall<PagesGetRequest, PagesWikipageFull>> Get(PagesGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesGetRequest, PagesWikipageFull>("pages.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesSaveRequest, int?>> Save(PagesSaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesSaveRequest, int?>("pages.save", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesSaveAccessRequest, int?>> SaveAccess(PagesSaveAccessRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesSaveAccessRequest, int?>("pages.saveAccess", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesGetHistoryRequest, IEnumerable<PagesWikipageVersion>>> GetHistory(PagesGetHistoryRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesGetHistoryRequest, IEnumerable<PagesWikipageVersion>>("pages.getHistory", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesGetTitlesRequest, IEnumerable<PagesWikipage>>> GetTitles(PagesGetTitlesRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesGetTitlesRequest, IEnumerable<PagesWikipage>>("pages.getTitles", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesGetVersionRequest, PagesWikipageFull>> GetVersion(PagesGetVersionRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesGetVersionRequest, PagesWikipageFull>("pages.getVersion", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesParseWikiRequest, string>> ParseWiki(PagesParseWikiRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesParseWikiRequest, string>("pages.parseWiki", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PagesClearCacheRequest, bool?>> ClearCache(PagesClearCacheRequest request)
        {
            return await RequestManager.CreateRequestAsync<PagesClearCacheRequest, bool?>("pages.clearCache", request).ConfigureAwait(false);
        }
    }

    internal class PhotosApi : IPhotosApi
    {
        public async Task<ApiCall<PhotosCreateAlbumRequest, PhotosPhotoAlbumFull>> CreateAlbum(PhotosCreateAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosCreateAlbumRequest, PhotosPhotoAlbumFull>("photos.createAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosEditAlbumRequest, bool?>> EditAlbum(PhotosEditAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosEditAlbumRequest, bool?>("photos.editAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetAlbumsRequest, PhotosGetAlbumsResponse>> GetAlbums(PhotosGetAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetAlbumsRequest, PhotosGetAlbumsResponse>("photos.getAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetRequest, PhotosGetResponse>> Get(PhotosGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetRequest, PhotosGetResponse>("photos.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetRequest, PhotosGetExtendedResponse>> GetExtended(PhotosGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetRequest, PhotosGetExtendedResponse>("photos.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetAlbumsCountRequest, int?>> GetAlbumsCount(PhotosGetAlbumsCountRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetAlbumsCountRequest, int?>("photos.getAlbumsCount", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhoto>>> GetById(PhotosGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetByIdRequest, IEnumerable<PhotosPhoto>>("photos.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetByIdRequest, IEnumerable<PhotosPhotoFull>>> GetByIdExtended(PhotosGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetByIdRequest, IEnumerable<PhotosPhotoFull>>("photos.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetUploadServerRequest, PhotosPhotoUpload>> GetUploadServer(PhotosGetUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetUploadServerRequest, PhotosPhotoUpload>("photos.getUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetOwnerPhotoUploadServerRequest, PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(PhotosGetOwnerPhotoUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetOwnerPhotoUploadServerRequest, PhotosGetOwnerPhotoUploadServerResponse>("photos.getOwnerPhotoUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetChatUploadServerRequest, PhotosGetChatUploadServerResponse>> GetChatUploadServer(PhotosGetChatUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetChatUploadServerRequest, PhotosGetChatUploadServerResponse>("photos.getChatUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetMarketUploadServerRequest, PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(PhotosGetMarketUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetMarketUploadServerRequest, PhotosGetMarketUploadServerResponse>("photos.getMarketUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetMarketAlbumUploadServerRequest, PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(PhotosGetMarketAlbumUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetMarketAlbumUploadServerRequest, PhotosGetMarketAlbumUploadServerResponse>("photos.getMarketAlbumUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveMarketPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketPhoto(PhotosSaveMarketPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveMarketPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveMarketAlbumPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(PhotosSaveMarketAlbumPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveMarketAlbumPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveOwnerPhotoRequest, PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(PhotosSaveOwnerPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoRequest, PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveWallPhotoRequest, IEnumerable<PhotosPhoto>>> SaveWallPhoto(PhotosSaveWallPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveWallPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetWallUploadServerRequest, PhotosPhotoUpload>> GetWallUploadServer(PhotosGetWallUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetWallUploadServerRequest, PhotosPhotoUpload>("photos.getWallUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetMessagesUploadServerRequest, PhotosPhotoUpload>> GetMessagesUploadServer(PhotosGetMessagesUploadServerRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetMessagesUploadServerRequest, PhotosPhotoUpload>("photos.getMessagesUploadServer", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveMessagesPhotoRequest, IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(PhotosSaveMessagesPhotoRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveMessagesPhotoRequest, IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosReportRequest, bool?>> Report(PhotosReportRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosReportRequest, bool?>("photos.report", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosReportCommentRequest, bool?>> ReportComment(PhotosReportCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosReportCommentRequest, bool?>("photos.reportComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSearchRequest, PhotosSearchResponse>> Search(PhotosSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSearchRequest, PhotosSearchResponse>("photos.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosSaveRequest, IEnumerable<PhotosPhoto>>> Save(PhotosSaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosSaveRequest, IEnumerable<PhotosPhoto>>("photos.save", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosCopyRequest, int?>> Copy(PhotosCopyRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosCopyRequest, int?>("photos.copy", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosEditRequest, bool?>> Edit(PhotosEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosEditRequest, bool?>("photos.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosMoveRequest, bool?>> Move(PhotosMoveRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosMoveRequest, bool?>("photos.move", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosMakeCoverRequest, bool?>> MakeCover(PhotosMakeCoverRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosMakeCoverRequest, bool?>("photos.makeCover", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosReorderAlbumsRequest, bool?>> ReorderAlbums(PhotosReorderAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosReorderAlbumsRequest, bool?>("photos.reorderAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosReorderPhotosRequest, bool?>> ReorderPhotos(PhotosReorderPhotosRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosReorderPhotosRequest, bool?>("photos.reorderPhotos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetAllRequest, PhotosGetAllResponse>> GetAll(PhotosGetAllRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetAllRequest, PhotosGetAllResponse>("photos.getAll", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetAllRequest, PhotosGetAllExtendedResponse>> GetAllExtended(PhotosGetAllRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetAllRequest, PhotosGetAllExtendedResponse>("photos.getAll", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetUserPhotosRequest, PhotosGetUserPhotosResponse>> GetUserPhotos(PhotosGetUserPhotosRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetUserPhotosRequest, PhotosGetUserPhotosResponse>("photos.getUserPhotos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosDeleteAlbumRequest, bool?>> DeleteAlbum(PhotosDeleteAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosDeleteAlbumRequest, bool?>("photos.deleteAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosDeleteRequest, bool?>> Delete(PhotosDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosDeleteRequest, bool?>("photos.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosRestoreRequest, bool?>> Restore(PhotosRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosRestoreRequest, bool?>("photos.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosConfirmTagRequest, bool?>> ConfirmTag(PhotosConfirmTagRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosConfirmTagRequest, bool?>("photos.confirmTag", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsResponse>> GetComments(PhotosGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetCommentsRequest, PhotosGetCommentsResponse>("photos.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetCommentsRequest, PhotosGetCommentsExtendedResponse>> GetCommentsExtended(PhotosGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetCommentsRequest, PhotosGetCommentsExtendedResponse>("photos.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetAllCommentsRequest, PhotosGetAllCommentsResponse>> GetAllComments(PhotosGetAllCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetAllCommentsRequest, PhotosGetAllCommentsResponse>("photos.getAllComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosCreateCommentRequest, int?>> CreateComment(PhotosCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosCreateCommentRequest, int?>("photos.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosDeleteCommentRequest, bool?>> DeleteComment(PhotosDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosDeleteCommentRequest, bool?>("photos.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosRestoreCommentRequest, bool?>> RestoreComment(PhotosRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosRestoreCommentRequest, bool?>("photos.restoreComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosEditCommentRequest, bool?>> EditComment(PhotosEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosEditCommentRequest, bool?>("photos.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetTagsRequest, IEnumerable<PhotosPhotoTag>>> GetTags(PhotosGetTagsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetTagsRequest, IEnumerable<PhotosPhotoTag>>("photos.getTags", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosPutTagRequest, int?>> PutTag(PhotosPutTagRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosPutTagRequest, int?>("photos.putTag", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosRemoveTagRequest, bool?>> RemoveTag(PhotosRemoveTagRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosRemoveTagRequest, bool?>("photos.removeTag", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PhotosGetNewTagsRequest, PhotosGetNewTagsResponse>> GetNewTags(PhotosGetNewTagsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PhotosGetNewTagsRequest, PhotosGetNewTagsResponse>("photos.getNewTags", request).ConfigureAwait(false);
        }
    }

    internal class PlacesApi : IPlacesApi
    {
        public async Task<ApiCall<PlacesAddRequest, PlacesAddResponse>> Add(PlacesAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesAddRequest, PlacesAddResponse>("places.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PlacesGetByIdRequest, IEnumerable<PlacesPlaceMin>>> GetById(PlacesGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesGetByIdRequest, IEnumerable<PlacesPlaceMin>>("places.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PlacesSearchRequest, PlacesSearchResponse>> Search(PlacesSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesSearchRequest, PlacesSearchResponse>("places.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PlacesCheckinRequest, PlacesCheckinResponse>> Checkin(PlacesCheckinRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesCheckinRequest, PlacesCheckinResponse>("places.checkin", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PlacesGetCheckinsRequest, PlacesGetCheckinsResponse>> GetCheckins(PlacesGetCheckinsRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesGetCheckinsRequest, PlacesGetCheckinsResponse>("places.getCheckins", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PlacesGetTypesRequest, IEnumerable<PlacesTypes>>> GetTypes(PlacesGetTypesRequest request)
        {
            return await RequestManager.CreateRequestAsync<PlacesGetTypesRequest, IEnumerable<PlacesTypes>>("places.getTypes", request).ConfigureAwait(false);
        }
    }

    internal class PollsApi : IPollsApi
    {
        public async Task<ApiCall<PollsGetByIdRequest, PollsPoll>> GetById(PollsGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsGetByIdRequest, PollsPoll>("polls.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PollsAddVoteRequest, bool?>> AddVote(PollsAddVoteRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsAddVoteRequest, bool?>("polls.addVote", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PollsDeleteVoteRequest, bool?>> DeleteVote(PollsDeleteVoteRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsDeleteVoteRequest, bool?>("polls.deleteVote", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PollsGetVotersRequest, IEnumerable<PollsVoters>>> GetVoters(PollsGetVotersRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsGetVotersRequest, IEnumerable<PollsVoters>>("polls.getVoters", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PollsCreateRequest, PollsPoll>> Create(PollsCreateRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsCreateRequest, PollsPoll>("polls.create", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<PollsEditRequest, bool?>> Edit(PollsEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<PollsEditRequest, bool?>("polls.edit", request).ConfigureAwait(false);
        }
    }

    internal class SearchApi : ISearchApi
    {
        public async Task<ApiCall<SearchGetHintsRequest, IEnumerable<SearchHint>>> GetHints(SearchGetHintsRequest request)
        {
            return await RequestManager.CreateRequestAsync<SearchGetHintsRequest, IEnumerable<SearchHint>>("search.getHints", request).ConfigureAwait(false);
        }
    }

    internal class SecureApi : ISecureApi
    {
        public async Task<ApiCall<SecureGetAppBalanceRequest, int?>> GetAppBalance(SecureGetAppBalanceRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureGetAppBalanceRequest, int?>("secure.getAppBalance", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureGetTransactionsHistoryRequest, IEnumerable<SecureTransaction>>> GetTransactionsHistory(SecureGetTransactionsHistoryRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureGetTransactionsHistoryRequest, IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureGetSMSHistoryRequest, IEnumerable<SecureSmsNotification>>> GetSMSHistory(SecureGetSMSHistoryRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureGetSMSHistoryRequest, IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureSendSMSNotificationRequest, bool?>> SendSMSNotification(SecureSendSMSNotificationRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureSendSMSNotificationRequest, bool?>("secure.sendSMSNotification", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureSendNotificationRequest, IEnumerable<int>>> SendNotification(SecureSendNotificationRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureSendNotificationRequest, IEnumerable<int>>("secure.sendNotification", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureSetCounterRequest, bool?>> SetCounter(SecureSetCounterRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureSetCounterRequest, bool?>("secure.setCounter", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureSetUserLevelRequest, bool?>> SetUserLevel(SecureSetUserLevelRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureSetUserLevelRequest, bool?>("secure.setUserLevel", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureGetUserLevelRequest, IEnumerable<SecureLevel>>> GetUserLevel(SecureGetUserLevelRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureGetUserLevelRequest, IEnumerable<SecureLevel>>("secure.getUserLevel", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureAddAppEventRequest, bool?>> AddAppEvent(SecureAddAppEventRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureAddAppEventRequest, bool?>("secure.addAppEvent", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<SecureCheckTokenRequest, SecureTokenChecked>> CheckToken(SecureCheckTokenRequest request)
        {
            return await RequestManager.CreateRequestAsync<SecureCheckTokenRequest, SecureTokenChecked>("secure.checkToken", request).ConfigureAwait(false);
        }
    }

    internal class StatsApi : IStatsApi
    {
        public async Task<ApiCall<StatsGetRequest, IEnumerable<StatsPeriod>>> Get(StatsGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<StatsGetRequest, IEnumerable<StatsPeriod>>("stats.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<StatsTrackVisitorRequest, bool?>> TrackVisitor(StatsTrackVisitorRequest request)
        {
            return await RequestManager.CreateRequestAsync<StatsTrackVisitorRequest, bool?>("stats.trackVisitor", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<StatsGetPostReachRequest, IEnumerable<StatsWallpostStat>>> GetPostReach(StatsGetPostReachRequest request)
        {
            return await RequestManager.CreateRequestAsync<StatsGetPostReachRequest, IEnumerable<StatsWallpostStat>>("stats.getPostReach", request).ConfigureAwait(false);
        }
    }

    internal class StatusApi : IStatusApi
    {
        public async Task<ApiCall<StatusGetRequest, StatusStatus>> Get(StatusGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<StatusGetRequest, StatusStatus>("status.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<StatusSetRequest, bool?>> Set(StatusSetRequest request)
        {
            return await RequestManager.CreateRequestAsync<StatusSetRequest, bool?>("status.set", request).ConfigureAwait(false);
        }
    }

    internal class StorageApi : IStorageApi
    {
        public async Task<ApiCall<StorageGetRequest, string>> Get(StorageGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<StorageGetRequest, string>("storage.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<StorageSetRequest, bool?>> Set(StorageSetRequest request)
        {
            return await RequestManager.CreateRequestAsync<StorageSetRequest, bool?>("storage.set", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<StorageGetKeysRequest, IEnumerable<string>>> GetKeys(StorageGetKeysRequest request)
        {
            return await RequestManager.CreateRequestAsync<StorageGetKeysRequest, IEnumerable<string>>("storage.getKeys", request).ConfigureAwait(false);
        }
    }

    internal class UsersApi : IUsersApi
    {
        public async Task<ApiCall<UsersGetRequest, IEnumerable<UsersUserXtrCounters>>> Get(UsersGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersGetRequest, IEnumerable<UsersUserXtrCounters>>("users.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersSearchRequest, UsersSearchResponse>> Search(UsersSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersSearchRequest, UsersSearchResponse>("users.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersIsAppUserRequest, bool?>> IsAppUser(UsersIsAppUserRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersIsAppUserRequest, bool?>("users.isAppUser", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsResponse>> GetSubscriptions(UsersGetSubscriptionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersGetSubscriptionsRequest, UsersGetSubscriptionsResponse>("users.getSubscriptions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersGetSubscriptionsRequest, UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UsersGetSubscriptionsRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersGetSubscriptionsRequest, UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersGetFollowersRequest, UsersGetFollowersResponse>> GetFollowers(UsersGetFollowersRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersGetFollowersRequest, UsersGetFollowersResponse>("users.getFollowers", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersReportRequest, bool?>> Report(UsersReportRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersReportRequest, bool?>("users.report", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UsersGetNearbyRequest, UsersGetNearbyResponse>> GetNearby(UsersGetNearbyRequest request)
        {
            return await RequestManager.CreateRequestAsync<UsersGetNearbyRequest, UsersGetNearbyResponse>("users.getNearby", request).ConfigureAwait(false);
        }
    }

    internal class UtilsApi : IUtilsApi
    {
        public async Task<ApiCall<UtilsCheckLinkRequest, UtilsLinkChecked>> CheckLink(UtilsCheckLinkRequest request)
        {
            return await RequestManager.CreateRequestAsync<UtilsCheckLinkRequest, UtilsLinkChecked>("utils.checkLink", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UtilsResolveScreenNameRequest, UtilsDomainResolved>> ResolveScreenName(UtilsResolveScreenNameRequest request)
        {
            return await RequestManager.CreateRequestAsync<UtilsResolveScreenNameRequest, UtilsDomainResolved>("utils.resolveScreenName", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<UtilsGetServerTimeRequest, int?>> GetServerTime(UtilsGetServerTimeRequest request)
        {
            return await RequestManager.CreateRequestAsync<UtilsGetServerTimeRequest, int?>("utils.getServerTime", request).ConfigureAwait(false);
        }
    }

    internal class VideoApi : IVideoApi
    {
        public async Task<ApiCall<VideoGetRequest, VideoGetResponse>> Get(VideoGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetRequest, VideoGetResponse>("video.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetRequest, VideoGetExtendedResponse>> GetExtended(VideoGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetRequest, VideoGetExtendedResponse>("video.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoEditRequest, bool?>> Edit(VideoEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoEditRequest, bool?>("video.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoAddRequest, bool?>> Add(VideoAddRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoAddRequest, bool?>("video.add", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoSaveRequest, VideoSaveResult>> Save(VideoSaveRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoSaveRequest, VideoSaveResult>("video.save", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoDeleteRequest, bool?>> Delete(VideoDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoDeleteRequest, bool?>("video.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoRestoreRequest, bool?>> Restore(VideoRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoRestoreRequest, bool?>("video.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoSearchRequest, VideoSearchResponse>> Search(VideoSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoSearchRequest, VideoSearchResponse>("video.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoSearchRequest, VideoSearchExtendedResponse>> SearchExtended(VideoSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoSearchRequest, VideoSearchExtendedResponse>("video.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosResponse>> GetUserVideos(VideoGetUserVideosRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetUserVideosRequest, VideoGetUserVideosResponse>("video.getUserVideos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetUserVideosRequest, VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(VideoGetUserVideosRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetUserVideosRequest, VideoGetUserVideosExtendedResponse>("video.getUserVideos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsResponse>> GetAlbums(VideoGetAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetAlbumsRequest, VideoGetAlbumsResponse>("video.getAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetAlbumsRequest, VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(VideoGetAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetAlbumsRequest, VideoGetAlbumsExtendedResponse>("video.getAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetAlbumByIdRequest, VideoVideoAlbumFull>> GetAlbumById(VideoGetAlbumByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetAlbumByIdRequest, VideoVideoAlbumFull>("video.getAlbumById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoAddAlbumRequest, VideoAddAlbumResponse>> AddAlbum(VideoAddAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoAddAlbumRequest, VideoAddAlbumResponse>("video.addAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoEditAlbumRequest, bool?>> EditAlbum(VideoEditAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoEditAlbumRequest, bool?>("video.editAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoDeleteAlbumRequest, bool?>> DeleteAlbum(VideoDeleteAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoDeleteAlbumRequest, bool?>("video.deleteAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoReorderAlbumsRequest, bool?>> ReorderAlbums(VideoReorderAlbumsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoReorderAlbumsRequest, bool?>("video.reorderAlbums", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoReorderVideosRequest, bool?>> ReorderVideos(VideoReorderVideosRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoReorderVideosRequest, bool?>("video.reorderVideos", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoAddToAlbumRequest, bool?>> AddToAlbum(VideoAddToAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoAddToAlbumRequest, bool?>("video.addToAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoRemoveFromAlbumRequest, bool?>> RemoveFromAlbum(VideoRemoveFromAlbumRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoRemoveFromAlbumRequest, bool?>("video.removeFromAlbum", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetAlbumsByVideoRequest, IEnumerable<int>>> GetAlbumsByVideo(VideoGetAlbumsByVideoRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoRequest, IEnumerable<int>>("video.getAlbumsByVideo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetAlbumsByVideoRequest, VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(VideoGetAlbumsByVideoRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoRequest, VideoGetAlbumsByVideoExtendedResponse>("video.getAlbumsByVideo", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsResponse>> GetComments(VideoGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCommentsRequest, VideoGetCommentsResponse>("video.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCommentsRequest, VideoGetCommentsExtendedResponse>> GetCommentsExtended(VideoGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCommentsRequest, VideoGetCommentsExtendedResponse>("video.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoCreateCommentRequest, int?>> CreateComment(VideoCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoCreateCommentRequest, int?>("video.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoDeleteCommentRequest, bool?>> DeleteComment(VideoDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoDeleteCommentRequest, bool?>("video.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoRestoreCommentRequest, bool?>> RestoreComment(VideoRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoRestoreCommentRequest, bool?>("video.restoreComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoEditCommentRequest, bool?>> EditComment(VideoEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoEditCommentRequest, bool?>("video.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetTagsRequest, IEnumerable<VideoVideoTag>>> GetTags(VideoGetTagsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetTagsRequest, IEnumerable<VideoVideoTag>>("video.getTags", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoPutTagRequest, int?>> PutTag(VideoPutTagRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoPutTagRequest, int?>("video.putTag", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoRemoveTagRequest, bool?>> RemoveTag(VideoRemoveTagRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoRemoveTagRequest, bool?>("video.removeTag", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetNewTagsRequest, VideoGetNewTagsResponse>> GetNewTags(VideoGetNewTagsRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetNewTagsRequest, VideoGetNewTagsResponse>("video.getNewTags", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoReportRequest, bool?>> Report(VideoReportRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoReportRequest, bool?>("video.report", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoReportCommentRequest, bool?>> ReportComment(VideoReportCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoReportCommentRequest, bool?>("video.reportComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogResponse>> GetCatalog(VideoGetCatalogRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCatalogRequest, VideoGetCatalogResponse>("video.getCatalog", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCatalogRequest, VideoGetCatalogExtendedResponse>> GetCatalogExtended(VideoGetCatalogRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCatalogRequest, VideoGetCatalogExtendedResponse>("video.getCatalog", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionResponse>> GetCatalogSection(VideoGetCatalogSectionRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCatalogSectionRequest, VideoGetCatalogSectionResponse>("video.getCatalogSection", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoGetCatalogSectionRequest, VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(VideoGetCatalogSectionRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoGetCatalogSectionRequest, VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<VideoHideCatalogSectionRequest, bool?>> HideCatalogSection(VideoHideCatalogSectionRequest request)
        {
            return await RequestManager.CreateRequestAsync<VideoHideCatalogSectionRequest, bool?>("video.hideCatalogSection", request).ConfigureAwait(false);
        }
    }

    internal class WallApi : IWallApi
    {
        public async Task<ApiCall<WallGetRequest, WallGetResponse>> Get(WallGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetRequest, WallGetResponse>("wall.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetRequest, WallGetExtendedResponse>> GetExtended(WallGetRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetRequest, WallGetExtendedResponse>("wall.get", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallSearchRequest, WallSearchResponse>> Search(WallSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallSearchRequest, WallSearchResponse>("wall.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallSearchRequest, WallSearchExtendedResponse>> SearchExtended(WallSearchRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallSearchRequest, WallSearchExtendedResponse>("wall.search", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetByIdRequest, IEnumerable<WallWallpostFull>>> GetById(WallGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetByIdRequest, IEnumerable<WallWallpostFull>>("wall.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetByIdRequest, WallGetByIdExtendedResponse>> GetByIdExtended(WallGetByIdRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetByIdRequest, WallGetByIdExtendedResponse>("wall.getById", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallPostRequest, WallPostResponse>> Post(WallPostRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallPostRequest, WallPostResponse>("wall.post", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallRepostRequest, WallRepostResponse>> Repost(WallRepostRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallRepostRequest, WallRepostResponse>("wall.repost", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetRepostsRequest, WallGetRepostsResponse>> GetReposts(WallGetRepostsRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetRepostsRequest, WallGetRepostsResponse>("wall.getReposts", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallEditRequest, bool?>> Edit(WallEditRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallEditRequest, bool?>("wall.edit", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallDeleteRequest, bool?>> Delete(WallDeleteRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallDeleteRequest, bool?>("wall.delete", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallRestoreRequest, bool?>> Restore(WallRestoreRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallRestoreRequest, bool?>("wall.restore", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallPinRequest, bool?>> Pin(WallPinRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallPinRequest, bool?>("wall.pin", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallUnpinRequest, bool?>> Unpin(WallUnpinRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallUnpinRequest, bool?>("wall.unpin", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetCommentsRequest, WallGetCommentsResponse>> GetComments(WallGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetCommentsRequest, WallGetCommentsResponse>("wall.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallGetCommentsRequest, WallGetCommentsExtendedResponse>> GetCommentsExtended(WallGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallGetCommentsRequest, WallGetCommentsExtendedResponse>("wall.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallCreateCommentRequest, WallCreateCommentResponse>> CreateComment(WallCreateCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallCreateCommentRequest, WallCreateCommentResponse>("wall.createComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallEditCommentRequest, bool?>> EditComment(WallEditCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallEditCommentRequest, bool?>("wall.editComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallDeleteCommentRequest, bool?>> DeleteComment(WallDeleteCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallDeleteCommentRequest, bool?>("wall.deleteComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallRestoreCommentRequest, bool?>> RestoreComment(WallRestoreCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallRestoreCommentRequest, bool?>("wall.restoreComment", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallReportPostRequest, bool?>> ReportPost(WallReportPostRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallReportPostRequest, bool?>("wall.reportPost", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WallReportCommentRequest, bool?>> ReportComment(WallReportCommentRequest request)
        {
            return await RequestManager.CreateRequestAsync<WallReportCommentRequest, bool?>("wall.reportComment", request).ConfigureAwait(false);
        }
    }

    internal class WidgetsApi : IWidgetsApi
    {
        public async Task<ApiCall<WidgetsGetCommentsRequest, WidgetsGetCommentsResponse>> GetComments(WidgetsGetCommentsRequest request)
        {
            return await RequestManager.CreateRequestAsync<WidgetsGetCommentsRequest, WidgetsGetCommentsResponse>("widgets.getComments", request).ConfigureAwait(false);
        }

        public async Task<ApiCall<WidgetsGetPagesRequest, WidgetsGetPagesResponse>> GetPages(WidgetsGetPagesRequest request)
        {
            return await RequestManager.CreateRequestAsync<WidgetsGetPagesRequest, WidgetsGetPagesResponse>("widgets.getPages", request).ConfigureAwait(false);
        }
    }
}