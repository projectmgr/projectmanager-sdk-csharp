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
    /// API methods related to TaskAssignee
    /// </summary>
    public class TaskAssigneeClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskAssigneeClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Replace all TaskAssignees on a Task with new TaskAssignees.
        ///
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources
        /// to a Task and designate what proportion of their time will be allocated to this Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose TaskAssignees will be replaced</param>
        /// <param name="body">The new list of TaskAssignees for this Task</param>
        public async Task<AstroResult<ChangeSetStatusDtoAstroResult>> ReplaceTaskAssignees(Guid taskId, AssigneeUpsertDto[] body)
        {
            var url = $"/project-api/public/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDtoAstroResult>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Adds or updates a TaskAssignee to a Task.  If the TaskAssignee is already assigned to the Task, update
        /// their allocation.  If the TaskAssignee is not yet assigned to the Task, assign them and set their
        /// allocation level to the correct amount.
        ///
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources
        /// to a Task and designate what proportion of their time will be allocated to this Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task to add or update an assignment</param>
        /// <param name="body">List of Assignee data</param>
        public async Task<AstroResult<ChangeSetStatusDtoAstroResult>> CreateOrUpdateTaskAssignee(Guid taskId, AssigneeUpsertDto[] body)
        {
            var url = $"/project-api/public/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDtoAstroResult>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Remove one or more TaskAssignees from a Task.
        ///
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources
        /// to a Task and designate what proportion of their time will be allocated to this Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose TaskAssignee will be removed</param>
        /// <param name="body">List of TaskAssignee records to remove</param>
        public async Task<AstroResult<ChangeSetStatusDtoAstroResult>> DeleteTaskAssignees(Guid taskId, IdDto[] body)
        {
            var url = $"/project-api/public/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDtoAstroResult>(HttpMethod.Delete, url, null, body, null);
        }
    }
}