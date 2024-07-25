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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Information about notifications for the current user.
    ///
    /// A notification represents a message sent to a user to inform them of relevant actions or events within their
    /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
    /// than 1,000 pending notifications some old notifications will be deleted automatically.
    /// </summary>
    public class NotificationUnreadCountDto : ApiModel
    {

        /// <summary>
        /// The number of unread notifications for the current user.
        /// </summary>
        public int? UnreadCount { get; set; }
    }
}
