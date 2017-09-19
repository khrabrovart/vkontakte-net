using Citrina.Methods;

namespace Citrina
{
    /// <summary>
    /// Provides a client to work with VK API methods.
    /// </summary>
    public class CitrinaClient : ICitrinaClient
    {
        #region API Properties

        /// <summary>
        /// Gets methods to work with authentication.
        /// <para>
        /// Read more about authentication on official VK page https://vk.com/dev/access_token
        /// </para>
        /// </summary>
        public IAuthHelper AuthHelper { get; }

        /// <summary>
        /// Gets methods to work with your custom methods.
        /// <para>
        /// Read more about custom Execute methods on official VK page https://vk.com/dev/execute
        /// </para>
        /// </summary>
        public IExecuteApi Execute { get; }

        /// <summary>
        /// Gets methods to work with account API.
        /// <para>
        /// Read more about account API on official VK page https://vk.com/dev/account
        /// </para>
        /// </summary>
        public IAccountApi Account { get; }

        /// <summary>
        /// Gets methods to work with ads API.
        /// <para>
        /// Read more about ads API on official VK page https://vk.com/dev/ads
        /// </para>
        /// </summary>
        public IAdsApi Ads { get; }

        /// <summary>
        /// Gets methods to work with apps API.
        /// <para>
        /// Read more about apps API on official VK page https://vk.com/dev/apps
        /// </para>
        /// </summary>
        public IAppsApi Apps { get; }

        /// <summary>
        /// Gets methods to work with audio API.
        /// <para>
        /// Read more about audio API on official VK page https://vk.com/dev/audio
        /// </para>
        /// </summary>
        //public IAudioApi Audio { get; }

        /// <summary>
        /// Gets methods to work with auth API.
        /// <para>
        /// Read more about auth API on official VK page https://vk.com/dev/auth
        /// </para>
        /// </summary>
        public IAuthApi Auth { get; }

        /// <summary>
        /// Gets methods to work with board API.
        /// <para>
        /// Read more about board API on official VK page https://vk.com/dev/board
        /// </para>
        /// </summary>
        public IBoardApi Board { get; }

        /// <summary>
        /// Gets methods to work with database API.
        /// <para>
        /// Read more about database API on official VK page https://vk.com/dev/database
        /// </para>
        /// </summary>
        public IDatabaseApi Database { get; }

        /// <summary>
        /// Gets methods to work with docs API.
        /// <para>
        /// Read more about docs API on official VK page https://vk.com/dev/docs
        /// </para>
        /// </summary>
        public IDocsApi Docs { get; }

        /// <summary>
        /// Gets methods to work with fave API.
        /// <para>
        /// Read more about fave API on official VK page https://vk.com/dev/fave
        /// </para>
        /// </summary>
        public IFaveApi Fave { get; }

        /// <summary>
        /// Gets methods to work with friends API.
        /// <para>
        /// Read more about friends API on official VK page https://vk.com/dev/friends
        /// </para>
        /// </summary>
        public IFriendsApi Friends { get; }

        /// <summary>
        /// Gets methods to work with gifts API.
        /// <para>
        /// Read more about gifts API on official VK page https://vk.com/dev/gifts
        /// </para>
        /// </summary>
        public IGiftsApi Gifts { get; }

        /// <summary>
        /// Gets methods to work with groups API.
        /// <para>
        /// Read more about groups API on official VK page https://vk.com/dev/groups
        /// </para>
        /// </summary>
        public IGroupsApi Groups { get; }

        /// <summary>
        /// Gets methods to work with leads API.
        /// <para>
        /// Read more about leads API on official VK page https://vk.com/dev/leads
        /// </para>
        /// </summary>
        public ILeadsApi Leads { get; }

        /// <summary>
        /// Gets methods to work with likes API.
        /// <para>
        /// Read more about likes API on official VK page https://vk.com/dev/likes
        /// </para>
        /// </summary>
        public ILikesApi Likes { get; }

        /// <summary>
        /// Gets methods to work with market API.
        /// <para>
        /// Read more about market API on official VK page https://vk.com/dev/market
        /// </para>
        /// </summary>
        public IMarketApi Market { get; }

        /// <summary>
        /// Gets methods to work with messages API.
        /// <para>
        /// Read more about messages API on official VK page https://vk.com/dev/messages
        /// </para>
        /// </summary>
        public IMessagesApi Messages { get; }

        /// <summary>
        /// Gets methods to work with newsfeed API.
        /// <para>
        /// Read more about newsfeed API on official VK page https://vk.com/dev/newsfeed
        /// </para>
        /// </summary>
        public INewsfeedApi Newsfeed { get; }

        /// <summary>
        /// Gets methods to work with notes API.
        /// <para>
        /// Read more about notes API on official VK page https://vk.com/dev/notes
        /// </para>
        /// </summary>
        public INotesApi Notes { get; }

        /// <summary>
        /// Gets methods to work with notifications API.
        /// <para>
        /// Read more about notifications API on official VK page https://vk.com/dev/notifications
        /// </para>
        /// </summary>
        public INotificationsApi Notifications { get; }

