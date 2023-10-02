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
        /// Returns a list of membership options for existing members. Optionally include users who are not a member yet.
        ///
        /// </summary>
        /// <param name="projectId">Reference to the project</param>
        /// <param name="includeAllUsers">Set to true to include all users in the workspace</param>
        public async Task<AstroResult<ProjectMemberDto[]>> RetrieveProjectMembers(Guid projectId, bool? includeAllUsers = null)
        {
            var url = $"/api/data/projects/{projectId}/members";
            var options = new Dictionary<string, object>();
            if (includeAllUsers != null) { options["includeAllUsers"] = includeAllUsers; }
            return await _client.Request<ProjectMemberDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Return the membership of a project for a user.
        ///
        /// </summary>
        /// <param name="projectId">Reference of Project</param>
        /// <param name="userId">Reference of User</param>
        public async Task<AstroResult<ProjectMemberDto>> RetrieveUserProjectMemberShip(Guid projectId, Guid userId)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Creates a membership for a user in a project and assigns the user appropriate permissions
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to set</param>
        public async Task<AstroResult<ProjectMemberDto>> CreateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Update existing Project Access Control for user for project
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        /// <param name="body">The permission to update</param>
        public async Task<AstroResult<ProjectMemberDto>> UpdateUserProjectMembership(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Deletes Project Member
        ///
        /// </summary>
        /// <param name="projectId">Reference to Project</param>
        /// <param name="userId">Reference to User</param>
        public async Task<AstroResult<string>> RemoveUserProjectMembership(Guid projectId, Guid userId)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
