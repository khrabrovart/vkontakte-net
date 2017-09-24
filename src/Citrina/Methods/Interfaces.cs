using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IUsersApi
    {
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(UserAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(ServiceAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// </summary>
        Task<ApiRequest<UsersSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null);
        /// <summary>
        /// Returns information whether a user installed the application.
        /// </summary>
        Task<ApiRequest<bool?>> IsAppUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(ServiceAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Reports (submits a complain about) a user.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? userId = null, string type = null, string comment = null);
        /// <summary>
        /// Indexes current user location and returns nearby users.
        /// </summary>
        Task<ApiRequest<UsersGetNearbyResponse>> GetNearby(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null, string nameCase = null);
    }

    public interface IAuthApi
    {
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        Task<ApiRequest<bool?>> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null);
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        Task<ApiRequest<bool?>> CheckPhone(ServiceAccessToken accessToken, string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null);
        /// <summary>
        /// Registers a new user by phone number.
        /// </summary>
        Task<ApiRequest<AuthSignupResponse>> Signup(string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null);
        /// <summary>
        /// Registers a new user by phone number.
        /// </summary>
        Task<ApiRequest<AuthSignupResponse>> Signup(ServiceAccessToken accessToken, string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null);
        /// <summary>
        /// Completes a user's registration (begun with the [vk.com/dev/auth.signup|auth.signup] method) using an authorization code.
        /// </summary>
        Task<ApiRequest<AuthConfirmResponse>> Confirm(int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null);
        /// <summary>
        /// Completes a user's registration (begun with the [vk.com/dev/auth.signup|auth.signup] method) using an authorization code.
        /// </summary>
        Task<ApiRequest<AuthConfirmResponse>> Confirm(ServiceAccessToken accessToken, int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null);
        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        /// </summary>
        Task<ApiRequest<AuthRestoreResponse>> Restore(string phone = null, string lastName = null);
        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        /// </summary>
        Task<ApiRequest<AuthRestoreResponse>> Restore(ServiceAccessToken accessToken, string phone = null, string lastName = null);
    }

    public interface IWallApi
    {
        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchResponse>> Search(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// </summary>
        Task<ApiRequest<WallPostResponse>> Post(UserAccessToken accessToken, int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null);
        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallRepostResponse>> Repost(UserAccessToken accessToken, string @object = null, string message = null, int? groupId = null, bool? markAsAds = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null);
        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Pins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> Pin(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Unpins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> Unpin(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallCreateCommentResponse>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Edits a comment on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportPost(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? reason = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
    }

    public interface IPhotosApi
    {
        /// <summary>
        /// Creates an empty photo album.
        /// </summary>
        Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbum(UserAccessToken accessToken, string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);
        /// <summary>
        /// Edits information about a photo album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(ServiceAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns the number of photo albums belonging to a user or community.
        /// </summary>
        Task<ApiRequest<int?>> GetAlbumsCount(UserAccessToken accessToken, int? userId = null, int? groupId = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns the server address for photo upload.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetUploadServer(UserAccessToken accessToken, int? albumId = null, int? groupId = null);
        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(UserAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null);
        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(GroupAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null);
        /// <summary>
        /// Returns an upload server address for a profile or community photo.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(UserAccessToken accessToken, int? ownerId = null);
        /// <summary>
        /// Returns an upload link for chat cover pictures.
        /// </summary>
        Task<ApiRequest<PhotosGetChatUploadServerResponse>> GetChatUploadServer(UserAccessToken accessToken, int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null);
        /// <summary>
        /// Returns the server address for market photo upload.
        /// </summary>
        Task<ApiRequest<PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(UserAccessToken accessToken, int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null);
        /// <summary>
        /// Returns the server address for market album photo upload.
        /// </summary>
        Task<ApiRequest<PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Saves market photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null);
        /// <summary>
        /// Saves cover photo after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhoto(UserAccessToken accessToken, string photo = null, string hash = null);
        /// <summary>
        /// Saves market album photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Saves a profile or community photo. Upload URL can be got with the [vk.com/dev/photos.getOwnerPhotoUploadServer|photos.getOwnerPhotoUploadServer] method.
        /// </summary>
        Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(UserAccessToken accessToken, string server = null, string hash = null, string photo = null);
        /// <summary>
        /// Saves a photo to a user's or community's wall after being uploaded.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhoto(UserAccessToken accessToken, int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);
        /// <summary>
        /// Returns the server address for photo upload onto a user's wall.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(UserAccessToken accessToken);
        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(GroupAccessToken accessToken);
        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(UserAccessToken accessToken, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(GroupAccessToken accessToken, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Reports (submits a complaint about) a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? reason = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(UserAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Saves photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> Save(UserAccessToken accessToken, int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);
        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album
        /// </summary>
        Task<ApiRequest<int?>> Copy(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null);
        /// <summary>
        /// Edits the caption of a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null);
        /// <summary>
        /// Moves a photo from one album to another.
        /// </summary>
        Task<ApiRequest<bool?>> Move(UserAccessToken accessToken, int? ownerId = null, int? targetAlbumId = null, int? photoId = null);
        /// <summary>
        /// Makes a photo into an album cover.
        /// </summary>
        Task<ApiRequest<bool?>> MakeCover(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? albumId = null);
        /// <summary>
        /// Reorders the album in the list of user albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderPhotos(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? before = null, int? after = null);
        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllResponse>> GetAll(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);
        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllExtended(UserAccessToken accessToken, int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);
        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? albumId = null, int? groupId = null);
        /// <summary>
        /// Deletes a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? photoId = null);
        /// <summary>
        /// Restores a deleted photo.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? photoId = null);
        /// <summary>
        /// Confirms a tag on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ConfirmTag(UserAccessToken accessToken, int? ownerId = null, string photoId = null, int? tagId = null);
        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllComments(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Adds a new comment on the photo.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null);
        /// <summary>
        /// Deletes a comment on the photo.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a deleted comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Edits a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Returns a list of tags on a photo.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null);
        /// <summary>
        /// Adds a tag on the photo.
        /// </summary>
        Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null);
        /// <summary>
        /// Removes a tag from a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? tagId = null);
        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// </summary>
        Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null);
    }

    public interface IFriendsApi
    {
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetOnline(UserAccessToken accessToken, int? userId = null, int? listId = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(UserAccessToken accessToken, int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetMutual(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualTargetUids(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetRecent(UserAccessToken accessToken, int? count = null);
        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? offset = null, int? count = null, bool? @out = null, int? sort = null, bool? suggested = null);
        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(UserAccessToken accessToken, int? offset = null, int? count = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? suggested = null);
        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null, bool? @out = null, int? sort = null, bool? suggested = null);
        /// <summary>
        /// Approves or creates a friend request.
        /// </summary>
        Task<ApiRequest<int?>> Add(UserAccessToken accessToken, int? userId = null, string text = null, bool? follow = null);
        /// <summary>
        /// Edits the friend lists of the selected user.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? userId = null, IEnumerable<int?> listIds = null);
        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// </summary>
        Task<ApiRequest<FriendsDeleteResponse>> Delete(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of the user's friend lists.
        /// </summary>
        Task<ApiRequest<FriendsGetListsResponse>> GetLists(UserAccessToken accessToken, int? userId = null, bool? returnSystem = null);
        /// <summary>
        /// Creates a new friend list for the current user.
        /// </summary>
        Task<ApiRequest<FriendsAddListResponse>> AddList(UserAccessToken accessToken, string name = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Edits a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> EditList(UserAccessToken accessToken, string name = null, int? listId = null, IEnumerable<int?> userIds = null, IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null);
        /// <summary>
        /// Deletes a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteList(UserAccessToken accessToken, int? listId = null);
        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetAppUsers(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhones(UserAccessToken accessToken, IEnumerable<string> phones = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAllRequests(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// </summary>
        Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestions(UserAccessToken accessToken, IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriends(UserAccessToken accessToken, IEnumerable<int?> userIds = null, bool? needSign = null);
        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// </summary>
        Task<ApiRequest<FriendsGetAvailableForCallResponse>> GetAvailableForCall(UserAccessToken accessToken, string nameCase = null);
        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// </summary>
        Task<ApiRequest<FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// </summary>
        Task<ApiRequest<FriendsSearchResponse>> Search(UserAccessToken accessToken, int? userId = null, string q = null, IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null);
    }

    public interface IWidgetsApi
    {
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(UserAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(int? widgetApiId = null, string order = null, string period = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(ServiceAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null);
    }

    public interface ISecureApi
    {
        /// <summary>
        /// Returns payment balance of the application in hundredth of a vote.
        /// </summary>
        Task<ApiRequest<int?>> GetAppBalance(ServiceAccessToken accessToken);
        /// <summary>
        /// Shows history of votes transaction between users and the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistory(ServiceAccessToken accessToken);
        /// <summary>
        /// Shows a list of SMS notifications sent by the application using [vk.com/dev/secure.sendSMSNotification|secure.sendSMSNotification] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistory(ServiceAccessToken accessToken, int? userId = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? limit = null);
        /// <summary>
        /// Sends 'SMS' notification to a user's mobile device.
        /// </summary>
        Task<ApiRequest<bool?>> SendSMSNotification(ServiceAccessToken accessToken, int? userId = null, string message = null);
        /// <summary>
        /// Sends notification to the user.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> SendNotification(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null, int? userId = null, string message = null);
        /// <summary>
        /// Sets a counter which is shown to the user in bold in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetCounter(ServiceAccessToken accessToken, IEnumerable<string> counters = null, int? userId = null, int? counter = null);
        /// <summary>
        /// Sets user game level in the application which can be seen by his/her friends.
        /// </summary>
        Task<ApiRequest<bool?>> SetUserLevel(ServiceAccessToken accessToken, IEnumerable<string> levels = null, int? userId = null, int? level = null);
        /// <summary>
        /// Returns one of the previously set game levels of one or more users in the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevel(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Adds user activity information to an application
        /// </summary>
        Task<ApiRequest<bool?>> AddAppEvent(UserAccessToken accessToken, int? userId = null, int? activityId = null, int? value = null);
        /// <summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        /// </summary>
        Task<ApiRequest<SecureTokenChecked>> CheckToken(UserAccessToken accessToken, string token = null, string ip = null);
    }

    public interface IStreamingApi
    {
        /// <summary>
        /// Allows to receive data for the connection to Streaming API.
        /// </summary>
        Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrl(ServiceAccessToken accessToken);
    }

    public interface IStorageApi
    {
        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        Task<ApiRequest<string>> Get(UserAccessToken accessToken, string key = null, IEnumerable<string> keys = null, int? userId = null);
        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// </summary>
        Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string key = null, string value = null, int? userId = null);
        /// <summary>
        /// Returns the names of all variables.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> GetKeys(UserAccessToken accessToken, int? userId = null, int? count = null);
    }

    public interface IOrdersApi
    {
        /// <summary>
        /// Returns a list of orders.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> Get(UserAccessToken accessToken, int? count = null, bool? testMode = null);
        /// <summary>
        /// Returns information about orders by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> GetById(UserAccessToken accessToken, int? orderId = null, IEnumerable<int?> orderIds = null, bool? testMode = null);
        /// <summary>
        /// Changes order status.
        /// </summary>
        Task<ApiRequest<string>> ChangeState(UserAccessToken accessToken, int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null);
        Task<ApiRequest<OrdersAmount>> GetAmount(int? userId = null, IEnumerable<string> votes = null);
    }

    public interface IStatusApi
    {
        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// </summary>
        Task<ApiRequest<StatusStatus>> Get(UserAccessToken accessToken, int? userId = null, int? groupId = null);
        /// <summary>
        /// Sets a new status for the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string text = null, int? groupId = null);
    }

    public interface ILeadsApi
    {
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(UserAccessToken accessToken, string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(ServiceAccessToken accessToken, string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(UserAccessToken accessToken, int? leadId = null, string secret = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(int? leadId = null, string secret = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(ServiceAccessToken accessToken, int? leadId = null, string secret = null);
        /// <summary>
        /// Returns lead stats data.
        /// </summary>
        Task<ApiRequest<LeadsLead>> GetStats(UserAccessToken accessToken, int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(UserAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(ServiceAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Checks if the user can start the lead.
        /// </summary>
        Task<ApiRequest<LeadsChecked>> CheckUser(UserAccessToken accessToken, int? leadId = null, int? testResult = null, int? age = null, string country = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(UserAccessToken accessToken, string data = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(string data = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(ServiceAccessToken accessToken, string data = null);
    }

    public interface IPagesApi
    {
        /// <summary>
        /// Returns information about a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> Get(UserAccessToken accessToken, int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null);
        /// <summary>
        /// Saves the text of a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> Save(UserAccessToken accessToken, string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null);
        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> SaveAccess(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null);
        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipageVersion>>> GetHistory(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitles(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> GetVersion(UserAccessToken accessToken, int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null);
        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// </summary>
        Task<ApiRequest<string>> ParseWiki(UserAccessToken accessToken, string text = null, int? groupId = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(UserAccessToken accessToken, string url = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(string url = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(ServiceAccessToken accessToken, string url = null);
    }

    public interface IGroupsApi
    {
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(UserAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(UserAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(UserAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(UserAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(GroupAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(ServiceAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(ServiceAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(GroupAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// </summary>
        Task<ApiRequest<bool?>> Join(UserAccessToken accessToken, int? groupId = null, string notSure = null);
        /// <summary>
        /// With this method you can leave a group, public page, or event.
        /// </summary>
        Task<ApiRequest<bool?>> Leave(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// </summary>
        Task<ApiRequest<GroupsSearchResponse>> Search(UserAccessToken accessToken, string q = null, string type = null, int? countryId = null, int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns communities list for a catalog category.
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? categoryId = null, int? subcategoryId = null);
        /// <summary>
        /// Returns categories list for communities catalog
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfo(UserAccessToken accessToken, bool? subcategories = null);
        /// <summary>
        /// Returns categories list for communities catalog
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(UserAccessToken accessToken, bool? extended = null, bool? subcategories = null);
        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesResponse>> GetInvites(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns invited users list of a community
        /// </summary>
        Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsers(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Adds a user to a community blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null, DateTime? endDate = null, int? reason = null, string comment = null, bool? commentVisible = null);
        /// <summary>
        /// Removes a user from a community blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// </summary>
        Task<ApiRequest<GroupsGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? userId = null);
        /// <summary>
        /// Creates a new community.
        /// </summary>
        Task<ApiRequest<GroupsGroup>> Create(UserAccessToken accessToken, string title = null, string description = null, string type = null, int? publicCategory = null, int? subtype = null);
        /// <summary>
        /// Edits a community.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? groupId = null, string title = null, string description = null, string screenName = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, DateTime? eventStartDate = null, DateTime? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, int? ageLimits = null, bool? market = null, bool? marketComments = null, IEnumerable<int?> marketCountry = null, IEnumerable<int?> marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null, bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null);
        /// <summary>
        /// Edits the place in community.
        /// </summary>
        Task<ApiRequest<GroupsEditPlaceResponse>> EditPlace(UserAccessToken accessToken, int? groupId = null, string title = null, string address = null, int? countryId = null, int? cityId = null, double? latitude = null, double? longitude = null);
        /// <summary>
        /// Returns community settings.
        /// </summary>
        Task<ApiRequest<GroupsGroupSettings>> GetSettings(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsFields(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// </summary>
        Task<ApiRequest<bool?>> EditManager(UserAccessToken accessToken, int? groupId = null, int? userId = null, string role = null, bool? isContact = null, string contactPosition = null, string contactPhone = null, string contactEmail = null);
        /// <summary>
        /// Allows to invite friends to the community.
        /// </summary>
        Task<ApiRequest<bool?>> Invite(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Allows to add a link to the community.
        /// </summary>
        Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, int? groupId = null, string link = null, string text = null);
        /// <summary>
        /// Allows to delete a link from the community.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null);
        /// <summary>
        /// Allows to edit a link in the community.
        /// </summary>
        Task<ApiRequest<bool?>> EditLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, string text = null);
        /// <summary>
        /// Allows to reorder links in the community.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, int? after = null);
        /// <summary>
        /// Removes a user from the community.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Allows to approve join request to the community.
        /// </summary>
        Task<ApiRequest<bool?>> ApproveRequest(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community.
        /// </summary>
        Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(UserAccessToken accessToken, int? groupId = null, string serverUrl = null);
        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community.
        /// </summary>
        Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(GroupAccessToken accessToken, int? groupId = null, string serverUrl = null);
        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null, string secretKey = null);
        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null, string secretKey = null);
        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackSettings(UserAccessToken accessToken, int? groupId = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null);
        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackSettings(GroupAccessToken accessToken, int? groupId = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null);
    }

    public interface IBoardApi
    {
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> AddTopic(UserAccessToken accessToken, int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string title = null);
        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null);
        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(GroupAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null);
        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> OpenTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// </summary>
        Task<ApiRequest<bool?>> CloseTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> FixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> UnfixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
    }

    public interface IVideoApi
    {
        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);
        /// <summary>
        /// Edits information about a video on a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null);
        /// <summary>
        /// Adds a video to a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Add(UserAccessToken accessToken, int? targetId = null, int? videoId = null, int? ownerId = null);
        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// </summary>
        Task<ApiRequest<VideoSaveResult>> Save(UserAccessToken accessToken, string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null);
        /// <summary>
        /// Deletes a video from a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? videoId = null, int? ownerId = null, int? targetId = null);
        /// <summary>
        /// Restores a previously deleted video.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? videoId = null, int? ownerId = null);
        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null);
        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// </summary>
        Task<ApiRequest<VideoGetUserVideosResponse>> GetUserVideos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// </summary>
        Task<ApiRequest<VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns video album info
        /// </summary>
        Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, int? albumId = null);
        /// <summary>
        /// Creates an empty album for videos.
        /// </summary>
        Task<ApiRequest<VideoAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? groupId = null, string title = null, IEnumerable<string> privacy = null);
        /// <summary>
        /// Edits the title of a video album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null);
        /// <summary>
        /// Deletes a video album.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null);
        /// <summary>
        /// Reorders the album in the list of user video albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the video in the video album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderVideos(UserAccessToken accessToken, int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null);
        Task<ApiRequest<bool?>> AddToAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<bool?>> RemoveFromAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<IEnumerable<int?>>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null);
        /// <summary>
        /// Adds a new comment on a video.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Deletes a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Edits the text of a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Returns a list of tags on a video.
        /// </summary>
        Task<ApiRequest<IEnumerable<VideoVideoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? videoId = null);
        /// <summary>
        /// Adds a tag on a video.
        /// </summary>
        Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? userId = null, int? ownerId = null, int? videoId = null, string taggedName = null);
        /// <summary>
        /// Removes a tag from a video.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? tagId = null, int? ownerId = null, int? videoId = null);
        /// <summary>
        /// Returns a list of videos with tags that have not been viewed.
        /// </summary>
        Task<ApiRequest<VideoGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Hides a video catalog section from a user.
        /// </summary>
        Task<ApiRequest<bool?>> HideCatalogSection(UserAccessToken accessToken, int? sectionId = null);
    }

    public interface INotesApi
    {
        /// <summary>
        /// Returns a list of notes created by a user.
        /// </summary>
        Task<ApiRequest<NotesGetResponse>> Get(UserAccessToken accessToken, IEnumerable<int?> noteIds = null, int? userId = null, int? count = null);
        /// <summary>
        /// Returns a note by its ID.
        /// </summary>
        Task<ApiRequest<NotesNote>> GetById(UserAccessToken accessToken, int? noteId = null, int? ownerId = null);
        /// <summary>
        /// Creates a new note for the current user.
        /// </summary>
        Task<ApiRequest<int?>> Add(UserAccessToken accessToken, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);
        /// <summary>
        /// Edits a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);
        /// <summary>
        /// Deletes a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? noteId = null);
        /// <summary>
        /// Returns a list of comments on a note.
        /// </summary>
        Task<ApiRequest<NotesGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? count = null);
        /// <summary>
        /// Adds a new comment on a note.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null);
        /// <summary>
        /// Edits a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null, string message = null);
        /// <summary>
        /// Deletes a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null);
        /// <summary>
        /// Restores a deleted comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null);
    }

    public interface IPlacesApi
    {
        /// <summary>
        /// Adds a new location to the location database.
        /// </summary>
        Task<ApiRequest<PlacesAddResponse>> Add(UserAccessToken accessToken, int? type = null, string title = null, double? latitude = null, double? longitude = null, int? country = null, int? city = null, string address = null);
        /// <summary>
        /// Returns information about locations by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PlacesPlaceMin>>> GetById(UserAccessToken accessToken, IEnumerable<int?> places = null);
        /// <summary>
        /// Returns a list of locations that match the search criteria.
        /// </summary>
        Task<ApiRequest<PlacesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? city = null, double? latitude = null, double? longitude = null, int? radius = null, int? offset = null, int? count = null);
        /// <summary>
        /// Checks a user in at the specified location.
        /// </summary>
        Task<ApiRequest<PlacesCheckinResponse>> Checkin(UserAccessToken accessToken, int? placeId = null, string text = null, double? latitude = null, double? longitude = null, bool? friendsOnly = null, IEnumerable<string> services = null);
        /// <summary>
        /// Returns a list of user check-ins at locations according to the set parameters.
        /// </summary>
        Task<ApiRequest<PlacesGetCheckinsResponse>> GetCheckins(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? place = null, int? userId = null, DateTime? offset = null, DateTime? count = null, DateTime? timestamp = null, bool? friendsOnly = null, bool? needPlaces = null);
        /// <summary>
        /// Returns a list of all types of locations.
        /// </summary>
        Task<ApiRequest<IEnumerable<PlacesTypes>>> GetTypes(UserAccessToken accessToken);
    }

    public interface IAccountApi
    {
        /// <summary>
        /// Returns non-null values of user counters.
        /// </summary>
        Task<ApiRequest<AccountAccountCounters>> GetCounters(UserAccessToken accessToken, IEnumerable<string> filter = null);
        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetNameInMenu(UserAccessToken accessToken, int? userId = null, string name = null);
        /// <summary>
        /// Marks the current user as online for 15 minutes.
        /// </summary>
        Task<ApiRequest<bool?>> SetOnline(UserAccessToken accessToken, bool? voip = null);
        /// <summary>
        /// Marks a current user as offline.
        /// </summary>
        Task<ApiRequest<bool?>> SetOffline(UserAccessToken accessToken);
        /// <summary>
        /// Allows to search the VK users using phone numbers, e-mail addresses and user IDs on other services.
        /// </summary>
        Task<ApiRequest<AccountLookupResult>> LookupContacts(UserAccessToken accessToken, IEnumerable<string> contacts = null, string service = null, string mycontact = null, bool? returnAll = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications
        /// </summary>
        Task<ApiRequest<bool?>> RegisterDevice(UserAccessToken accessToken, string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null);
        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// </summary>
        Task<ApiRequest<bool?>> UnregisterDevice(UserAccessToken accessToken, string deviceId = null);
        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// </summary>
        Task<ApiRequest<bool?>> SetSilenceMode(UserAccessToken accessToken, string deviceId = null, int? time = null, int? peerId = null, int? sound = null);
        /// <summary>
        /// Gets settings of push notifications.
        /// </summary>
        Task<ApiRequest<AccountPushSettings>> GetPushSettings(UserAccessToken accessToken, string deviceId = null);
        /// <summary>
        /// Change push settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetPushSettings(UserAccessToken accessToken, string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null);
        /// <summary>
        /// Gets settings of the user in this application.
        /// </summary>
        Task<ApiRequest<int?>> GetAppPermissions(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        /// </summary>
        Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffers(UserAccessToken accessToken, int? count = null);
        /// <summary>
        /// Adds user to the banlist.
        /// </summary>
        Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Deletes user from the blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a user's blacklist.
        /// </summary>
        Task<ApiRequest<AccountGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns current account info.
        /// </summary>
        Task<ApiRequest<AccountInfo>> GetInfo(UserAccessToken accessToken, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to edit the current account info.
        /// </summary>
        Task<ApiRequest<bool?>> SetInfo(UserAccessToken accessToken, string name = null, string value = null);
        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        /// </summary>
        Task<ApiRequest<AccountChangePasswordResponse>> ChangePassword(UserAccessToken accessToken, string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null);
        /// <summary>
        /// Returns the current account info.
        /// </summary>
        Task<ApiRequest<AccountUserSettings>> GetProfileInfo(UserAccessToken accessToken);
        /// <summary>
        /// Edits current profile info.
        /// </summary>
        Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfo(UserAccessToken accessToken, string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null);
    }

    public interface IMessagesApi
    {
        /// <summary>
        /// Returns a list of the current user's incoming or outgoing private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetResponse>> Get(UserAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null);
        /// <summary>
        /// Returns a list of the current user's incoming or outgoing private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetResponse>> Get(GroupAccessToken accessToken, bool? @out = null, int? offset = null, int? count = null, int? filter = null, int? timeOffset = null, int? previewLength = null, int? lastMessageId = null);
        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(UserAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null);
        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        Task<ApiRequest<MessagesGetDialogsResponse>> GetDialogs(GroupAccessToken accessToken, int? offset = null, int? count = null, int? startMessageId = null, int? previewLength = null, bool? unread = null, bool? important = null, bool? unanswered = null);
        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<int?> messageIds = null);
        /// <summary>
        /// Returns messages by their IDs.
        /// </summary>
        Task<ApiRequest<MessagesGetByIdResponse>> GetById(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null);
        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// </summary>
        Task<ApiRequest<MessagesSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? peerId = null, DateTime? date = null, int? previewLength = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(UserAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null);
        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryResponse>> GetHistory(GroupAccessToken accessToken, int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null);
        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(UserAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// </summary>
        Task<ApiRequest<MessagesGetHistoryAttachmentsResponse>> GetHistoryAttachments(GroupAccessToken accessToken, int? peerId = null, string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<int?>> Send(UserAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null);
        /// <summary>
        /// Sends a message.
        /// </summary>
        Task<ApiRequest<int?>> Send(GroupAccessToken accessToken, int? userId = null, int? randomId = null, int? peerId = null, string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null, double? lat = null, double? @long = null, string attachment = null, string forwardMessages = null, int? stickerId = null, bool? notification = null);
        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        Task<ApiRequest<MessagesDeleteResponse>> Delete(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null);
        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        Task<ApiRequest<MessagesDeleteResponse>> Delete(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, bool? spam = null);
        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteDialog(UserAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Deletes all private messages in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteDialog(GroupAccessToken accessToken, string userId = null, int? peerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? messageId = null);
        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(GroupAccessToken accessToken, int? messageId = null);
        /// <summary>
        /// Marks messages as read.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsRead(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null);
        /// <summary>
        /// Marks messages as read.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsRead(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, string peerId = null, int? startMessageId = null);
        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(UserAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null);
        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> MarkAsImportant(GroupAccessToken accessToken, IEnumerable<int?> messageIds = null, int? important = null);
        /// <summary>
        /// Marks and unmarks dialogs as important.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsImportantDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null);
        /// <summary>
        /// Marks and unmarks dialogs as unanswered.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsUnansweredDialog(GroupAccessToken accessToken, IEnumerable<int?> peerId = null, int? important = null);
        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(UserAccessToken accessToken, int? lpVersion = null, bool? needPts = null);
        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// </summary>
        Task<ApiRequest<MessagesLongpollParams>> GetLongPollServer(GroupAccessToken accessToken, int? lpVersion = null, bool? needPts = null);
        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(UserAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null);
        /// <summary>
        /// Returns updates in user's private messages.
        /// </summary>
        Task<ApiRequest<MessagesGetLongPollHistoryResponse>> GetLongPollHistory(GroupAccessToken accessToken, int? ts = null, int? pts = null, int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<MessagesChat>> GetChat(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<MessagesChatFull>> GetChatFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesChat>>> GetChatChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null);
        /// <summary>
        /// Returns information about a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesChatFull>>> GetChatChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Creates a chat with several participants.
        /// </summary>
        Task<ApiRequest<int?>> CreateChat(UserAccessToken accessToken, IEnumerable<int?> userIds = null, string title = null);
        /// <summary>
        /// Edits the title of a chat.
        /// </summary>
        Task<ApiRequest<bool?>> EditChat(UserAccessToken accessToken, int? chatId = null, string title = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetChatUsers(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<IEnumerable<MessagesUserXtrInvitedBy>>> GetChatUsersFields(UserAccessToken accessToken, int? chatId = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<MessagesGetChatUsersChatIdsResponse>> GetChatUsersChatIds(UserAccessToken accessToken, int? chatId = null, IEnumerable<int?> chatIds = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// </summary>
        Task<ApiRequest<MessagesGetChatUsersChatIdsFieldsResponse>> GetChatUsersChatIdsFields(UserAccessToken accessToken, int? chatId = null, string nameCase = null);
        /// <summary>
        /// Changes the status of a user as typing in a conversation.
        /// </summary>
        Task<ApiRequest<bool?>> SetActivity(UserAccessToken accessToken, string userId = null, string type = null, int? peerId = null);
        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> SearchDialogs(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> SearchDialogs(GroupAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Adds a new user to a chat.
        /// </summary>
        Task<ApiRequest<bool?>> AddChatUser(UserAccessToken accessToken, int? chatId = null, int? userId = null);
        /// <summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveChatUser(UserAccessToken accessToken, int? chatId = null, string userId = null);
        /// <summary>
        /// Returns a user's current status and date of last activity.
        /// </summary>
        Task<ApiRequest<MessagesLastActivity>> GetLastActivity(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        /// </summary>
        Task<ApiRequest<MessagesSetChatPhotoResponse>> SetChatPhoto(UserAccessToken accessToken, string file = null);
        /// <summary>
        /// Deletes a chat's cover picture.
        /// </summary>
        Task<ApiRequest<MessagesDeleteChatPhotoResponse>> DeleteChatPhoto(UserAccessToken accessToken, int? chatId = null);
        /// <summary>
        /// Denies sending message from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DenyMessagesFromGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Allows sending messages from community to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> AllowMessagesFromGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// </summary>
        Task<ApiRequest<MessagesIsMessagesFromGroupAllowedResponse>> IsMessagesFromGroupAllowed(GroupAccessToken accessToken, int? groupId = null, int? userId = null);
    }

    public interface INewsfeedApi
    {
        /// <summary>
        /// Returns data required to show newsfeed for the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetResponse>> Get(UserAccessToken accessToken, IEnumerable<string> filters = null, bool? returnBanned = null, DateTime? startTime = null, DateTime? endTime = null, int? maxPhotos = null, IEnumerable<string> sourceIds = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// , Returns a list of newsfeeds recommended to the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommended(UserAccessToken accessToken, DateTime? startTime = null, DateTime? endTime = null, int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? count = null, IEnumerable<string> filters = null, string reposts = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.
        /// </summary>
        Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentions(UserAccessToken accessToken, int? ownerId = null, DateTime? startTime = null, DateTime? endTime = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedResponse>> GetBanned(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedExtended(UserAccessToken accessToken, bool? extended = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> AddBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null);
        /// <summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null);
        /// <summary>
        /// Hides an item from the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> IgnoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns a hidden item to the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> UnignoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsResponse>> GetLists(UserAccessToken accessToken, IEnumerable<int?> listIds = null);
        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsExtended(UserAccessToken accessToken, IEnumerable<int?> listIds = null, bool? extended = null);
        /// <summary>
        /// Creates and edits user newsfeed lists
        /// </summary>
        Task<ApiRequest<int?>> SaveList(UserAccessToken accessToken, int? listId = null, string title = null, IEnumerable<int?> sourceIds = null, bool? noReposts = null);
        Task<ApiRequest<bool?>> DeleteList(int? listId = null);
        /// <summary>
        /// Unsubscribes the current user from specified newsfeeds.
        /// </summary>
        Task<ApiRequest<bool?>> Unsubscribe(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns communities and users that current user is suggested to follow.
        /// </summary>
        Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(UserAccessToken accessToken, int? offset = null, int? count = null, bool? shuffle = null, IEnumerable<string> fields = null);
    }

    public interface ILikesApi
    {
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesAddResponse>> Add(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string accessKey = null);
        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesDeleteResponse>> Delete(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// </summary>
        Task<ApiRequest<LikesIsLikedResponse>> IsLiked(UserAccessToken accessToken, int? userId = null, string type = null, int? ownerId = null, int? itemId = null);
    }

    public interface IPollsApi
    {
        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// </summary>
        Task<ApiRequest<PollsPoll>> GetById(UserAccessToken accessToken, int? ownerId = null, bool? isBoard = null, int? pollId = null);
        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> AddVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null);
        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null);
        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// </summary>
        Task<ApiRequest<IEnumerable<PollsVoters>>> GetVoters(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// </summary>
        Task<ApiRequest<PollsPoll>> Create(UserAccessToken accessToken, string question = null, bool? isAnonymous = null, int? ownerId = null, JsonArray addAnswers = null);
        /// <summary>
        /// Edits created polls
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, string question = null, JsonArray addAnswers = null, JsonArray editAnswers = null, JsonArray deleteAnswers = null);
    }

    public interface IDocsApi
    {
        /// <summary>
        /// Returns detailed information about user or community documents.
        /// </summary>
        Task<ApiRequest<DocsGetResponse>> Get(UserAccessToken accessToken, int? count = null, int? offset = null, int? ownerId = null);
        /// <summary>
        /// Returns information about documents by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> GetById(UserAccessToken accessToken, IEnumerable<string> docs = null);
        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        Task<ApiRequest<DocsGetUploadServerResponse>> GetUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// </summary>
        Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(GroupAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> Save(UserAccessToken accessToken, string file = null, string title = null, string tags = null);
        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// </summary>
        Task<ApiRequest<IEnumerable<DocsDoc>>> Save(GroupAccessToken accessToken, string file = null, string title = null, string tags = null);
        /// <summary>
        /// Deletes a user or community document.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? docId = null);
        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// </summary>
        Task<ApiRequest<DocsAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string accessKey = null);
        /// <summary>
        /// Returns documents types available for current user.
        /// </summary>
        Task<ApiRequest<DocsGetTypesResponse>> GetTypes(UserAccessToken accessToken, int? ownerId = null);
        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        Task<ApiRequest<DocsSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// </summary>
        Task<ApiRequest<DocsSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? count = null, int? offset = null);
        /// <summary>
        /// Edits a document.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null);
    }

    public interface IFaveApi
    {
        /// <summary>
        /// Returns a list of users whom the current user has bookmarked.
        /// </summary>
        Task<ApiRequest<FaveGetUsersResponse>> GetUsers(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of photos that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetPhotosResponse>> GetPhotos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of wall posts that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetPostsResponse>> GetPosts(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of videos that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetVideosResponse>> GetVideos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of links that the current user has bookmarked.
        /// </summary>
        Task<ApiRequest<FaveGetLinksResponse>> GetLinks(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns market items bookmarked by current user.
        /// </summary>
        Task<ApiRequest<FaveGetMarketItemsResponse>> GetMarketItems(UserAccessToken accessToken, int? count = null, bool? extended = null);
        /// <summary>
        /// Adds a profile to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Removes a profile from user faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Adds a community to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Removes a community from user faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Adds a link to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, string link = null, string text = null);
        /// <summary>
        /// Removes link from the user's faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveLink(UserAccessToken accessToken, string linkId = null);
    }

    public interface INotificationsApi
    {
        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<NotificationsGetResponse>> Get(UserAccessToken accessToken, int? count = null, string startFrom = null, IEnumerable<string> filters = null, DateTime? startTime = null, DateTime? endTime = null);
        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsViewed(UserAccessToken accessToken);
    }

    public interface IStatsApi
    {
        /// <summary>
        /// Returns statistics of a community or an application.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsPeriod>>> Get(UserAccessToken accessToken, int? groupId = null, int? appId = null, string dateFrom = null, string dateTo = null);
        Task<ApiRequest<bool?>> TrackVisitor(UserAccessToken accessToken);
        /// <summary>
        /// Returns stats for a wall post.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReach(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
    }

    public interface ISearchApi
    {
        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// </summary>
        Task<ApiRequest<IEnumerable<SearchHint>>> GetHints(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> filters = null, bool? searchGlobal = null);
    }

    public interface IAppsApi
    {
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(UserAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(ServiceAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Sends a request to another user in an app that uses VK authorization.
        /// </summary>
        Task<ApiRequest<int?>> SendRequest(UserAccessToken accessToken, int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null);
        /// <summary>
        /// Deletes all request notifications from the current app.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAppRequests(UserAccessToken accessToken);
        /// <summary>
        /// Creates friends list for requests and invites in current app.
        /// </summary>
        Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsList(UserAccessToken accessToken, int? count = null, string type = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboard(UserAccessToken accessToken, string type = null, bool? global = null);
        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(UserAccessToken accessToken, string type = null, bool? global = null, bool? extended = null);
        /// <summary>
        /// Returns user score in app
        /// </summary>
        Task<ApiRequest<int?>> GetScore(UserAccessToken accessToken, int? userId = null);
    }

    public interface IUtilsApi
    {
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(UserAccessToken accessToken, string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(GroupAccessToken accessToken, string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(ServiceAccessToken accessToken, string url = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(UserAccessToken accessToken, string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(GroupAccessToken accessToken, string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(ServiceAccessToken accessToken, string key = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(UserAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(GroupAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(ServiceAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(UserAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(GroupAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(ServiceAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(UserAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(GroupAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(ServiceAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(UserAccessToken accessToken);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(GroupAccessToken accessToken);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime();
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(ServiceAccessToken accessToken);
    }

    public interface IDatabaseApi
    {
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(UserAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(ServiceAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(UserAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(ServiceAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(UserAccessToken accessToken, IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(ServiceAccessToken accessToken, IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(UserAccessToken accessToken, IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(ServiceAccessToken accessToken, IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(UserAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(ServiceAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(UserAccessToken accessToken, IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(ServiceAccessToken accessToken, IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(UserAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(ServiceAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(UserAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(ServiceAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(UserAccessToken accessToken, int? countryId = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(int? countryId = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(ServiceAccessToken accessToken, int? countryId = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(UserAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(ServiceAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(UserAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(int? facultyId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(ServiceAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null);
    }

    public interface IGiftsApi
    {
        /// <summary>
        /// Returns a list of user gifts.
        /// </summary>
        Task<ApiRequest<GiftsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, int? count = null, int? offset = null);
    }

    public interface IAdsApi
    {
        /// <summary>
        /// Returns a list of advertising accounts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccounts(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsClient>>> GetClients(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Creates clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateClients(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> UpdateClients(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> DeleteClients(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaigns(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null);
        /// <summary>
        /// Creates advertising campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> UpdateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> DeleteCampaigns(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns number of ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAd>>> GetAds(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Returns descriptions of ad layouts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayout(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Returns ad targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargeting(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Creates ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateAds(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> UpdateAds(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> DeleteAds(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Allows to check the ad link.
        /// </summary>
        Task<ApiRequest<AdsLinkStatus>> CheckLink(UserAccessToken accessToken, int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null);
        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsStats>>> GetStatistics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);
        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);
        /// <summary>
        /// Allows to get detailed information about the ad post reach.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsPostStats>>> GetAdsPostsReach(UserAccessToken accessToken, int? accountId = null, string adsIds = null);
        /// <summary>
        /// Returns current budget of the advertising account.
        /// </summary>
        Task<ApiRequest<int?>> GetBudget(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsers(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> AddOfficeUsers(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveOfficeUsers(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// </summary>
        Task<ApiRequest<AdsTargStats>> GetTargetingStats(UserAccessToken accessToken, int? accountId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null, string linkDomain = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a list of possible ad categories.
        /// </summary>
        Task<ApiRequest<AdsGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, string lang = null);
        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// </summary>
        Task<ApiRequest<string>> GetUploadURL(UserAccessToken accessToken, int? adFormat = null);
        /// <summary>
        /// Returns URL to upload an ad video to.
        /// </summary>
        Task<ApiRequest<string>> GetVideoUploadURL();
        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        /// </summary>
        Task<ApiRequest<AdsFloodStats>> GetFloodStats(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// </summary>
        Task<ApiRequest<AdsRejectReason>> GetRejectionReason(UserAccessToken accessToken, int? accountId = null, int? adId = null);
        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        /// </summary>
        Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, string name = null, string domain = null, int? lifetime = null);
        /// <summary>
        /// Edits a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> UpdateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null);
        /// <summary>
        /// Deletes a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null);
        /// <summary>
        /// Returns a list of target groups.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroups(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? extended = null);
        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// </summary>
        Task<ApiRequest<int?>> ImportTargetContacts(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null);
    }

    public interface IMarketApi
    {
        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns items list for a community.
        /// </summary>
        Task<ApiRequest<MarketGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null, bool? extended = null);
        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<string> itemIds = null);
        /// <summary>
        /// Returns information about market items by their ids.
        /// </summary>
        Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> itemIds = null, bool? extended = null);
        /// <summary>
        /// Searches market items in a community's catalog
        /// </summary>
        Task<ApiRequest<MarketSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null);
        /// <summary>
        /// Searches market items in a community's catalog
        /// </summary>
        Task<ApiRequest<MarketSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns community's collections list.
        /// </summary>
        Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns items album's data
        /// </summary>
        Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null);
        /// <summary>
        /// Creates a new comment for an item.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Returns comments list for an item.
        /// </summary>
        Task<ApiRequest<MarketGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Deletes an item's comment
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a recently deleted comment
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Chages item comment's text
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Sends a complaint to the item's comment.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns a list of market categories.
        /// </summary>
        Task<ApiRequest<MarketGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Sends a complaint to the item.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, int? reason = null);
        /// <summary>
        /// Ads a new item to the market.
        /// </summary>
        Task<ApiRequest<MarketAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null);
        /// <summary>
        /// Edits an item.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null);
        /// <summary>
        /// Deletes an item.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Restores recently deleted item
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Changes item place in a collection.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderItems(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the collections list.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Creates new collection of items
        /// </summary>
        Task<ApiRequest<MarketAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null);
        /// <summary>
        /// Edits a collection of items
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null);
        /// <summary>
        /// Deletes a collection of items.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null);
        /// <summary>
        /// Removes an item from one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveFromAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null);
        /// <summary>
        /// Adds an item to one or multiple collections.
        /// </summary>
        Task<ApiRequest<bool?>> AddToAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null);
    }

}