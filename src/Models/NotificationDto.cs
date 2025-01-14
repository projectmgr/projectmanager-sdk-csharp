/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A notification represents a message sent to a user to inform them of relevant actions or events within their
    /// workspace. Notifications are ephemeral and may be deleted when they are no longer needed.  When a user has more
    /// than 1,000 pending notifications some old notifications will be deleted automatically.
    /// </summary>
    public class NotificationDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this notification
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique identifier of the sender of this notification
        /// </summary>
        public Guid? SenderId { get; set; }

        /// <summary>
        /// If you received multiple notifications from the same user in a short period of time, they will be
        /// grouped together.  For example, if you receive multiple notifications about users joining the same
        /// project, they will be grouped together in the Children element.
        /// </summary>
        public NotificationDto[] Children { get; set; }

        /// <summary>
        /// A friendly category or type for this notification
        /// </summary>
        public string NotificationType { get; set; }

        /// <summary>
        /// Timestamp when the notification was sent
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// User readable subject line for the notification
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// User readable message content for the notification
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Timestamp when the notification was acknowledged as read
        /// </summary>
        public DateTime? ReadDate { get; set; }

        /// <summary>
        /// A string containing JSON-encoded extra data for the notification
        /// </summary>
        public NotificationDataDto Data { get; set; }
    }
}
