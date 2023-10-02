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
    /// A ProjectMember is a user who can collaborate on a Project.  You can control
    /// permissions for what each ProjectMember can do and how they can interact with
    /// the Project using this model.
    /// </summary>
    public class ProjectMemberDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the user of this ProjectMember.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// the initials of the user
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The display name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The current permission of the user
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// The color for their avatar
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Specifies the permissions that you can set against the project member. This changes based on who is logged in and the role they have.
        /// </summary>
        public PermissionOptionsDto PermissionOptions { get; set; }
    }
}
