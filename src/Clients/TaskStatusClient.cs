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
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to TaskStatus
    /// </summary>
    public class TaskStatusClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskStatusClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the list of TaskStatus levels for a specific Project within your Workspace.
        ///
        /// A TaskStatus is a named status level used by your business to determine how to measure the
        /// progress of Tasks.  You can define your own named status levels that are appropriate for
        /// your business and determine which status levels are considered done.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve TaskStatuses</param>
        public async Task<AstroResult<TaskStatusDtoListAstroResult>> RetrieveTaskStatuses(Guid projectId)
        {
            var url = $"/project-api/public/projects/{projectId}/tasks/statuses";
            return await _client.Request<TaskStatusDtoListAstroResult>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Creates a new TaskStatus level for a specific Project within your Workspace.
        ///
        /// A TaskStatus is a named status level used by your business to determine how to measure the
        /// progress of Tasks.  You can define your own named status levels that are appropriate for
        /// your business and determine which status levels are considered done.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for the new TaskStatus</param>
        /// <param name="body">Information about the new TaskStatus level to create within this Project</param>
        public async Task<AstroResult<TaskStatusDtoAstroResult>> CreateTaskStatus(Guid projectId, TaskStatusCreateDto body)
        {
            var url = $"/project-api/public/projects/{projectId}/tasks/statuses";
            return await _client.Request<TaskStatusDtoAstroResult>(HttpMethod.Post, url, null, body, null);
        }
    }
}
