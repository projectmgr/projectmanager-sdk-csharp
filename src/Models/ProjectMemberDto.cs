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
    public class ProjectMemberDto
    {

        /// <summary>
        /// The unique identifier of the user of this ProjectMember.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// The name of this membertype
        /// </summary>
        public string MemberType { get; set; }
    }
}
