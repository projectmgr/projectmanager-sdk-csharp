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
    /// A UserRole is a name for a privilege level granted to a specific User.  The &#39;Global Admin&#39;
    /// UserRole is granted to the owner of the Workspace, and this UserRole cannot be changed.
    /// You can choose which UserRole applies to a User within your Workspace.
    /// </summary>
    public class UserRoleDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this UserRole.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The friendly name of this UserRole.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this UserRole.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Set to true if this is the default Admin role
        /// </summary>
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Set to true if this is a custom role (Only supported on Enterprise Plan)
        /// </summary>
        public bool? IsCustom { get; set; }

        /// <summary>
        /// Set to true if this is the default Global Admin role
        /// </summary>
        public bool? IsGlobalAdmin { get; set; }

        /// <summary>
        /// Set to true if this is the Guest role
        /// </summary>
        public bool? IsGuest { get; set; }

        /// <summary>
        /// This is the role that will be assigned to new users by default.
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Returns the permission setup associated with this UserRole
        /// </summary>
        public UserRolePermissionsDto Permissions { get; set; }
    }
}
