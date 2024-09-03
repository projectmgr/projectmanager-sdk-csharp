/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Notification
    /// </summary>
    public class NotificationClient : INotificationClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NotificationClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve the most recent notifications for the current user, along with the amount of notifications.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        ///
        /// This API retrieves 500 notifications at a time.  To fetch more than 500 notifications, repeat this API call
        /// using the parameter `lastId` of the oldest notification from each batch to fetch the next 500 notifications.
        /// </summary>
        /// <param name="lastId">To continue loading more notifications in a series of requests, provide the ID of the oldest notification from the currently loaded batch as the `lastId` parameter</param>
        public async Task<AstroResult<NotificationResponseDto>> RetrieveNotifications(Guid? lastId = null)
        {
            var url = $"/api/data/notifications";
            var options = new Dictionary<string, object>();
            if (lastId != null) { options["lastId"] = lastId; }
            return await _client.Request<NotificationResponseDto>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Retrieve the total count of pending notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        public async Task<AstroResult<NotificationTotalCountDto>> NotificationCount()
        {
            var url = $"/api/data/notifications/count";
            return await _client.Request<NotificationTotalCountDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Retrieve the count of unread notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        public async Task<AstroResult<NotificationUnreadCountDto>> UnreadNotificationCount()
        {
            var url = $"/api/data/notifications/unreadcount";
            return await _client.Request<NotificationUnreadCountDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Delete all pending notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        public async Task<AstroResult<string>> DeleteAllNotifications()
        {
            var url = $"/api/data/notifications/deleteall";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Marks a pending notification as read.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id"></param>
        public async Task<AstroResult<NotificationTimestampDto>> MarkNotificationRead(Guid id)
        {
            var url = $"/api/data/notifications/{id}/markread";
            return await _client.Request<NotificationTimestampDto>(HttpMethod.Post, url, null);
        }

        /// <summary>
        /// Marks all pending notification for the current user as read.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        public async Task<AstroResult<NotificationTimestampDto>> ReadAllNotifications()
        {
            var url = $"/api/data/notifications/markallread";
            return await _client.Request<NotificationTimestampDto>(HttpMethod.Post, url, null);
        }

        /// <summary>
        /// Deletes a pending notification that is no longer wanted.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id"></param>
        public async Task<AstroResult<string>> DeleteNotification(Guid id)
        {
            var url = $"/api/data/notifications/delete/{id}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Marks a pending notification as unread.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id"></param>
        public async Task<AstroResult<string>> MarkNotificationUnread(Guid id)
        {
            var url = $"/api/data/notifications/{id}/markunread";
            return await _client.Request<string>(HttpMethod.Post, url, null);
        }
    }
}
