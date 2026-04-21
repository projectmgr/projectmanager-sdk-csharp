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
    /// Request body for POST /api/data/security/businessroles. Creates a custom workspace role; the server assigns the role id and the name must be unique in the workspace. Permission flags use the same shape as RetrieveMe `permissions` (Astro.Common.Dto.WorkSpaces.WorkSpacePermissionsDto). Subscription entitlements are applied server-side; nothing in Chargebee is updated by this request.
    /// </summary>
    public class RoleCreateDto : ApiModel
    {

        /// <summary>
        /// Display name of the new custom role; must not duplicate another role name in the workspace (case-insensitive).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional description; must not match reserved system role description tokens.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Workspace permissions for the new role. Same property names as RetrieveMe; `true`/`false` per flag. Omitted or null properties are treated as off. `ChangeOwnEmail` is not modeled here and defaults to off for new custom roles.
        /// </summary>
        public WorkSpacePermissionsDto Permissions { get; set; }
    }
}
