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
    /// Request to grant project access to all active people on a business team.
    /// </summary>
    public class AddProjectTeamMembersRequestDto : ApiModel
    {

        /// <summary>
        /// When true, new teammates receive editor-level access (subject to workspace role rules).
        /// When false, they receive collaborator access (again subject to role rules, e.g. guests).
        /// </summary>
        public bool? AddAsEditor { get; set; }
    }
}
