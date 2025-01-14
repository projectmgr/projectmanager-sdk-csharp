/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
        /// Returns a list of users that can be added as members of a new project, as well as their available project security roles.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        Task<AstroResult<ProjectMemberDto[]>> RetrieveNewProjectMembers();

        /// <summary>
        /// Returns a list of users that are currently members of a specified project, as well as their current project security roles and available project security roles.
        /// Optionally include users who are not currently members of the project, but who are available to be added.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to the project</param>
        /// <param name="includeAllUsers">Set to true to include all users in the workspace</param>
        Task<AstroResult<ProjectMemberDto[]>> RetrieveProjectMembers(Guid projectId, bool? includeAllUsers = null);

        /// <summary>
        /// Returns the project security role in a specified project for a current project member.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference of Project</param>
        /// <param name="userId">Reference of User</param>
        Task<AstroResult<ProjectMemberDto>> RetrieveUserProjectMembership(Guid projectId, Guid userId);

        /// <summary>
        /// Creates a membership for a user in a specified project, and assigns the user the appropriate project access based on the specified project security role.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to set</param>
        Task<AstroResult<ProjectMemberDto>> CreateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body);

        /// <summary>
        /// Updates the project access for a current member of a specified project by giving the user a new project security role.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to update</param>
        Task<AstroResult<ProjectMemberDto>> UpdateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body);

        /// <summary>
        /// Removes a current project member from a specified project. This removes the user&#39;s access to that project.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        Task<AstroResult<string>> RemoveUserProjectMembership(Guid projectId, Guid userId);
    }
}
