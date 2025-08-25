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
    /// ProjectAccessDto
    /// </summary>
    public class ProjectAccessDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the user of this ProjectMember.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// The unique identifier of the user of this Project.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The role of the user in the project
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// If set to true, the user has joined the project.
        /// If set to false, the user may still have access due to the access all projects permission.
        /// In the UI only projects that the user has joined will be shown in the navigation on the left
        /// </summary>
        public bool? HasJoined { get; set; }
    }
}
