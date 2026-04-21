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
    /// Workspace business role returned by the data API security endpoints (list/update responses and create response).
    /// </summary>
    public class RoleDto : ApiModel
    {

        /// <summary>
        /// Unique identifier of the business user role (`BusinessUserRoleId`).
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Display name of the role (e.g. Member, Manager, or a custom role name).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional description; for system roles may match a well-known description token used server-side.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True when this row is the non-editable global administrator role for the workspace.
        /// </summary>
        public bool? IsGlobalAdmin { get; set; }

        /// <summary>
        /// True when this role has account administrator privileges (non-guest elevated role).
        /// </summary>
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// True for user-defined roles; false for built-in system roles.
        /// </summary>
        public bool? IsCustom { get; set; }

        /// <summary>
        /// True when this role represents the default team member role for the workspace.
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// True when this role is the guest (client) role with restricted permissions.
        /// </summary>
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Workspace security matrix. Keys are camelCase action names (for example invitePeople). Each entry includes isGranted and, when the action is subscription-gated, optional featureId and featureName.
        /// </summary>
        public object Permissions { get; set; }
    }
}
