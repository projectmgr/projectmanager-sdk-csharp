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
    /// Represents the access permissions assigned to a single user within a project.
    /// </summary>
    public class ProjectAccessEntryDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the user to whom the access permissions apply.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Indicates whether the user has permission to edit the project.
        /// </summary>
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Indicates whether the user has permission to manage the project (e.g., assign roles, change settings).
        /// </summary>
        public bool? CanManage { get; set; }
    }
}
