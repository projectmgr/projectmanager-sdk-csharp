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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ProjectMembers
    /// </summary>
    public interface IProjectMembersClient
    {

        /// <summary>
        /// Returns a list of membership options for existing members. Optionally include users who are not a member yet.
        ///
        /// </summary>
        /// <param name="projectId">Reference to the project</param>
        /// <param name="includeAllUsers">Set to true to include all users in the workspace</param>
        Task<AstroResult<ProjectMemberDto[]>> RetrieveProjectMembers(Guid projectId, bool? includeAllUsers = null);

        /// <summary>
        /// Return the membership of a project for a user.
        ///
        /// </summary>
        /// <param name="projectId">Reference of Project</param>
        /// <param name="userId">Reference of User</param>
        Task<AstroResult<ProjectMemberDto>> RetrieveUserProjectMemberShip(Guid projectId, Guid userId);

        /// <summary>
        /// Creates a membership for a user in a project and assigns the user appropriate permissions
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to set</param>
        Task<AstroResult<ProjectMemberDto>> CreateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body);

        /// <summary>
        /// Update existing Project Access Control for user for project
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to update</param>
        Task<AstroResult<ProjectMemberDto>> UpdateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body);

        /// <summary>
        /// Deletes Project Member
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        Task<AstroResult<string>> RemoveUserProjectMembership(Guid projectId, Guid userId);
    }
}
