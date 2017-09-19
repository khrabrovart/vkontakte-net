using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods
{
    internal class UsersApi : IUsersApi
    {
        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(UserAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", accessToken,
                new { access_token = accessToken, user_ids = userIds, fields, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", null,
                new { user_ids = userIds, fields, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(ServiceAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", accessToken,
                new { access_token = accessToken, user_ids = userIds, fields, name_case = nameCase });
        }

        public Task<ApiRequest<UsersSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null)
        {
            return RequestManager.CreateRequestAsync<UsersSearchResponse>("users.search", accessToken,
                new { access_token = accessToken, q, sort, offset, count, fields, city, country, hometown, university_country = universityCountry, university, university_year = universityYear, university_faculty = universityFaculty, university_chair = universityChair, sex, status, age_from = ageFrom, age_to = ageTo, birth_day = birthDay, birth_month = birthMonth, birth_year = birthYear, online, has_photo = hasPhoto, school_country = schoolCountry, school_city = schoolCity, school_class = schoolClass, school, school_year = schoolYear, religion, interests, company, position, group_id = groupId, from_list = fromList });
        }

        public Task<ApiRequest<bool?>> IsAppUser(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("users.isAppUser", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", accessToken,
                new { access_token = accessToken, user_id = userId, extended, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", null,
                new { user_id = userId, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", null,
                new { user_id = userId, extended, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(ServiceAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", accessToken,
                new { access_token = accessToken, user_id = userId, extended, offset, count, fields });
        }

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, fields, name_case = nameCase });
        }

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", null,
                new { user_id = userId, offset, count, fields, name_case = nameCase });
        }

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, fields, name_case = nameCase });
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? userId = null, string type = null, string comment = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("users.report", accessToken,
                new { access_token = accessToken, user_id = userId, type, comment });
        }

        public Task<ApiRequest<UsersGetNearbyResponse>> GetNearby(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<UsersGetNearbyResponse>("users.getNearby", accessToken,
                new { access_token = accessToken, latitude, longitude, accuracy, timeout, radius, fields, name_case = nameCase });
        }

    }

    internal class AuthApi : IAuthApi
    {
        public Task<ApiRequest<bool?>> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", null,
                new { phone, client_id = clientId, client_secret = clientSecret, auth_by_phone = authByPhone });
        }

        public Task<ApiRequest<bool?>> CheckPhone(ServiceAccessToken accessToken, string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", accessToken,
                new { access_token = accessToken, phone, client_id = clientId, client_secret = clientSecret, auth_by_phone = authByPhone });
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", null,
                new { first_name = firstName, last_name = lastName, birthday, client_id = clientId, client_secret = clientSecret, phone, password, test_mode = testMode, voice, sex, sid });
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(ServiceAccessToken accessToken, string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", accessToken,
                new { access_token = accessToken, first_name = firstName, last_name = lastName, birthday, client_id = clientId, client_secret = clientSecret, phone, password, test_mode = testMode, voice, sex, sid });
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", null,
                new { client_id = clientId, client_secret = clientSecret, phone, code, password, test_mode = testMode, intro });
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(ServiceAccessToken accessToken, int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", accessToken,
                new { access_token = accessToken, client_id = clientId, client_secret = clientSecret, phone, code, password, test_mode = testMode, intro });
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(string phone = null, string lastName = null)
        {
            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", null,
                new { phone, last_name = lastName });
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(ServiceAccessToken accessToken, string phone = null, string lastName = null)
        {
            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", accessToken,
                new { access_token = accessToken, phone, last_name = lastName });
        }

    }

    internal class WallApi : IWallApi
    {
        public Task<ApiRequest<WallGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, offset, count, filter, fields });
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, offset, count, filter, extended, fields });
        }

        public Task<ApiRequest<WallGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, offset, count, filter, fields });
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, offset, count, filter, extended, fields });
        }

        public Task<ApiRequest<WallSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, query, owners_only = ownersOnly, count, offset, fields });
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, query, owners_only = ownersOnly, count, offset, extended, fields });
        }

        public Task<ApiRequest<WallSearchResponse>> Search(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, query, owners_only = ownersOnly, count, offset, fields });
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, domain, query, owners_only = ownersOnly, count, offset, extended, fields });
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken,
                new { access_token = accessToken, posts, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken,
                new { access_token = accessToken, posts, extended, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", null,
                new { posts, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", null,
                new { posts, extended, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken,
                new { access_token = accessToken, posts, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken,
                new { access_token = accessToken, posts, extended, copy_history_depth = copyHistoryDepth, fields });
        }

        public Task<ApiRequest<WallPostResponse>> Post(UserAccessToken accessToken, int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null)
        {
            return RequestManager.CreateRequestAsync<WallPostResponse>("wall.post", accessToken,
                new { access_token = accessToken, owner_id = ownerId, friends_only = friendsOnly, from_group = fromGroup, message, attachments, services, signed, publish_date = publishDate, lat, @long, place_id = placeId, post_id = postId, guid, mark_as_ads = markAsAds });
        }

        public Task<ApiRequest<WallRepostResponse>> Repost(UserAccessToken accessToken, string @object = null, string message = null, int? groupId = null, bool? markAsAds = null)
        {
            return RequestManager.CreateRequestAsync<WallRepostResponse>("wall.repost", accessToken,
                new { access_token = accessToken, @object, message, group_id = groupId, mark_as_ads = markAsAds });
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, offset, count });
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", null,
                new { owner_id = ownerId, post_id = postId, offset, count });
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, offset, count });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, friends_only = friendsOnly, message, attachments, services, signed, publish_date = publishDate, lat, @long, place_id = placeId, mark_as_ads = markAsAds });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.delete", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId });
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.restore", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId });
        }

        public Task<ApiRequest<bool?>> Pin(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.pin", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId });
        }

        public Task<ApiRequest<bool?>> Unpin(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.unpin", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId });
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength });
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength, extended });
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", null,
                new { owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength });
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", null,
                new { owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength, extended });
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength });
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, preview_length = previewLength, extended });
        }

        public Task<ApiRequest<WallCreateCommentResponse>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<WallCreateCommentResponse>("wall.createComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, from_group = fromGroup, message, reply_to_comment = replyToComment, attachments, sticker_id = stickerId, guid });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.editComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, message, attachments });
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.deleteComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.restoreComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> ReportPost(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.reportPost", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId, reason });
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("wall.reportComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, reason });
        }

    }

    internal class PhotosApi : IPhotosApi
    {
        public Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbum(UserAccessToken accessToken, string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            return RequestManager.CreateRequestAsync<PhotosPhotoAlbumFull>("photos.createAlbum", accessToken,
                new { access_token = accessToken, title, group_id = groupId, description, privacy_view = privacyView, privacy_comment = privacyComment, upload_by_admins_only = uploadByAdminsOnly, comments_disabled = commentsDisabled });
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.editAlbum", accessToken,
                new { access_token = accessToken, album_id = albumId, title, description, owner_id = ownerId, privacy_view = privacyView, privacy_comment = privacyComment, upload_by_admins_only = uploadByAdminsOnly, comments_disabled = commentsDisabled });
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_ids = albumIds, offset, count, need_system = needSystem, need_covers = needCovers, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", null,
                new { owner_id = ownerId, album_ids = albumIds, offset, count, need_system = needSystem, need_covers = needCovers, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(ServiceAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_ids = albumIds, offset, count, need_system = needSystem, need_covers = needCovers, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, extended, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", null,
                new { owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", null,
                new { owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, extended, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, photo_ids = photoIds, rev, extended, feed_type = feedType, feed, photo_sizes = photoSizes, offset, count });
        }

        public Task<ApiRequest<int?>> GetAlbumsCount(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<int?>("photos.getAlbumsCount", accessToken,
                new { access_token = accessToken, user_id = userId, group_id = groupId });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken,
                new { access_token = accessToken, photos, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken,
                new { access_token = accessToken, photos, extended, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", null,
                new { photos, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", null,
                new { photos, extended, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken,
                new { access_token = accessToken, photos, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken,
                new { access_token = accessToken, photos, extended, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetUploadServer(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getUploadServer", accessToken,
                new { access_token = accessToken, album_id = albumId, group_id = groupId });
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(UserAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId, crop_x = cropX, crop_y = cropY, crop_x2 = cropX2, crop_y2 = cropY2 });
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(GroupAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId, crop_x = cropX, crop_y = cropY, crop_x2 = cropX2, crop_y2 = cropY2 });
        }

        public Task<ApiRequest<PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(UserAccessToken accessToken, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetOwnerPhotoUploadServerResponse>("photos.getOwnerPhotoUploadServer", accessToken,
                new { access_token = accessToken, owner_id = ownerId });
        }

        public Task<ApiRequest<PhotosGetChatUploadServerResponse>> GetChatUploadServer(UserAccessToken accessToken, int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetChatUploadServerResponse>("photos.getChatUploadServer", accessToken,
                new { access_token = accessToken, chat_id = chatId, crop_x = cropX, crop_y = cropY, crop_width = cropWidth });
        }

        public Task<ApiRequest<PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(UserAccessToken accessToken, int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetMarketUploadServerResponse>("photos.getMarketUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId, main_photo = mainPhoto, crop_x = cropX, crop_y = cropY, crop_width = cropWidth });
        }

        public Task<ApiRequest<PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetMarketAlbumUploadServerResponse>("photos.getMarketAlbumUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", accessToken,
                new { access_token = accessToken, group_id = groupId, photo, server, hash, crop_data = cropData, crop_hash = cropHash });
        }

        public Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhoto(UserAccessToken accessToken, string photo = null, string hash = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseImage>>("photos.saveOwnerCoverPhoto", accessToken,
                new { access_token = accessToken, photo, hash });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", accessToken,
                new { access_token = accessToken, group_id = groupId, photo, server, hash });
        }

        public Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(UserAccessToken accessToken, string server = null, string hash = null, string photo = null)
        {
            return RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", accessToken,
                new { access_token = accessToken, server, hash, photo });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhoto(UserAccessToken accessToken, int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", accessToken,
                new { access_token = accessToken, user_id = userId, group_id = groupId, photo, server, hash, latitude, longitude, caption });
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getWallUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(UserAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(GroupAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(UserAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken,
                new { access_token = accessToken, photo, server, hash });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(GroupAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken,
                new { access_token = accessToken, photo, server, hash });
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.report", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, reason });
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.reportComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, reason });
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(UserAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken,
                new { access_token = accessToken, q, lat, @long, start_time = startTime, end_time = endTime, sort, offset, count, radius });
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", null,
                new { q, lat, @long, start_time = startTime, end_time = endTime, sort, offset, count, radius });
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken,
                new { access_token = accessToken, q, lat, @long, start_time = startTime, end_time = endTime, sort, offset, count, radius });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> Save(UserAccessToken accessToken, int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.save", accessToken,
                new { access_token = accessToken, album_id = albumId, group_id = groupId, server, photos_list = photosList, hash, latitude, longitude, caption });
        }

        public Task<ApiRequest<int?>> Copy(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            return RequestManager.CreateRequestAsync<int?>("photos.copy", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, access_key = accessKey });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, caption, latitude, longitude, place_str = placeStr, foursquare_id = foursquareId, delete_place = deletePlace });
        }

        public Task<ApiRequest<bool?>> Move(UserAccessToken accessToken, int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.move", accessToken,
                new { access_token = accessToken, owner_id = ownerId, target_album_id = targetAlbumId, photo_id = photoId });
        }

        public Task<ApiRequest<bool?>> MakeCover(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.makeCover", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, album_id = albumId });
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.reorderAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, before, after });
        }

        public Task<ApiRequest<bool?>> ReorderPhotos(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? before = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.reorderPhotos", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, before, after });
        }

        public Task<ApiRequest<PhotosGetAllResponse>> GetAll(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllResponse>("photos.getAll", accessToken,
                new { access_token = accessToken, owner_id = ownerId, offset, count, photo_sizes = photoSizes, no_service_albums = noServiceAlbums, need_hidden = needHidden, skip_hidden = skipHidden });
        }

        public Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllExtended(UserAccessToken accessToken, int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllExtendedResponse>("photos.getAll", accessToken,
                new { access_token = accessToken, owner_id = ownerId, extended, offset, count, photo_sizes = photoSizes, no_service_albums = noServiceAlbums, need_hidden = needHidden, skip_hidden = skipHidden });
        }

        public Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosResponse>("photos.getUserPhotos", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, extended, sort });
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.deleteAlbum", accessToken,
                new { access_token = accessToken, album_id = albumId, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.delete", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId });
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.restore", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId });
        }

        public Task<ApiRequest<bool?>> ConfirmTag(UserAccessToken accessToken, int? ownerId = null, string photoId = null, int? tagId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.confirmTag", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, tag_id = tagId });
        }

        public Task<ApiRequest<PhotosGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetCommentsResponse>("photos.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, access_key = accessKey, fields });
        }

        public Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetCommentsExtendedResponse>("photos.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, access_key = accessKey, extended, fields });
        }

        public Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllComments(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetAllCommentsResponse>("photos.getAllComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, need_likes = needLikes, offset, count });
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<int?>("photos.createComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, message, attachments, from_group = fromGroup, reply_to_comment = replyToComment, sticker_id = stickerId, access_key = accessKey, guid });
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.deleteComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.restoreComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.editComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, message, attachments });
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoTag>>("photos.getTags", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, access_key = accessKey });
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null)
        {
            return RequestManager.CreateRequestAsync<int?>("photos.putTag", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, user_id = userId, x, y, x2, y2 });
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("photos.removeTag", accessToken,
                new { access_token = accessToken, owner_id = ownerId, photo_id = photoId, tag_id = tagId });
        }

        public Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PhotosGetNewTagsResponse>("photos.getNewTags", accessToken,
                new { access_token = accessToken, offset, count });
        }

    }

    internal class FriendsApi : IFriendsApi
    {
        public Task<ApiRequest<FriendsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken,
                new { access_token = accessToken, user_id = userId, order, list_id = listId, count, offset, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken,
                new { access_token = accessToken, user_id = userId, order, list_id = listId, count, offset, fields, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", null,
                new { user_id = userId, order, list_id = listId, count, offset, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", null,
                new { user_id = userId, order, list_id = listId, count, offset, fields, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken,
                new { access_token = accessToken, user_id = userId, order, list_id = listId, count, offset, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken,
                new { access_token = accessToken, user_id = userId, order, list_id = listId, count, offset, fields, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetOnline(UserAccessToken accessToken, int? userId = null, int? listId = null, string order = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getOnline", accessToken,
                new { access_token = accessToken, user_id = userId, list_id = listId, order, count, offset });
        }

        public Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(UserAccessToken accessToken, int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", accessToken,
                new { access_token = accessToken, user_id = userId, list_id = listId, online_mobile = onlineMobile, order, count, offset });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetMutual(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, string order = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getMutual", accessToken,
                new { access_token = accessToken, source_uid = sourceUid, target_uid = targetUid, order, count, offset });
        }

        public Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualTargetUids(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<FriendsMutualFriend>>("friends.getMutual", accessToken,
                new { access_token = accessToken, source_uid = sourceUid, target_uid = targetUid, target_uids = targetUids, order, count, offset });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetRecent(UserAccessToken accessToken, int? count = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getRecent", accessToken,
                new { access_token = accessToken, count });
        }

        public Task<ApiRequest<FriendsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? offset = null, int? count = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsResponse>("friends.getRequests", accessToken,
                new { access_token = accessToken, offset, count, @out, sort, suggested });
        }

        public Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(UserAccessToken accessToken, int? offset = null, int? count = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsNeedMutualResponse>("friends.getRequests", accessToken,
                new { access_token = accessToken, offset, count, need_mutual = needMutual, @out, sort, suggested });
        }

        public Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetRequestsExtendedResponse>("friends.getRequests", accessToken,
                new { access_token = accessToken, offset, count, extended, @out, sort, suggested });
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, int? userId = null, string text = null, bool? follow = null)
        {
            return RequestManager.CreateRequestAsync<int?>("friends.add", accessToken,
                new { access_token = accessToken, user_id = userId, text, follow });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? userId = null, IEnumerable<int?> listIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("friends.edit", accessToken,
                new { access_token = accessToken, user_id = userId, list_ids = listIds });
        }

        public Task<ApiRequest<FriendsDeleteResponse>> Delete(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<FriendsDeleteResponse>("friends.delete", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<FriendsGetListsResponse>> GetLists(UserAccessToken accessToken, int? userId = null, bool? returnSystem = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetListsResponse>("friends.getLists", accessToken,
                new { access_token = accessToken, user_id = userId, return_system = returnSystem });
        }

        public Task<ApiRequest<FriendsAddListResponse>> AddList(UserAccessToken accessToken, string name = null, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<FriendsAddListResponse>("friends.addList", accessToken,
                new { access_token = accessToken, name, user_ids = userIds });
        }

        public Task<ApiRequest<bool?>> EditList(UserAccessToken accessToken, string name = null, int? listId = null, IEnumerable<int?> userIds = null, IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("friends.editList", accessToken,
                new { access_token = accessToken, name, list_id = listId, user_ids = userIds, add_user_ids = addUserIds, delete_user_ids = deleteUserIds });
        }

        public Task<ApiRequest<bool?>> DeleteList(UserAccessToken accessToken, int? listId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("friends.deleteList", accessToken,
                new { access_token = accessToken, list_id = listId });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAppUsers()
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getAppUsers", null,
                new { });
        }

        public Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhones(UserAccessToken accessToken, IEnumerable<string> phones = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", accessToken,
                new { access_token = accessToken, phones, fields });
        }

        public Task<ApiRequest<bool?>> DeleteAllRequests()
        {
            return RequestManager.CreateRequestAsync<bool?>("friends.deleteAllRequests", null,
                new { });
        }

        public Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestions(UserAccessToken accessToken, IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetSuggestionsResponse>("friends.getSuggestions", accessToken,
                new { access_token = accessToken, filter, count, offset, fields, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriends(UserAccessToken accessToken, IEnumerable<int?> userIds = null, bool? needSign = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<FriendsFriendStatus>>("friends.areFriends", accessToken,
                new { access_token = accessToken, user_ids = userIds, need_sign = needSign });
        }

        public Task<ApiRequest<FriendsGetAvailableForCallResponse>> GetAvailableForCall(UserAccessToken accessToken, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallResponse>("friends.getAvailableForCall", accessToken,
                new { access_token = accessToken, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallFieldsResponse>("friends.getAvailableForCall", accessToken,
                new { access_token = accessToken, fields, name_case = nameCase });
        }

        public Task<ApiRequest<FriendsSearchResponse>> Search(UserAccessToken accessToken, int? userId = null, string q = null, IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<FriendsSearchResponse>("friends.search", accessToken,
                new { access_token = accessToken, user_id = userId, q, fields, name_case = nameCase, offset, count });
        }

    }

    internal class WidgetsApi : IWidgetsApi
    {
        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", accessToken,
                new { access_token = accessToken, widget_api_id = widgetApiId, url, page_id = pageId, order, fields, count });
        }

        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", null,
                new { widget_api_id = widgetApiId, url, page_id = pageId, order, fields, count });
        }

        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", accessToken,
                new { access_token = accessToken, widget_api_id = widgetApiId, url, page_id = pageId, order, fields, count });
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(UserAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", accessToken,
                new { access_token = accessToken, widget_api_id = widgetApiId, order, period, count });
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", null,
                new { widget_api_id = widgetApiId, order, period, count });
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(ServiceAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", accessToken,
                new { access_token = accessToken, widget_api_id = widgetApiId, order, period, count });
        }

    }

    internal class SecureApi : ISecureApi
    {
        public Task<ApiRequest<int?>> GetAppBalance(ServiceAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<int?>("secure.getAppBalance", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistory(ServiceAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistory(ServiceAccessToken accessToken, int? userId = null, int? dateFrom = null, int? dateTo = null, int? limit = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", accessToken,
                new { access_token = accessToken, user_id = userId, date_from = dateFrom, date_to = dateTo, limit });
        }

        public Task<ApiRequest<bool?>> SendSMSNotification(ServiceAccessToken accessToken, int? userId = null, string message = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("secure.sendSMSNotification", accessToken,
                new { access_token = accessToken, user_id = userId, message });
        }

        public Task<ApiRequest<IEnumerable<int?>>> SendNotification(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null, int? userId = null, string message = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("secure.sendNotification", accessToken,
                new { access_token = accessToken, user_ids = userIds, user_id = userId, message });
        }

        public Task<ApiRequest<bool?>> SetCounter(ServiceAccessToken accessToken, IEnumerable<string> counters = null, int? userId = null, int? counter = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("secure.setCounter", accessToken,
                new { access_token = accessToken, counters, user_id = userId, counter });
        }

        public Task<ApiRequest<bool?>> SetUserLevel(ServiceAccessToken accessToken, IEnumerable<string> levels = null, int? userId = null, int? level = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("secure.setUserLevel", accessToken,
                new { access_token = accessToken, levels, user_id = userId, level });
        }

        public Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevel(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<SecureLevel>>("secure.getUserLevel", accessToken,
                new { access_token = accessToken, user_ids = userIds });
        }

        public Task<ApiRequest<bool?>> AddAppEvent(UserAccessToken accessToken, int? userId = null, int? activityId = null, int? value = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("secure.addAppEvent", accessToken,
                new { access_token = accessToken, user_id = userId, activity_id = activityId, value });
        }

        public Task<ApiRequest<SecureTokenChecked>> CheckToken(UserAccessToken accessToken, string token = null, string ip = null)
        {
            return RequestManager.CreateRequestAsync<SecureTokenChecked>("secure.checkToken", accessToken,
                new { access_token = accessToken, token, ip });
        }

    }

    internal class StreamingApi : IStreamingApi
    {
        public Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrl(ServiceAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<StreamingGetServerUrlResponse>("streaming.getServerUrl", accessToken,
                new { access_token = accessToken });
        }

    }

    internal class StorageApi : IStorageApi
    {
        public Task<ApiRequest<string>> Get(UserAccessToken accessToken, string key = null, IEnumerable<string> keys = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<string>("storage.get", accessToken,
                new { access_token = accessToken, key, keys, user_id = userId });
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string key = null, string value = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("storage.set", accessToken,
                new { access_token = accessToken, key, value, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<string>>> GetKeys(UserAccessToken accessToken, int? userId = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<string>>("storage.getKeys", accessToken,
                new { access_token = accessToken, user_id = userId, count });
        }

    }

    internal class OrdersApi : IOrdersApi
    {
        public Task<ApiRequest<IEnumerable<OrdersOrder>>> Get(UserAccessToken accessToken, int? count = null, bool? testMode = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.get", accessToken,
                new { access_token = accessToken, count, test_mode = testMode });
        }

        public Task<ApiRequest<IEnumerable<OrdersOrder>>> GetById(UserAccessToken accessToken, int? orderId = null, IEnumerable<int?> orderIds = null, bool? testMode = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.getById", accessToken,
                new { access_token = accessToken, order_id = orderId, order_ids = orderIds, test_mode = testMode });
        }

        public Task<ApiRequest<string>> ChangeState(UserAccessToken accessToken, int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null)
        {
            return RequestManager.CreateRequestAsync<string>("orders.changeState", accessToken,
                new { access_token = accessToken, order_id = orderId, action, app_order_id = appOrderId, test_mode = testMode });
        }

        public Task<ApiRequest<OrdersAmount>> GetAmount(int? userId = null, IEnumerable<string> votes = null)
        {
            return RequestManager.CreateRequestAsync<OrdersAmount>("orders.getAmount", null,
                new { user_id = userId, votes });
        }

    }

    internal class StatusApi : IStatusApi
    {
        public Task<ApiRequest<StatusStatus>> Get(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<StatusStatus>("status.get", accessToken,
                new { access_token = accessToken, user_id = userId, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("status.set", accessToken,
                new { access_token = accessToken, text, group_id = groupId });
        }

    }

    internal class LeadsApi : ILeadsApi
    {
        public Task<ApiRequest<LeadsComplete>> Complete(UserAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken,
                new { access_token = accessToken, vk_sid = vkSid, secret, comment });
        }

        public Task<ApiRequest<LeadsComplete>> Complete(string vkSid = null, string secret = null, string comment = null)
        {
            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", null,
                new { vk_sid = vkSid, secret, comment });
        }

        public Task<ApiRequest<LeadsComplete>> Complete(ServiceAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken,
                new { access_token = accessToken, vk_sid = vkSid, secret, comment });
        }

        public Task<ApiRequest<LeadsStart>> Start(UserAccessToken accessToken, int? leadId = null, string secret = null)
        {
            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken,
                new { access_token = accessToken, lead_id = leadId, secret });
        }

        public Task<ApiRequest<LeadsStart>> Start(int? leadId = null, string secret = null)
        {
            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", null,
                new { lead_id = leadId, secret });
        }

        public Task<ApiRequest<LeadsStart>> Start(ServiceAccessToken accessToken, int? leadId = null, string secret = null)
        {
            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken,
                new { access_token = accessToken, lead_id = leadId, secret });
        }

        public Task<ApiRequest<LeadsLead>> GetStats(UserAccessToken accessToken, int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null)
        {
            return RequestManager.CreateRequestAsync<LeadsLead>("leads.getStats", accessToken,
                new { access_token = accessToken, lead_id = leadId, secret, date_start = dateStart, date_end = dateEnd });
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(UserAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken,
                new { access_token = accessToken, offer_id = offerId, secret, offset, count, status, reverse });
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", null,
                new { offer_id = offerId, secret, offset, count, status, reverse });
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(ServiceAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken,
                new { access_token = accessToken, offer_id = offerId, secret, offset, count, status, reverse });
        }

        public Task<ApiRequest<LeadsChecked>> CheckUser(UserAccessToken accessToken, int? leadId = null, int? testResult = null, int? age = null, string country = null)
        {
            return RequestManager.CreateRequestAsync<LeadsChecked>("leads.checkUser", accessToken,
                new { access_token = accessToken, lead_id = leadId, test_result = testResult, age, country });
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(UserAccessToken accessToken, string data = null)
        {
            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken,
                new { access_token = accessToken, data });
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(string data = null)
        {
            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", null,
                new { data });
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(ServiceAccessToken accessToken, string data = null)
        {
            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken,
                new { access_token = accessToken, data });
        }

    }

    internal class PagesApi : IPagesApi
    {
        public Task<ApiRequest<PagesWikipageFull>> Get(UserAccessToken accessToken, int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null)
        {
            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, page_id = pageId, global, site_preview = sitePreview, title, need_source = needSource, need_html = needHtml });
        }

        public Task<ApiRequest<int?>> Save(UserAccessToken accessToken, string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null)
        {
            return RequestManager.CreateRequestAsync<int?>("pages.save", accessToken,
                new { access_token = accessToken, text, page_id = pageId, group_id = groupId, user_id = userId, title });
        }

        public Task<ApiRequest<int?>> SaveAccess(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null)
        {
            return RequestManager.CreateRequestAsync<int?>("pages.saveAccess", accessToken,
                new { access_token = accessToken, page_id = pageId, group_id = groupId, user_id = userId, view, edit });
        }

        public Task<ApiRequest<IEnumerable<PagesWikipageVersion>>> GetHistory(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipageVersion>>("pages.getHistory", accessToken,
                new { access_token = accessToken, page_id = pageId, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitles(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipage>>("pages.getTitles", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<PagesWikipageFull>> GetVersion(UserAccessToken accessToken, int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null)
        {
            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.getVersion", accessToken,
                new { access_token = accessToken, version_id = versionId, group_id = groupId, user_id = userId, need_html = needHtml });
        }

        public Task<ApiRequest<string>> ParseWiki(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<string>("pages.parseWiki", accessToken,
                new { access_token = accessToken, text, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> ClearCache(UserAccessToken accessToken, string url = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken,
                new { access_token = accessToken, url });
        }

        public Task<ApiRequest<bool?>> ClearCache(string url = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", null,
                new { url });
        }

        public Task<ApiRequest<bool?>> ClearCache(ServiceAccessToken accessToken, string url = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken,
                new { access_token = accessToken, url });
        }

    }

    internal class GroupsApi : IGroupsApi
    {
        public Task<ApiRequest<bool?>> IsMember(UserAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(UserAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, user_ids = userIds });
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(UserAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, extended });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(UserAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> IsMember(GroupAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, user_ids = userIds });
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, extended });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> IsMember(string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", null,
                new { group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(string groupId = null, int? userId = null, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", null,
                new { group_id = groupId, user_id = userId, user_ids = userIds });
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(string groupId = null, int? userId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", null,
                new { group_id = groupId, user_id = userId, extended });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", null,
                new { group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> IsMember(ServiceAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(ServiceAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, user_ids = userIds });
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, extended });
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken,
                new { access_token = accessToken, group_ids = groupIds, group_id = groupId, fields });
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(GroupAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken,
                new { access_token = accessToken, group_ids = groupIds, group_id = groupId, fields });
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", null,
                new { group_ids = groupIds, group_id = groupId, fields });
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken,
                new { access_token = accessToken, group_ids = groupIds, group_id = groupId, fields });
        }

        public Task<ApiRequest<GroupsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetResponse>("groups.get", accessToken,
                new { access_token = accessToken, user_id = userId, filter, fields, offset, count });
        }

        public Task<ApiRequest<GroupsGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetExtendedResponse>("groups.get", accessToken,
                new { access_token = accessToken, user_id = userId, extended, filter, fields, offset, count });
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count });
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, fields });
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, filter });
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count });
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, fields });
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, filter });
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(string groupId = null, string sort = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", null,
                new { group_id = groupId, sort, offset, count });
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", null,
                new { group_id = groupId, sort, offset, count, fields });
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", null,
                new { group_id = groupId, sort, offset, count, filter });
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count });
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, fields });
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken,
                new { access_token = accessToken, group_id = groupId, sort, offset, count, filter });
        }

        public Task<ApiRequest<bool?>> Join(UserAccessToken accessToken, int? groupId = null, string notSure = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.join", accessToken,
                new { access_token = accessToken, group_id = groupId, not_sure = notSure });
        }

        public Task<ApiRequest<bool?>> Leave(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.leave", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsSearchResponse>> Search(UserAccessToken accessToken, string q = null, string type = null, int? countryId = null, int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsSearchResponse>("groups.search", accessToken,
                new { access_token = accessToken, q, type, country_id = countryId, city_id = cityId, future, market, sort, offset, count });
        }

        public Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? categoryId = null, int? subcategoryId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogResponse>("groups.getCatalog", accessToken,
                new { access_token = accessToken, category_id = categoryId, subcategory_id = subcategoryId });
        }

        public Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfo(UserAccessToken accessToken, bool? subcategories = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", accessToken,
                new { access_token = accessToken, subcategories });
        }

        public Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(UserAccessToken accessToken, bool? extended = null, bool? subcategories = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoExtendedResponse>("groups.getCatalogInfo", accessToken,
                new { access_token = accessToken, extended, subcategories });
        }

        public Task<ApiRequest<GroupsGetInvitesResponse>> GetInvites(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitesResponse>("groups.getInvites", accessToken,
                new { access_token = accessToken, offset, count });
        }

        public Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitesExtendedResponse>("groups.getInvites", accessToken,
                new { access_token = accessToken, offset, count, extended });
        }

        public Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsers(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", accessToken,
                new { access_token = accessToken, group_id = groupId, offset, count, fields, name_case = nameCase });
        }

        public Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null, int? endDate = null, int? reason = null, string comment = null, bool? commentVisible = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.banUser", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, end_date = endDate, reason, comment, comment_visible = commentVisible });
        }

        public Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.unbanUser", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<GroupsGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetBannedResponse>("groups.getBanned", accessToken,
                new { access_token = accessToken, group_id = groupId, offset, count, fields, user_id = userId });
        }

        public Task<ApiRequest<GroupsGroup>> Create(UserAccessToken accessToken, string title = null, string description = null, string type = null, int? publicCategory = null, int? subtype = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGroup>("groups.create", accessToken,
                new { access_token = accessToken, title, description, type, public_category = publicCategory, subtype });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? groupId = null, string title = null, string description = null, string screenName = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, int? eventStartDate = null, int? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, int? ageLimits = null, bool? market = null, bool? marketComments = null, IEnumerable<int?> marketCountry = null, IEnumerable<int?> marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null, bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.edit", accessToken,
                new { access_token = accessToken, group_id = groupId, title, description, screen_name = screenName, access, website, subject, email, phone, rss, event_start_date = eventStartDate, event_finish_date = eventFinishDate, event_group_id = eventGroupId, public_category = publicCategory, public_subcategory = publicSubcategory, public_date = publicDate, wall, topics, photos, video, audio, links, events, places, contacts, docs, wiki, messages, age_limits = ageLimits, market, market_comments = marketComments, market_country = marketCountry, market_city = marketCity, market_currency = marketCurrency, market_contact = marketContact, market_wiki = marketWiki, obscene_filter = obsceneFilter, obscene_stopwords = obsceneStopwords, obscene_words = obsceneWords });
        }

        public Task<ApiRequest<GroupsEditPlaceResponse>> EditPlace(UserAccessToken accessToken, int? groupId = null, string title = null, string address = null, int? countryId = null, int? cityId = null, double? latitude = null, double? longitude = null)
        {
            return RequestManager.CreateRequestAsync<GroupsEditPlaceResponse>("groups.editPlace", accessToken,
                new { access_token = accessToken, group_id = groupId, title, address, country_id = countryId, city_id = cityId, latitude, longitude });
        }

        public Task<ApiRequest<GroupsGroupSettings>> GetSettings(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGroupSettings>("groups.getSettings", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequestsResponse>("groups.getRequests", accessToken,
                new { access_token = accessToken, group_id = groupId, offset, count });
        }

        public Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsFields(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetRequestsFieldsResponse>("groups.getRequests", accessToken,
                new { access_token = accessToken, group_id = groupId, offset, count, fields });
        }

        public Task<ApiRequest<bool?>> EditManager(UserAccessToken accessToken, int? groupId = null, int? userId = null, string role = null, bool? isContact = null, string contactPosition = null, string contactPhone = null, string contactEmail = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.editManager", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId, role, is_contact = isContact, contact_position = contactPosition, contact_phone = contactPhone, contact_email = contactEmail });
        }

        public Task<ApiRequest<bool?>> Invite(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.invite", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, int? groupId = null, string link = null, string text = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.addLink", accessToken,
                new { access_token = accessToken, group_id = groupId, link, text });
        }

        public Task<ApiRequest<bool?>> DeleteLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.deleteLink", accessToken,
                new { access_token = accessToken, group_id = groupId, link_id = linkId });
        }

        public Task<ApiRequest<bool?>> EditLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, string text = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.editLink", accessToken,
                new { access_token = accessToken, group_id = groupId, link_id = linkId, text });
        }

        public Task<ApiRequest<bool?>> ReorderLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.reorderLink", accessToken,
                new { access_token = accessToken, group_id = groupId, link_id = linkId, after });
        }

        public Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.removeUser", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> ApproveRequest(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.approveRequest", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(UserAccessToken accessToken, int? groupId = null, string serverUrl = null)
        {
            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerResponse>("groups.setCallbackServer", accessToken,
                new { access_token = accessToken, group_id = groupId, server_url = serverUrl });
        }

        public Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(GroupAccessToken accessToken, int? groupId = null, string serverUrl = null)
        {
            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerResponse>("groups.setCallbackServer", accessToken,
                new { access_token = accessToken, group_id = groupId, server_url = serverUrl });
        }

        public Task<ApiRequest<bool?>> SetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null, string secretKey = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackServerSettings", accessToken,
                new { access_token = accessToken, group_id = groupId, secret_key = secretKey });
        }

        public Task<ApiRequest<bool?>> SetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null, string secretKey = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackServerSettings", accessToken,
                new { access_token = accessToken, group_id = groupId, secret_key = secretKey });
        }

        public Task<ApiRequest<bool?>> SetCallbackSettings(UserAccessToken accessToken, int? groupId = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackSettings", accessToken,
                new { access_token = accessToken, group_id = groupId, message_new = messageNew, message_reply = messageReply, message_allow = messageAllow, message_deny = messageDeny, photo_new = photoNew, audio_new = audioNew, video_new = videoNew, wall_reply_new = wallReplyNew, wall_reply_edit = wallReplyEdit, wall_reply_delete = wallReplyDelete, wall_reply_restore = wallReplyRestore, wall_post_new = wallPostNew, wall_repost = wallRepost, board_post_new = boardPostNew, board_post_edit = boardPostEdit, board_post_restore = boardPostRestore, board_post_delete = boardPostDelete, photo_comment_new = photoCommentNew, photo_comment_edit = photoCommentEdit, photo_comment_delete = photoCommentDelete, photo_comment_restore = photoCommentRestore, video_comment_new = videoCommentNew, video_comment_edit = videoCommentEdit, video_comment_delete = videoCommentDelete, video_comment_restore = videoCommentRestore, market_comment_new = marketCommentNew, market_comment_edit = marketCommentEdit, market_comment_delete = marketCommentDelete, market_comment_restore = marketCommentRestore, poll_vote_new = pollVoteNew, group_join = groupJoin, group_leave = groupLeave });
        }

        public Task<ApiRequest<bool?>> SetCallbackSettings(GroupAccessToken accessToken, int? groupId = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackSettings", accessToken,
                new { access_token = accessToken, group_id = groupId, message_new = messageNew, message_reply = messageReply, message_allow = messageAllow, message_deny = messageDeny, photo_new = photoNew, audio_new = audioNew, video_new = videoNew, wall_reply_new = wallReplyNew, wall_reply_edit = wallReplyEdit, wall_reply_delete = wallReplyDelete, wall_reply_restore = wallReplyRestore, wall_post_new = wallPostNew, wall_repost = wallRepost, board_post_new = boardPostNew, board_post_edit = boardPostEdit, board_post_restore = boardPostRestore, board_post_delete = boardPostDelete, photo_comment_new = photoCommentNew, photo_comment_edit = photoCommentEdit, photo_comment_delete = photoCommentDelete, photo_comment_restore = photoCommentRestore, video_comment_new = videoCommentNew, video_comment_edit = videoCommentEdit, video_comment_delete = videoCommentDelete, video_comment_restore = videoCommentRestore, market_comment_new = marketCommentNew, market_comment_edit = marketCommentEdit, market_comment_delete = marketCommentDelete, market_comment_restore = marketCommentRestore, poll_vote_new = pollVoteNew, group_join = groupJoin, group_leave = groupLeave });
        }

    }

    internal class BoardApi : IBoardApi
    {
        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_ids = topicIds, order, offset, count, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_ids = topicIds, order, offset, count, extended, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", null,
                new { group_id = groupId, topic_ids = topicIds, order, offset, count, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", null,
                new { group_id = groupId, topic_ids = topicIds, order, offset, count, extended, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_ids = topicIds, order, offset, count, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_ids = topicIds, order, offset, count, extended, preview, preview_length = previewLength });
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort });
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, extended, sort });
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", null,
                new { group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort });
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", null,
                new { group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, extended, sort });
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort });
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, extended, sort });
        }

        public Task<ApiRequest<int?>> AddTopic(UserAccessToken accessToken, int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<int?>("board.addTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, title, text, from_group = fromGroup, attachments });
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<int?>("board.createComment", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, message, attachments, from_group = fromGroup, sticker_id = stickerId, guid });
        }

        public Task<ApiRequest<bool?>> DeleteTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.deleteTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId });
        }

        public Task<ApiRequest<bool?>> EditTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string title = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.editTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, title });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.editComment", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, comment_id = commentId, message, attachments });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(GroupAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> OpenTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.openTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId });
        }

        public Task<ApiRequest<bool?>> CloseTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.closeTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId });
        }

        public Task<ApiRequest<bool?>> FixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.fixTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId });
        }

        public Task<ApiRequest<bool?>> UnfixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("board.unfixTopic", accessToken,
                new { access_token = accessToken, group_id = groupId, topic_id = topicId });
        }

    }

    internal class VideoApi : IVideoApi
    {
        public Task<ApiRequest<VideoGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetResponse>("video.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, videos, album_id = albumId, count, offset });
        }

        public Task<ApiRequest<VideoGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetExtendedResponse>("video.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, videos, album_id = albumId, count, offset, extended });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId, name, desc, privacy_view = privacyView, privacy_comment = privacyComment, no_comments = noComments, repeat });
        }

        public Task<ApiRequest<bool?>> Add(UserAccessToken accessToken, int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.add", accessToken,
                new { access_token = accessToken, target_id = targetId, video_id = videoId, owner_id = ownerId });
        }

        public Task<ApiRequest<VideoSaveResult>> Save(UserAccessToken accessToken, string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            return RequestManager.CreateRequestAsync<VideoSaveResult>("video.save", accessToken,
                new { access_token = accessToken, name, description, is_private = isPrivate, wallpost, link, group_id = groupId, album_id = albumId, privacy_view = privacyView, privacy_comment = privacyComment, no_comments = noComments, repeat });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.delete", accessToken,
                new { access_token = accessToken, video_id = videoId, owner_id = ownerId, target_id = targetId });
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? videoId = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.restore", accessToken,
                new { access_token = accessToken, video_id = videoId, owner_id = ownerId });
        }

        public Task<ApiRequest<VideoSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoSearchResponse>("video.search", accessToken,
                new { access_token = accessToken, q, sort, hd, adult, filters, search_own = searchOwn, offset, longer, shorter, count });
        }

        public Task<ApiRequest<VideoSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoSearchExtendedResponse>("video.search", accessToken,
                new { access_token = accessToken, q, sort, hd, adult, filters, search_own = searchOwn, offset, longer, shorter, count, extended });
        }

        public Task<ApiRequest<VideoGetUserVideosResponse>> GetUserVideos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetUserVideosResponse>("video.getUserVideos", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count });
        }

        public Task<ApiRequest<VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetUserVideosExtendedResponse>("video.getUserVideos", accessToken,
                new { access_token = accessToken, user_id = userId, offset, count, extended });
        }

        public Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsResponse>("video.getAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, offset, count });
        }

        public Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsExtendedResponse>("video.getAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, offset, count, extended });
        }

        public Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            return RequestManager.CreateRequestAsync<VideoVideoAlbumFull>("video.getAlbumById", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId });
        }

        public Task<ApiRequest<VideoAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? groupId = null, string title = null, IEnumerable<string> privacy = null)
        {
            return RequestManager.CreateRequestAsync<VideoAddAlbumResponse>("video.addAlbum", accessToken,
                new { access_token = accessToken, group_id = groupId, title, privacy });
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.editAlbum", accessToken,
                new { access_token = accessToken, group_id = groupId, album_id = albumId, title, privacy });
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.deleteAlbum", accessToken,
                new { access_token = accessToken, group_id = groupId, album_id = albumId });
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.reorderAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, before, after });
        }

        public Task<ApiRequest<bool?>> ReorderVideos(UserAccessToken accessToken, int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.reorderVideos", accessToken,
                new { access_token = accessToken, target_id = targetId, album_id = albumId, owner_id = ownerId, video_id = videoId, before_owner_id = beforeOwnerId, before_video_id = beforeVideoId, after_owner_id = afterOwnerId, after_video_id = afterVideoId });
        }

        public Task<ApiRequest<bool?>> AddToAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.addToAlbum", null,
                new { target_id = targetId, album_id = albumId, album_ids = albumIds, owner_id = ownerId, video_id = videoId });
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.removeFromAlbum", null,
                new { target_id = targetId, album_id = albumId, album_ids = albumIds, owner_id = ownerId, video_id = videoId });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null, int? videoId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("video.getAlbumsByVideo", null,
                new { target_id = targetId, owner_id = ownerId, video_id = videoId });
        }

        public Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoExtendedResponse>("video.getAlbumsByVideo", null,
                new { target_id = targetId, owner_id = ownerId, video_id = videoId, extended });
        }

        public Task<ApiRequest<VideoGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCommentsResponse>("video.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort });
        }

        public Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCommentsExtendedResponse>("video.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId, need_likes = needLikes, start_comment_id = startCommentId, offset, count, sort, extended });
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<int?>("video.createComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId, message, attachments, from_group = fromGroup, reply_to_comment = replyToComment, sticker_id = stickerId, guid });
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.deleteComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.restoreComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.editComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, message, attachments });
        }

        public Task<ApiRequest<IEnumerable<VideoVideoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? videoId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<VideoVideoTag>>("video.getTags", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId });
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? userId = null, int? ownerId = null, int? videoId = null, string taggedName = null)
        {
            return RequestManager.CreateRequestAsync<int?>("video.putTag", accessToken,
                new { access_token = accessToken, user_id = userId, owner_id = ownerId, video_id = videoId, tagged_name = taggedName });
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? tagId = null, int? ownerId = null, int? videoId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.removeTag", accessToken,
                new { access_token = accessToken, tag_id = tagId, owner_id = ownerId, video_id = videoId });
        }

        public Task<ApiRequest<VideoGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetNewTagsResponse>("video.getNewTags", accessToken,
                new { access_token = accessToken, offset, count });
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.report", accessToken,
                new { access_token = accessToken, owner_id = ownerId, video_id = videoId, reason, comment, search_query = searchQuery });
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.reportComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, reason });
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken,
                new { access_token = accessToken, count, items_count = itemsCount, from, filters });
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken,
                new { access_token = accessToken, count, items_count = itemsCount, from, filters, extended });
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", null,
                new { count, items_count = itemsCount, from, filters });
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", null,
                new { count, items_count = itemsCount, from, filters, extended });
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken,
                new { access_token = accessToken, count, items_count = itemsCount, from, filters });
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken,
                new { access_token = accessToken, count, items_count = itemsCount, from, filters, extended });
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken,
                new { access_token = accessToken, section_id = sectionId, from, count });
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken,
                new { access_token = accessToken, section_id = sectionId, from, count, extended });
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(string sectionId = null, string from = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", null,
                new { section_id = sectionId, from, count });
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", null,
                new { section_id = sectionId, from, count, extended });
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken,
                new { access_token = accessToken, section_id = sectionId, from, count });
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken,
                new { access_token = accessToken, section_id = sectionId, from, count, extended });
        }

        public Task<ApiRequest<bool?>> HideCatalogSection(UserAccessToken accessToken, int? sectionId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("video.hideCatalogSection", accessToken,
                new { access_token = accessToken, section_id = sectionId });
        }

    }

    internal class NotesApi : INotesApi
    {
        public Task<ApiRequest<NotesGetResponse>> Get(UserAccessToken accessToken, IEnumerable<int?> noteIds = null, int? userId = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<NotesGetResponse>("notes.get", accessToken,
                new { access_token = accessToken, note_ids = noteIds, user_id = userId, count });
        }

        public Task<ApiRequest<NotesNote>> GetById(UserAccessToken accessToken, int? noteId = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<NotesNote>("notes.getById", accessToken,
                new { access_token = accessToken, note_id = noteId, owner_id = ownerId });
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            return RequestManager.CreateRequestAsync<int?>("notes.add", accessToken,
                new { access_token = accessToken, title, text, privacy_view = privacyView, privacy_comment = privacyComment });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("notes.edit", accessToken,
                new { access_token = accessToken, note_id = noteId, title, text, privacy_view = privacyView, privacy_comment = privacyComment });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? noteId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("notes.delete", accessToken,
                new { access_token = accessToken, note_id = noteId });
        }

        public Task<ApiRequest<NotesGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<NotesGetCommentsResponse>("notes.getComments", accessToken,
                new { access_token = accessToken, note_id = noteId, owner_id = ownerId, count });
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<int?>("notes.createComment", accessToken,
                new { access_token = accessToken, note_id = noteId, owner_id = ownerId, reply_to = replyTo, message, guid });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null, string message = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("notes.editComment", accessToken,
                new { access_token = accessToken, comment_id = commentId, owner_id = ownerId, message });
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("notes.deleteComment", accessToken,
                new { access_token = accessToken, comment_id = commentId, owner_id = ownerId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("notes.restoreComment", accessToken,
                new { access_token = accessToken, comment_id = commentId, owner_id = ownerId });
        }

    }

    internal class PlacesApi : IPlacesApi
    {
        public Task<ApiRequest<PlacesAddResponse>> Add(UserAccessToken accessToken, int? type = null, string title = null, double? latitude = null, double? longitude = null, int? country = null, int? city = null, string address = null)
        {
            return RequestManager.CreateRequestAsync<PlacesAddResponse>("places.add", accessToken,
                new { access_token = accessToken, type, title, latitude, longitude, country, city, address });
        }

        public Task<ApiRequest<IEnumerable<PlacesPlaceMin>>> GetById(UserAccessToken accessToken, IEnumerable<int?> places = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PlacesPlaceMin>>("places.getById", accessToken,
                new { access_token = accessToken, places });
        }

        public Task<ApiRequest<PlacesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? city = null, double? latitude = null, double? longitude = null, int? radius = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<PlacesSearchResponse>("places.search", accessToken,
                new { access_token = accessToken, q, city, latitude, longitude, radius, offset, count });
        }

        public Task<ApiRequest<PlacesCheckinResponse>> Checkin(UserAccessToken accessToken, int? placeId = null, string text = null, double? latitude = null, double? longitude = null, bool? friendsOnly = null, IEnumerable<string> services = null)
        {
            return RequestManager.CreateRequestAsync<PlacesCheckinResponse>("places.checkin", accessToken,
                new { access_token = accessToken, place_id = placeId, text, latitude, longitude, friends_only = friendsOnly, services });
        }

        public Task<ApiRequest<PlacesGetCheckinsResponse>> GetCheckins(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? place = null, int? userId = null, int? offset = null, int? count = null, int? timestamp = null, bool? friendsOnly = null, bool? needPlaces = null)
        {
            return RequestManager.CreateRequestAsync<PlacesGetCheckinsResponse>("places.getCheckins", accessToken,
                new { access_token = accessToken, latitude, longitude, place, user_id = userId, offset, count, timestamp, friends_only = friendsOnly, need_places = needPlaces });
        }

        public Task<ApiRequest<IEnumerable<PlacesTypes>>> GetTypes()
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PlacesTypes>>("places.getTypes", null,
                new { });
        }

    }

    internal class AccountApi : IAccountApi
    {
        public Task<ApiRequest<AccountAccountCounters>> GetCounters(UserAccessToken accessToken, IEnumerable<string> filter = null)
        {
            return RequestManager.CreateRequestAsync<AccountAccountCounters>("account.getCounters", accessToken,
                new { access_token = accessToken, filter });
        }

        public Task<ApiRequest<bool?>> SetNameInMenu(UserAccessToken accessToken, int? userId = null, string name = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setNameInMenu", accessToken,
                new { access_token = accessToken, user_id = userId, name });
        }

        public Task<ApiRequest<bool?>> SetOnline(UserAccessToken accessToken, bool? voip = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setOnline", accessToken,
                new { access_token = accessToken, voip });
        }

        public Task<ApiRequest<bool?>> SetOffline()
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setOffline", null,
                new { });
        }

        public Task<ApiRequest<AccountLookupResult>> LookupContacts(UserAccessToken accessToken, IEnumerable<string> contacts = null, string service = null, string mycontact = null, bool? returnAll = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<AccountLookupResult>("account.lookupContacts", accessToken,
                new { access_token = accessToken, contacts, service, mycontact, return_all = returnAll, fields });
        }

        public Task<ApiRequest<bool?>> RegisterDevice(UserAccessToken accessToken, string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.registerDevice", accessToken,
                new { access_token = accessToken, token, device_model = deviceModel, device_year = deviceYear, device_id = deviceId, system_version = systemVersion, settings });
        }

        public Task<ApiRequest<bool?>> UnregisterDevice(UserAccessToken accessToken, string deviceId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.unregisterDevice", accessToken,
                new { access_token = accessToken, device_id = deviceId });
        }

        public Task<ApiRequest<bool?>> SetSilenceMode(UserAccessToken accessToken, string deviceId = null, int? time = null, int? peerId = null, int? sound = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setSilenceMode", accessToken,
                new { access_token = accessToken, device_id = deviceId, time, peer_id = peerId, sound });
        }

        public Task<ApiRequest<AccountPushSettings>> GetPushSettings(UserAccessToken accessToken, string deviceId = null)
        {
            return RequestManager.CreateRequestAsync<AccountPushSettings>("account.getPushSettings", accessToken,
                new { access_token = accessToken, device_id = deviceId });
        }

        public Task<ApiRequest<bool?>> SetPushSettings(UserAccessToken accessToken, string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setPushSettings", accessToken,
                new { access_token = accessToken, device_id = deviceId, settings, key, value });
        }

        public Task<ApiRequest<int?>> GetAppPermissions(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<int?>("account.getAppPermissions", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffers(UserAccessToken accessToken, int? count = null)
        {
            return RequestManager.CreateRequestAsync<AccountGetActiveOffersResponse>("account.getActiveOffers", accessToken,
                new { access_token = accessToken, count });
        }

        public Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.banUser", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.unbanUser", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<AccountGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<AccountGetBannedResponse>("account.getBanned", accessToken,
                new { access_token = accessToken, offset, count });
        }

        public Task<ApiRequest<AccountInfo>> GetInfo(UserAccessToken accessToken, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<AccountInfo>("account.getInfo", accessToken,
                new { access_token = accessToken, fields });
        }

        public Task<ApiRequest<bool?>> SetInfo(UserAccessToken accessToken, string name = null, string value = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("account.setInfo", accessToken,
                new { access_token = accessToken, name, value });
        }

        public Task<ApiRequest<AccountChangePasswordResponse>> ChangePassword(UserAccessToken accessToken, string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null)
        {
            return RequestManager.CreateRequestAsync<AccountChangePasswordResponse>("account.changePassword", accessToken,
                new { access_token = accessToken, restore_sid = restoreSid, change_password_hash = changePasswordHash, old_password = oldPassword, new_password = newPassword });
        }

        public Task<ApiRequest<AccountUserSettings>> GetProfileInfo()
        {
            return RequestManager.CreateRequestAsync<AccountUserSettings>("account.getProfileInfo", null,
                new { });
        }

        public Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfo(UserAccessToken accessToken, string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null)
        {
            return RequestManager.CreateRequestAsync<AccountSaveProfileInfoResponse>("account.saveProfileInfo", accessToken,
                new { access_token = accessToken, first_name = firstName, last_name = lastName, maiden_name = maidenName, screen_name = screenName, cancel_request_id = cancelRequestId, sex, relation, relation_partner_id = relationPartnerId, bdate, bdate_visibility = bdateVisibility, home_town = homeTown, country_id = countryId, city_id = cityId, status });
        }

    }

    internal class MessagesApi : IMessagesApi
    {
        public Task<ApiRequest<MessagesGetResponse>> Get(UserAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken,
                new { access_token = accessToken, @out, offset, count, filter, time_offset = timeOffset, preview_length = previewLength, last_message_id = lastMessageId });
        }

        public Task<ApiRequest<MessagesGetResponse>> Get(GroupAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetResponse>("messages.get", accessToken,
                new { access_token = accessToken, @out, offset, count, filter, time_offset = timeOffset, preview_length = previewLength, last_message_id = lastMessageId });
        }

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(UserAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetDialogsResponse>("messages.getDialogs", accessToken,
                new { access_token = accessToken, offset, count, start_message_id = startMessageId, preview_length = previewLength, unread, important, unanswered });
        }

        public Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(GroupAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetDialogsResponse>("messages.getDialogs", accessToken,
                new { access_token = accessToken, offset, count, start_message_id = startMessageId, preview_length = previewLength, unread, important, unanswered });
        }

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<int?> messageIds = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken,
                new { access_token = accessToken, message_ids = messageIds });
        }

        public Task<ApiRequest<MessagesGetByIdResponse>> GetById(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetByIdResponse>("messages.getById", accessToken,
                new { access_token = accessToken, message_ids = messageIds });
        }

        public Task<ApiRequest<MessagesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? peerId = null, int? date = null, int? previewLength = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<MessagesSearchResponse>("messages.search", accessToken,
                new { access_token = accessToken, q, peer_id = peerId, date, preview_length = previewLength, offset, count });
        }

        public Task<ApiRequest<MessagesSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? peerId = null, int? date = null, int? previewLength = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<MessagesSearchResponse>("messages.search", accessToken,
                new { access_token = accessToken, q, peer_id = peerId, date, preview_length = previewLength, offset, count });
        }

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(UserAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryResponse>("messages.getHistory", accessToken,
                new { access_token = accessToken, offset, count, user_id = userId, peer_id = peerId, start_message_id = startMessageId, rev });
        }

        public Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(GroupAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryResponse>("messages.getHistory", accessToken,
                new { access_token = accessToken, offset, count, user_id = userId, peer_id = peerId, start_message_id = startMessageId, rev });
        }

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(UserAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", accessToken,
                new { access_token = accessToken, peer_id = peerId, media_type = mediaType, start_from = startFrom, count, photo_sizes = photoSizes, fields });
        }

        public Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(GroupAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", accessToken,
                new { access_token = accessToken, peer_id = peerId, media_type = mediaType, start_from = startFrom, count, photo_sizes = photoSizes, fields });
        }

        public Task<ApiRequest<int?>> Send(UserAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null)
        {
            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken,
                new { access_token = accessToken, user_id = userId, random_id = randomId, peer_id = peerId, domain, chat_id = chatId, user_ids = userIds, message, lat, @long, attachment, forward_messages = forwardMessages, sticker_id = stickerId, notification });
        }

        public Task<ApiRequest<int?>> Send(GroupAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null)
        {
            return RequestManager.CreateRequestAsync<int?>("messages.send", accessToken,
                new { access_token = accessToken, user_id = userId, random_id = randomId, peer_id = peerId, domain, chat_id = chatId, user_ids = userIds, message, lat, @long, attachment, forward_messages = forwardMessages, sticker_id = stickerId, notification });
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken,
                new { access_token = accessToken, message_ids = messageIds, spam });
        }

        public Task<ApiRequest<MessagesDeleteResponse>> Delete(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteResponse>("messages.delete", accessToken,
                new { access_token = accessToken, message_ids = messageIds, spam });
        }

        public Task<ApiRequest<bool?>> DeleteDialog(UserAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.deleteDialog", accessToken,
                new { access_token = accessToken, user_id = userId, peer_id = peerId, offset, count });
        }

        public Task<ApiRequest<bool?>> DeleteDialog(GroupAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.deleteDialog", accessToken,
                new { access_token = accessToken, user_id = userId, peer_id = peerId, offset, count });
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? messageId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken,
                new { access_token = accessToken, message_id = messageId });
        }

        public Task<ApiRequest<bool?>> Restore(GroupAccessToken accessToken, int? messageId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.restore", accessToken,
                new { access_token = accessToken, message_id = messageId });
        }

        public Task<ApiRequest<bool?>> MarkAsRead(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.markAsRead", accessToken,
                new { access_token = accessToken, message_ids = messageIds, peer_id = peerId, start_message_id = startMessageId });
        }

        public Task<ApiRequest<bool?>> MarkAsRead(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.markAsRead", accessToken,
                new { access_token = accessToken, message_ids = messageIds, peer_id = peerId, start_message_id = startMessageId });
        }

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken,
                new { access_token = accessToken, message_ids = messageIds, important });
        }

        public Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.markAsImportant", accessToken,
                new { access_token = accessToken, message_ids = messageIds, important });
        }

        public Task<ApiRequest<bool?>> MarkAsImportantDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.markAsImportantDialog", accessToken,
                new { access_token = accessToken, peer_id = peerId, important });
        }

        public Task<ApiRequest<bool?>> MarkAsUnansweredDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.markAsUnansweredDialog", accessToken,
                new { access_token = accessToken, peer_id = peerId, important });
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(UserAccessToken accessToken, int? lpVersion = null, bool? needPts = null)
        {
            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken,
                new { access_token = accessToken, lp_version = lpVersion, need_pts = needPts });
        }

        public Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(GroupAccessToken accessToken, int? lpVersion = null, bool? needPts = null)
        {
            return RequestManager.CreateRequestAsync<MessagesLongpollParams>("messages.getLongPollServer", accessToken,
                new { access_token = accessToken, lp_version = lpVersion, need_pts = needPts });
        }

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(UserAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", accessToken,
                new { access_token = accessToken, ts, pts, preview_length = previewLength, onlines, fields, events_limit = eventsLimit, msgs_limit = msgsLimit, max_msg_id = maxMsgId });
        }

        public Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(GroupAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", accessToken,
                new { access_token = accessToken, ts, pts, preview_length = previewLength, onlines, fields, events_limit = eventsLimit, msgs_limit = msgsLimit, max_msg_id = maxMsgId });
        }

        public Task<ApiRequest<MessagesChat>> GetChat(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<MessagesChat>("messages.getChat", accessToken,
                new { access_token = accessToken, chat_id = chatId, name_case = nameCase });
        }

        public Task<ApiRequest<MessagesChatFull>> GetChatFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<MessagesChatFull>("messages.getChat", accessToken,
                new { access_token = accessToken, chat_id = chatId, fields, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<MessagesChat>>> GetChatChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<MessagesChat>>("messages.getChat", accessToken,
                new { access_token = accessToken, chat_id = chatId, chat_ids = chatIds, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<MessagesChatFull>>("messages.getChat", accessToken,
                new { access_token = accessToken, chat_id = chatId, name_case = nameCase });
        }

        public Task<ApiRequest<int?>> CreateChat(UserAccessToken accessToken, IEnumerable<int?> userIds = null, string title = null)
        {
            return RequestManager.CreateRequestAsync<int?>("messages.createChat", accessToken,
                new { access_token = accessToken, user_ids = userIds, title });
        }

        public Task<ApiRequest<bool?>> EditChat(UserAccessToken accessToken, int? chatId = null, string title = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.editChat", accessToken,
                new { access_token = accessToken, chat_id = chatId, title });
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetChatUsers(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("messages.getChatUsers", accessToken,
                new { access_token = accessToken, chat_id = chatId, name_case = nameCase });
        }

        public Task<ApiRequest<IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<MessagesUserXtrInvitedBy>>("messages.getChatUsers", accessToken,
                new { access_token = accessToken, chat_id = chatId, fields, name_case = nameCase });
        }

        public Task<ApiRequest<MessagesGetChatUsersChatIdsResponse>> GetChatUsersChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersChatIdsResponse>("messages.getChatUsers", accessToken,
                new { access_token = accessToken, chat_id = chatId, chat_ids = chatIds, name_case = nameCase });
        }

        public Task<ApiRequest<MessagesGetChatUsersChatIdsFieldsResponse>> GetChatUsersChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<MessagesGetChatUsersChatIdsFieldsResponse>("messages.getChatUsers", accessToken,
                new { access_token = accessToken, chat_id = chatId, name_case = nameCase });
        }

        public Task<ApiRequest<bool?>> SetActivity(UserAccessToken accessToken, string userId = null, string type = null, int? peerId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.setActivity", accessToken,
                new { access_token = accessToken, user_id = userId, type, peer_id = peerId });
        }

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<string>>("messages.searchDialogs", accessToken,
                new { access_token = accessToken, q, limit, fields });
        }

        public Task<ApiRequest<IEnumerable<string>>> SearchDialogs(GroupAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<string>>("messages.searchDialogs", accessToken,
                new { access_token = accessToken, q, limit, fields });
        }

        public Task<ApiRequest<bool?>> AddChatUser(UserAccessToken accessToken, int? chatId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.addChatUser", accessToken,
                new { access_token = accessToken, chat_id = chatId, user_id = userId });
        }

        public Task<ApiRequest<bool?>> RemoveChatUser(UserAccessToken accessToken, int? chatId = null, string userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.removeChatUser", accessToken,
                new { access_token = accessToken, chat_id = chatId, user_id = userId });
        }

        public Task<ApiRequest<MessagesLastActivity>> GetLastActivity(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesLastActivity>("messages.getLastActivity", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhoto(UserAccessToken accessToken, string file = null)
        {
            return RequestManager.CreateRequestAsync<MessagesSetChatPhotoResponse>("messages.setChatPhoto", accessToken,
                new { access_token = accessToken, file });
        }

        public Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(UserAccessToken accessToken, int? chatId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", accessToken,
                new { access_token = accessToken, chat_id = chatId });
        }

        public Task<ApiRequest<bool?>> DenyMessagesFromGroup(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.denyMessagesFromGroup", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> AllowMessagesFromGroup(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("messages.allowMessagesFromGroup", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(UserAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

        public Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(GroupAccessToken accessToken, int? groupId = null, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", accessToken,
                new { access_token = accessToken, group_id = groupId, user_id = userId });
        }

    }

    internal class NewsfeedApi : INewsfeedApi
    {
        public Task<ApiRequest<NewsfeedGetResponse>> Get(UserAccessToken accessToken, IEnumerable<string> filters = null, bool? returnBanned = null, int? startTime = null, int? endTime = null, int? maxPhotos = null, IEnumerable<string> sourceIds = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetResponse>("newsfeed.get", accessToken,
                new { access_token = accessToken, filters, return_banned = returnBanned, start_time = startTime, end_time = endTime, max_photos = maxPhotos, source_ids = sourceIds, start_from = startFrom, count, fields });
        }

        public Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommended(UserAccessToken accessToken, int? startTime = null, int? endTime = null, int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", accessToken,
                new { access_token = accessToken, start_time = startTime, end_time = endTime, max_photos = maxPhotos, start_from = startFrom, count, fields });
        }

        public Task<ApiRequest<NewsfeedGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? count = null, IEnumerable<string> filters = null, string reposts = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetCommentsResponse>("newsfeed.getComments", accessToken,
                new { access_token = accessToken, count, filters, reposts, start_time = startTime, end_time = endTime, start_from = startFrom, fields });
        }

        public Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentions(UserAccessToken accessToken, int? ownerId = null, int? startTime = null, int? endTime = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetMentionsResponse>("newsfeed.getMentions", accessToken,
                new { access_token = accessToken, owner_id = ownerId, start_time = startTime, end_time = endTime, offset, count });
        }

        public Task<ApiRequest<NewsfeedGetBannedResponse>> GetBanned(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetBannedResponse>("newsfeed.getBanned", accessToken,
                new { access_token = accessToken, fields, name_case = nameCase });
        }

        public Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedExtended(UserAccessToken accessToken, bool? extended = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetBannedExtendedResponse>("newsfeed.getBanned", accessToken,
                new { access_token = accessToken, extended, fields, name_case = nameCase });
        }

        public Task<ApiRequest<bool?>> AddBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.addBan", accessToken,
                new { access_token = accessToken, user_ids = userIds, group_ids = groupIds });
        }

        public Task<ApiRequest<bool?>> DeleteBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteBan", accessToken,
                new { access_token = accessToken, user_ids = userIds, group_ids = groupIds });
        }

        public Task<ApiRequest<bool?>> IgnoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.ignoreItem", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<bool?>> UnignoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unignoreItem", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<NewsfeedSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchResponse>("newsfeed.search", accessToken,
                new { access_token = accessToken, q, count, latitude, longitude, start_time = startTime, end_time = endTime, start_from = startFrom, fields });
        }

        public Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchExtendedResponse>("newsfeed.search", accessToken,
                new { access_token = accessToken, q, extended, count, latitude, longitude, start_time = startTime, end_time = endTime, start_from = startFrom, fields });
        }

        public Task<ApiRequest<NewsfeedSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchResponse>("newsfeed.search", accessToken,
                new { access_token = accessToken, q, count, latitude, longitude, start_time = startTime, end_time = endTime, start_from = startFrom, fields });
        }

        public Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedSearchExtendedResponse>("newsfeed.search", accessToken,
                new { access_token = accessToken, q, extended, count, latitude, longitude, start_time = startTime, end_time = endTime, start_from = startFrom, fields });
        }

        public Task<ApiRequest<NewsfeedGetListsResponse>> GetLists(UserAccessToken accessToken, IEnumerable<int?> listIds = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetListsResponse>("newsfeed.getLists", accessToken,
                new { access_token = accessToken, list_ids = listIds });
        }

        public Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsExtended(UserAccessToken accessToken, IEnumerable<int?> listIds = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetListsExtendedResponse>("newsfeed.getLists", accessToken,
                new { access_token = accessToken, list_ids = listIds, extended });
        }

        public Task<ApiRequest<int?>> SaveList(UserAccessToken accessToken, int? listId = null, string title = null, IEnumerable<int?> sourceIds = null, bool? noReposts = null)
        {
            return RequestManager.CreateRequestAsync<int?>("newsfeed.saveList", accessToken,
                new { access_token = accessToken, list_id = listId, title, source_ids = sourceIds, no_reposts = noReposts });
        }

        public Task<ApiRequest<bool?>> DeleteList(int? listId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteList", null,
                new { list_id = listId });
        }

        public Task<ApiRequest<bool?>> Unsubscribe(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unsubscribe", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(UserAccessToken accessToken, int? offset = null, int? count = null, bool? shuffle = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<NewsfeedGetSuggestedSourcesResponse>("newsfeed.getSuggestedSources", accessToken,
                new { access_token = accessToken, offset, count, shuffle, fields });
        }

    }

    internal class LikesApi : ILikesApi
    {
        public Task<ApiRequest<LikesGetListResponse>> GetList(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, extended, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", null,
                new { type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", null,
                new { type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, extended, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId, page_url = pageUrl, filter, friends_only = friendsOnly, extended, offset, count, skip_own = skipOwn });
        }

        public Task<ApiRequest<LikesAddResponse>> Add(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string accessKey = null)
        {
            return RequestManager.CreateRequestAsync<LikesAddResponse>("likes.add", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId, access_key = accessKey });
        }

        public Task<ApiRequest<LikesDeleteResponse>> Delete(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<LikesDeleteResponse>("likes.delete", accessToken,
                new { access_token = accessToken, type, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<LikesIsLikedResponse>> IsLiked(UserAccessToken accessToken, int? userId = null, string type = null, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<LikesIsLikedResponse>("likes.isLiked", accessToken,
                new { access_token = accessToken, user_id = userId, type, owner_id = ownerId, item_id = itemId });
        }

    }

    internal class PollsApi : IPollsApi
    {
        public Task<ApiRequest<PollsPoll>> GetById(UserAccessToken accessToken, int? ownerId = null, bool? isBoard = null, int? pollId = null)
        {
            return RequestManager.CreateRequestAsync<PollsPoll>("polls.getById", accessToken,
                new { access_token = accessToken, owner_id = ownerId, is_board = isBoard, poll_id = pollId });
        }

        public Task<ApiRequest<bool?>> AddVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("polls.addVote", accessToken,
                new { access_token = accessToken, owner_id = ownerId, poll_id = pollId, answer_id = answerId, is_board = isBoard });
        }

        public Task<ApiRequest<bool?>> DeleteVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("polls.deleteVote", accessToken,
                new { access_token = accessToken, owner_id = ownerId, poll_id = pollId, answer_id = answerId, is_board = isBoard });
        }

        public Task<ApiRequest<IEnumerable<PollsVoters>>> GetVoters(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<PollsVoters>>("polls.getVoters", accessToken,
                new { access_token = accessToken, owner_id = ownerId, poll_id = pollId, answer_ids = answerIds, is_board = isBoard, friends_only = friendsOnly, offset, count, fields, name_case = nameCase });
        }

        public Task<ApiRequest<PollsPoll>> Create(UserAccessToken accessToken, string question = null, bool? isAnonymous = null, int? ownerId = null, JsonArray addAnswers = null)
        {
            return RequestManager.CreateRequestAsync<PollsPoll>("polls.create", accessToken,
                new { access_token = accessToken, question, is_anonymous = isAnonymous, owner_id = ownerId, add_answers = addAnswers });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, string question = null, JsonArray addAnswers = null, JsonArray editAnswers = null, JsonArray deleteAnswers = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("polls.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, poll_id = pollId, question, add_answers = addAnswers, edit_answers = editAnswers, delete_answers = deleteAnswers });
        }

    }

    internal class DocsApi : IDocsApi
    {
        public Task<ApiRequest<DocsGetResponse>> Get(UserAccessToken accessToken, int? count = null, int? offset = null, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<DocsGetResponse>("docs.get", accessToken,
                new { access_token = accessToken, count, offset, owner_id = ownerId });
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> GetById(UserAccessToken accessToken, IEnumerable<string> docs = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.getById", accessToken,
                new { access_token = accessToken, docs });
        }

        public Task<ApiRequest<DocsGetUploadServerResponse>> GetUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<DocsGetUploadServerResponse>("docs.getUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(GroupAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(UserAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken,
                new { access_token = accessToken, file, title, tags });
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(GroupAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken,
                new { access_token = accessToken, file, title, tags });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? docId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("docs.delete", accessToken,
                new { access_token = accessToken, owner_id = ownerId, doc_id = docId });
        }

        public Task<ApiRequest<DocsAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string accessKey = null)
        {
            return RequestManager.CreateRequestAsync<DocsAddResponse>("docs.add", accessToken,
                new { access_token = accessToken, owner_id = ownerId, doc_id = docId, access_key = accessKey });
        }

        public Task<ApiRequest<DocsGetTypesResponse>> GetTypes(UserAccessToken accessToken, int? ownerId = null)
        {
            return RequestManager.CreateRequestAsync<DocsGetTypesResponse>("docs.getTypes", accessToken,
                new { access_token = accessToken, owner_id = ownerId });
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken,
                new { access_token = accessToken, q, count, offset });
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken,
                new { access_token = accessToken, q, count, offset });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("docs.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, doc_id = docId, title, tags });
        }

    }

    internal class FaveApi : IFaveApi
    {
        public Task<ApiRequest<FaveGetUsersResponse>> GetUsers(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetUsersResponse>("fave.getUsers", accessToken,
                new { access_token = accessToken, offset, count });
        }

        public Task<ApiRequest<FaveGetPhotosResponse>> GetPhotos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? photoSizes = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetPhotosResponse>("fave.getPhotos", accessToken,
                new { access_token = accessToken, offset, count, photo_sizes = photoSizes });
        }

        public Task<ApiRequest<FaveGetPostsResponse>> GetPosts(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetPostsResponse>("fave.getPosts", accessToken,
                new { access_token = accessToken, offset, count, extended });
        }

        public Task<ApiRequest<FaveGetVideosResponse>> GetVideos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetVideosResponse>("fave.getVideos", accessToken,
                new { access_token = accessToken, offset, count, extended });
        }

        public Task<ApiRequest<FaveGetLinksResponse>> GetLinks(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetLinksResponse>("fave.getLinks", accessToken,
                new { access_token = accessToken, offset, count });
        }

        public Task<ApiRequest<FaveGetMarketItemsResponse>> GetMarketItems(UserAccessToken accessToken, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<FaveGetMarketItemsResponse>("fave.getMarketItems", accessToken,
                new { access_token = accessToken, count, extended });
        }

        public Task<ApiRequest<bool?>> AddUser(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.addUser", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.removeUser", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

        public Task<ApiRequest<bool?>> AddGroup(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.addGroup", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> RemoveGroup(UserAccessToken accessToken, int? groupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.removeGroup", accessToken,
                new { access_token = accessToken, group_id = groupId });
        }

        public Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, string link = null, string text = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.addLink", accessToken,
                new { access_token = accessToken, link, text });
        }

        public Task<ApiRequest<bool?>> RemoveLink(UserAccessToken accessToken, string linkId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("fave.removeLink", accessToken,
                new { access_token = accessToken, link_id = linkId });
        }

    }

    internal class NotificationsApi : INotificationsApi
    {
        public Task<ApiRequest<NotificationsGetResponse>> Get(UserAccessToken accessToken, int? count = null, string startFrom = null, IEnumerable<string> filters = null, int? startTime = null, int? endTime = null)
        {
            return RequestManager.CreateRequestAsync<NotificationsGetResponse>("notifications.get", accessToken,
                new { access_token = accessToken, count, start_from = startFrom, filters, start_time = startTime, end_time = endTime });
        }

        public Task<ApiRequest<bool?>> MarkAsViewed()
        {
            return RequestManager.CreateRequestAsync<bool?>("notifications.markAsViewed", null,
                new { });
        }

    }

    internal class StatsApi : IStatsApi
    {
        public Task<ApiRequest<IEnumerable<StatsPeriod>>> Get(UserAccessToken accessToken, int? groupId = null, int? appId = null, string dateFrom = null, string dateTo = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<StatsPeriod>>("stats.get", accessToken,
                new { access_token = accessToken, group_id = groupId, app_id = appId, date_from = dateFrom, date_to = dateTo });
        }

        public Task<ApiRequest<bool?>> TrackVisitor()
        {
            return RequestManager.CreateRequestAsync<bool?>("stats.trackVisitor", null,
                new { });
        }

        public Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReach(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<StatsWallpostStat>>("stats.getPostReach", accessToken,
                new { access_token = accessToken, owner_id = ownerId, post_id = postId });
        }

    }

    internal class SearchApi : ISearchApi
    {
        public Task<ApiRequest<IEnumerable<SearchHint>>> GetHints(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> filters = null, bool? searchGlobal = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<SearchHint>>("search.getHints", accessToken,
                new { access_token = accessToken, q, limit, filters, search_global = searchGlobal });
        }

    }

    internal class AppsApi : IAppsApi
    {
        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken,
                new { access_token = accessToken, sort, offset, count, platform, extended, return_friends = returnFriends, fields, name_case = nameCase, q, genre_id = genreId, filter });
        }

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", null,
                new { sort, offset, count, platform, extended, return_friends = returnFriends, fields, name_case = nameCase, q, genre_id = genreId, filter });
        }

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken,
                new { access_token = accessToken, sort, offset, count, platform, extended, return_friends = returnFriends, fields, name_case = nameCase, q, genre_id = genreId, filter });
        }

        public Task<ApiRequest<AppsGetResponse>> Get(UserAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken,
                new { access_token = accessToken, app_id = appId, app_ids = appIds, platform, fields, name_case = nameCase });
        }

        public Task<ApiRequest<AppsGetResponse>> Get(int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", null,
                new { app_id = appId, app_ids = appIds, platform, fields, name_case = nameCase });
        }

        public Task<ApiRequest<AppsGetResponse>> Get(ServiceAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken,
                new { access_token = accessToken, app_id = appId, app_ids = appIds, platform, fields, name_case = nameCase });
        }

        public Task<ApiRequest<int?>> SendRequest(UserAccessToken accessToken, int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null)
        {
            return RequestManager.CreateRequestAsync<int?>("apps.sendRequest", accessToken,
                new { access_token = accessToken, user_id = userId, text, type, name, key, separate });
        }

        public Task<ApiRequest<bool?>> DeleteAppRequests()
        {
            return RequestManager.CreateRequestAsync<bool?>("apps.deleteAppRequests", null,
                new { });
        }

        public Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsList(UserAccessToken accessToken, int? count = null, string type = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetFriendsListResponse>("apps.getFriendsList", accessToken,
                new { access_token = accessToken, count, type, fields });
        }

        public Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboard(UserAccessToken accessToken, string type = null, bool? global = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetLeaderboardResponse>("apps.getLeaderboard", accessToken,
                new { access_token = accessToken, type, global });
        }

        public Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(UserAccessToken accessToken, string type = null, bool? global = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", accessToken,
                new { access_token = accessToken, type, global, extended });
        }

        public Task<ApiRequest<int?>> GetScore(UserAccessToken accessToken, int? userId = null)
        {
            return RequestManager.CreateRequestAsync<int?>("apps.getScore", accessToken,
                new { access_token = accessToken, user_id = userId });
        }

    }

    internal class UtilsApi : IUtilsApi
    {
        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(UserAccessToken accessToken, string url = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken,
                new { access_token = accessToken, url });
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(GroupAccessToken accessToken, string url = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken,
                new { access_token = accessToken, url });
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(string url = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", null,
                new { url });
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(ServiceAccessToken accessToken, string url = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken,
                new { access_token = accessToken, url });
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(UserAccessToken accessToken, string key = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken,
                new { access_token = accessToken, key });
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(GroupAccessToken accessToken, string key = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken,
                new { access_token = accessToken, key });
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(string key = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", null,
                new { key });
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(ServiceAccessToken accessToken, string key = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken,
                new { access_token = accessToken, key });
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken,
                new { access_token = accessToken, count, offset });
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(GroupAccessToken accessToken, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken,
                new { access_token = accessToken, count, offset });
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", null,
                new { count, offset });
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(ServiceAccessToken accessToken, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken,
                new { access_token = accessToken, count, offset });
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount });
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount, extended });
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount });
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount, extended });
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", null,
                new { key, access_key = accessKey, interval, intervals_count = intervalsCount });
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", null,
                new { key, access_key = accessKey, interval, intervals_count = intervalsCount, extended });
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount });
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken,
                new { access_token = accessToken, key, access_key = accessKey, interval, intervals_count = intervalsCount, extended });
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(UserAccessToken accessToken, string url = null, bool? @private = null)
        {
            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken,
                new { access_token = accessToken, url, @private });
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(GroupAccessToken accessToken, string url = null, bool? @private = null)
        {
            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken,
                new { access_token = accessToken, url, @private });
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(string url = null, bool? @private = null)
        {
            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", null,
                new { url, @private });
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(ServiceAccessToken accessToken, string url = null, bool? @private = null)
        {
            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken,
                new { access_token = accessToken, url, @private });
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(UserAccessToken accessToken, string screenName = null)
        {
            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken,
                new { access_token = accessToken, screen_name = screenName });
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(GroupAccessToken accessToken, string screenName = null)
        {
            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken,
                new { access_token = accessToken, screen_name = screenName });
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(string screenName = null)
        {
            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", null,
                new { screen_name = screenName });
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(ServiceAccessToken accessToken, string screenName = null)
        {
            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken,
                new { access_token = accessToken, screen_name = screenName });
        }

        public Task<ApiRequest<int?>> GetServerTime(UserAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<int?>> GetServerTime(GroupAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken,
                new { access_token = accessToken });
        }

        public Task<ApiRequest<int?>> GetServerTime()
        {
            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", null,
                new { });
        }

        public Task<ApiRequest<int?>> GetServerTime(ServiceAccessToken accessToken)
        {
            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken,
                new { access_token = accessToken });
        }

    }

    internal class DatabaseApi : IDatabaseApi
    {
        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(UserAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", accessToken,
                new { access_token = accessToken, need_all = needAll, code, offset, count });
        }

        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", null,
                new { need_all = needAll, code, offset, count });
        }

        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(ServiceAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", accessToken,
                new { access_token = accessToken, need_all = needAll, code, offset, count });
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(UserAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", accessToken,
                new { access_token = accessToken, country_id = countryId, q, offset, count });
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", null,
                new { country_id = countryId, q, offset, count });
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(ServiceAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", accessToken,
                new { access_token = accessToken, country_id = countryId, q, offset, count });
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(UserAccessToken accessToken, IEnumerable<int?> streetIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", accessToken,
                new { access_token = accessToken, street_ids = streetIds });
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(IEnumerable<int?> streetIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", null,
                new { street_ids = streetIds });
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(ServiceAccessToken accessToken, IEnumerable<int?> streetIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", accessToken,
                new { access_token = accessToken, street_ids = streetIds });
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(UserAccessToken accessToken, IEnumerable<int?> countryIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", accessToken,
                new { access_token = accessToken, country_ids = countryIds });
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(IEnumerable<int?> countryIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", null,
                new { country_ids = countryIds });
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(ServiceAccessToken accessToken, IEnumerable<int?> countryIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", accessToken,
                new { access_token = accessToken, country_ids = countryIds });
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(UserAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", accessToken,
                new { access_token = accessToken, country_id = countryId, region_id = regionId, q, need_all = needAll, offset, count });
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", null,
                new { country_id = countryId, region_id = regionId, q, need_all = needAll, offset, count });
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(ServiceAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", accessToken,
                new { access_token = accessToken, country_id = countryId, region_id = regionId, q, need_all = needAll, offset, count });
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(UserAccessToken accessToken, IEnumerable<int?> cityIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", accessToken,
                new { access_token = accessToken, city_ids = cityIds });
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(IEnumerable<int?> cityIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", null,
                new { city_ids = cityIds });
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(ServiceAccessToken accessToken, IEnumerable<int?> cityIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", accessToken,
                new { access_token = accessToken, city_ids = cityIds });
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(UserAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", accessToken,
                new { access_token = accessToken, q, country_id = countryId, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", null,
                new { q, country_id = countryId, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(ServiceAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", accessToken,
                new { access_token = accessToken, q, country_id = countryId, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(UserAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", accessToken,
                new { access_token = accessToken, q, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", null,
                new { q, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(ServiceAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", accessToken,
                new { access_token = accessToken, q, city_id = cityId, offset, count });
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(UserAccessToken accessToken, int? countryId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", accessToken,
                new { access_token = accessToken, country_id = countryId });
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(int? countryId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", null,
                new { country_id = countryId });
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(ServiceAccessToken accessToken, int? countryId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", accessToken,
                new { access_token = accessToken, country_id = countryId });
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(UserAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", accessToken,
                new { access_token = accessToken, university_id = universityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(int? universityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", null,
                new { university_id = universityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(ServiceAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", accessToken,
                new { access_token = accessToken, university_id = universityId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(UserAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", accessToken,
                new { access_token = accessToken, faculty_id = facultyId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(int? facultyId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", null,
                new { faculty_id = facultyId, offset, count });
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(ServiceAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", accessToken,
                new { access_token = accessToken, faculty_id = facultyId, offset, count });
        }

    }

    internal class GiftsApi : IGiftsApi
    {
        public Task<ApiRequest<GiftsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<GiftsGetResponse>("gifts.get", accessToken,
                new { access_token = accessToken, user_id = userId, count, offset });
        }

    }

    internal class AdsApi : IAdsApi
    {
        public Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccounts()
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsAccount>>("ads.getAccounts", null,
                new { });
        }

        public Task<ApiRequest<IEnumerable<AdsClient>>> GetClients(UserAccessToken accessToken, int? accountId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsClient>>("ads.getClients", accessToken,
                new { access_token = accessToken, account_id = accountId });
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createClients", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<int?>> UpdateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.updateClients", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<int?>> DeleteClients(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.deleteClients", accessToken,
                new { access_token = accessToken, account_id = accountId, ids });
        }

        public Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaigns(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsCampaign>>("ads.getCampaigns", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, include_deleted = includeDeleted, campaign_ids = campaignIds });
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createCampaigns", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<int?>> UpdateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.updateCampaigns", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<int?>> DeleteCampaigns(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.deleteCampaigns", accessToken,
                new { access_token = accessToken, account_id = accountId, ids });
        }

        public Task<ApiRequest<IEnumerable<AdsAd>>> GetAds(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsAd>>("ads.getAds", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, include_deleted = includeDeleted, campaign_ids = campaignIds, ad_ids = adIds, limit, offset });
        }

        public Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayout(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsAdLayout>>("ads.getAdsLayout", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, include_deleted = includeDeleted, campaign_ids = campaignIds, ad_ids = adIds, limit, offset });
        }

        public Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargeting(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, include_deleted = includeDeleted, campaign_ids = campaignIds, ad_ids = adIds, limit, offset });
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createAds", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<IEnumerable<int?>>> UpdateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.updateAds", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<IEnumerable<int?>>> DeleteAds(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.deleteAds", accessToken,
                new { access_token = accessToken, account_id = accountId, ids });
        }

        public Task<ApiRequest<AdsLinkStatus>> CheckLink(UserAccessToken accessToken, int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null)
        {
            return RequestManager.CreateRequestAsync<AdsLinkStatus>("ads.checkLink", accessToken,
                new { access_token = accessToken, account_id = accountId, link_type = linkType, link_url = linkUrl, campaign_id = campaignId });
        }

        public Task<ApiRequest<IEnumerable<AdsStats>>> GetStatistics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsStats>>("ads.getStatistics", accessToken,
                new { access_token = accessToken, account_id = accountId, ids_type = idsType, ids, period, date_from = dateFrom, date_to = dateTo });
        }

        public Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsDemoStats>>("ads.getDemographics", accessToken,
                new { access_token = accessToken, account_id = accountId, ids_type = idsType, ids, period, date_from = dateFrom, date_to = dateTo });
        }

        public Task<ApiRequest<IEnumerable<AdsPostStats>>> GetAdsPostsReach(UserAccessToken accessToken, int? accountId = null, string adsIds = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsPostStats>>("ads.getAdsPostsReach", accessToken,
                new { access_token = accessToken, account_id = accountId, ads_ids = adsIds });
        }

        public Task<ApiRequest<int?>> GetBudget(UserAccessToken accessToken, int? accountId = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.getBudget", accessToken,
                new { access_token = accessToken, account_id = accountId });
        }

        public Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsers(UserAccessToken accessToken, int? accountId = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsUsers>>("ads.getOfficeUsers", accessToken,
                new { access_token = accessToken, account_id = accountId });
        }

        public Task<ApiRequest<bool?>> AddOfficeUsers(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("ads.addOfficeUsers", accessToken,
                new { access_token = accessToken, account_id = accountId, data });
        }

        public Task<ApiRequest<bool?>> RemoveOfficeUsers(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("ads.removeOfficeUsers", accessToken,
                new { access_token = accessToken, account_id = accountId, ids });
        }

        public Task<ApiRequest<AdsTargStats>> GetTargetingStats(UserAccessToken accessToken, int? accountId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null, string linkDomain = null)
        {
            return RequestManager.CreateRequestAsync<AdsTargStats>("ads.getTargetingStats", accessToken,
                new { access_token = accessToken, account_id = accountId, criteria, ad_id = adId, ad_format = adFormat, ad_platform = adPlatform, link_url = linkUrl, link_domain = linkDomain });
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", accessToken,
                new { access_token = accessToken, section, ids, q, country, lang });
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", accessToken,
                new { access_token = accessToken, section, ids, q, country, lang });
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", accessToken,
                new { access_token = accessToken, section, ids, q, country, cities, lang });
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", accessToken,
                new { access_token = accessToken, section, ids, q, country, lang });
        }

        public Task<ApiRequest<AdsGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, string lang = null)
        {
            return RequestManager.CreateRequestAsync<AdsGetCategoriesResponse>("ads.getCategories", accessToken,
                new { access_token = accessToken, lang });
        }

        public Task<ApiRequest<string>> GetUploadURL(UserAccessToken accessToken, int? adFormat = null)
        {
            return RequestManager.CreateRequestAsync<string>("ads.getUploadURL", accessToken,
                new { access_token = accessToken, ad_format = adFormat });
        }

        public Task<ApiRequest<string>> GetVideoUploadURL()
        {
            return RequestManager.CreateRequestAsync<string>("ads.getVideoUploadURL", null,
                new { });
        }

        public Task<ApiRequest<AdsFloodStats>> GetFloodStats(UserAccessToken accessToken, int? accountId = null)
        {
            return RequestManager.CreateRequestAsync<AdsFloodStats>("ads.getFloodStats", accessToken,
                new { access_token = accessToken, account_id = accountId });
        }

        public Task<ApiRequest<AdsRejectReason>> GetRejectionReason(UserAccessToken accessToken, int? accountId = null, int? adId = null)
        {
            return RequestManager.CreateRequestAsync<AdsRejectReason>("ads.getRejectionReason", accessToken,
                new { access_token = accessToken, account_id = accountId, ad_id = adId });
        }

        public Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, string name = null, string domain = null, int? lifetime = null)
        {
            return RequestManager.CreateRequestAsync<AdsCreateTargetGroupResponse>("ads.createTargetGroup", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, name, domain, lifetime });
        }

        public Task<ApiRequest<bool?>> UpdateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("ads.updateTargetGroup", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, target_group_id = targetGroupId, name, domain, lifetime });
        }

        public Task<ApiRequest<bool?>> DeleteTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("ads.deleteTargetGroup", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, target_group_id = targetGroupId });
        }

        public Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroups(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, extended });
        }

        public Task<ApiRequest<int?>> ImportTargetContacts(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null)
        {
            return RequestManager.CreateRequestAsync<int?>("ads.importTargetContacts", accessToken,
                new { access_token = accessToken, account_id = accountId, client_id = clientId, target_group_id = targetGroupId, contacts });
        }

    }

    internal class MarketApi : IMarketApi
    {
        public Task<ApiRequest<MarketGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetResponse>("market.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, count, offset });
        }

        public Task<ApiRequest<MarketGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetExtendedResponse>("market.get", accessToken,
                new { access_token = accessToken, owner_id = ownerId, count, offset, extended });
        }

        public Task<ApiRequest<MarketGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<string> itemIds = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetByIdResponse>("market.getById", accessToken,
                new { access_token = accessToken, item_ids = itemIds });
        }

        public Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> itemIds = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetByIdExtendedResponse>("market.getById", accessToken,
                new { access_token = accessToken, item_ids = itemIds, extended });
        }

        public Task<ApiRequest<MarketSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<MarketSearchResponse>("market.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, q, price_from = priceFrom, price_to = priceTo, tags, rev, offset, count });
        }

        public Task<ApiRequest<MarketSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null)
        {
            return RequestManager.CreateRequestAsync<MarketSearchExtendedResponse>("market.search", accessToken,
                new { access_token = accessToken, owner_id = ownerId, q, price_from = priceFrom, price_to = priceTo, tags, rev, offset, count, extended });
        }

        public Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetAlbumsResponse>("market.getAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, offset, count });
        }

        public Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetAlbumByIdResponse>("market.getAlbumById", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_ids = albumIds });
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            return RequestManager.CreateRequestAsync<int?>("market.createComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, message, attachments, from_group = fromGroup, reply_to_comment = replyToComment, sticker_id = stickerId, guid });
        }

        public Task<ApiRequest<MarketGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetCommentsResponse>("market.getComments", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, need_likes = needLikes, start_comment_id = startCommentId, count, sort, extended, fields });
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.deleteComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.restoreComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId });
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.editComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, message, attachments });
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.reportComment", accessToken,
                new { access_token = accessToken, owner_id = ownerId, comment_id = commentId, reason });
        }

        public Task<ApiRequest<MarketGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            return RequestManager.CreateRequestAsync<MarketGetCategoriesResponse>("market.getCategories", accessToken,
                new { access_token = accessToken, count, offset });
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, int? reason = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.report", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, reason });
        }

        public Task<ApiRequest<MarketAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            return RequestManager.CreateRequestAsync<MarketAddResponse>("market.add", accessToken,
                new { access_token = accessToken, owner_id = ownerId, name, description, category_id = categoryId, price, deleted, main_photo_id = mainPhotoId, photo_ids = photoIds });
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.edit", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, name, description, category_id = categoryId, price, deleted, main_photo_id = mainPhotoId, photo_ids = photoIds });
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.delete", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.restore", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId });
        }

        public Task<ApiRequest<bool?>> ReorderItems(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.reorderItems", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, item_id = itemId, before, after });
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.reorderAlbums", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, before, after });
        }

        public Task<ApiRequest<MarketAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            return RequestManager.CreateRequestAsync<MarketAddAlbumResponse>("market.addAlbum", accessToken,
                new { access_token = accessToken, owner_id = ownerId, title, photo_id = photoId, main_album = mainAlbum });
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.editAlbum", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId, title, photo_id = photoId, main_album = mainAlbum });
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.deleteAlbum", accessToken,
                new { access_token = accessToken, owner_id = ownerId, album_id = albumId });
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.removeFromAlbum", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, album_ids = albumIds });
        }

        public Task<ApiRequest<bool?>> AddToAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            return RequestManager.CreateRequestAsync<bool?>("market.addToAlbum", accessToken,
                new { access_token = accessToken, owner_id = ownerId, item_id = itemId, album_ids = albumIds });
        }

    }

}