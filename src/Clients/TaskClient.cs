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
    /// API methods related to Task
    /// </summary>
    public class TaskClient : ITaskClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve a list of Tasks that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<TaskDto[]>> QueryTasks(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/tasks";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (select != null) { options["$select"] = select; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<TaskDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieve a Task by its unique identifier or by its short ID.  A Task has both a unique identifier, which is a GUID, and a short ID, which is a small text label that is unique only within your Workspace.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task to retrieve</param>
        public async Task<AstroResult<TaskDetailsDto>> RetrieveTask(string taskId)
        {
            var url = $"/api/data/tasks/{taskId}";
            return await _client.Request<TaskDetailsDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Update an existing Task and replace the values of fields specified.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// Multiple users can be working on data at the same time.  When you call an API to update an object, this call is converted into a Changeset that is then applied sequentially.  You can use RetrieveChangeset to see the status of an individual Changeset.
        ///
        /// Known Issues:  This API returns an error if your Update call includes too many changes in a single API call.  Please restrict usage to one change per API request.  This API will be deprecated and replaced with an improved API call in a future release.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task to update</param>
        /// <param name="body">All non-null fields in this object will replace existing data in the Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> UpdateTask(Guid taskId, TaskUpdateDto body)
        {
            var url = $"/api/data/tasks/{taskId}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Delete an existing Task.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// Multiple users can be working on data at the same time.  When you call an API to update an object, this call is converted into a Changeset that is then applied sequentially.  You can use RetrieveChangeset to see the status of an individual Changeset.
        ///
        /// </summary>
        /// <param name="taskId">Unique identifier of the Task to delete</param>
        public async Task<AstroResult<ChangeSetStatusDto>> DeleteTask(Guid taskId)
        {
            var url = $"/api/data/tasks/{taskId}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Create a new Task within a specified project.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that will contain this Task</param>
        /// <param name="body">The new Task to create</param>
        public async Task<AstroResult<ChangeSetStatusDto>> CreateTask(Guid projectId, TaskCreateDto body)
        {
            var url = $"/api/data/projects/{projectId}/tasks";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieves all TaskPriorities defined within your Workspace.
        ///
        /// A TaskPriority is a named priority level used by your business to determine how to decide which Tasks are the most important.  You can name your TaskPriority levels anything you like and you can reorganize the order of the TaskPriority levels at any time.
        ///
        /// Note that TaskPriority and ProjectPriority are different classes of priority levels.  Even if they may have similar names, they are different objects and must be tracked separately.
        ///
        /// </summary>
        public async Task<AstroResult<TaskPriorityDto[]>> RetrieveTaskPriorities()
        {
            var url = $"/api/data/tasks/priorities";
            return await _client.Request<TaskPriorityDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Create multiple new Tasks within a specified project with a single API call.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to indicate whether they have a dependency or a connection.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that will contain these Tasks</param>
        /// <param name="body">The list of new Tasks to create</param>
        public async Task<AstroResult<ChangeSetStatusDto[]>> CreateManyTasks(Guid projectId, BulkTaskCreateDto[] body)
        {
            var url = $"/api/data/projects/{projectId}/tasks/bulk";
            return await _client.Request<ChangeSetStatusDto[]>(HttpMethod.Post, url, null, body, null);
        }
    }
}
