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
    }
}
