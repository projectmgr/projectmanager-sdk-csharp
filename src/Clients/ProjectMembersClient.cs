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
        /// Return the membership of a project for a user.
        ///
        /// </summary>
        /// <param name="projectId">Reference of Project to update</param>
        /// <param name="userId">Reference of User to update</param>
        public async Task<AstroResult<ProjectMemberDto>> RetrieveUserProjectMemberShip(Guid projectId, Guid userId)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Creates a membership for a user in a project and assigns the user appropriate permissions
        ///
        /// </summary>
        /// <param name="projectId">Reference of Project to update</param>
        /// <param name="userId">Reference of User to update</param>
        /// <param name="body">The permission to set</param>
        public async Task<AstroResult<ProjectMemberDto>> CreateUserProjectMemberShip(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Update existing Project Access Control for user for project
        ///
        /// </summary>
        /// <param name="projectId">Reference of Project to update</param>
        /// <param name="userId">Reference of User to update</param>
        /// <param name="body">Reference of Permission to update</param>
        public async Task<AstroResult<ProjectMemberDto>> UpdateUserProjectMemberShip(Guid projectId, Guid userId, ProjectMemberRoleDto body)
        {
            var url = $"/api/data/projects/{projectId}/members/{userId}";
            return await _client.Request<ProjectMemberDto>(HttpMethod.Put, url, null, body, null);
        }
    }
}
