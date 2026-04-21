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
    /// One property change when updating a business role (batch change-set item).
    /// </summary>
    public class RoleUpdateChangeItemDto : ApiModel
    {

        /// <summary>
        /// Field to change: name, description, or permissions.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// New value for the field; for permissions, a JSON object in the role permissions matrix shape.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Optional identifier when the change targets a nested or keyed item.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
