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
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve TaskFields</param>
        public async Task<AstroResult<GetTaskFieldsResponseDto[]>> RetrieveTaskFields(Guid projectId)
        {
            var url = $"/project-api/public/projects/{projectId}/tasks/fields";
            return await _client.Request<GetTaskFieldsResponseDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Creates a new TaskFields for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project within which to create this TaskField</param>
        /// <param name="body">Information about the TaskField to create</param>
        public async Task<AstroResult<ChangeSetStatusDto>> CreateTaskField(Guid projectId, CreateTaskFieldRequestDto body)
        {
            var url = $"/project-api/public/projects/{projectId}/tasks/fields";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Deletes a TaskField for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this TaskField</param>
        /// <param name="fieldId">The unique identifier of the TaskField to delete</param>
        public async Task<AstroResult<string>> DeleteTaskField(Guid projectId, Guid fieldId)
        {
            var url = $"/project-api/public/projects/{projectId}/tasks/fields/{fieldId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Retrieves the current TaskField value for a particular Task and TaskField.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task of the value to retrieve</param>
        /// <param name="fieldId">The unique identifier of the TaskField of the value to retrieve</param>
        public async Task<AstroResult<TaskFieldsValueResponseDto>> RetrieveTaskFieldValue(Guid taskId, Guid fieldId)
        {
            var url = $"/project-api/public/tasks/{taskId}/fields/{fieldId}";
            return await _client.Request<TaskFieldsValueResponseDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Replaces the current value of a TaskFields for a specific Task within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose value you wish to update</param>
        /// <param name="fieldId">The unique identifier of the TaskField whose value you wish to update</param>
        /// <param name="body">The new value for this TaskField for this Task</param>
        public async Task<AstroResult<ChangeSetStatusDto>> UpdateTaskFieldValue(Guid taskId, Guid fieldId, UpdateTaskFieldValueDto body)
        {
            var url = $"/project-api/public/tasks/{taskId}/fields/{fieldId}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Retrieves all TaskField values for a particular Task.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can define TaskFields for any integration purpose that is important to your business.  Each TaskField has a data type as well as options in how it is handled.  TaskFields can be edited for each Task inside this Project.
        ///
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we want TaskField values</param>
        public async Task<AstroResult<TaskFieldsValueResponseDto[]>> RetrieveAllTaskFieldValues(Guid taskId)
        {
            var url = $"/project-api/public/tasks/{taskId}/fields";
            return await _client.Request<TaskFieldsValueResponseDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
