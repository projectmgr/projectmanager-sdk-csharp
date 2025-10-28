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
    /// The basic permission object
    /// </summary>
    public class UserRolePermissionDto : ApiModel
    {

        /// <summary>
        /// The description of the permission
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if the permission is on
        /// </summary>
        public bool? Value { get; set; }

        /// <summary>
        /// If true this permission can be turned on or off for this role.
        /// Most roles can have all permissions modified, but some roles have all or some permissions fixed.
        /// </summary>
        public bool? CanBeModified { get; set; }
    }
}
