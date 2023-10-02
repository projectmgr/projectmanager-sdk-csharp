/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Specifies the permissions a member can be changed to on a project.
    /// This objects values can change based on the logged in user and the role they have.
    /// </summary>
    public class PermissionOptionsDto : ApiModel
    {

        /// <summary>
        /// If true, the users access can be removed
        /// </summary>
        public bool? None { get; set; }

        /// <summary>
        /// If true the user can be changed to collaborator
        /// </summary>
        public bool? Collaborate { get; set; }

        /// <summary>
        /// If true a user can be set as guest, a guest can only be Guest or None
        /// </summary>
        public bool? Guest { get; set; }

        /// <summary>
        /// If true the user can be changed to editor
        /// </summary>
        public bool? Editor { get; set; }

        /// <summary>
        /// If true the user can be changed to Manager
        /// </summary>
        public bool? Manager { get; set; }
    }
}
