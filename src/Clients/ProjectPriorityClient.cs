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
    /// API methods related to ProjectPriority
    /// </summary>
    public class ProjectPriorityClient : IProjectPriorityClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectPriorityClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectPriorities defined within your Workspace.
        ///
        /// A ProjectPriority is a named priority level used by your business to determine how to decide
        /// which Projects are the most important.  You can name your ProjectPriority levels anything you like
        /// and you can reorganize the order of the ProjectPriority levels at any time.
        ///
        /// Note that TaskPriority and ProjectPriority are different classes of priority levels.  Even
        /// if they may have similar names, they are different objects and must be tracked separately.
        /// </summary>
        public async Task<AstroResult<ProjectPriorityDto[]>> RetrieveProjectPriorities()
        {
            var url = $"/api/data/projects/priorities";
            return await _client.Request<ProjectPriorityDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Create a project priority
        /// </summary>
        /// <param name="body">The data to create the priority</param>
        public async Task<AstroResult<ProjectPriorityDto>> CreateProjectPriority(ProjectPriorityCreateDto body)
        {
            var url = $"/api/data/projects/priorities";
            return await _client.RequestWithBody<ProjectPriorityDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates a project priority
        /// </summary>
        /// <param name="priorityId">The id of the priority to update</param>
        /// <param name="body">The data to update</param>
        public async Task<AstroResult<ProjectPriorityDto>> UpdateProjectPriority(Guid priorityId, ProjectPriorityCreateDto body)
        {
            var url = $"/api/data/projects/priorities/{priorityId}";
            return await _client.RequestWithBody<ProjectPriorityDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Delete a project priority. They will also be removed from any projects they were assigned too.
        /// </summary>
        /// <param name="priorityId">The id of the priority to remove</param>
        public async Task<AstroResult<string>> DeleteProjectPriority(Guid priorityId)
        {
            var url = $"/api/data/projects/priorities/{priorityId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
