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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ProjectMembers
    /// </summary>
    public class ProjectMembersClient : IProjectMembersClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectMembersClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns a list of users that can be added as members of a new project, as well as their available project security roles.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        public async Task<AstroResult<ProjectMemberDto[]>> RetrieveNewProjectMembers()
        {
            var url = $"/api/data/projects/members";
            return await _client.Request<ProjectMemberDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Returns a list of users that are currently members of a specified project, as well as their current project security roles and available project security roles.
        /// Optionally include users who are not currently members of the project, but who can be added.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to the project</param>
        /// <param name="includeAllUsers">Set to true to include all users in the workspace</param>
        public async Task<AstroResult<ProjectMemberDto[]>> RetrieveProjectMembers(Guid projectId, bool? includeAllUsers = null)
        {
            var url = $"/api/data/projects/{projectId}/members";
            var options = new Dictionary<string, object>();
            if (includeAllUsers != null) { options["includeAllUsers"] = includeAllUsers; }
            return await _client.Request<ProjectMemberDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Updates the project access for a current member of a specified project
        /// by giving the users a new project security role.
        ///
        /// A project member is a user who has access to a specific project.
        /// Project members are assigned a project security role, which controls the level of access they have to
        /// the project.
        /// Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="body">The permission to update</param>
        public async Task<AstroResult<ProjectMemberDto>> UpdateAListOfUserProjectMembership(Guid projectId, ProjectMembersAccessDto body)
        {
            var url = $"/api/data/projects/{projectId}/members";
            return await _client.RequestWithBody<ProjectMemberDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Returns the project security role in a specified project for a current project member.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference of Project</param>
        /// <param name="userId">Reference of User</param>
        public async Task<AstroResult<ProjectMemberDto>> RetrieveUserProjectMembership(Guid projectId, Guid userId)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a membership for a user in a specified project
        /// and assigns the user the appropriate project access based on the specified project security role.
        ///
        /// A project member is a user who has access to a specific project.
        /// Project members are assigned a project security role, which controls the level of access they have to
        /// the project.
        /// Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to set</param>
        public async Task<AstroResult<ProjectMemberDto>> CreateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.RequestWithBody<ProjectMemberDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates the project access for a current member of a specified project by giving the user a new project security role.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to update</param>
        public async Task<AstroResult<ProjectMemberDto>> UpdateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.RequestWithBody<ProjectMemberDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes a current project member from a specified project. This removes the user&#39;s access to that project.
        ///
        /// A project member is a user who has access to a specific project. Project members are assigned a project security role, which controls the level of access they have to
        /// the project. Possible project security roles include manage, edit, collaborate, creator, and guest.
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        public async Task<AstroResult<string>> RemoveUserProjectMembership(Guid projectId, Guid userId)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
