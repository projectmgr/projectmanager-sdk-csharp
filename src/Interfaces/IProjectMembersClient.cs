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
        /// Returns a list of projects where the currently authenticated user is a member.
        ///
        /// The information returned by this API indicates the project&#39;s ID and the current user&#39;s role.
        /// </summary>
        Task<AstroResult<ProjectAccessDto[]>> RetrieveProjectsByUser();

        /// <summary>
        /// Returns a list of users that are currently members of a specified project, as well as their current project security roles and available project security roles.
        /// Optionally include users who are not currently members of the project, but who can be added.
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
        /// Creates or updates (upserts) a user&#39;s membership in a specified project. If the user is not yet a member they
        /// are added; if they are already a member their project security role is replaced.
        ///
        /// The role is optional. When the role is omitted for a new member, a default role is applied based on the user&#39;s
        /// workspace access: users who can edit all projects become a Manager, guest users become a Guest, and everyone
        /// else becomes an Editor. When the role is omitted for a user who is already a member, their current role is left
        /// unchanged.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to set. The role is optional.</param>
        Task<AstroResult<ProjectMemberDto>> CreateOrUpdateProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body);

        /// <summary>
        /// Removes a current project member from a specified project. This removes the user&#39;s access to that project.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        Task<AstroResult<string>> RemoveUserProjectMembership(Guid projectId, Guid userId);

        /// <summary>
        /// Adds all active people on a business team to a project.
        ///
        /// Resolves the team to its member resources, grants project access to each user who is not already a member,
        /// and leaves existing members unchanged. Access levels follow the same rules as creating or updating
        /// individual project membership (workspace role constraints, guest vs licensed user, global admin, etc.).
        ///
        /// A project member is a user who has access to a specific project.
        /// Project members are assigned a project security role, which controls the level of access they have to
        /// the project.
        /// Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to the project receiving access.</param>
        /// <param name="teamId">Business team identifier (`BusinessTeamId`); all active team members with a user account are considered.</param>
        /// <param name="body">Optional flags for default access (e.g. editor vs collaborator) for newly added members.</param>
        Task<AstroResult<ProjectMemberDto>> AddTeamToProject(Guid projectId, Guid teamId, AddProjectTeamMembersRequestDto body);
    }
}
