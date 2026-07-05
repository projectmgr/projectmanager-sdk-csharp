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
    /// Dto To Describe a ProjectMember Role
    /// </summary>
    public class ProjectMemberRoleDto : ApiModel
    {

        /// <summary>
        /// Role to apply. Optional — when omitted, a default role is applied based on the
        /// target user&#39;s workspace access: users who can edit all projects become a Manager,
        /// guest users become a Guest, and everyone else becomes an Editor. When updating an
        /// existing member, omitting the role leaves their current role unchanged.
        ///
        /// For a list of values, see `ProjectPermissionValues`.
        /// </summary>
        public string Role { get; set; }
    }
}
