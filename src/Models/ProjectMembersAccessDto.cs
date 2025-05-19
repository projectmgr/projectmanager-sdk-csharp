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
    /// DTO to assign roles to a list of project members
    /// </summary>
    public class ProjectMembersAccessDto : ApiModel
    {

        /// <summary>
        /// List of project members and their roles
        /// </summary>
        public ProjectAccessEntryDto[] ProjectAccess { get; set; }
    }
}
