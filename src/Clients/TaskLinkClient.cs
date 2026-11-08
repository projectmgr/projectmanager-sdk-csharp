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
    /// API methods related to TaskLink
    /// </summary>
    public class TaskLinkClient : ITaskLinkClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskLinkClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates a new link (dependency) from this Task to another Task in the same Project.
        ///
        /// A Task Link connects a predecessor Task to a successor Task, indicating a scheduling
        /// dependency between them. The link type controls how the two Tasks&#39; dates relate to
        /// each other, and lag adds (or, if negative, removes) time between them.
        ///
        /// Valid LinkType values (case-insensitive): finishToStart, startToStart, finishToFinish, startToFinish.
        /// Omitting LinkType defaults to finishToStart.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="body">The Task to link to, along with the link type and lag</param>
        public async Task<AstroResult<ChangeSetStatusDto>> CreateTaskLink(Guid taskId, TaskLinkCreateDto body)
        {
            var url = $"/api/data/tasks/{taskId}/links-to";
            return await _client.RequestWithBody<ChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates the link type and/or lag of an existing link between this Task and another Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="successorTaskId">The unique identifier of the successor Task for this link</param>
        /// <param name="body">The new link type and lag for this link</param>
        public async Task<AstroResult<ChangeSetStatusDto>> UpdateTaskLink(Guid taskId, Guid successorTaskId, TaskLinkUpdateDto body)
        {
            var url = $"/api/data/tasks/{taskId}/links-to/{successorTaskId}";
            return await _client.RequestWithBody<ChangeSetStatusDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes an existing link between this Task and another Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="successorTaskId">The unique identifier of the successor Task for this link</param>
        public async Task<AstroResult<ChangeSetStatusDto>> DeleteTaskLink(Guid taskId, Guid successorTaskId)
        {
            var url = $"/api/data/tasks/{taskId}/links-to/{successorTaskId}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Retrieve the existing links from this Task to other Tasks.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task</param>
        public async Task<AstroResult<TaskLinkDto[]>> RetrieveTaskLinks(Guid taskId)
        {
            var url = $"/api/data/tasks/{taskId}/links";
            return await _client.Request<TaskLinkDto[]>(HttpMethod.Get, url, null);
        }
    }
}
