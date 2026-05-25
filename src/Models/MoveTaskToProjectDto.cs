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
    /// Move task to project data transfer object. Contains information about target project to move, necessary options and users to add access for if needed.
    /// </summary>
    public class MoveTaskToProjectDto : ApiModel
    {

        /// <summary>
        /// Target project id to move
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Move time entries associated with the task. If false, time entries will be copied to the new project but remain in the original project as well. If true, time entries will be moved to the new project and removed from the original project.
        /// </summary>
        public bool? KeepTimeEntries { get; set; }

        /// <summary>
        /// List of user IDs to add access for in the new project.
        /// </summary>
        public Guid[] AddAccessUserIds { get; set; }
    }
}
