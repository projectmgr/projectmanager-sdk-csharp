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
    /// Contains the optional data associated with the notifcation.
    /// </summary>
    public class NotificationDataDto : ApiModel
    {

        /// <summary>
        /// Set if the notification is related to a task
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Set if the notification is related to a project
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// set if the notification is related to a task
        /// </summary>
        public string TaskShortId { get; set; }

        /// <summary>
        /// set if the notification is related to a project
        /// </summary>
        public string ProjectShortId { get; set; }

        /// <summary>
        /// Name of the project the notification is related to
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Name of the task this notification is related to
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Firstname of the person initiating the notification
        /// </summary>
        public string SenderFirstName { get; set; }

        /// <summary>
        /// Assignee for the notification
        /// </summary>
        public Guid? AssigneeId { get; set; }

        /// <summary>
        /// View
        /// </summary>
        public string View { get; set; }

        /// <summary>
        /// Id for the shared item
        /// </summary>
        public string ShareId { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        public string FileName { get; set; }
    }
}