        /// <summary>
        /// Gets methods to work with orders API.
        /// <para>
        /// Read more about orders API on official VK page https://vk.com/dev/orders
        /// </para>
        /// </summary>
        public IOrdersApi Orders { get; }

        /// <summary>
        /// Gets methods to work with pages API.
        /// <para>
        /// Read more about pages API on official VK page https://vk.com/dev/pages
        /// </para>
        /// </summary>
        public IPagesApi Pages { get; }

        /// <summary>
        /// Gets methods to work with photos API.
        /// <para>
        /// Read more about photos API on official VK page https://vk.com/dev/photos
        /// </para>
        /// </summary>
        public IPhotosApi Photos { get; }

        /// <summary>
        /// Gets methods to work with places API.
        /// <para>
        /// Read more about places API on official VK page https://vk.com/dev/places
        /// </para>
        /// </summary>
        public IPlacesApi Places { get; }

        /// <summary>
        /// Gets methods to work with polls API.
        /// <para>
        /// Read more about polls API on official VK page https://vk.com/dev/polls
        /// </para>
        /// </summary>
        public IPollsApi Polls { get; }

        /// <summary>
        /// Gets methods to work with search API.
        /// <para>
        /// Read more about search API on official VK page https://vk.com/dev/search
        /// </para>
        /// </summary>
        public ISearchApi Search { get; }

        /// <summary>
        /// Gets methods to work with secure API.
        /// <para>
        /// Read more about secure API on official VK page https://vk.com/dev/secure
        /// </para>
        /// </summary>
        public ISecureApi Secure { get; }

        /// <summary>
        /// Gets methods to work with stats API.
        /// <para>
        /// Read more about stats API on official VK page https://vk.com/dev/stats
        /// </para>
        /// </summary>
        public IStatsApi Stats { get; }

        /// <summary>
        /// Gets methods to work with status API.
        /// <para>
        /// Read more about status API on official VK page https://vk.com/dev/status
        /// </para>
        /// </summary>
        public IStatusApi Status { get; }

        /// <summary>
        /// Gets methods to work with storage API.
        /// <para>
        /// Read more about storage API on official VK page https://vk.com/dev/storage
        /// </para>
        /// </summary>
        public IStorageApi Storage { get; }

        /// <summary>
        /// Gets methods to work with users API.
        /// <para>
        /// Read more about users API on official VK page https://vk.com/dev/users
        /// </para>
        /// </summary>
        public IUsersApi Users { get; }

        /// <summary>
        /// Gets methods to work with utils API.
        /// <para>
        /// Read more about utils API on official VK page https://vk.com/dev/utils
        /// </para>
        /// </summary>
        public IUtilsApi Utils { get; }

        /// <summary>
        /// Gets methods to work with video API.
        /// <para>
        /// Read more about video API on official VK page https://vk.com/dev/video
        /// </para>
        /// </summary>
        public IVideoApi Video { get; }

        /// <summary>
        /// Gets methods to work with wall API.
        /// <para>
        /// Read more about wall API on official VK page https://vk.com/dev/wall
        /// </para>
        /// </summary>
        public IWallApi Wall { get; }

        /// <summary>
        /// Gets methods to work with widgets API.
        /// <para>
        /// Read more about widgets API on official VK page https://vk.com/dev/widgets
        /// </para>
        /// </summary>
        public IWidgetsApi Widgets { get; }

        #endregion

        /// <summary>
        /// Creates a client to work with VK API methods.
        /// </summary>
        public CitrinaClient()
        {
            AuthHelper = new AuthHelper();
            Execute = new ExecuteApi();

            Account = new AccountApi();
            Ads = new AdsApi();
            Apps = new AppsApi();

            //Что там с этим AudioApi
            //Audio = new AudioApi();
            Auth = new AuthApi();
            Board = new BoardApi();
            Database = new DatabaseApi();
            Docs = new DocsApi();
            Fave = new FaveApi();
            Friends = new FriendsApi();
            Gifts = new GiftsApi();
            Groups = new GroupsApi();
            Leads = new LeadsApi();
            Likes = new LikesApi();
            Market = new MarketApi();
            Messages = new MessagesApi();
            Newsfeed = new NewsfeedApi();
            Notes = new NotesApi();
            Notifications = new NotificationsApi();
            Orders = new OrdersApi();
            Pages = new PagesApi();
            Photos = new PhotosApi();
            Places = new PlacesApi();
            Polls = new PollsApi();
            Search = new SearchApi();
            Secure = new SecureApi();
            Stats = new StatsApi();
            Status = new StatusApi();
            Storage = new StorageApi();
            Users = new UsersApi();
            Utils = new UtilsApi();
            Video = new VideoApi();
            Wall = new WallApi();
            Widgets = new WidgetsApi();
        }

        /// <summary>
        /// Creates a customized client to work with VK API methods.
        /// </summary>
        public CitrinaClient(CitrinaClientOptions options) : this()
        {
            RequestSettings.Timeout = options.RequestTimeout;
        }
    }
}