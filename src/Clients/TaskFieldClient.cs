/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
    /// API methods related to TaskField
    /// </summary>
    public class TaskFieldClient : ITaskFieldClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskFieldClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all TaskFields defined for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve TaskFields</param>
        public async Task<AstroResult<TaskFieldDto[]>> RetrieveTaskFields(Guid projectId)
        {
            var url = $"/api/data/projects/{projectId}/tasks/fields";
            return await _client.Request<TaskFieldDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new TaskField for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project within which to create this TaskField</param>
        /// <param name="body">Information about the TaskField to create</param>
        public async Task<AstroResult<ChangeSetStatusDto>> CreateTaskField(Guid projectId, CreateTaskFieldDto body)
        {
            var url = $"/api/data/projects/{projectId}/tasks/fields";
            return await _client.RequestWithBody<ChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Retrieve a list of TaskFields that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside a Project.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<TaskFieldDto[]>> QueryTaskFields(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/projects/tasks/fields";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<TaskFieldDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Deletes a TaskField for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this TaskField</param>
        /// <param name="fieldId">The unique identifier of the TaskField to delete</param>
        public async Task<AstroResult<string>> DeleteTaskField(Guid projectId, Guid fieldId)
        {
            var url = $"/api/data/projects/{projectId}/tasks/fields/{fieldId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Retrieves all TaskField values for a particular Task.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we want TaskField values</param>
        public async Task<AstroResult<TaskFieldValueDto[]>> RetrieveAllTaskFieldValues(Guid taskId)
        {
            var url = $"/api/data/tasks/{taskId}/fields/values";
            return await _client.Request<TaskFieldValueDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Retrieve a list of TaskFieldValues that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<TaskFieldValueDto[]>> QueryTaskFieldValues(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/tasks/fields/values";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<TaskFieldValueDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Retrieves the current TaskField value for a particular Task and TaskField.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task of the value to retrieve</param>
        /// <param name="fieldId">The unique identifier of the TaskField of the value to retrieve</param>
        public async Task<AstroResult<TaskFieldValueDto>> RetrieveTaskFieldValue(Guid taskId, Guid fieldId)
        {
            var url = $"/api/data/tasks/{taskId}/fields/{fieldId}/values";
            return await _client.Request<TaskFieldValueDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Replaces the current value of a TaskField for a specific Task within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose value you wish to update</param>
        /// <param name="fieldId">The unique identifier of the TaskField whose value you wish to update</param>
        /// <param name="body">The new value for this TaskField for this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> UpdateTaskFieldValue(Guid taskId, Guid fieldId, UpdateTaskFieldValueDto body)
        {
            var url = $"/api/data/tasks/{taskId}/fields/{fieldId}/values";
            return await _client.RequestWithBody<ChangeSetStatusDto>(HttpMethod.Put, url, null, body);
        }
    }
}
