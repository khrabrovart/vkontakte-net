namespace Citrina
{
    /// <summary>
    /// Provides a client to work with VK API methods.
    /// </summary>
    public interface ICitrinaClient
    {
        /// <summary>
        /// Gets methods to work with authentication.
        /// <para>
        /// Read more about authentication on official VK page https://vk.com/dev/access_token
        /// </para>
        /// </summary>
        IAuthHelper AuthHelper { get; }

        /// <summary>
        /// Gets methods to work with your custom methods.
        /// <para>
        /// Read more about custom Execute methods on official VK page https://vk.com/dev/execute
        /// </para>
        /// </summary>
        IExecuteApi Execute { get; }

        /// <summary>
        /// Gets methods to work with account API.
        /// <para>
        /// Read more about account API on official VK page https://vk.com/dev/account
        /// </para>
        /// </summary>
        IAccountApi Account { get; }

        /// <summary>
        /// Gets methods to work with ads API.
        /// <para>
        /// Read more about ads API on official VK page https://vk.com/dev/ads
        /// </para>
        /// </summary>
        IAdsApi Ads { get; }

        /// <summary>
        /// Gets methods to work with apps API.
        /// <para>
        /// Read more about apps API on official VK page https://vk.com/dev/apps
        /// </para>
        /// </summary>
        IAppsApi Apps { get; }

        /// <summary>
        /// Gets methods to work with auth API.
        /// <para>
        /// Read more about auth API on official VK page https://vk.com/dev/auth
        /// </para>
        /// </summary>
        IAuthApi Auth { get; }

        /// <summary>
        /// Gets methods to work with board API.
        /// <para>
        /// Read more about board API on official VK page https://vk.com/dev/board
        /// </para>
        /// </summary>
        IBoardApi Board { get; }

        /// <summary>
        /// Gets methods to work with database API.
        /// <para>
        /// Read more about database API on official VK page https://vk.com/dev/database
        /// </para>
        /// </summary>
        IDatabaseApi Database { get; }

        /// <summary>
        /// Gets methods to work with docs API.
        /// <para>
        /// Read more about docs API on official VK page https://vk.com/dev/docs
        /// </para>
        /// </summary>
        IDocsApi Docs { get; }

        /// <summary>
        /// Gets methods to work with fave API.
        /// <para>
        /// Read more about fave API on official VK page https://vk.com/dev/fave
        /// </para>
        /// </summary>
        IFaveApi Fave { get; }

        /// <summary>
        /// Gets methods to work with friends API.
        /// <para>
        /// Read more about friends API on official VK page https://vk.com/dev/friends
        /// </para>
        /// </summary>
        IFriendsApi Friends { get; }

        /// <summary>
        /// Gets methods to work with gifts API.
        /// <para>
        /// Read more about gifts API on official VK page https://vk.com/dev/gifts
        /// </para>
        /// </summary>
        IGiftsApi Gifts { get; }

        /// <summary>
        /// Gets methods to work with groups API.
        /// <para>
        /// Read more about groups API on official VK page https://vk.com/dev/groups
        /// </para>
        /// </summary>
        IGroupsApi Groups { get; }

        /// <summary>
        /// Gets methods to work with leads API.
        /// <para>
        /// Read more about leads API on official VK page https://vk.com/dev/leads
        /// </para>
        /// </summary>
        ILeadsApi Leads { get; }

        /// <summary>
        /// Gets methods to work with likes API.
        /// <para>
        /// Read more about likes API on official VK page https://vk.com/dev/likes
        /// </para>
        /// </summary>
        ILikesApi Likes { get; }

        /// <summary>
        /// Gets methods to work with market API.
        /// <para>
        /// Read more about market API on official VK page https://vk.com/dev/market
        /// </para>
        /// </summary>
        IMarketApi Market { get; }

        /// <summary>
        /// Gets methods to work with messages API.
        /// <para>
        /// Read more about messages API on official VK page https://vk.com/dev/messages
        /// </para>
        /// </summary>
        IMessagesApi Messages { get; }

        /// <summary>
        /// Gets methods to work with newsfeed API.
        /// <para>
        /// Read more about newsfeed API on official VK page https://vk.com/dev/newsfeed
        /// </para>
        /// </summary>
        INewsfeedApi Newsfeed { get; }

        /// <summary>
        /// Gets methods to work with notes API.
        /// <para>
        /// Read more about notes API on official VK page https://vk.com/dev/notes
        /// </para>
        /// </summary>
        INotesApi Notes { get; }

        /// <summary>
        /// Gets methods to work with notifications API.
        /// <para>
        /// Read more about notifications API on official VK page https://vk.com/dev/notifications
        /// </para>
        /// </summary>
        INotificationsApi Notifications { get; }

        /// <summary>
        /// Gets methods to work with orders API.
        /// <para>
        /// Read more about orders API on official VK page https://vk.com/dev/orders
        /// </para>
        /// </summary>
        IOrdersApi Orders { get; }

        /// <summary>
        /// Gets methods to work with pages API.
        /// <para>
        /// Read more about pages API on official VK page https://vk.com/dev/pages
        /// </para>
        /// </summary>
        IPagesApi Pages { get; }

        /// <summary>
        /// Gets methods to work with photos API.
        /// <para>
        /// Read more about photos API on official VK page https://vk.com/dev/photos
        /// </para>
        /// </summary>
        IPhotosApi Photos { get; }

        /// <summary>
        /// Gets methods to work with places API.
        /// <para>
        /// Read more about places API on official VK page https://vk.com/dev/places
        /// </para>
        /// </summary>
        IPlacesApi Places { get; }

        /// <summary>
        /// Gets methods to work with polls API.
        /// <para>
        /// Read more about polls API on official VK page https://vk.com/dev/polls
        /// </para>
        /// </summary>
        IPollsApi Polls { get; }

        /// <summary>
        /// Gets methods to work with search API.
        /// <para>
        /// Read more about search API on official VK page https://vk.com/dev/search
        /// </para>
        /// </summary>
        ISearchApi Search { get; }

        /// <summary>
        /// Gets methods to work with secure API.
        /// <para>
        /// Read more about secure API on official VK page https://vk.com/dev/secure
        /// </para>
        /// </summary>
        ISecureApi Secure { get; }

        /// <summary>
        /// Gets methods to work with stats API.
        /// <para>
        /// Read more about stats API on official VK page https://vk.com/dev/stats
        /// </para>
        /// </summary>
        IStatsApi Stats { get; }

        /// <summary>
        /// Gets methods to work with status API.
        /// <para>
        /// Read more about status API on official VK page https://vk.com/dev/status
        /// </para>
        /// </summary>
        IStatusApi Status { get; }

        /// <summary>
        /// Gets methods to work with storage API.
        /// <para>
        /// Read more about storage API on official VK page https://vk.com/dev/storage
        /// </para>
        /// </summary>
        IStorageApi Storage { get; }

        /// <summary>
        /// Gets methods to work with users API.
        /// <para>
        /// Read more about users API on official VK page https://vk.com/dev/users
        /// </para>
        /// </summary>
        IUsersApi Users { get; }

        /// <summary>
        /// Gets methods to work with utils API.
        /// <para>
        /// Read more about utils API on official VK page https://vk.com/dev/utils
        /// </para>
        /// </summary>
        IUtilsApi Utils { get; }

        /// <summary>
        /// Gets methods to work with video API.
        /// <para>
        /// Read more about video API on official VK page https://vk.com/dev/video
        /// </para>
        /// </summary>
        IVideoApi Video { get; }

        /// <summary>
        /// Gets methods to work with wall API.
        /// <para>
        /// Read more about wall API on official VK page https://vk.com/dev/wall
        /// </para>
        /// </summary>
        IWallApi Wall { get; }

        /// <summary>
        /// Gets methods to work with widgets API.
        /// <para>
        /// Read more about widgets API on official VK page https://vk.com/dev/widgets
        /// </para>
        /// </summary>
        IWidgetsApi Widgets { get; }
    }
}