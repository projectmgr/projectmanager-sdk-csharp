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
    /// API methods related to TaskTag
    /// </summary>
    public class TaskTagClient : ITaskTagClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskTagClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Replaces the existing TaskTags on a Task with a newly provided list of TaskTags.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you classify your Tasks and prioritize work.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will replace TaskTags</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">The replacement list of TaskTags for this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> ReplaceTaskTags(Guid taskId, NameDto[] body, string xintegrationname = null)
        {
            var url = $"/api/data/tasks/{taskId}/tags";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Add one or more new TaskTags to a Task.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you classify your Tasks and prioritize work.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will add TaskTags</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">The new TaskTags to add to this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> AddTaskTagtoTask(Guid taskId, NameDto[] body, string xintegrationname = null)
        {
            var url = $"/api/data/tasks/{taskId}/tags";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Removes one or more existing TaskTags from a Task.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you classify your Tasks and prioritize work.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will remove existing TaskTags</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">The TaskTags to remove from this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> RemoveTaskTagfromTask(Guid taskId, NameDto[] body, string xintegrationname = null)
        {
            var url = $"/api/data/tasks/{taskId}/tags";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null, body, null);
        }
    }
}
