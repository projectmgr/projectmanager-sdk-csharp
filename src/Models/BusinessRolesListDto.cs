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
    /// Business roles for the account security UI. Each role includes a permissions object whose keys are camelCase action names (for example invitePeople) with isGranted and subscription-related fields per row.
    /// </summary>
    public class BusinessRolesListDto : ApiModel
    {

        /// <summary>
        /// All business roles in the workspace, including built-in and custom roles.
        /// </summary>
        public RoleDto[] Roles { get; set; }
    }
}
