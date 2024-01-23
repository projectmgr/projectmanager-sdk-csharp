/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
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
    /// API methods related to TaskAssignee
    /// </summary>
    public class TaskAssigneeClient : ITaskAssigneeClient
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
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources to a Task and designate how much of their time will be allocated to this Task.
        ///
        /// In the request body, id is the id of the Resource you would like to assign to the Task, and assignedEffort is the amount of time that Resource is expected to spend on the task. assignedEffort should be entered in minutes.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose TaskAssignees will be replaced</param>
        /// <param name="body">The new list of TaskAssignees for this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> ReplaceTaskAssignees(Guid taskId, AssigneeUpsertDto[] body)
        {
            var url = $"/api/data/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Adds or updates a TaskAssignee to a Task.  If the TaskAssignee is already assigned to the Task, update their allocation.  If the TaskAssignee is not yet assigned to the Task, assign them and set their allocation level to the correct amount.
        ///
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources to a Task and designate what proportion of their time will be allocated to this Task.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task to add or update an assignment</param>
        /// <param name="body">List of Assignee data</param>
        public async Task<AstroResult<ChangeSetStatusDto>> CreateOrUpdateTaskassignee(Guid taskId, AssigneeUpsertDto[] body)
        {
            var url = $"/api/data/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Remove one or more TaskAssignees from a Task.
        ///
        /// A TaskAssignee is an assignment of a Resource to a Task.  You can assign multiple Resources to a Task and designate what proportion of their time will be allocated to this Task.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose TaskAssignee will be removed</param>
        /// <param name="body">List of TaskAssignee records to remove</param>
        public async Task<AstroResult<ChangeSetStatusDto>> DeleteTaskAssignees(Guid taskId, IdDto[] body)
        {
            var url = $"/api/data/tasks/{taskId}/assignees";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null, body, null);
        }
    }
}
