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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to Notification
    /// </summary>
    public interface INotificationClient
    {

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
        /// <param name="senderId">Filter the notifications to only those sent by the user with the specified ID</param>
        /// <param name="notificationTypes">Specifies the types of notifications to return. If not provided, all notifications will be returned.</param>
        /// <param name="asFlatList">If set to true all notifications will be returned as a flat list, otherwise they will be grouped by parent in the same manner as displayed in the UI.</param>
        Task<AstroResult<NotificationResponseDto>> RetrieveNotifications(Guid? lastId = null, Guid? senderId = null, string[] notificationTypes = null, bool? asFlatList = null);

        /// <summary>
        /// Retrieve the total count of pending notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        Task<AstroResult<NotificationTotalCountDto>> NotificationCount();

        /// <summary>
        /// Retrieve the count of unread notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        Task<AstroResult<NotificationUnreadCountDto>> UnreadNotificationCount();

        /// <summary>
        /// Delete all pending notifications for the current user.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        Task<AstroResult<string>> DeleteAllNotifications();

        /// <summary>
        /// Marks a pending notification as read.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id">The unique identifier of the notification to mark read</param>
        Task<AstroResult<NotificationTimestampDto>> MarkNotificationRead(Guid id);

        /// <summary>
        /// Marks all pending notification for the current user as read.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        Task<AstroResult<NotificationTimestampDto>> ReadAllNotifications();

        /// <summary>
        /// Deletes a pending notification that is no longer wanted.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id">The unique identifier of the notification to mark read</param>
        Task<AstroResult<string>> DeleteNotification(Guid id);

        /// <summary>
        /// Marks a pending notification as unread.
        ///
        /// A notification represents a message sent to a user to inform them of relevant actions or events within their
        /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
        /// than 1,000 pending notifications some old notifications will be deleted automatically.
        /// </summary>
        /// <param name="id">The unique identifier of the notification to mark read</param>
        Task<AstroResult<string>> MarkNotificationUnread(Guid id);
    }
}
