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
    /// API methods related to TaskStatus
    /// </summary>
    public class TaskStatusClient : ITaskStatusClient
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
        public async Task<AstroResult<TaskStatusDto[]>> RetrieveTaskStatuses(Guid projectId)
        {
            var url = $"/api/data/projects/{projectId}/tasks/statuses";
            return await _client.Request<TaskStatusDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new TaskStatus level for a specific Project within your Workspace.
        ///
        /// A TaskStatus is a named status level used by your business to determine how to measure the
        /// progress of Tasks.  You can define your own named status levels that are appropriate for
        /// your business.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for the new TaskStatus</param>
        /// <param name="body">Information about the new TaskStatus level to create within this Project</param>
        public async Task<AstroResult<TaskStatusDto>> CreateTaskStatus(Guid projectId, TaskStatusCreateDto body)
        {
            var url = $"/api/data/projects/{projectId}/tasks/statuses";
            return await _client.RequestWithBody<TaskStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates an existing TaskStatus level for a specific Project within your Workspace.
        ///
        /// A TaskStatus is a named status level used by your business to determine how to measure the
        /// progress of Tasks.  You can define your own named status levels that are appropriate for
        /// your business.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for the new TaskStatus</param>
        /// <param name="body">Information about the existing TaskStatus level to update within this Project</param>
        public async Task<AstroResult<TaskStatusDto>> UpdateTaskStatus(Guid projectId, TaskStatusUpdateDto body)
        {
            var url = $"/api/data/projects/{projectId}/tasks/statuses";
            return await _client.RequestWithBody<TaskStatusDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// The endpoint is used to delete a TaskStatus.
        ///
        /// You will not be able to delete a TaskStatus if there are tasks that have been assigned to this status level
        /// or if the TaskStatus is the default status level.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for the TaskStatus level to delete</param>
        /// <param name="taskStatusId">The Id of the TaskStatus level to be removed.</param>
        public async Task<AstroResult<string>> DeleteTaskStatus(Guid projectId, Guid taskStatusId)
        {
            var url = $"/api/data/projects/{projectId}/tasks/statuses/{taskStatusId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
